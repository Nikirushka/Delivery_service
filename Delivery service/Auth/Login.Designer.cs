namespace Delivery_service
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Main_menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Password_panel = new System.Windows.Forms.Panel();
            this.Login_panel = new System.Windows.Forms.Panel();
            this.PasswordP = new System.Windows.Forms.PictureBox();
            this.LoginP = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo_pic = new System.Windows.Forms.PictureBox();
            this.IdkB = new System.Windows.Forms.Button();
            this.NewB = new System.Windows.Forms.Button();
            this.LoginB = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.Close_button = new System.Windows.Forms.PictureBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Main_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_button)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_menu
            // 
            this.Main_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.Main_menu.Controls.Add(this.pictureBox1);
            this.Main_menu.Controls.Add(this.Password_panel);
            this.Main_menu.Controls.Add(this.Login_panel);
            this.Main_menu.Controls.Add(this.PasswordP);
            this.Main_menu.Controls.Add(this.LoginP);
            this.Main_menu.Controls.Add(this.label2);
            this.Main_menu.Controls.Add(this.label1);
            this.Main_menu.Controls.Add(this.Logo_pic);
            this.Main_menu.Controls.Add(this.IdkB);
            this.Main_menu.Controls.Add(this.NewB);
            this.Main_menu.Controls.Add(this.LoginB);
            this.Main_menu.Controls.Add(this.PasswordTB);
            this.Main_menu.Controls.Add(this.LoginTB);
            this.Main_menu.Controls.Add(this.Close_button);
            this.Main_menu.Location = new System.Drawing.Point(9, 10);
            this.Main_menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Main_menu.Name = "Main_menu";
            this.Main_menu.Size = new System.Drawing.Size(357, 387);
            this.Main_menu.TabIndex = 0;
            this.Main_menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_menu_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Delivery_service.Properties.Resources.Open_pass;
            this.pictureBox1.Location = new System.Drawing.Point(276, 206);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Password_panel
            // 
            this.Password_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(212)))));
            this.Password_panel.Location = new System.Drawing.Point(58, 237);
            this.Password_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password_panel.Name = "Password_panel";
            this.Password_panel.Size = new System.Drawing.Size(244, 1);
            this.Password_panel.TabIndex = 12;
            // 
            // Login_panel
            // 
            this.Login_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(212)))));
            this.Login_panel.Location = new System.Drawing.Point(58, 171);
            this.Login_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(244, 1);
            this.Login_panel.TabIndex = 11;
            // 
            // PasswordP
            // 
            this.PasswordP.Image = global::Delivery_service.Properties.Resources.Password;
            this.PasswordP.Location = new System.Drawing.Point(58, 206);
            this.PasswordP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordP.Name = "PasswordP";
            this.PasswordP.Size = new System.Drawing.Size(26, 27);
            this.PasswordP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordP.TabIndex = 10;
            this.PasswordP.TabStop = false;
            this.PasswordP.MouseEnter += new System.EventHandler(this.PasswordTB_MouseEnter);
            this.PasswordP.MouseLeave += new System.EventHandler(this.PasswordTB_MouseLeave);
            // 
            // LoginP
            // 
            this.LoginP.Image = global::Delivery_service.Properties.Resources.Login;
            this.LoginP.Location = new System.Drawing.Point(58, 140);
            this.LoginP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginP.Name = "LoginP";
            this.LoginP.Size = new System.Drawing.Size(26, 27);
            this.LoginP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginP.TabIndex = 9;
            this.LoginP.TabStop = false;
            this.LoginP.MouseEnter += new System.EventHandler(this.LoginTB_MouseEnter);
            this.LoginP.MouseLeave += new System.EventHandler(this.LoginTB_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(53, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(52, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин ";
            // 
            // Logo_pic
            // 
            this.Logo_pic.Image = global::Delivery_service.Properties.Resources.Delivery_png;
            this.Logo_pic.Location = new System.Drawing.Point(131, 5);
            this.Logo_pic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logo_pic.Name = "Logo_pic";
            this.Logo_pic.Size = new System.Drawing.Size(94, 102);
            this.Logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_pic.TabIndex = 6;
            this.Logo_pic.TabStop = false;
            // 
            // IdkB
            // 
            this.IdkB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IdkB.FlatAppearance.BorderSize = 0;
            this.IdkB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdkB.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdkB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(212)))));
            this.IdkB.Location = new System.Drawing.Point(58, 340);
            this.IdkB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdkB.Name = "IdkB";
            this.IdkB.Size = new System.Drawing.Size(244, 44);
            this.IdkB.TabIndex = 5;
            this.IdkB.Text = "Не помню пароль";
            this.IdkB.UseVisualStyleBackColor = true;
            this.IdkB.Click += new System.EventHandler(this.IdkB_Click);
            this.IdkB.MouseEnter += new System.EventHandler(this.IdkB_MouseEnter);
            this.IdkB.MouseLeave += new System.EventHandler(this.IdkB_MouseLeave);
            // 
            // NewB
            // 
            this.NewB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewB.FlatAppearance.BorderSize = 2;
            this.NewB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.NewB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(212)))));
            this.NewB.Location = new System.Drawing.Point(58, 292);
            this.NewB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewB.Name = "NewB";
            this.NewB.Size = new System.Drawing.Size(244, 44);
            this.NewB.TabIndex = 4;
            this.NewB.Text = "Регистрация";
            this.NewB.UseVisualStyleBackColor = true;
            this.NewB.Click += new System.EventHandler(this.NewB_Click);
            this.NewB.MouseEnter += new System.EventHandler(this.NewB_MouseEnter);
            this.NewB.MouseLeave += new System.EventHandler(this.NewB_MouseLeave);
            // 
            // LoginB
            // 
            this.LoginB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.LoginB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginB.FlatAppearance.BorderSize = 2;
            this.LoginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.LoginB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(212)))));
            this.LoginB.Location = new System.Drawing.Point(58, 243);
            this.LoginB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(244, 44);
            this.LoginB.TabIndex = 3;
            this.LoginB.Text = "Войти";
            this.LoginB.UseVisualStyleBackColor = false;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            this.LoginB.MouseEnter += new System.EventHandler(this.LoginB_MouseEnter);
            this.LoginB.MouseLeave += new System.EventHandler(this.LoginB_MouseLeave);
            // 
            // PasswordTB
            // 
            this.PasswordTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.PasswordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.PasswordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.PasswordTB.Location = new System.Drawing.Point(88, 206);
            this.PasswordTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(184, 29);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_MouseEnter);
            this.PasswordTB.MouseEnter += new System.EventHandler(this.PasswordTB_MouseEnter);
            this.PasswordTB.MouseLeave += new System.EventHandler(this.PasswordTB_MouseLeave);
            // 
            // LoginTB
            // 
            this.LoginTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.LoginTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.LoginTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.LoginTB.Location = new System.Drawing.Point(88, 140);
            this.LoginTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(214, 29);
            this.LoginTB.TabIndex = 1;
            this.LoginTB.Click += new System.EventHandler(this.LoginTB_MouseEnter);
            this.LoginTB.TextChanged += new System.EventHandler(this.LoginTB_MouseEnter);
            this.LoginTB.MouseEnter += new System.EventHandler(this.LoginTB_MouseEnter);
            this.LoginTB.MouseLeave += new System.EventHandler(this.LoginTB_MouseLeave);
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.Image = global::Delivery_service.Properties.Resources.Close_button_leave;
            this.Close_button.Location = new System.Drawing.Point(315, 2);
            this.Close_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(38, 41);
            this.Close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_button.TabIndex = 0;
            this.Close_button.TabStop = false;
            this.Close_button.Click += new System.EventHandler(this.pictureBox1_Click);
            this.Close_button.MouseEnter += new System.EventHandler(this.Close_button_MouseEnter);
            this.Close_button.MouseLeave += new System.EventHandler(this.Close_button_MouseLeave);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.Main_menu;
            // 
            // gunaDragControl3
            // 
            this.gunaDragControl3.TargetControl = this.Logo_pic;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.Main_menu;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(376, 406);
            this.Controls.Add(this.Main_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery service";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.main_menu_MouseMove);
            this.Main_menu.ResumeLayout(false);
            this.Main_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_menu;
        private System.Windows.Forms.PictureBox Close_button;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Button IdkB;
        private System.Windows.Forms.Button NewB;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.PictureBox Logo_pic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LoginP;
        private System.Windows.Forms.PictureBox PasswordP;
        private System.Windows.Forms.Panel Login_panel;
        private System.Windows.Forms.Panel Password_panel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
    }
}

