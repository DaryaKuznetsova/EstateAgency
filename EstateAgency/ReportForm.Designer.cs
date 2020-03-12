namespace EstateAgency
{
    partial class ReportForm
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
            this.TableNameListBox = new System.Windows.Forms.CheckedListBox();
            this.TradeColumnsListBox = new System.Windows.Forms.CheckedListBox();
            this.EstateObjectColumnsListBox = new System.Windows.Forms.CheckedListBox();
            this.FirstDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SecondDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CreateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LandAreaMaxTextBox
            // 
            this.LandAreaMaxTextBox.ForeColor = System.Drawing.Color.Red;
            this.LandAreaMaxTextBox.Location = new System.Drawing.Point(545, 334);
            this.LandAreaMaxTextBox.Min = false;
            this.LandAreaMaxTextBox.Name = "LandAreaMaxTextBox";
            this.LandAreaMaxTextBox.Size = new System.Drawing.Size(44, 22);
            this.LandAreaMaxTextBox.TabIndex = 48;
            this.LandAreaMaxTextBox.Text = "-";
            this.LandAreaMaxTextBox.Value = 1E+10F;
            // 
            // LandAreaMinTextBox
            // 
            this.LandAreaMinTextBox.ForeColor = System.Drawing.Color.Red;
            this.LandAreaMinTextBox.Location = new System.Drawing.Point(498, 334);
            this.LandAreaMinTextBox.Min = false;
            this.LandAreaMinTextBox.Name = "LandAreaMinTextBox";
            this.LandAreaMinTextBox.Size = new System.Drawing.Size(41, 22);
            this.LandAreaMinTextBox.TabIndex = 47;
            this.LandAreaMinTextBox.Text = "-";
            this.LandAreaMinTextBox.Value = 1E+10F;
            // 
            // AreaMaxTextBox
            // 
            this.AreaMaxTextBox.ForeColor = System.Drawing.Color.Red;
            this.AreaMaxTextBox.Location = new System.Drawing.Point(546, 261);
            this.AreaMaxTextBox.Min = false;
            this.AreaMaxTextBox.Name = "AreaMaxTextBox";
            this.AreaMaxTextBox.Size = new System.Drawing.Size(44, 22);
            this.AreaMaxTextBox.TabIndex = 46;
            this.AreaMaxTextBox.Text = "-";
            this.AreaMaxTextBox.Value = 1E+10F;
            // 
            // AreaMinTextBox
            // 
            this.AreaMinTextBox.ForeColor = System.Drawing.Color.Red;
            this.AreaMinTextBox.Location = new System.Drawing.Point(498, 261);
            this.AreaMinTextBox.Min = false;
            this.AreaMinTextBox.Name = "AreaMinTextBox";
            this.AreaMinTextBox.Size = new System.Drawing.Size(41, 22);
            this.AreaMinTextBox.TabIndex = 45;
            this.AreaMinTextBox.Text = "-";
            this.AreaMinTextBox.Value = 1E+10F;
            // 
            // PriceMaxTextBox
            // 
            this.PriceMaxTextBox.ForeColor = System.Drawing.Color.Red;
            this.PriceMaxTextBox.Location = new System.Drawing.Point(435, 261);
            this.PriceMaxTextBox.Min = false;
            this.PriceMaxTextBox.Name = "PriceMaxTextBox";
            this.PriceMaxTextBox.Size = new System.Drawing.Size(43, 22);
            this.PriceMaxTextBox.TabIndex = 44;
            this.PriceMaxTextBox.Text = "-";
            this.PriceMaxTextBox.Value = 1E+10F;
            // 
            // PriceMinTextBox
            // 
            this.PriceMinTextBox.ForeColor = System.Drawing.Color.Red;
            this.PriceMinTextBox.Location = new System.Drawing.Point(378, 261);
            this.PriceMinTextBox.Min = false;
            this.PriceMinTextBox.Name = "PriceMinTextBox";
            this.PriceMinTextBox.Size = new System.Drawing.Size(47, 22);
            this.PriceMinTextBox.TabIndex = 43;
            this.PriceMinTextBox.Text = "-";
            this.PriceMinTextBox.Value = 1E+10F;
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.Location = new System.Drawing.Point(291, 291);
            this.RoomsLabel.Name = "RoomsLabel";
            this.RoomsLabel.Size = new System.Drawing.Size(137, 17);
            this.RoomsLabel.TabIndex = 42;
            this.RoomsLabel.Text = "Количество комнат";
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Location = new System.Drawing.Point(42, 291);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(49, 17);
            this.DistrictLabel.TabIndex = 41;
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
            this.RoomsCheckedListBox.Location = new System.Drawing.Point(291, 311);
            this.RoomsCheckedListBox.Name = "RoomsCheckedListBox";
            this.RoomsCheckedListBox.Size = new System.Drawing.Size(80, 55);
            this.RoomsCheckedListBox.TabIndex = 40;
            // 
            // DistrictCheckedListBox
            // 
            this.DistrictCheckedListBox.FormattingEnabled = true;
            this.DistrictCheckedListBox.Location = new System.Drawing.Point(42, 311);
            this.DistrictCheckedListBox.Name = "DistrictCheckedListBox";
            this.DistrictCheckedListBox.Size = new System.Drawing.Size(173, 55);
            this.DistrictCheckedListBox.TabIndex = 39;
            // 
            // LandAreaLabel
            // 
            this.LandAreaLabel.AutoSize = true;
            this.LandAreaLabel.Location = new System.Drawing.Point(495, 295);
            this.LandAreaLabel.Name = "LandAreaLabel";
            this.LandAreaLabel.Size = new System.Drawing.Size(124, 17);
            this.LandAreaLabel.TabIndex = 37;
            this.LandAreaLabel.Text = "Площадь участка";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(495, 237);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(68, 17);
            this.AreaLabel.TabIndex = 36;
            this.AreaLabel.Text = "Площадь";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(382, 239);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(43, 17);
            this.PriceLabel.TabIndex = 35;
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
            this.TradeTypeComboBox.Location = new System.Drawing.Point(222, 260);
            this.TradeTypeComboBox.Name = "TradeTypeComboBox";
            this.TradeTypeComboBox.Size = new System.Drawing.Size(149, 24);
            this.TradeTypeComboBox.TabIndex = 34;
            // 
            // RealtyTypeComboBox
            // 
            this.RealtyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RealtyTypeComboBox.FormattingEnabled = true;
            this.RealtyTypeComboBox.Items.AddRange(new object[] {
            "Квартира",
            "Комната",
            "Дом"});
            this.RealtyTypeComboBox.Location = new System.Drawing.Point(42, 260);
            this.RealtyTypeComboBox.Name = "RealtyTypeComboBox";
            this.RealtyTypeComboBox.Size = new System.Drawing.Size(174, 24);
            this.RealtyTypeComboBox.TabIndex = 33;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(639, 257);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(145, 31);
            this.SearchButton.TabIndex = 32;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // TableNameListBox
            // 
            this.TableNameListBox.FormattingEnabled = true;
            this.TableNameListBox.Items.AddRange(new object[] {
            "Сделки",
            "Объекты недвижимости"});
            this.TableNameListBox.Location = new System.Drawing.Point(12, 12);
            this.TableNameListBox.Name = "TableNameListBox";
            this.TableNameListBox.Size = new System.Drawing.Size(203, 55);
            this.TableNameListBox.TabIndex = 49;
            // 
            // TradeColumnsListBox
            // 
            this.TradeColumnsListBox.FormattingEnabled = true;
            this.TradeColumnsListBox.Items.AddRange(new object[] {
            "Id",
            "Id объекта недвижимости",
            "Id менеджера",
            "Id клиента",
            "Способ оплаты",
            "Инструмент оплаты"});
            this.TradeColumnsListBox.Location = new System.Drawing.Point(226, 12);
            this.TradeColumnsListBox.Name = "TradeColumnsListBox";
            this.TradeColumnsListBox.Size = new System.Drawing.Size(199, 106);
            this.TradeColumnsListBox.TabIndex = 50;
            // 
            // EstateObjectColumnsListBox
            // 
            this.EstateObjectColumnsListBox.FormattingEnabled = true;
            this.EstateObjectColumnsListBox.Items.AddRange(new object[] {
            "Id",
            "Статус",
            "Владелец",
            "Цена",
            "Адрес",
            "Район",
            "Описание",
            "Вид недвижимости",
            "Вид сделки",
            "Площадь",
            "Количество комнат",
            "Описание участка",
            "Площадь участка"});
            this.EstateObjectColumnsListBox.Location = new System.Drawing.Point(431, 12);
            this.EstateObjectColumnsListBox.Name = "EstateObjectColumnsListBox";
            this.EstateObjectColumnsListBox.Size = new System.Drawing.Size(206, 225);
            this.EstateObjectColumnsListBox.TabIndex = 51;
            // 
            // FirstDatePicker
            // 
            this.FirstDatePicker.Location = new System.Drawing.Point(12, 180);
            this.FirstDatePicker.Name = "FirstDatePicker";
            this.FirstDatePicker.Size = new System.Drawing.Size(200, 22);
            this.FirstDatePicker.TabIndex = 52;
            // 
            // SecondDatePicker
            // 
            this.SecondDatePicker.Location = new System.Drawing.Point(219, 179);
            this.SecondDatePicker.Name = "SecondDatePicker";
            this.SecondDatePicker.Size = new System.Drawing.Size(200, 22);
            this.SecondDatePicker.TabIndex = 53;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(599, 405);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(139, 40);
            this.CreateButton.TabIndex = 54;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 464);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 272);
            this.dataGridView1.TabIndex = 55;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 780);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.SecondDatePicker);
            this.Controls.Add(this.FirstDatePicker);
            this.Controls.Add(this.EstateObjectColumnsListBox);
            this.Controls.Add(this.TradeColumnsListBox);
            this.Controls.Add(this.TableNameListBox);
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
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.CheckedListBox TableNameListBox;
        private System.Windows.Forms.CheckedListBox TradeColumnsListBox;
        private System.Windows.Forms.CheckedListBox EstateObjectColumnsListBox;
        private System.Windows.Forms.DateTimePicker FirstDatePicker;
        private System.Windows.Forms.DateTimePicker SecondDatePicker;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}