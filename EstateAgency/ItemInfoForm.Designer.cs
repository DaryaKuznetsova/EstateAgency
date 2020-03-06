namespace EstateAgency
{
    partial class ItemInfoForm
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
            this.LandAreaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LandTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomsTextBox = new System.Windows.Forms.TextBox();
            this.BuyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOwnerButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DistrictComboBox = new System.Windows.Forms.ComboBox();
            this.TradeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.RealtyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.OwnerComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PrevImageButton = new System.Windows.Forms.Button();
            this.NextImageButton = new System.Windows.Forms.Button();
            this.AddImageButton = new System.Windows.Forms.Button();
            this.DeleteImageButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LandAreaTextBox
            // 
            this.LandAreaTextBox.Location = new System.Drawing.Point(148, 419);
            this.LandAreaTextBox.Name = "LandAreaTextBox";
            this.LandAreaTextBox.Size = new System.Drawing.Size(116, 22);
            this.LandAreaTextBox.TabIndex = 44;
            this.LandAreaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LandAreaTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Площадь участка";
            // 
            // LandTextBox
            // 
            this.LandTextBox.Location = new System.Drawing.Point(15, 345);
            this.LandTextBox.Multiline = true;
            this.LandTextBox.Name = "LandTextBox";
            this.LandTextBox.Size = new System.Drawing.Size(469, 68);
            this.LandTextBox.TabIndex = 42;
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(97, 317);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(100, 22);
            this.areaTextBox.TabIndex = 41;
            this.areaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.areaTextBox_KeyPress);
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(14, 317);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(68, 17);
            this.AreaLabel.TabIndex = 40;
            this.AreaLabel.Text = "Площадь";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(97, 202);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.AddressTextBox.TabIndex = 39;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(97, 174);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.PriceTextBox.TabIndex = 38;
            this.PriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceTextBox_KeyPress);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(10, 230);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(475, 67);
            this.DescriptionTextBox.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Владелец";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Адрес";
            // 
            // RoomsTextBox
            // 
            this.RoomsTextBox.Location = new System.Drawing.Point(384, 317);
            this.RoomsTextBox.Name = "RoomsTextBox";
            this.RoomsTextBox.Size = new System.Drawing.Size(100, 22);
            this.RoomsTextBox.TabIndex = 52;
            this.RoomsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RoomsTextBox_KeyPress);
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(148, 641);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(75, 23);
            this.BuyButton.TabIndex = 54;
            this.BuyButton.Text = "Купить";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(238, 641);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 55;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(212, 602);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(137, 23);
            this.ChangeButton.TabIndex = 56;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Количество комнат";
            // 
            // AddOwnerButton
            // 
            this.AddOwnerButton.Location = new System.Drawing.Point(224, 144);
            this.AddOwnerButton.Name = "AddOwnerButton";
            this.AddOwnerButton.Size = new System.Drawing.Size(75, 23);
            this.AddOwnerButton.TabIndex = 59;
            this.AddOwnerButton.Text = "Добавть";
            this.AddOwnerButton.UseVisualStyleBackColor = true;
            this.AddOwnerButton.Click += new System.EventHandler(this.AddOwnerButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(356, 641);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 23);
            this.AddButton.TabIndex = 60;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DistrictComboBox
            // 
            this.DistrictComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DistrictComboBox.FormattingEnabled = true;
            this.DistrictComboBox.Location = new System.Drawing.Point(15, 71);
            this.DistrictComboBox.Name = "DistrictComboBox";
            this.DistrictComboBox.Size = new System.Drawing.Size(173, 24);
            this.DistrictComboBox.TabIndex = 63;
            // 
            // TradeTypeComboBox
            // 
            this.TradeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TradeTypeComboBox.FormattingEnabled = true;
            this.TradeTypeComboBox.Items.AddRange(new object[] {
            "Купить",
            "Снять",
            "Посуточно"});
            this.TradeTypeComboBox.Location = new System.Drawing.Point(17, 12);
            this.TradeTypeComboBox.Name = "TradeTypeComboBox";
            this.TradeTypeComboBox.Size = new System.Drawing.Size(149, 24);
            this.TradeTypeComboBox.TabIndex = 62;
            // 
            // RealtyTypeComboBox
            // 
            this.RealtyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RealtyTypeComboBox.FormattingEnabled = true;
            this.RealtyTypeComboBox.Items.AddRange(new object[] {
            "Квартира",
            "Комната",
            "Дом"});
            this.RealtyTypeComboBox.Location = new System.Drawing.Point(14, 42);
            this.RealtyTypeComboBox.Name = "RealtyTypeComboBox";
            this.RealtyTypeComboBox.Size = new System.Drawing.Size(174, 24);
            this.RealtyTypeComboBox.TabIndex = 61;
            this.RealtyTypeComboBox.ValueMemberChanged += new System.EventHandler(this.RealtyTypeComboBox_ValueMemberChanged);
            this.RealtyTypeComboBox.TextChanged += new System.EventHandler(this.RealtyTypeComboBox_TextChanged);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(212, 12);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(121, 24);
            this.StatusComboBox.TabIndex = 64;
            // 
            // OwnerComboBox
            // 
            this.OwnerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OwnerComboBox.FormattingEnabled = true;
            this.OwnerComboBox.Location = new System.Drawing.Point(97, 144);
            this.OwnerComboBox.Name = "OwnerComboBox";
            this.OwnerComboBox.Size = new System.Drawing.Size(121, 24);
            this.OwnerComboBox.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(569, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 402);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // PrevImageButton
            // 
            this.PrevImageButton.Location = new System.Drawing.Point(527, 273);
            this.PrevImageButton.Name = "PrevImageButton";
            this.PrevImageButton.Size = new System.Drawing.Size(36, 23);
            this.PrevImageButton.TabIndex = 67;
            this.PrevImageButton.Text = "<";
            this.PrevImageButton.UseVisualStyleBackColor = true;
            this.PrevImageButton.Click += new System.EventHandler(this.PrevImageButton_Click);
            // 
            // NextImageButton
            // 
            this.NextImageButton.Location = new System.Drawing.Point(963, 273);
            this.NextImageButton.Name = "NextImageButton";
            this.NextImageButton.Size = new System.Drawing.Size(34, 23);
            this.NextImageButton.TabIndex = 68;
            this.NextImageButton.Text = ">";
            this.NextImageButton.UseVisualStyleBackColor = true;
            this.NextImageButton.Click += new System.EventHandler(this.NextImageButton_Click);
            // 
            // AddImageButton
            // 
            this.AddImageButton.Location = new System.Drawing.Point(569, 496);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(75, 23);
            this.AddImageButton.TabIndex = 69;
            this.AddImageButton.Text = "Добавть";
            this.AddImageButton.UseVisualStyleBackColor = true;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            // 
            // DeleteImageButton
            // 
            this.DeleteImageButton.Location = new System.Drawing.Point(820, 495);
            this.DeleteImageButton.Name = "DeleteImageButton";
            this.DeleteImageButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteImageButton.TabIndex = 70;
            this.DeleteImageButton.Text = "Удалить изображение";
            this.DeleteImageButton.UseVisualStyleBackColor = true;
            this.DeleteImageButton.Click += new System.EventHandler(this.DeleteImageButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(499, 601);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 71;
            this.acceptButton.Text = "Подтвердить";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // ItemInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 682);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.DeleteImageButton);
            this.Controls.Add(this.AddImageButton);
            this.Controls.Add(this.NextImageButton);
            this.Controls.Add(this.PrevImageButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OwnerComboBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.DistrictComboBox);
            this.Controls.Add(this.TradeTypeComboBox);
            this.Controls.Add(this.RealtyTypeComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddOwnerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.RoomsTextBox);
            this.Controls.Add(this.LandAreaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LandTextBox);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "ItemInfoForm";
            this.Text = "ItemInfoForm";
            this.Load += new System.EventHandler(this.ItemInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        public System.Windows.Forms.TextBox LandAreaTextBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox LandTextBox;
        public System.Windows.Forms.TextBox areaTextBox;
        public System.Windows.Forms.Label AreaLabel;
        public System.Windows.Forms.TextBox AddressTextBox;
        public System.Windows.Forms.TextBox PriceTextBox;
        public System.Windows.Forms.TextBox DescriptionTextBox;
        public System.Windows.Forms.TextBox RoomsTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button AddOwnerButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox DistrictComboBox;
        private System.Windows.Forms.ComboBox TradeTypeComboBox;
        private System.Windows.Forms.ComboBox RealtyTypeComboBox;
        public System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.ComboBox OwnerComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PrevImageButton;
        private System.Windows.Forms.Button NextImageButton;
        private System.Windows.Forms.Button AddImageButton;
        private System.Windows.Forms.Button DeleteImageButton;
        private System.Windows.Forms.Button acceptButton;
    }
}