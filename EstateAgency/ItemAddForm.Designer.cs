namespace EstateAgency
{
    partial class ItemAddForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.RealtyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TradeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DistrictComboBox = new System.Windows.Forms.ComboBox();
            this.RoomsComboBox = new System.Windows.Forms.ComboBox();
            this.AddOwnerButton = new System.Windows.Forms.Button();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.LandTextBox = new System.Windows.Forms.TextBox();
            this.LandAreaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Владелец";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 198);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(475, 67);
            this.DescriptionTextBox.TabIndex = 9;
            // 
            // RealtyTypeComboBox
            // 
            this.RealtyTypeComboBox.FormattingEnabled = true;
            this.RealtyTypeComboBox.Items.AddRange(new object[] {
            "Комната",
            "Дом",
            "Квартира"});
            this.RealtyTypeComboBox.Location = new System.Drawing.Point(16, 12);
            this.RealtyTypeComboBox.Name = "RealtyTypeComboBox";
            this.RealtyTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.RealtyTypeComboBox.TabIndex = 12;
            this.RealtyTypeComboBox.Text = "Жилая недвижимость";
            this.RealtyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.RealtyTypeComboBox_SelectedIndexChanged);
            // 
            // TradeTypeComboBox
            // 
            this.TradeTypeComboBox.FormattingEnabled = true;
            this.TradeTypeComboBox.Items.AddRange(new object[] {
            "Купить",
            "Снять",
            "Посуточно"});
            this.TradeTypeComboBox.Location = new System.Drawing.Point(143, 12);
            this.TradeTypeComboBox.Name = "TradeTypeComboBox";
            this.TradeTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.TradeTypeComboBox.TabIndex = 13;
            this.TradeTypeComboBox.Text = "Купить";
            // 
            // DistrictComboBox
            // 
            this.DistrictComboBox.FormattingEnabled = true;
            this.DistrictComboBox.Items.AddRange(new object[] {
            "Свердловский",
            "Кировский",
            "Индустриальный"});
            this.DistrictComboBox.Location = new System.Drawing.Point(270, 12);
            this.DistrictComboBox.Name = "DistrictComboBox";
            this.DistrictComboBox.Size = new System.Drawing.Size(121, 24);
            this.DistrictComboBox.TabIndex = 15;
            this.DistrictComboBox.Text = "Район";
            // 
            // RoomsComboBox
            // 
            this.RoomsComboBox.FormattingEnabled = true;
            this.RoomsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6+"});
            this.RoomsComboBox.Location = new System.Drawing.Point(204, 272);
            this.RoomsComboBox.Name = "RoomsComboBox";
            this.RoomsComboBox.Size = new System.Drawing.Size(121, 24);
            this.RoomsComboBox.TabIndex = 16;
            this.RoomsComboBox.Text = "Количество комнат";
            // 
            // AddOwnerButton
            // 
            this.AddOwnerButton.Location = new System.Drawing.Point(98, 77);
            this.AddOwnerButton.Name = "AddOwnerButton";
            this.AddOwnerButton.Size = new System.Drawing.Size(91, 23);
            this.AddOwnerButton.TabIndex = 18;
            this.AddOwnerButton.Text = "Добавить";
            this.AddOwnerButton.UseVisualStyleBackColor = true;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(98, 117);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 22);
            this.PriceTextBox.TabIndex = 19;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(98, 159);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(100, 22);
            this.AddressTextBox.TabIndex = 20;
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(15, 272);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(68, 17);
            this.AreaLabel.TabIndex = 21;
            this.AreaLabel.Text = "Площадь";
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(98, 272);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(100, 22);
            this.areaTextBox.TabIndex = 22;
            // 
            // LandTextBox
            // 
            this.LandTextBox.Location = new System.Drawing.Point(18, 313);
            this.LandTextBox.Multiline = true;
            this.LandTextBox.Name = "LandTextBox";
            this.LandTextBox.Size = new System.Drawing.Size(469, 68);
            this.LandTextBox.TabIndex = 23;
            // 
            // LandAreaTextBox
            // 
            this.LandAreaTextBox.Location = new System.Drawing.Point(148, 402);
            this.LandAreaTextBox.Name = "LandAreaTextBox";
            this.LandAreaTextBox.Size = new System.Drawing.Size(116, 22);
            this.LandAreaTextBox.TabIndex = 25;
            this.LandAreaTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Площадь участка";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 445);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(469, 82);
            this.textBox3.TabIndex = 26;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(89, 560);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(127, 23);
            this.CancelButton.TabIndex = 27;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(270, 560);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 23);
            this.AddButton.TabIndex = 28;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ItemAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 630);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LandAreaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LandTextBox);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.AddOwnerButton);
            this.Controls.Add(this.RoomsComboBox);
            this.Controls.Add(this.DistrictComboBox);
            this.Controls.Add(this.TradeTypeComboBox);
            this.Controls.Add(this.RealtyTypeComboBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "ItemAddForm";
            this.Text = "ItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ComboBox TradeTypeComboBox;
        private System.Windows.Forms.ComboBox DistrictComboBox;
        private System.Windows.Forms.ComboBox RoomsComboBox;
        private System.Windows.Forms.Button AddOwnerButton;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox LandTextBox;
        private System.Windows.Forms.TextBox LandAreaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.ComboBox RealtyTypeComboBox;
    }
}