using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T_SQLGame;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginScreen
{
    public partial class LoginScreen : Form
    {
        static readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SQLGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public LoginScreen()
        {
            InitializeComponent();
        }

        private static void RegisterAccount(string userName, string passWord)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("spCreateAccount", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Account", userName);
            cmd.Parameters.AddWithValue("@Password", passWord);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        private static void VerifyBoxes()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand();

        }
        private static bool VerifyAccount(string userName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("spUserExists", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", userName);
            SqlDataReader reader = cmd.ExecuteReader();
            bool userExists = reader.HasRows;
            connection.Close();
            return userExists;
        }

        private static bool VerifyPassword(string passWord)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("spPasswordMatches", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Password", passWord);
            SqlDataReader reader = cmd.ExecuteReader();
            bool passwordMatches = reader.HasRows;
            connection.Close();
            return passwordMatches; 
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string userName = loginBox.Text;
            string passWord = passwordBox.Text;
            if (VerifyAccount(userName))
            {
                consolePrompt.Text = "This username already exists.";
                return;
            }
            else
            {
                if (SmallChecks(userName, passWord))
                {
                    RegisterAccount(userName, passWord);
                    consolePrompt.Text = "Account created succesfully.";
                    return;
                }
                return;
            }
        }

        private bool SmallChecks(string username, string password)
        {
            if (username.Length <= 0 || username.Length>= 33)
            {
                consolePrompt.Text = "This username is too big or too small.";
                return false; 
            }
            else if(password.Length <=0 || password.Length>= 33)
            {
                consolePrompt.Text = "This password is too big or too small.";
                return false;
            }
            return true;
        }
        private void PlayerInformation(GameWindow screen, string username)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("playerInformation", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", username);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int health = reader.GetInt32(0);
                int maxHealth = reader.GetInt32(1);
                int accountId = reader.GetInt32(2);
                int level = reader.GetInt32(3);
                int experience = reader.GetInt32(4);

                connection.Close();

                screen.LoginPlayer(username, health, maxHealth, accountId, level, experience);
            }
            else if (!reader.HasRows)
            {
                reader.Close();

                SqlCommand createCommand = new SqlCommand("createCharacter", connection);
                createCommand.CommandType = CommandType.StoredProcedure;
                createCommand.Parameters.AddWithValue("@Username", username);
                createCommand.ExecuteNonQuery();

                connection.Close();

                PlayerInformation(screen, username);
                return;
            }
            else
            {
                connection.Close();
                consolePrompt.Text = "Failed.";
                return;
            }
        }

        private void GameConnect(string username, string password)
        {

            GameWindow screen = new GameWindow();
            screen.Show();
            PlayerInformation(screen, username);

            //this.Close();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            string userName = loginBox.Text;
            string passWord = passwordBox.Text;
            if (!VerifyAccount(userName))
            {
                consolePrompt.Text = "This account doesnt exist, create one first.";
                return;
            }
            else
            {
                if (VerifyPassword(passWord))
                {
                    consolePrompt.Text = "Nice everything matches you will login.";
                    GameConnect(userName, passWord);
                    return;
                }
                else
                {
                    consolePrompt.Text = "Wrong password, check it.";
                    return;
                }
            }
        }
    }
}
