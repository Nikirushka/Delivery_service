using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Delivery_service
{
    public partial class ForOwner : Form
    {
        private OleDbConnection myConnection;
        private OleDbDataReader reader;
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb";
        string ClientID = "";
        public ForOwner(string id)
        {

            InitializeComponent();
            Settings.ForeColor = Color.FromArgb(227, 213, 212);
            Question.ForeColor = Color.FromArgb(227, 213, 212);
            Orders.ForeColor = Color.FromArgb(227, 213, 212);
            Help.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height = NewDelivery.Height;
            NavPanel.Top = NewDelivery.Top;
            NavPanel.Left = NewDelivery.Left;
            NewDelivery.ForeColor = Color.FromArgb(217, 35, 73);
            NewDelivery.Image = Properties.Resources.NewDelivery_on;
            NamePanel.Text = "Новая доставка";
            ClientID = id;
            UpdateProfile();
            UpdateDelivery();
            NewDeliveryPanel.Show();
            NewDeliveryPanel.Location = loc;
            MyDeliveryPanel.Hide();
            ProfilePanel.Hide();
        }
        Point loc = new Point(191, 63);

        private void NewOrder_Click(object sender, EventArgs e)
        {
            MyDeliveryPanel.Hide();
            ProfilePanel.Hide();
            NewDeliveryPanel.Show();
            NewDeliveryPanel.Location = loc;
            NamePanel.Text = "Новая доставка";
            Settings.ForeColor = Color.FromArgb(227, 213, 212);
            Question.ForeColor = Color.FromArgb(227, 213, 212);
            Orders.ForeColor = Color.FromArgb(227, 213, 212);
            Help.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height = NewDelivery.Height;
            NavPanel.Top = NewDelivery.Top;
            NavPanel.Left = NewDelivery.Left;
            NewDelivery.ForeColor = Color.FromArgb(217, 35, 73);
            NewDelivery.Image = Properties.Resources.NewDelivery_on;
        }

        private void ForClient_Load(object sender, EventArgs e)
        {

        }

        private void Orders_Click(object sender, EventArgs e)
        {
            UpdateDelivery();
            MyDeliveryPanel.Location = loc;
            MyDeliveryPanel.Show();
            ProfilePanel.Hide();
            NewDeliveryPanel.Hide();
            NamePanel.Text = "Мои доставки";
            Settings.ForeColor = Color.FromArgb(227, 213, 212);
            NewDelivery.ForeColor = Color.FromArgb(227, 213, 212);
            Question.ForeColor = Color.FromArgb(227, 213, 212);
            Help.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height = Orders.Height;
            NavPanel.Top = Orders.Top;
            NavPanel.Left = Orders.Left;
            Orders.ForeColor = Color.FromArgb(217, 35, 73);
            Orders.Image = Properties.Resources.MyDelivery_on;
            NewDelivery.Image = Properties.Resources.NewDelivery;
        }

        private void Question_Click(object sender, EventArgs e)
        {
            MyDeliveryPanel.Hide();
            ProfilePanel.Hide();
            NewDeliveryPanel.Hide();
            NamePanel.Text = "Задать вопрос";
            Settings.ForeColor = Color.FromArgb(227, 213, 212);
            NewDelivery.ForeColor = Color.FromArgb(227, 213, 212);
            Orders.ForeColor = Color.FromArgb(227, 213, 212);
            Help.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height = Question.Height;
            NavPanel.Top = Question.Top;
            NavPanel.Left = Question.Left;
            Question.ForeColor = Color.FromArgb(217, 35, 73);
            Question.Image = Properties.Resources.Question_on;
            NewDelivery.Image = Properties.Resources.NewDelivery;
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MyDeliveryPanel.Hide();
            ProfilePanel.Hide();
            NewDeliveryPanel.Hide();
            NamePanel.Text = "Помощь";
            Settings.ForeColor = Color.FromArgb(227, 213, 212);
            NewDelivery.ForeColor = Color.FromArgb(227, 213, 212);
            Orders.ForeColor = Color.FromArgb(227, 213, 212);
            Question.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height = Help.Height;
            NavPanel.Top = Help.Top;
            NavPanel.Left = Help.Left;
            Help.ForeColor = Color.FromArgb(217, 35, 73);
            Help.Image = Properties.Resources.Help_on;
            NewDelivery.Image = Properties.Resources.NewDelivery;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            MyDeliveryPanel.Hide();
            ProfilePanel.Hide();
            NewDeliveryPanel.Hide();
            NamePanel.Text = "Настройки";
            Question.ForeColor = Color.FromArgb(227, 213, 212);
            NewDelivery.ForeColor = Color.FromArgb(227, 213, 212);
            Orders.ForeColor = Color.FromArgb(227, 213, 212);
            Help.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height = Settings.Height;
            NavPanel.Top = Settings.Top;
            NavPanel.Left = Settings.Left;
            Settings.ForeColor = Color.FromArgb(217, 35, 73);
            Settings.Image = Properties.Resources.Settings_on;
            NewDelivery.Image = Properties.Resources.NewDelivery;
        }

        private void NewDelivery_Leave(object sender, EventArgs e)
        {
            NewDelivery.ForeColor = Color.FromArgb(227, 213, 212);
            NewDelivery.Image = Properties.Resources.NewDelivery;
        }

        private void Orders_Leave(object sender, EventArgs e)
        {
            Orders.ForeColor = Color.FromArgb(227, 213, 212);
            Orders.Image = Properties.Resources.MyDelivery;
        }

        private void Question_Leave(object sender, EventArgs e)
        {
            Question.ForeColor = Color.FromArgb(227, 213, 212);
            Question.Image = Properties.Resources.Question;
        }

        private void Help_Leave(object sender, EventArgs e)
        {
            Help.ForeColor = Color.FromArgb(227, 213, 212);
            Help.Image = Properties.Resources.Help;
        }

        private void Settings_Leave(object sender, EventArgs e)
        {
            Settings.ForeColor = Color.FromArgb(227, 213, 212);
            Settings.Image = Properties.Resources.Settings;
        }

        private void ProfilePic_MouseLeave(object sender, EventArgs e)
        {
            ProfilePic.Image = Properties.Resources.Profile;
        }

        private void ProfilePic_MouseEnter(object sender, EventArgs e)
        {
            ProfilePic.Image = Properties.Resources.Profile_on;
        }

        private void Close_button_MouseEnter(object sender, EventArgs e)
        {
            Close_button.Image = Properties.Resources.Close_button_enter;
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.Image = Properties.Resources.Close_button_leave2;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PhotoProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateProfile()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"SELECT * FROM [Delivery service user] WHERE id={ClientID}";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        NameTextBox.Text = ClientName.Text = label1.Text= reader.GetString(2);
                        SurnameTextBox.Text = reader.GetString(1);
                        PatrTextBox.Text = reader.GetString(3);
                        PhoneTextBox.Text = reader.GetString(4);
                        EmailTextBox.Text = reader.GetString(5);
                        LoginTextBox.Text = reader.GetString(7);
                        PasswordTextBox.Text = reader.GetString(8);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
 
            }
        }
        private void ProfilePic_Click(object sender, EventArgs e)
        {
            MyDeliveryPanel.Hide();
            UpdateProfile();
            NewDeliveryPanel.Hide();
            NamePanel.Text = "Профиль";
            ProfilePanel.Location = loc;
            ProfilePanel.Show();
            Settings.ForeColor = Color.FromArgb(227, 213, 212);
            Question.ForeColor = Color.FromArgb(227, 213, 212);
            Orders.ForeColor = Color.FromArgb(227, 213, 212);
            Help.ForeColor = Color.FromArgb(227, 213, 212);
            NewDelivery.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height =0;
            NavPanel.Top = 0;
            NavPanel.Left = 0;
            Orders.Image = Properties.Resources.MyDelivery;
            Settings.Image = Properties.Resources.Settings;
            Question.Image = Properties.Resources.Question;
            Help.Image = Properties.Resources.Help;
            NewDelivery.Image = Properties.Resources.NewDelivery;
            ProfilePic.Image = Properties.Resources.Profile_on;
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"UPDATE [Delivery service user] SET Surname ='{SurnameTextBox.Text}', Name ='{NameTextBox.Text}', Patronymic ='{PatrTextBox.Text}', [Phone number] ='{PhoneTextBox.Text}', Email ='{EmailTextBox.Text}', Login ='{LoginTextBox.Text}', [Password]='{PasswordTextBox.Text}' WHERE id={ClientID}";
                    OleDbCommand command = new OleDbCommand(query, connection);            
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            UpdateProfile();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // добавление новой доставки
                    Random rand = new Random();
                    OleDbCommand command = new OleDbCommand($"INSERT INTO [Delivery order] " +
                        $"([Client id],[Courier id],[Contract id], [Status id], [Object description], [Reception point], [Destination point], [Commentary]) " +
                        $"VALUES ( {ClientID},1,2,1, @obj, @rec, @des, @commentary)", connection);
                    command.Parameters.AddWithValue("@obj", ObjTextBox.Text);
                    command.Parameters.AddWithValue("@rec", RecTextBox.Text);
                    command.Parameters.AddWithValue("@des", DesTextBox.Text);
                    command.Parameters.AddWithValue("@commentary", CommentaryTextBox.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void UpdateDelivery()
        {
            try
            {
                string query = $"select [Object description], Price, [Reception Point], [Destination Point],[Deadline date], [Commentary] from [Delivery order] where [client id]={ClientID}";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DeliveryDataGridView.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            string DeliveryID=" ";
            int index = 0;
            foreach (DataGridViewCell cell in DeliveryDataGridView.SelectedCells)
            {
                index = cell.RowIndex;
            }
            string obj = DeliveryDataGridView[0, index].Value.ToString();
            string rp = DeliveryDataGridView[2, index].Value.ToString();
            string dp = DeliveryDataGridView[3, index].Value.ToString();
            string com = DeliveryDataGridView[5, index].Value.ToString();
            try
            {
                string query = $"select [id] from [Delivery order] where [Client id]={ClientID} and [Object description]='{obj}'and [Reception point]='{rp}' and [Destination point]='{dp}' and [Commentary]='{com}' ";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    DeliveryID = command.ExecuteScalar().ToString();
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InfoDeliveryForClient infoDelivery = new InfoDeliveryForClient(DeliveryID,obj, rp, dp, DeliveryDataGridView[4, index].Value.ToString(), com);
            DialogResult dialogResult = new DialogResult();
            dialogResult = infoDelivery.ShowDialog();
            UpdateDelivery();
            
        }

        private void DeliveryDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string DeliveryID = " ";
            int index = 0;
            foreach (DataGridViewCell cell in DeliveryDataGridView.SelectedCells)
            {
                index = cell.RowIndex;
            }
            string obj = DeliveryDataGridView[0, index].Value.ToString();
            string rp = DeliveryDataGridView[2, index].Value.ToString();
            string dp = DeliveryDataGridView[3, index].Value.ToString();
            string com = DeliveryDataGridView[5, index].Value.ToString();
            try
            {
                string query = $"select [id] from [Delivery order] where [Client id]={ClientID} and [Object description]='{obj}'and [Reception point]='{rp}' and [Destination point]='{dp}' and [Commentary]='{com}' ";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    DeliveryID = command.ExecuteScalar().ToString();
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InfoDeliveryForClient infoDelivery = new InfoDeliveryForClient(DeliveryID,DeliveryDataGridView[0,index].Value.ToString(), DeliveryDataGridView[2, index].Value.ToString(), DeliveryDataGridView[3, index].Value.ToString(), DeliveryDataGridView[4, index].Value.ToString(), DeliveryDataGridView[5, index].Value.ToString());
            DialogResult dialogResult = new DialogResult();
            dialogResult = infoDelivery.ShowDialog();
            UpdateDelivery();
        }
    }
}
