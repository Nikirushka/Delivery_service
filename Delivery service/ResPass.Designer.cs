namespace Delivery_service
{
    partial class ResPass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResPass));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.restore_menu = new System.Windows.Forms.Panel();
            this.EmailTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo_pic = new System.Windows.Forms.PictureBox();
            this.LoginB = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.PictureBox();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.restore_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_button)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // restore_menu
            // 
            this.restore_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.restore_menu.Controls.Add(this.EmailTextBox);
            this.restore_menu.Controls.Add(this.label1);
            this.restore_menu.Controls.Add(this.Logo_pic);
            this.restore_menu.Controls.Add(this.LoginB);
            this.restore_menu.Controls.Add(this.Close_button);
            this.restore_menu.Location = new System.Drawing.Point(9, 10);
            this.restore_menu.Margin = new System.Windows.Forms.Padding(2);
            this.restore_menu.Name = "restore_menu";
            this.restore_menu.Size = new System.Drawing.Size(260, 253);
            this.restore_menu.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.EmailTextBox.BaseColor = System.Drawing.Color.White;
            this.EmailTextBox.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.EmailTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmailTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailTextBox.Location = new System.Drawing.Point(7, 142);
            this.EmailTextBox.MultiLine = true;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.Radius = 7;
            this.EmailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailTextBox.Size = new System.Drawing.Size(244, 45);
            this.EmailTextBox.TabIndex = 14;
            this.EmailTextBox.Text = "Email";
            this.EmailTextBox.TextOffsetX = 7;
            this.EmailTextBox.Click += new System.EventHandler(this.EmailTextBox_MouseClick);
            this.EmailTextBox.Enter += new System.EventHandler(this.EmailTextBox_MouseClick);
            this.EmailTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EmailTextBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(27, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите ваш Email";
            // 
            // Logo_pic
            // 
            this.Logo_pic.Image = global::Delivery_service.Properties.Resources.Delivery_png;
            this.Logo_pic.Location = new System.Drawing.Point(81, 5);
            this.Logo_pic.Margin = new System.Windows.Forms.Padding(2);
            this.Logo_pic.Name = "Logo_pic";
            this.Logo_pic.Size = new System.Drawing.Size(94, 102);
            this.Logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_pic.TabIndex = 6;
            this.Logo_pic.TabStop = false;
            // 
            // LoginB
            // 
            this.LoginB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.LoginB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginB.FlatAppearance.BorderSize = 2;
            this.LoginB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.LoginB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(212)))));
            this.LoginB.Location = new System.Drawing.Point(7, 196);
            this.LoginB.Margin = new System.Windows.Forms.Padding(2);
            this.LoginB.Name = "LoginB";
            this.LoginB.Size = new System.Drawing.Size(244, 44);
            this.LoginB.TabIndex = 3;
            this.LoginB.Text = "Восстановить";
            this.LoginB.UseVisualStyleBackColor = false;
            this.LoginB.Click += new System.EventHandler(this.LoginB_Click);
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.Image = global::Delivery_service.Properties.Resources.Close_button_leave;
            this.Close_button.Location = new System.Drawing.Point(221, 2);
            this.Close_button.Margin = new System.Windows.Forms.Padding(2);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(38, 41);
            this.Close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_button.TabIndex = 0;
            this.Close_button.TabStop = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            this.Close_button.MouseEnter += new System.EventHandler(this.Close_button_MouseEnter);
            this.Close_button.MouseLeave += new System.EventHandler(this.Close_button_MouseLeave);
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.restore_menu;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.restore_menu;
            // 
            // ResPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(213)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(278, 274);
            this.Controls.Add(this.restore_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResPass";
            this.restore_menu.ResumeLayout(false);
            this.restore_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel restore_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logo_pic;
        private System.Windows.Forms.Button LoginB;
        private System.Windows.Forms.PictureBox Close_button;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaTextBox EmailTextBox;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
    }
}