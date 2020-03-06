namespace EstateAgency
{
    partial class SearchObjectForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdvancedSearchButton = new System.Windows.Forms.Button();
            this.LandAreaLabel = new System.Windows.Forms.Label();
            this.LandAreaTextBox2 = new System.Windows.Forms.TextBox();
            this.LandAreaTextBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DistrictComboBox = new System.Windows.Forms.ComboBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AreaMaxTextBox = new System.Windows.Forms.TextBox();
            this.AreaMinTextBox = new System.Windows.Forms.TextBox();
            this.PriceMaxTextBox = new System.Windows.Forms.TextBox();
            this.PriceMinTextBox = new System.Windows.Forms.TextBox();
            this.TradeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.RealtyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(756, 393);
            this.dataGridView1.TabIndex = 37;
            // 
            // AdvancedSearchButton
            // 
            this.AdvancedSearchButton.Location = new System.Drawing.Point(605, 84);
            this.AdvancedSearchButton.Name = "AdvancedSearchButton";
            this.AdvancedSearchButton.Size = new System.Drawing.Size(145, 62);
            this.AdvancedSearchButton.TabIndex = 36;
            this.AdvancedSearchButton.Text = "Расширенный поиск";
            this.AdvancedSearchButton.UseVisualStyleBackColor = true;
            // 
            // LandAreaLabel
            // 
            this.LandAreaLabel.AutoSize = true;
            this.LandAreaLabel.Location = new System.Drawing.Point(488, 68);
            this.LandAreaLabel.Name = "LandAreaLabel";
            this.LandAreaLabel.Size = new System.Drawing.Size(124, 17);
            this.LandAreaLabel.TabIndex = 35;
            this.LandAreaLabel.Text = "Площадь участка";
            // 
            // LandAreaTextBox2
            // 
            this.LandAreaTextBox2.Location = new System.Drawing.Point(543, 93);
            this.LandAreaTextBox2.Name = "LandAreaTextBox2";
            this.LandAreaTextBox2.Size = new System.Drawing.Size(51, 22);
            this.LandAreaTextBox2.TabIndex = 34;
            this.LandAreaTextBox2.Text = "До";
            // 
            // LandAreaTextBox1
            // 
            this.LandAreaTextBox1.Location = new System.Drawing.Point(485, 93);
            this.LandAreaTextBox1.Name = "LandAreaTextBox1";
            this.LandAreaTextBox1.Size = new System.Drawing.Size(52, 22);
            this.LandAreaTextBox1.TabIndex = 33;
            this.LandAreaTextBox1.Text = "От";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6+"});
            this.comboBox1.Location = new System.Drawing.Point(284, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.Text = "Количество комнат";
            // 
            // DistrictComboBox
            // 
            this.DistrictComboBox.FormattingEnabled = true;
            this.DistrictComboBox.Location = new System.Drawing.Point(36, 65);
            this.DistrictComboBox.Name = "DistrictComboBox";
            this.DistrictComboBox.Size = new System.Drawing.Size(173, 24);
            this.DistrictComboBox.TabIndex = 31;
            this.DistrictComboBox.Text = "Район";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(488, 10);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(68, 17);
            this.AreaLabel.TabIndex = 30;
            this.AreaLabel.Text = "Площадь";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(375, 12);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(43, 17);
            this.PriceLabel.TabIndex = 29;
            this.PriceLabel.Text = "Цена";
            // 
            // AreaMaxTextBox
            // 
            this.AreaMaxTextBox.Location = new System.Drawing.Point(543, 35);
            this.AreaMaxTextBox.Name = "AreaMaxTextBox";
            this.AreaMaxTextBox.Size = new System.Drawing.Size(51, 22);
            this.AreaMaxTextBox.TabIndex = 28;
            this.AreaMaxTextBox.Text = "До";
            // 
            // AreaMinTextBox
            // 
            this.AreaMinTextBox.Location = new System.Drawing.Point(485, 35);
            this.AreaMinTextBox.Name = "AreaMinTextBox";
            this.AreaMinTextBox.Size = new System.Drawing.Size(52, 22);
            this.AreaMinTextBox.TabIndex = 27;
            this.AreaMinTextBox.Text = "От";
            // 
            // PriceMaxTextBox
            // 
            this.PriceMaxTextBox.Location = new System.Drawing.Point(428, 35);
            this.PriceMaxTextBox.Name = "PriceMaxTextBox";
            this.PriceMaxTextBox.Size = new System.Drawing.Size(51, 22);
            this.PriceMaxTextBox.TabIndex = 26;
            this.PriceMaxTextBox.Text = "До";
            // 
            // PriceMinTextBox
            // 
            this.PriceMinTextBox.Location = new System.Drawing.Point(370, 35);
            this.PriceMinTextBox.Name = "PriceMinTextBox";
            this.PriceMinTextBox.Size = new System.Drawing.Size(52, 22);
            this.PriceMinTextBox.TabIndex = 25;
            this.PriceMinTextBox.Text = "От";
            // 
            // TradeTypeComboBox
            // 
            this.TradeTypeComboBox.FormattingEnabled = true;
            this.TradeTypeComboBox.Items.AddRange(new object[] {
            "Купить",
            "Снять",
            "Посуточно"});
            this.TradeTypeComboBox.Location = new System.Drawing.Point(215, 33);
            this.TradeTypeComboBox.Name = "TradeTypeComboBox";
            this.TradeTypeComboBox.Size = new System.Drawing.Size(149, 24);
            this.TradeTypeComboBox.TabIndex = 24;
            this.TradeTypeComboBox.Text = "Купить";
            // 
            // RealtyTypeComboBox
            // 
            this.RealtyTypeComboBox.FormattingEnabled = true;
            this.RealtyTypeComboBox.Items.AddRange(new object[] {
            "Квартира",
            "Комната",
            "Дом"});
            this.RealtyTypeComboBox.Location = new System.Drawing.Point(35, 33);
            this.RealtyTypeComboBox.Name = "RealtyTypeComboBox";
            this.RealtyTypeComboBox.Size = new System.Drawing.Size(174, 24);
            this.RealtyTypeComboBox.TabIndex = 23;
            this.RealtyTypeComboBox.Text = "Жилая недвижимость";
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(680, -67);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(70, 58);
            this.EnterButton.TabIndex = 22;
            this.EnterButton.Text = "Вход в систему";
            this.EnterButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(605, 26);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(145, 31);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(69, 579);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 38;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(428, 576);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(109, 23);
            this.ChangeButton.TabIndex = 39;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(554, 576);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(107, 23);
            this.InfoButton.TabIndex = 40;
            this.InfoButton.Text = "Подробнее";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // SearchObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AdvancedSearchButton);
            this.Controls.Add(this.LandAreaLabel);
            this.Controls.Add(this.LandAreaTextBox2);
            this.Controls.Add(this.LandAreaTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DistrictComboBox);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AreaMaxTextBox);
            this.Controls.Add(this.AreaMinTextBox);
            this.Controls.Add(this.PriceMaxTextBox);
            this.Controls.Add(this.PriceMinTextBox);
            this.Controls.Add(this.TradeTypeComboBox);
            this.Controls.Add(this.RealtyTypeComboBox);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.SearchButton);
            this.Name = "SearchObjectForm";
            this.Text = "SearchObjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AdvancedSearchButton;
        private System.Windows.Forms.Label LandAreaLabel;
        private System.Windows.Forms.TextBox LandAreaTextBox2;
        private System.Windows.Forms.TextBox LandAreaTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox DistrictComboBox;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox AreaMaxTextBox;
        private System.Windows.Forms.TextBox AreaMinTextBox;
        private System.Windows.Forms.TextBox PriceMaxTextBox;
        private System.Windows.Forms.TextBox PriceMinTextBox;
        private System.Windows.Forms.ComboBox TradeTypeComboBox;
        private System.Windows.Forms.ComboBox RealtyTypeComboBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InfoButton;
    }
}