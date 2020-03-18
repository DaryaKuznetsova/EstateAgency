namespace EstateAgency
{
    partial class RegistrationForm
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
            this.SurnameLable = new System.Windows.Forms.Label();
            this.NameLable = new System.Windows.Forms.Label();
            this.PatronymicLable = new System.Windows.Forms.Label();
            this.PhoneLable = new System.Windows.Forms.Label();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.Password2Lable = new System.Windows.Forms.Label();
            this.ManagerCheckBox = new System.Windows.Forms.CheckBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Password2TextBox = new System.Windows.Forms.TextBox();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SurnameLable
            // 
            this.SurnameLable.AutoSize = true;
            this.SurnameLable.Location = new System.Drawing.Point(64, 66);
            this.SurnameLable.Name = "SurnameLable";
            this.SurnameLable.Size = new System.Drawing.Size(70, 17);
            this.SurnameLable.TabIndex = 0;
            this.SurnameLable.Text = "Фамилия";
            // 
            // NameLable
            // 
            this.NameLable.AutoSize = true;
            this.NameLable.Location = new System.Drawing.Point(64, 94);
            this.NameLable.Name = "NameLable";
            this.NameLable.Size = new System.Drawing.Size(35, 17);
            this.NameLable.TabIndex = 1;
            this.NameLable.Text = "Имя";
            // 
            // PatronymicLable
            // 
            this.PatronymicLable.AutoSize = true;
            this.PatronymicLable.Location = new System.Drawing.Point(64, 122);
            this.PatronymicLable.Name = "PatronymicLable";
            this.PatronymicLable.Size = new System.Drawing.Size(71, 17);
            this.PatronymicLable.TabIndex = 2;
            this.PatronymicLable.Text = "Отчество";
            // 
            // PhoneLable
            // 
            this.PhoneLable.AutoSize = true;
            this.PhoneLable.Location = new System.Drawing.Point(64, 150);
            this.PhoneLable.Name = "PhoneLable";
            this.PhoneLable.Size = new System.Drawing.Size(121, 17);
            this.PhoneLable.TabIndex = 3;
            this.PhoneLable.Text = "Номер телефона";
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.Location = new System.Drawing.Point(64, 207);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(57, 17);
            this.PasswordLable.TabIndex = 4;
            this.PasswordLable.Text = "Пароль";
            // 
            // Password2Lable
            // 
            this.Password2Lable.AutoSize = true;
            this.Password2Lable.Location = new System.Drawing.Point(64, 235);
            this.Password2Lable.Name = "Password2Lable";
            this.Password2Lable.Size = new System.Drawing.Size(130, 17);
            this.Password2Lable.TabIndex = 5;
            this.Password2Lable.Text = "Повторите пароль";
            // 
            // ManagerCheckBox
            // 
            this.ManagerCheckBox.AutoSize = true;
            this.ManagerCheckBox.Location = new System.Drawing.Point(129, 281);
            this.ManagerCheckBox.Name = "ManagerCheckBox";
            this.ManagerCheckBox.Size = new System.Drawing.Size(110, 21);
            this.ManagerCheckBox.TabIndex = 15;
            this.ManagerCheckBox.Text = "Я менеджер";
            this.ManagerCheckBox.UseVisualStyleBackColor = true;
            this.ManagerCheckBox.CheckedChanged += new System.EventHandler(this.ManagerCheckBox_CheckedChanged);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(101, 334);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(167, 33);
            this.RegistrationButton.TabIndex = 16;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(196, 61);
            this.SurnameTextBox.MaxLength = 20;
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 22);
            this.SurnameTextBox.TabIndex = 8;
            this.SurnameTextBox.TextChanged += new System.EventHandler(this.SurnameTextBox_TextChanged);
            this.SurnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurnameTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(196, 89);
            this.NameTextBox.MaxLength = 20;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 9;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(196, 117);
            this.PatronymicTextBox.MaxLength = 20;
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(100, 22);
            this.PatronymicTextBox.TabIndex = 10;
            this.PatronymicTextBox.TextChanged += new System.EventHandler(this.PatronymicTextBox_TextChanged);
            this.PatronymicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PatronymicTextBox_KeyPress);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(196, 145);
            this.PhoneTextBox.MaxLength = 12;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.PhoneTextBox.TabIndex = 11;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            this.PhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTextBox_KeyPress);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(196, 202);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordTextBox.TabIndex = 13;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // Password2TextBox
            // 
            this.Password2TextBox.Location = new System.Drawing.Point(196, 230);
            this.Password2TextBox.Name = "Password2TextBox";
            this.Password2TextBox.Size = new System.Drawing.Size(100, 22);
            this.Password2TextBox.TabIndex = 14;
            this.Password2TextBox.TextChanged += new System.EventHandler(this.Password2TextBox_TextChanged);
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(210, 306);
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.CodeTextBox.TabIndex = 17;
            this.CodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeTextBox_KeyPress);
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Location = new System.Drawing.Point(64, 311);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(140, 17);
            this.CodeLabel.TabIndex = 15;
            this.CodeLabel.Text = "Код подтверждения";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(64, 179);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(42, 17);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(196, 174);
            this.EmailTextBox.MaxLength = 32;
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 22);
            this.EmailTextBox.TabIndex = 12;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 447);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.Password2TextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.ManagerCheckBox);
            this.Controls.Add(this.Password2Lable);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.PhoneLable);
            this.Controls.Add(this.PatronymicLable);
            this.Controls.Add(this.NameLable);
            this.Controls.Add(this.SurnameLable);
            this.Name = "RegistrationForm";
            this.Text = "Estate Agency Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SurnameLable;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label PatronymicLable;
        private System.Windows.Forms.Label PhoneLable;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Label Password2Lable;
        private System.Windows.Forms.CheckBox ManagerCheckBox;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox Password2TextBox;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
    }
}