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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EnterButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.RequestButton = new System.Windows.Forms.Button();
            this.LandAreaMaxTextBox = new Controls.MaxMinTextBox(this.components);
            this.LandAreaMinTextBox = new Controls.MaxMinTextBox(this.components);
            this.AreaMaxTextBox = new Controls.MaxMinTextBox(this.components);
            this.AreaMinTextBox = new Controls.MaxMinTextBox(this.components);
            this.PriceMaxTextBox = new Controls.MaxMinTextBox(this.components);
            this.PriceMinTextBox = new Controls.MaxMinTextBox(this.components);
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.DistrictLabel = new System.Windows.Forms.Label();
            this.RoomsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DistrictCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.LandAreaLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TradeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.RealtyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
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
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(680, -67);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(70, 58);
            this.EnterButton.TabIndex = 22;
            this.EnterButton.Text = "Вход в систему";
            this.EnterButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 560);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(108, 39);
            this.DeleteButton.TabIndex = 38;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(244, 560);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(125, 39);
            this.ChangeButton.TabIndex = 39;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(375, 560);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(118, 39);
            this.InfoButton.TabIndex = 40;
            this.InfoButton.Text = "Подробнее";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // RequestButton
            // 
            this.RequestButton.Location = new System.Drawing.Point(126, 560);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(115, 39);
            this.RequestButton.TabIndex = 41;
            this.RequestButton.Text = "Рассмотреть заявку\r\n";
            this.RequestButton.UseVisualStyleBackColor = true;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // LandAreaMaxTextBox
            // 
            this.LandAreaMaxTextBox.ForeColor = System.Drawing.Color.Red;
            this.LandAreaMaxTextBox.Location = new System.Drawing.Point(527, 103);
            this.LandAreaMaxTextBox.Min = false;
            this.LandAreaMaxTextBox.Name = "LandAreaMaxTextBox";
            this.LandAreaMaxTextBox.Size = new System.Drawing.Size(44, 22);
            this.LandAreaMaxTextBox.TabIndex = 58;
            this.LandAreaMaxTextBox.Text = "-";
            this.LandAreaMaxTextBox.Value = 1E+10F;
            // 
            // LandAreaMinTextBox
            // 
            this.LandAreaMinTextBox.ForeColor = System.Drawing.Color.Red;
            this.LandAreaMinTextBox.Location = new System.Drawing.Point(480, 103);
            this.LandAreaMinTextBox.Min = false;
            this.LandAreaMinTextBox.Name = "LandAreaMinTextBox";
            this.LandAreaMinTextBox.Size = new System.Drawing.Size(41, 22);
            this.LandAreaMinTextBox.TabIndex = 57;
            this.LandAreaMinTextBox.Text = "-";
            this.LandAreaMinTextBox.Value = 1E+10F;
            // 
            // AreaMaxTextBox
            // 
            this.AreaMaxTextBox.ForeColor = System.Drawing.Color.Red;
            this.AreaMaxTextBox.Location = new System.Drawing.Point(528, 30);
            this.AreaMaxTextBox.Min = false;
            this.AreaMaxTextBox.Name = "AreaMaxTextBox";
            this.AreaMaxTextBox.Size = new System.Drawing.Size(44, 22);
            this.AreaMaxTextBox.TabIndex = 56;
            this.AreaMaxTextBox.Text = "-";
            this.AreaMaxTextBox.Value = 1E+10F;
            // 
            // AreaMinTextBox
            // 
            this.AreaMinTextBox.ForeColor = System.Drawing.Color.Red;
            this.AreaMinTextBox.Location = new System.Drawing.Point(480, 30);
            this.AreaMinTextBox.Min = false;
            this.AreaMinTextBox.Name = "AreaMinTextBox";
            this.AreaMinTextBox.Size = new System.Drawing.Size(41, 22);
            this.AreaMinTextBox.TabIndex = 55;
            this.AreaMinTextBox.Text = "-";
            this.AreaMinTextBox.Value = 1E+10F;
            // 
            // PriceMaxTextBox
            // 
            this.PriceMaxTextBox.ForeColor = System.Drawing.Color.Red;
            this.PriceMaxTextBox.Location = new System.Drawing.Point(417, 30);
            this.PriceMaxTextBox.Min = false;
            this.PriceMaxTextBox.Name = "PriceMaxTextBox";
            this.PriceMaxTextBox.Size = new System.Drawing.Size(43, 22);
            this.PriceMaxTextBox.TabIndex = 54;
            this.PriceMaxTextBox.Text = "-";
            this.PriceMaxTextBox.Value = 1E+10F;
            // 
            // PriceMinTextBox
            // 
            this.PriceMinTextBox.ForeColor = System.Drawing.Color.Red;
            this.PriceMinTextBox.Location = new System.Drawing.Point(360, 30);
            this.PriceMinTextBox.Min = false;
            this.PriceMinTextBox.Name = "PriceMinTextBox";
            this.PriceMinTextBox.Size = new System.Drawing.Size(47, 22);
            this.PriceMinTextBox.TabIndex = 53;
            this.PriceMinTextBox.Text = "-";
            this.PriceMinTextBox.Value = 1E+10F;
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.Location = new System.Drawing.Point(273, 60);
            this.RoomsLabel.Name = "RoomsLabel";
            this.RoomsLabel.Size = new System.Drawing.Size(137, 17);
            this.RoomsLabel.TabIndex = 52;
            this.RoomsLabel.Text = "Количество комнат";
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Location = new System.Drawing.Point(24, 60);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(49, 17);
            this.DistrictLabel.TabIndex = 51;
            this.DistrictLabel.Text = "Район";
            // 
            // RoomsCheckedListBox
            // 
            this.RoomsCheckedListBox.FormattingEnabled = true;
            this.RoomsCheckedListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.RoomsCheckedListBox.Location = new System.Drawing.Point(273, 80);
            this.RoomsCheckedListBox.Name = "RoomsCheckedListBox";
            this.RoomsCheckedListBox.Size = new System.Drawing.Size(80, 55);
            this.RoomsCheckedListBox.TabIndex = 50;
            // 
            // DistrictCheckedListBox
            // 
            this.DistrictCheckedListBox.FormattingEnabled = true;
            this.DistrictCheckedListBox.Location = new System.Drawing.Point(24, 80);
            this.DistrictCheckedListBox.Name = "DistrictCheckedListBox";
            this.DistrictCheckedListBox.Size = new System.Drawing.Size(173, 55);
            this.DistrictCheckedListBox.TabIndex = 49;
            // 
            // LandAreaLabel
            // 
            this.LandAreaLabel.AutoSize = true;
            this.LandAreaLabel.Location = new System.Drawing.Point(477, 64);
            this.LandAreaLabel.Name = "LandAreaLabel";
            this.LandAreaLabel.Size = new System.Drawing.Size(124, 17);
            this.LandAreaLabel.TabIndex = 47;
            this.LandAreaLabel.Text = "Площадь участка";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(477, 6);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(68, 17);
            this.AreaLabel.TabIndex = 46;
            this.AreaLabel.Text = "Площадь";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(364, 8);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(43, 17);
            this.PriceLabel.TabIndex = 45;
            this.PriceLabel.Text = "Цена";
            // 
            // TradeTypeComboBox
            // 
            this.TradeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TradeTypeComboBox.FormattingEnabled = true;
            this.TradeTypeComboBox.Items.AddRange(new object[] {
            "Купить",
            "Снять",
            "Посуточно"});
            this.TradeTypeComboBox.Location = new System.Drawing.Point(204, 29);
            this.TradeTypeComboBox.Name = "TradeTypeComboBox";
            this.TradeTypeComboBox.Size = new System.Drawing.Size(149, 24);
            this.TradeTypeComboBox.TabIndex = 44;
            // 
            // RealtyTypeComboBox
            // 
            this.RealtyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RealtyTypeComboBox.FormattingEnabled = true;
            this.RealtyTypeComboBox.Items.AddRange(new object[] {
            "Квартира",
            "Комната",
            "Дом"});
            this.RealtyTypeComboBox.Location = new System.Drawing.Point(24, 29);
            this.RealtyTypeComboBox.Name = "RealtyTypeComboBox";
            this.RealtyTypeComboBox.Size = new System.Drawing.Size(174, 24);
            this.RealtyTypeComboBox.TabIndex = 43;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(594, 22);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(145, 31);
            this.SearchButton.TabIndex = 42;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // SearchObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.LandAreaMaxTextBox);
            this.Controls.Add(this.LandAreaMinTextBox);
            this.Controls.Add(this.AreaMaxTextBox);
            this.Controls.Add(this.AreaMinTextBox);
            this.Controls.Add(this.PriceMaxTextBox);
            this.Controls.Add(this.PriceMinTextBox);
            this.Controls.Add(this.RoomsLabel);
            this.Controls.Add(this.DistrictLabel);
            this.Controls.Add(this.RoomsCheckedListBox);
            this.Controls.Add(this.DistrictCheckedListBox);
            this.Controls.Add(this.LandAreaLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.TradeTypeComboBox);
            this.Controls.Add(this.RealtyTypeComboBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RequestButton);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EnterButton);
            this.Name = "SearchObjectForm";
            this.Text = "SearchObjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button RequestButton;
        private Controls.MaxMinTextBox LandAreaMaxTextBox;
        private Controls.MaxMinTextBox LandAreaMinTextBox;
        private Controls.MaxMinTextBox AreaMaxTextBox;
        private Controls.MaxMinTextBox AreaMinTextBox;
        private Controls.MaxMinTextBox PriceMaxTextBox;
        private Controls.MaxMinTextBox PriceMinTextBox;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.Label DistrictLabel;
        private System.Windows.Forms.CheckedListBox RoomsCheckedListBox;
        private System.Windows.Forms.CheckedListBox DistrictCheckedListBox;
        private System.Windows.Forms.Label LandAreaLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.ComboBox TradeTypeComboBox;
        private System.Windows.Forms.ComboBox RealtyTypeComboBox;
        private System.Windows.Forms.Button SearchButton;
    }
}