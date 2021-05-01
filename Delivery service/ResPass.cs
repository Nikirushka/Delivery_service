using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery_service
{
    public partial class ResPass : Form
    {
        SqlConnection connection;
        SqlDataReader reader = null;
        SqlCommand cmd;

        string name, surname, phone, email, log, pass, patr;

        private void EmailTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            EmailTextBox.Text = "";
        }

        private void EmailTextBox_MouseClick(object sender, EventArgs e)
        {
            EmailTextBox.Text = "";
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|Delivery_service.mdf';Integrated Security=True;Connect Timeout=30";
        public ResPass()
        {
            InitializeComponent();
        }

        private void Close_button_MouseEnter(object sender, EventArgs e)
        {
            Close_button.Image = Properties.Resources.Close_button_enter;
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.Image = Properties.Resources.Close_button_leave;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            //gPq4gjXcvXCh82jvV9n098xCbRc0w444PqYZH223ZDt0w4LxbGfawsU1bzpPxo8n7HcAN7q1c8rK2iu7aP986nTvLphvLhc1pyoX
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                int id = 0;
                string query = $"exec GetIDbyEmail N'{EmailTextBox.Text}'";
                cmd = new SqlCommand(query, connection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader[0]);
                    }
                    reader.Close();
                    query = $"select * from [Delivery service user] where id={id}";
                    cmd = new SqlCommand(query, connection);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        name = reader[2].ToString();
                        surname = reader[1].ToString();
                        patr = reader[3].ToString();
                        phone = reader[5].ToString();
                        email = reader[6].ToString();
                        log = reader[8].ToString();
                        pass = reader[9].ToString();
                    }
                    MailAddress fromMailAddress = new MailAddress("help.delivery.service@gmail.com", "Support Delivery Service");
                    MailAddress toAddress = new MailAddress($"{EmailTextBox.Text}");
                    MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress);
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Subject = "Восстановление пароля - Delivery Service";
                    mailMessage.Body = $"log:{log},pas:{pass}" + @"<h2>Письмо-тест работы smtp-клиента</h2><font size=""5""face = ""Helvetica"" > Здравствуйте, это служба поддержки <b>Delivery Service<b></ font >";
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.Credentials = new NetworkCredential("help.delivery.service@gmail.com", "gPq4gjXcvXCh82jvV9n098xCbRc0w444PqYZH223ZDt0w4LxbGfawsU1bzpPxo8n7HcAN7q1c8rK2iu7aP986nTvLphvLhc1pyoX");
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mailMessage);
                    MessageBox.Show("Ваши данные успешно отправлены на вашу почту!", "Восстановление пароля - Delivery Service");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Пользователя с таким электронным адресом не существует!", "Ошибка!");
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
