namespace EstateAgency
{
    partial class PaymentForm
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
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PaymentTypeCB = new System.Windows.Forms.ComboBox();
            this.PaymentInstrumentCB = new System.Windows.Forms.ComboBox();
            this.PIl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(12, 91);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(138, 22);
            this.PhoneTextBox.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(12, 144);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(138, 22);
            this.EmailTextBox.TabIndex = 1;
            // 
            // PaymentTypeCB
            // 
            this.PaymentTypeCB.FormattingEnabled = true;
            this.PaymentTypeCB.Location = new System.Drawing.Point(18, 232);
            this.PaymentTypeCB.Name = "PaymentTypeCB";
            this.PaymentTypeCB.Size = new System.Drawing.Size(121, 24);
            this.PaymentTypeCB.TabIndex = 2;
            // 
            // PaymentInstrumentCB
            // 
            this.PaymentInstrumentCB.FormattingEnabled = true;
            this.PaymentInstrumentCB.Location = new System.Drawing.Point(145, 232);
            this.PaymentInstrumentCB.Name = "PaymentInstrumentCB";
            this.PaymentInstrumentCB.Size = new System.Drawing.Size(121, 24);
            this.PaymentInstrumentCB.TabIndex = 3;
            // 
            // PIl
            // 
            this.PIl.AutoSize = true;
            this.PIl.Location = new System.Drawing.Point(142, 212);
            this.PIl.Name = "PIl";
            this.PIl.Size = new System.Drawing.Size(109, 17);
            this.PIl.TabIndex = 4;
            this.PIl.Text = "Способ оплаты";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Электронная почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пожалуйста, свяжитесь с менеджером\r\n            для подписания договора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выберете способ оплаты";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PIl);
            this.Controls.Add(this.PaymentInstrumentCB);
            this.Controls.Add(this.PaymentTypeCB);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox PhoneTextBox;
        public System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.ComboBox PaymentTypeCB;
        private System.Windows.Forms.ComboBox PaymentInstrumentCB;
        private System.Windows.Forms.Label PIl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}