using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Delivery_service
{
    public partial class ForClient : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;
        string connectionString = @"Server=tcp:deliveryservice.database.windows.net,1433;Initial Catalog=Delivery service;Persist Security Info=False;User ID=Nikiru;Password=Rnp26122001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        string UserID = "";
        string ClientID = "";
        public ForClient(string id)
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
            UserID = id;
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"SELECT [id] FROM [Delivery service client] WHERE [user id]={UserID}";
            cmd = new SqlCommand(query, connection);
            ClientID = cmd.ExecuteScalar().ToString();
            connection.Close();
            UpdateProfile();
            NewDeliveryPanel.Show();
            NewDeliveryPanel.Location = loc;
            MyDeliveryPanel.Hide();
            ProfilePanel.Hide();
            QuestionPanel.Hide();
            InfoPanel.Hide();

        }
        Point loc = new Point(191, 63);

        private void NewOrder_Click(object sender, EventArgs e)
        {
            InfoPanel.Hide();
            QuestionPanel.Hide();
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
            RecDateTimePicker.Value = DateTime.Now;
            DesDateTimePicker.Value = DateTime.Now;
            RecDateTimePicker.MinDate = DateTime.Now;
            DesDateTimePicker.MinDate= DateTime.Now;
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            InfoPanel.Hide();
            QuestionPanel.Hide();
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
            InfoPanel.Hide();
            QuestionPanel.Location = loc;
            QuestionPanel.Show();
            UpdateQuestions();
            QuestionPanel.Show();
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
            InfoPanel.Location = loc;
            InfoPanel.Show();
            QuestionPanel.Hide();
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
            InfoPanel.Hide();
            UpdateProfile();
            ProfilePanel.Location = loc;
            ProfilePanel.Show();
            QuestionPanel.Hide();
            MyDeliveryPanel.Hide();
            NewDeliveryPanel.Hide();
            NamePanel.Text = "Профиль";
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

        private void UpdateProfile()
        {

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"exec InfoClient {UserID}";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SurnameTextBox.Text = reader.GetString(0);
                    NameTextBox.Text = ClientName.Text = label1.Text = reader.GetString(1);
                    PatrTextBox.Text = reader.GetString(2);
                    PhoneTextBox.Text = reader.GetString(4);
                    EmailTextBox.Text = reader.GetString(5);
                    LoginTextBox.Text = reader.GetString(7);
                    PasswordTextBox.Text = reader.GetString(8);
                    BirthDateTimePicker.Value = reader.GetDateTime(3);
                    RegDateTimePicker.Value = reader.GetDateTime(9);
                    CountOrdersLabel.Text = "Количество заказов : " + reader.GetInt32(10);
                    MemoryStream memoryStream = new MemoryStream();
                    memoryStream.Write((byte[])reader["Photo"], 0, ((byte[])reader["Photo"]).Length);
                    ProfilePicture.Image = Image.FromStream(memoryStream);
                    ProfilePic.Image = Image.FromStream(memoryStream);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ProfilePic_Click(object sender, EventArgs e)
        {

            InfoPanel.Hide();
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
            NavPanel.Height = 0;
            NavPanel.Top = 0;
            NavPanel.Left = 0;
            Orders.Image = Properties.Resources.MyDelivery;
            Settings.Image = Properties.Resources.Settings;
            Question.Image = Properties.Resources.Question;
            Help.Image = Properties.Resources.Help;
            NewDelivery.Image = Properties.Resources.NewDelivery;
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query;
                if (check == 1)
                {
                    query = $"UPDATE [Delivery service user] SET Surname =N'{SurnameTextBox.Text}', Name =N'{NameTextBox.Text}', Patronymic =N'{PatrTextBox.Text}', [Phone number] =N'{PhoneTextBox.Text}', Email =N'{EmailTextBox.Text}', Login =N'{LoginTextBox.Text}', [Password]=N'{PasswordTextBox.Text}',[Birth date]=N'{BirthDateTimePicker.Value.ToString("yyyy-MM-dd")}',[photo]=@p WHERE id={UserID}";
                    cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@p", memoryStream.ToArray());
                    check = 0;
                }
                else
                {
                    query = $"UPDATE [Delivery service user] SET Surname =N'{SurnameTextBox.Text}', Name =N'{NameTextBox.Text}', Patronymic =N'{PatrTextBox.Text}', [Phone number] =N'{PhoneTextBox.Text}', Email =N'{EmailTextBox.Text}', Login =N'{LoginTextBox.Text}', [Password]=N'{PasswordTextBox.Text}',[Birth date]=N'{BirthDateTimePicker.Value.ToString("yyyy-MM-dd")}' WHERE id={UserID}";
                    cmd = new SqlCommand(query, connection);
                }
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateProfile();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                // добавление новой доставки

                string query = $"INSERT INTO [Delivery service order]VALUES ({ClientID},14,5,N'{ObjTextBox.Text}',NULL,N'{RecTextBox.Text}',N'{RecDateTimePicker.Value.ToString("yyyy-MM-dd")}',N'{maskedTextBox1.Text}', N'{DesTextBox.Text}',N'{DesDateTimePicker.Value.ToString("yyyy-MM-dd")}',N'{maskedTextBox2.Text}',N' {CommentaryTextBox.Text}',GETDATE())";
                cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Orders_Click(sender, e);
        }

        private void UpdateDelivery()
        {
            try
            {
                string query = $"exec InfoDelivery N'{ClientID}'";
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DeliveryDataGridView.DataSource = ds.Tables[0];
                query = $"exec InfoDeliveryEnd N'{ClientID}'";
                adapter = new SqlDataAdapter(query, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                DeliveryDataGridView2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            LoadInfo();
        }
        private void LoadInfo()
        {
            string DeliveryID = " ";
            int index = 0;
            foreach (DataGridViewCell cell in DeliveryDataGridView2.SelectedCells)
            {
                index = cell.RowIndex;
            }
            string obj = DeliveryDataGridView2[2, index].Value.ToString();
            string rp = DeliveryDataGridView2[4, index].Value.ToString();
            string dp = DeliveryDataGridView2[7, index].Value.ToString();
            string com = DeliveryDataGridView2[10, index].Value.ToString();
            string rd = DeliveryDataGridView2[5, index].Value.ToString();
            string dd = DeliveryDataGridView2[8, index].Value.ToString();
            string rt = DeliveryDataGridView2[6, index].Value.ToString();
            string dt = DeliveryDataGridView2[9, index].Value.ToString();
            try
            {
                string query = $"select [id] from [Delivery service order] where [Client id]={ClientID} and [Object description]=N'{obj}'and [Reception point]=N'{rp}' and [Destination point]=N'{dp}' and [Commentary]=N'{com}' ";
                connection = new SqlConnection(connectionString);
                connection.Open();
                cmd = new SqlCommand(query, connection);
                DeliveryID = cmd.ExecuteScalar().ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InfoDeliveryForClient infoDelivery = new InfoDeliveryForClient(DeliveryID, obj, rp, dp, rt, dt, rd, dd, com);
            DialogResult dialogResult = new DialogResult();
            dialogResult = infoDelivery.ShowDialog();
            UpdateDelivery();
        }
        private void DeliveryDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LoadInfo();
        }

        private void UpdateQuestions()
        {
            try
            {
                string query = $"exec InfoAnswer {UserID}";
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                QuestionsDataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string query = $"INSERT INTO [delivery service questions] " +
                    $"([User id],[worker id], [question],[date]) " +
                    $"VALUES ( {UserID},1,@commentary,GETDATE())";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@commentary", QuestionTextBox.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateQuestions();
        }

        MemoryStream memoryStream = new MemoryStream();
        int check = 0;
        private void ProfilePicture_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ProfilePicture.Image = new Bitmap(openFileDialog1.FileName);
                    check = 1;
                    ProfilePicture.Image.Save(memoryStream, ProfilePicture.Image.RawFormat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ObjTextBox_Enter(object sender, EventArgs e)
        {
            ObjTextBox.Text = "";
        }

        private void CommentaryTextBox_Enter(object sender, EventArgs e)
        {
            CommentaryTextBox.Text = "";
        }

        private void RecTextBox_Enter(object sender, EventArgs e)
        {
            RecTextBox.Text = "";
        }

        private void DesTextBox_Enter(object sender, EventArgs e)
        {
            DesTextBox.Text = "";
        }
        private bool flag = false;
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (!flag)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.Height = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
                this.Width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            }
            else
                WindowState = FormWindowState.Normal;
            flag = !flag;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.FullScreen_enter;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.FullScreen;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Hide_enter;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Hide;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyDeliveryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string DeliveryID = " ";
            int index = 0;
            foreach (DataGridViewCell cell in DeliveryDataGridView.SelectedCells)
            {
                index = cell.RowIndex;
            }
            string sotr = DeliveryDataGridView[0, index].Value.ToString();
            string obj = DeliveryDataGridView[2, index].Value.ToString();
            string rp = DeliveryDataGridView[4, index].Value.ToString();
            string dp = DeliveryDataGridView[7, index].Value.ToString();
            string com = DeliveryDataGridView[10, index].Value.ToString();
            string rd = DeliveryDataGridView[5, index].Value.ToString();
            string dd = DeliveryDataGridView[8, index].Value.ToString();
            string rt = DeliveryDataGridView[6, index].Value.ToString();
            string dt = DeliveryDataGridView[9, index].Value.ToString();
            string cost = DeliveryDataGridView[3, index].Value.ToString();
            try
            {
                string query = $"select [id] from [Delivery service order] where [Client id]={ClientID} and [Object description]=N'{obj}'and [Reception point]=N'{rp}' and [Destination point]=N'{dp}' and [Commentary]=N'{com}' ";
                connection = new SqlConnection(connectionString);
                connection.Open();
                cmd = new SqlCommand(query, connection);
                DeliveryID = cmd.ExecuteScalar().ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InfoDeliveryForClient2 infoDelivery = new InfoDeliveryForClient2(sotr,cost,DeliveryID, obj, rp, dp, rt, dt, rd, dd, com);
            DialogResult dialogResult = new DialogResult();
            dialogResult = infoDelivery.ShowDialog();
            UpdateDelivery();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DesDateTimePicker.MinDate = RecDateTimePicker.Value;
            DesDateTimePicker.Value = RecDateTimePicker.Value;
           
        }

        private void ObjTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
