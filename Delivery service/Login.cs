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
using System.Data.SqlClient;

namespace Delivery_service
{
    public partial class Login : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;
        string connectionString = @"Server=tcp:deliveryservice.database.windows.net,1433;Initial Catalog=Delivery service;Persist Security Info=False;User ID=Nikiru;Password=Rnp26122001;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public Login()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Close_button_MouseEnter(object sender, EventArgs e)
        {
            Close_button.Image = Properties.Resources.Close_button_enter;
        }
        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.Image = Properties.Resources.Close_button_leave;
        }
        private void main_menu_MouseMove(object sender, MouseEventArgs e)
        {
            
            if(LoginTB.Text!="")
            {
                Login_panel.BackColor = Color.FromArgb(217, 35, 73);
                LoginP.Image = Properties.Resources.Login_on;
            }
            else
            {
                Login_panel.BackColor = Color.FromArgb(227, 213, 212);
                LoginP.Image = Properties.Resources.Login;
            }
            if (PasswordTB.Text != "")
            {
                Password_panel.BackColor = Color.FromArgb(217, 35, 73);
                PasswordP.Image = Properties.Resources.Password_on;
            }
            else
            {
                Password_panel.BackColor = Color.FromArgb(227, 213, 212);
                PasswordP.Image = Properties.Resources.Password;
            }
        }

        private void LoginB_MouseEnter(object sender, EventArgs e)
        {
            LoginB.ForeColor = Color.FromArgb(217, 35, 73);
        }

        private void LoginB_MouseLeave(object sender, EventArgs e)
        {
            LoginB.ForeColor = Color.FromArgb(227, 213, 212);
        }

        private void NewB_MouseEnter(object sender, EventArgs e)
        {
            NewB.ForeColor = Color.FromArgb(217, 35, 73);
        }

        private void NewB_MouseLeave(object sender, EventArgs e)
        {
            NewB.ForeColor = Color.FromArgb(227, 213, 212);
        }

        private void IdkB_MouseEnter(object sender, EventArgs e)
        {
            IdkB.ForeColor = Color.FromArgb(217, 35, 73);
        }

        private void IdkB_MouseLeave(object sender, EventArgs e)
        {
            IdkB.ForeColor = Color.FromArgb(227, 213, 212);
        }

        private void LoginTB_MouseEnter(object sender, EventArgs e)
        {
            Login_panel.BackColor= Color.FromArgb(217, 35, 73);
            LoginP.Image = Properties.Resources.Login_on;
        }

        private void LoginTB_MouseLeave(object sender, EventArgs e)
        {
            Login_panel.BackColor = Color.FromArgb(227, 213, 212);
            LoginP.Image = Properties.Resources.Login;
        }

        private void PasswordTB_MouseEnter(object sender, EventArgs e)
        {
            Password_panel.BackColor = Color.FromArgb(217, 35, 73);
            PasswordP.Image = Properties.Resources.Password_on;
        }

        private void PasswordTB_MouseLeave(object sender, EventArgs e)
        {
            Password_panel.BackColor = Color.FromArgb(227, 213, 212);
            PasswordP.Image = Properties.Resources.Password;
        }

        private void NewB_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewUser newUser = new NewUser();
            DialogResult dialogResult = new DialogResult();
            dialogResult = newUser.ShowDialog();
            this.Show();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            string query = $"SELECT * FROM [Delivery service user] WHERE Login='{LoginTB.Text}' ";
            cmd = new SqlCommand(query, connection);
            reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("Неправильный логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                reader.Close();
                return;
            }
            else
            {
                reader.Close();
                query = $"SELECT id FROM [Delivery service user] WHERE Login='{LoginTB.Text}' and Password='{PasswordTB.Text}'";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    string id = cmd.ExecuteScalar().ToString();
                    
                    query = $"SELECT * FROM [Delivery service client] WHERE [User id]={Convert.ToInt32(id)}";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        this.Hide();
                        ForClient forClient = new ForClient(id);
                        DialogResult dialogResult = new DialogResult();
                        dialogResult = forClient.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        reader.Close();
                        query = $"SELECT * FROM [Delivery service employee] WHERE [User id]={id}";
                        cmd = new SqlCommand(query, connection);
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            this.Hide();
                            ForEmployee forEmployee = new ForEmployee(id);
                            DialogResult dialogResult = new DialogResult();
                            dialogResult = forEmployee.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            reader.Close();
                            query = $"SELECT * FROM [Delivery service owner] WHERE [User id]={id}";
                            cmd = new SqlCommand(query, connection);
                            reader = cmd.ExecuteReader();
                            if (reader.HasRows)
                            {
                                this.Hide();
                                ForOwner forOwner = new ForOwner(id);
                                DialogResult dialogResult = new DialogResult();
                                dialogResult = forOwner.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                //this.Hide();
                                //ForEmployee forEmployee = new ForEmployee(id);
                                //DialogResult dialogResult = new DialogResult();
                                //dialogResult = forEmployee.ShowDialog();
                                //this.Show();
                            }

                        }
                    }

                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                connection.Close();
            }
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            PasswordTB.PasswordChar = '\0';
            pictureBox1.Image = Properties.Resources.Open_pass_on;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PasswordTB.PasswordChar = '*';
            pictureBox1.Image = Properties.Resources.Open_pass;
        }

        private void IdkB_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResPass resPass = new ResPass();
            DialogResult dialogResult = new DialogResult();
            dialogResult = resPass.ShowDialog();
            this.Show();
        }
    }
}
