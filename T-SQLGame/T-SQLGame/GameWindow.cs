using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace T_SQLGame
{
    public partial class GameWindow : Form
    {
        static readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SQLGame;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public string CharacterName { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int AccountId { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        Random rand = new Random();

        public GameWindow()
        {
            InitializeComponent();
        }

        private void UpdateHealthBar()
        {
            int healthPercentage = (int)((Health / (double)MaxHealth) * 100);
            healthBar.Value = healthPercentage;
        }

        private int GetExperienceTotal()
        {
            int experience = 0;
            experience = ((Level + 1) * (Level + 10)) * 2;
            return experience;
        }

        private void SendStats()
        {
            characterName.Text = CharacterName;
            itLevel.Text = Convert.ToString(Level);
            string actualExp = Convert.ToString(Experience);
            string totalExp = Convert.ToString(GetExperienceTotal());
            itExperience.Text = $"{actualExp} / {totalExp}";
        }

        private void HealthChange()
        {
            if (Health <= 0) this.Close();
            if (Health >= MaxHealth) Health = MaxHealth;
            if (Experience >= GetExperienceTotal())
            {
                Level++;
                MaxHealth += 10;
                Health = MaxHealth;
            }
            SendStats();
            UpdateHealthBar();
        }

        public void LoginPlayer(string userName, int health, int maxHealth, int accountId, int level, int experience)
        {
            CharacterName = userName;
            Health = health;
            MaxHealth = maxHealth;
            AccountId = accountId;
            Level = level;
            Experience= experience;

            UpdateHealthBar();
            SendStats();
        }

        private void addLog(string log)
        {
            eventLogs.Items.Add(log);
            eventLogs.SelectedIndex = eventLogs.Items.Count - 1;
        }

        private void fightButton_Click(object sender, EventArgs e)
        {
            int damage = rand.Next(1, 10);
            int exp = rand.Next(1, 3);
            Health -= damage;
            Experience += exp;
            HealthChange();
            addLog($"You received: {damage} damage.");
            addLog($"You gained: {exp} experience.");

            eventLogs.SelectedIndex = eventLogs.Items.Count - 1;
        }

        private void healButton_Click(object sender, EventArgs e)
        {
            int healed = rand.Next(1, 5);
            Health += healed;
            addLog($"You healed: {healed} hitpoints.");
            HealthChange();
        }

        private void lootButton_Click(object sender, EventArgs e)
        {
            // Does nothing yet...
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("savePlayer", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", CharacterName);
            cmd.Parameters.AddWithValue("@Health", Health);
            cmd.Parameters.AddWithValue("@MaxHealth", MaxHealth);
            cmd.Parameters.AddWithValue("@Level", Level);
            cmd.Parameters.AddWithValue("@Experience", Experience);
            cmd.ExecuteNonQuery();
            connection.Close();
            playersInfo_Click(sender, e);
        }

        private void playersInfo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("loadPlayers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            allCharacters.DataSource= dataTable;

        }
    }
}