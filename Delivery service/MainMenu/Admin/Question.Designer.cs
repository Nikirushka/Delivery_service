namespace Delivery_service
{
    partial class Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Close_button = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.QuestionTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Close_button)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 15;
            this.gunaElipse1.TargetControl = this;
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_button.Image = global::Delivery_service.Properties.Resources.Close_button_leave2;
            this.Close_button.Location = new System.Drawing.Point(600, 11);
            this.Close_button.Margin = new System.Windows.Forms.Padding(2);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(38, 41);
            this.Close_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_button.TabIndex = 1;
            this.Close_button.TabStop = false;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            this.Close_button.MouseEnter += new System.EventHandler(this.Close_button_MouseEnter);
            this.Close_button.MouseLeave += new System.EventHandler(this.Close_button_MouseLeave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(198, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(249, 32);
            this.label20.TabIndex = 2;
            this.label20.Text = "Ответить на вопрос";
            // 
            // gunaButton2
            // 
            this.gunaButton2.Animated = true;
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(236, 332);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(35)))), ((int)(((byte)(73)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 7;
            this.gunaButton2.Size = new System.Drawing.Size(179, 31);
            this.gunaButton2.TabIndex = 26;
            this.gunaButton2.Text = "Ответить";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.BackColor = System.Drawing.Color.Transparent;
            this.QuestionTextBox.BaseColor = System.Drawing.Color.White;
            this.QuestionTextBox.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.QuestionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuestionTextBox.FocusedBaseColor = System.Drawing.Color.WhiteSmoke;
            this.QuestionTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.QuestionTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.QuestionTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QuestionTextBox.Location = new System.Drawing.Point(12, 178);
            this.QuestionTextBox.MultiLine = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.PasswordChar = '\0';
            this.QuestionTextBox.Radius = 7;
            this.QuestionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuestionTextBox.Size = new System.Drawing.Size(626, 148);
            this.QuestionTextBox.TabIndex = 27;
            this.QuestionTextBox.Text = "Ответ";
            this.QuestionTextBox.TextOffsetX = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 123);
            this.label1.TabIndex = 28;
            this.label1.Text = "Вопрос";
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(648, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Close_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Question_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Close_button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.PictureBox Close_button;
        private System.Windows.Forms.Label label20;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox QuestionTextBox;
    }
}