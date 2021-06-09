using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Delivery_service
{
    public partial class ForAdmin : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;
        string connectionString = @"Server=tcp:deliveryservice.database.windows.net,1433;Initial Catalog=Delivery service;Persist Security Info=False;User ID=Nikiru;Password=Rnp26122001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        string UserID = "";
        string ClientID = "";
        public ForAdmin(string id)
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
            NamePanel.Text = "Новая доставка";
            UserID = id;

            UpdateClients();
            UpdateOwners();
            UpdateWorkers();
            UpdateDelivers();
            UpdateQuestions();
            NewDeliveryPanel.Show();
            NewDeliveryPanel.Location = loc;
            MyDeliveryPanel.Hide();
            QuestionPanel.Hide();
            InfoPanel.Hide();
            Workers.Hide();
            Delivers.Hide();
        }
        Point loc = new Point(191, 63);

        private void NewOrder_Click(object sender, EventArgs e)
        {
            UpdateClients();
            InfoPanel.Hide();
            Workers.Hide();
            Delivers.Hide();
            QuestionPanel.Hide();
            MyDeliveryPanel.Hide();
            NewDeliveryPanel.Show();
            NewDeliveryPanel.Location = loc;
            NamePanel.Text = "Клиенты";
            Settings.ForeColor = Color.FromArgb(227, 213, 212);
            Question.ForeColor = Color.FromArgb(227, 213, 212);
            Orders.ForeColor = Color.FromArgb(227, 213, 212);
            Help.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height = NewDelivery.Height;
            NavPanel.Top = NewDelivery.Top;
            NavPanel.Left = NewDelivery.Left;
            NewDelivery.ForeColor = Color.FromArgb(217, 35, 73);
        }

        private void ForClient_Load(object sender, EventArgs e)
        {
            
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            InfoPanel.Hide();
            QuestionPanel.Hide();
            UpdateOwners();
            MyDeliveryPanel.Location = loc;
            MyDeliveryPanel.Show();

            NewDeliveryPanel.Hide();
            Delivers.Hide();
            Workers.Hide();
            NamePanel.Text = "Владельцы";
            Settings.ForeColor = Color.FromArgb(227, 213, 212);
            NewDelivery.ForeColor = Color.FromArgb(227, 213, 212);
            Question.ForeColor = Color.FromArgb(227, 213, 212);
            Help.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height = Orders.Height;
            NavPanel.Top = Orders.Top;
            NavPanel.Left = Orders.Left;
            Orders.ForeColor = Color.FromArgb(217, 35, 73);
        }

        private void Question_Click(object sender, EventArgs e)
        {
            UpdateWorkers();
            InfoPanel.Hide();
            Workers.Location = loc;
            Workers.Show();
            Delivers.Hide();
            QuestionPanel.Hide();
            MyDeliveryPanel.Hide();
            Delivers.Hide();
            NewDeliveryPanel.Hide();
            NamePanel.Text = "Работники";
            Settings.ForeColor = Color.FromArgb(227, 213, 212);
            NewDelivery.ForeColor = Color.FromArgb(227, 213, 212);
            Orders.ForeColor = Color.FromArgb(227, 213, 212);
            Help.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height = Question.Height;
            NavPanel.Top = Question.Top;
            NavPanel.Left = Question.Left;
            Question.ForeColor = Color.FromArgb(217, 35, 73);
        }

        private void Help_Click(object sender, EventArgs e)
        {
            UpdateDelivers();
            Delivers.Location = loc;
            Delivers.Show();
            InfoPanel.Hide();
            QuestionPanel.Hide();
            Workers.Hide();
            MyDeliveryPanel.Hide();
            NewDeliveryPanel.Hide();
            NamePanel.Text = "Доставки";
            Settings.ForeColor = Color.FromArgb(227, 213, 212);
            NewDelivery.ForeColor = Color.FromArgb(227, 213, 212);
            Orders.ForeColor = Color.FromArgb(227, 213, 212);
            Question.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height = Help.Height;
            NavPanel.Top = Help.Top;
            NavPanel.Left = Help.Left;
            Help.ForeColor = Color.FromArgb(217, 35, 73);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            InfoPanel.Show();
            InfoPanel.Location = loc;
         
            QuestionPanel.Hide();
            MyDeliveryPanel.Hide();
            Delivers.Hide();
            Workers.Hide();
            NewDeliveryPanel.Hide();
            NamePanel.Text = "Справка";
            Question.ForeColor = Color.FromArgb(227, 213, 212);
            NewDelivery.ForeColor = Color.FromArgb(227, 213, 212);
            Orders.ForeColor = Color.FromArgb(227, 213, 212);
            Help.ForeColor = Color.FromArgb(227, 213, 212);
            NavPanel.Height = Settings.Height;
            NavPanel.Top = Settings.Top;
            NavPanel.Left = Settings.Left;
            Settings.ForeColor = Color.FromArgb(217, 35, 73);
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


        private void UpdateOwners()
        {
            try
            {
                string query = $"select [Delivery service owner].[User id] as Номер,[Delivery service user].Surname as Фамилия,[Delivery service user].Name as Имя,[Delivery service user].Patronymic as Отчество,[Delivery service user].[Birth date] as 'Дата рождения',[Delivery service user].[Phone number] as Телефон,[Delivery service user].Email,[Delivery service user].Login as Логин,[Delivery service user].Password as Пароль,[Delivery service user].[Registration date] as 'Дата регистрации' from [Delivery service owner] join [Delivery service user] on [Delivery service user].id =[Delivery service owner].[User id]";
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                gunaDataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateClients()
        {
            try
            {
                string query = $"select [Delivery service client].[id] as 'Номер клиента',[Delivery service client].[User id] as 'Номер пользователя',[Delivery service user].Surname as Фамилия,[Delivery service user].Name as Имя,[Delivery service user].Patronymic as Отчество,[Delivery service user].[Birth date] as 'Дата рождения',[Delivery service user].[Phone number] as Телефон,[Delivery service user].Email,[Delivery service user].Login as Логин,[Delivery service user].Password as Пароль,[Delivery service user].[Registration date] as 'Дата регистрации' from [Delivery Service Client] join [Delivery service user] on [Delivery service user].id =[Delivery service client].[User id]";
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                gunaDataGridView2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateWorkers()
        {
            try
            {
                string query = $"select [Delivery service employee].[id] as 'Номер работника', [Delivery service employee].[User id] as 'Номер пользователя',[Delivery service user].Surname as Фамилия,[Delivery service user].Name as Имя,[Delivery service user].Patronymic as Отчество,[Delivery service user].[Birth date] as 'Дата рождения',[Delivery service user].[Phone number] as Телефон,[Delivery service user].Email,[Delivery service user].Login as Логин,[Delivery service user].Password as Пароль,[Delivery service user].[Registration date] as 'Дата регистрации' from [Delivery service employee] join [Delivery service user] on [Delivery service user].id =[Delivery service employee].[User id]";
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                gunaDataGridView3.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateDelivers()
        {
            try
            {
                string query = $"select dlo.id as 'Номер заказa', dlo.[Client id] as 'Номер клиента', dlo.[Employee id] as 'Номер работника', [Delivery service order status].Name as 'Статус заказа', dlo.[Object description] as Описание, dlo.Price as Цена, dlo.[Reception point] as 'Откуда', dlo.[Reception date] as 'Дата', dlo.[Reception time] as 'Время', dlo.[Destination point] as 'Куда', dlo.[Destination date] as 'Дата', dlo.[Destination time] as 'Время', dlo.[Client id] as Комментарий, dlo.Date as 'Дата заказа' from [Delivery service order] dlo join [Delivery service order status] on [Delivery service order status].id=dlo.[Status id]";
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                gunaDataGridView4.DataSource = ds.Tables[0];
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser newUser = new NewUser();
            DialogResult dialogResult = new DialogResult();
            dialogResult = newUser.ShowDialog();
            this.Show();
            UpdateClients();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            int index = 0;
            foreach (DataGridViewCell cell in gunaDataGridView2.SelectedCells)
            {
                index = cell.RowIndex;
            }
            int usid = Convert.ToInt32((gunaDataGridView2[1, index].Value));
            string sur = (gunaDataGridView2[2, index].Value.ToString());
            string nam = (gunaDataGridView2[3, index].Value.ToString());
            string patr = (gunaDataGridView2[4, index].Value.ToString());
            DateTime date = Convert.ToDateTime((gunaDataGridView2[5, index].Value));
            string pho = (gunaDataGridView2[6, index].Value.ToString());
            string ema = (gunaDataGridView2[7, index].Value.ToString());
            string log = (gunaDataGridView2[8, index].Value.ToString());
            string pas = (gunaDataGridView2[9, index].Value.ToString());

            EditClient EditClient = new EditClient(usid,sur,nam,patr,date,pho,ema,log,pas);
            DialogResult dialogResult = new DialogResult();
            dialogResult = EditClient.ShowDialog();
            UpdateClients();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser newUser = new NewUser();
            DialogResult dialogResult = new DialogResult();
            dialogResult = newUser.ShowDialog();
            this.Show();
            UpdateOwners();
        }

        private void gunaButton4_Click_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            int index = 0;
            foreach (DataGridViewCell cell in gunaDataGridView1.SelectedCells)
            {
                index = cell.RowIndex;
            }
            int usid = Convert.ToInt32((gunaDataGridView1[0, index].Value));
            string sur = (gunaDataGridView1[1, index].Value.ToString());
            string nam = (gunaDataGridView1[2, index].Value.ToString());
            string patr = (gunaDataGridView1[3, index].Value.ToString());
            DateTime date = Convert.ToDateTime((gunaDataGridView1[4, index].Value));
            string pho = (gunaDataGridView1[5, index].Value.ToString());
            string ema = (gunaDataGridView1[6, index].Value.ToString());
            string log = (gunaDataGridView1[7, index].Value.ToString());
            string pas = (gunaDataGridView1[8, index].Value.ToString());

            EditOwner EditOwner = new EditOwner(usid, sur, nam, patr, date, pho, ema, log, pas);
            DialogResult dialogResult = new DialogResult();
            dialogResult = EditOwner.ShowDialog();
            UpdateOwners();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            int index = 0;
            foreach (DataGridViewCell cell in gunaDataGridView3.SelectedCells)
            {
                index = cell.RowIndex;
            }
            int usid = Convert.ToInt32((gunaDataGridView3[1, index].Value));
            string sur = (gunaDataGridView3[2, index].Value.ToString());
            string nam = (gunaDataGridView3[3, index].Value.ToString());
            string patr = (gunaDataGridView3[4, index].Value.ToString());
            DateTime date = Convert.ToDateTime((gunaDataGridView3[5, index].Value));
            string pho = (gunaDataGridView3[6, index].Value.ToString());
            string ema = (gunaDataGridView3[7, index].Value.ToString());
            string log = (gunaDataGridView3[8, index].Value.ToString());
            string pas = (gunaDataGridView3[9, index].Value.ToString());

            EditEmployee EditEmployee = new EditEmployee(usid, sur, nam, patr, date, pho, ema, log, pas);
            DialogResult dialogResult = new DialogResult();
            dialogResult = EditEmployee.ShowDialog();
            UpdateWorkers();
        }
    }
}
