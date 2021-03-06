using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Delivery_service
{
    public partial class ForEmployee : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;
        string connectionString = @"Server=tcp:deliveryservice.database.windows.net,1433;Initial Catalog=Delivery service;Persist Security Info=False;User ID=Nikiru;Password=Rnp26122001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        string UserID = "";
        string empid = "";
        MemoryStream memoryStream = new MemoryStream();
        public ForEmployee(string id)
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
            string query = $"SELECT [id] FROM [Delivery service employee] WHERE [user id]={UserID}";
            cmd = new SqlCommand(query, connection);
            empid = cmd.ExecuteScalar().ToString();
            connection.Close();
            UpdateProfile();
            UpdateDelivery();
            NewDeliveryPanel.Show();
            NewDeliveryPanel.Location = loc;
            ProfilePanel.Hide();
            QuestionPanel.Hide();
            InfoPanel.Hide();
            MyDeliveryPanel.Hide();

        }
        Point loc = new Point(191, 63);

        private void NewOrder_Click(object sender, EventArgs e)
        {
            UpdateDelivery();
            InfoPanel.Hide();
            MyDeliveryPanel.Hide();
            QuestionPanel.Hide();
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
            UpdateMyDelivery();
            MyDeliveryPanel.Show();
            InfoPanel.Hide();
            QuestionPanel.Hide();
            MyDeliveryPanel.Location = loc;
            ProfilePanel.Hide();
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
            MyDeliveryPanel.Hide();
            QuestionPanel.Show();
            NewDeliveryPanel.Hide();
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
            InfoPanel.Location = loc;
            InfoPanel.Show();
            QuestionPanel.Hide();
            NewDeliveryPanel.Hide();
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
            NewDeliveryPanel.Hide();
            MyDeliveryPanel.Hide();
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
                string query = $"exec infoemployee {UserID}";
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
                    CountOrdersLabel.Text = "Количество откликов : " + reader.GetInt32(10);
                    PositionTextBox.Text = reader.GetString(11);
                    DSTextBox.Text = reader.GetString(12);
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

        private void UpdateMyDelivery()
        {

            try
            {
                string query = $"select[Delivery service user].Surname as Клиент, [Delivery service order status].Name as 'Статус',[Delivery service order].[Object description] AS Описание,dbo.[Delivery service order].Price AS Цена, dbo.[Delivery service order].[Reception point] AS [Адрес получения], dbo.[Delivery service order].[Reception date] AS [Дата получения], dbo.[Delivery service order].[Reception time] AS[Время получения], dbo.[Delivery service order].[Destination point] AS[Адрес доставки], dbo.[Delivery service order].[Destination date] AS[Дата доставки], dbo.[Delivery service order].[Destination time] AS[Время доставки], dbo.[Delivery service order].Commentary AS Комментарий from[Delivery service order] join[Delivery service employee]  on[Delivery service employee].id =[Delivery service order].[Employee id] join[Delivery service] on[Delivery service].id =[Delivery service employee].[Delivery service id] join[Delivery service client] on[Delivery service client].id =[Delivery service order].[Client id] join[Delivery service user] on[Delivery service client].[User id] =[Delivery service user].id join[Delivery service user] dsu on[Delivery service employee].[User id]= dsu.id join[Delivery service order status] on[Delivery service order].[Status id] =[Delivery service order status].id where[Delivery service employee].[User id] = {UserID}";
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DeliveryDataGridView.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ProfilePic_Click(object sender, EventArgs e)
        {

            InfoPanel.Hide();
            NewDeliveryPanel.Hide();
            UpdateProfile();
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

            //try
            //{
            //    connection = new SqlConnection(connectionString);
            //    connection.Open();
            //    // добавление новой доставки

            //    string query = $"INSERT INTO [Delivery service order]VALUES ({ClientID},1,5,N'{ObjTextBox.Text}',NULL,N'{RecTextBox.Text}',N'{RecDateTimePicker.Value.ToString("yyyy-MM-dd")}',N'{maskedTextBox1.Text}', N'{DesTextBox.Text}',N'{DesDateTimePicker.Value.ToString("yyyy-MM-dd")}',N'{maskedTextBox2.Text}',N' {CommentaryTextBox.Text}',GETDATE())";
            //    cmd = new SqlCommand(query, connection);
            //    cmd.ExecuteNonQuery();
            //    connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //Orders_Click(sender, e);
        }

        private void UpdateDelivery()
        {
            try
            {
                string query = $"select * from NewOrders where Статус=N'Ожидание курьера' or Статус=N'Ожидание одобрения'";
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                NewOrdersDataGridView.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void NewDeliveryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string DeliveryID = " ";
            int index = 0;
            foreach (DataGridViewCell cell in NewOrdersDataGridView.SelectedCells)
            {
                index = cell.RowIndex;
            }
            string sur = NewOrdersDataGridView[0, index].Value.ToString();
            string obj = NewOrdersDataGridView[3, index].Value.ToString();
            string rp = NewOrdersDataGridView[5, index].Value.ToString();
            string dp = NewOrdersDataGridView[8, index].Value.ToString();
            string com = NewOrdersDataGridView[11, index].Value.ToString();
            string rd = NewOrdersDataGridView[6, index].Value.ToString();
            string dd = NewOrdersDataGridView[9, index].Value.ToString();
            string rt = NewOrdersDataGridView[7, index].Value.ToString();
            string dt = NewOrdersDataGridView[10, index].Value.ToString();
            try
            {
                string query = $"select [Delivery service order].id from [Delivery service order] join [Delivery service client] on [Delivery service Client].[id]=[Delivery service order].[Client id] join [Delivery service user] on [Delivery service user].[id]=[delivery service client].[user id] where [Delivery service user].Name=N'{sur}' and [Object description]=N'{obj}'and [Reception point]=N'{rp}' and [Destination point]=N'{dp}' and [Commentary]=N'{com}' ";
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
            InfoDeliveryForEmp infoDelivery = new InfoDeliveryForEmp(empid,DeliveryID,sur, obj, rp, dp, rt, dt, rd, dd, com);
            DialogResult dialogResult = new DialogResult();
            dialogResult = infoDelivery.ShowDialog();
            UpdateDelivery();
        }

        private void SurnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                return;
            }
            else e.Handled = true;
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                return;
            }
            else e.Handled = true;
        }

        private void PatrTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();
            if ((Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                return;
            }
            else e.Handled = true;
        }
    }
}
