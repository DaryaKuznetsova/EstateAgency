namespace EstateAgency
{
    partial class ManagerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.salesSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.reportSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.RealtyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TradeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PriceMinTextBox = new System.Windows.Forms.TextBox();
            this.PriceMaxTextBox = new System.Windows.Forms.TextBox();
            this.AreaMinTextBox = new System.Windows.Forms.TextBox();
            this.AreaMaxTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.DistrictComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LandAreaLabel = new System.Windows.Forms.Label();
            this.LandAreaTextBox2 = new System.Windows.Forms.TextBox();
            this.LandAreaTextBox1 = new System.Windows.Forms.TextBox();
            this.AdvancedSearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personSMI,
            this.catalogSMI,
            this.statisticsSMI,
            this.toolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personSMI
            // 
            this.personSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountSMI,
            this.salesSMI});
            this.personSMI.Name = "personSMI";
            this.personSMI.Size = new System.Drawing.Size(137, 28);
            this.personSMI.Text = "Личный кабинет";
            // 
            // accountSMI
            // 
            this.accountSMI.Name = "accountSMI";
            this.accountSMI.Size = new System.Drawing.Size(182, 26);
            this.accountSMI.Text = "Мой профиль";
            // 
            // salesSMI
            // 
            this.salesSMI.Name = "salesSMI";
            this.salesSMI.Size = new System.Drawing.Size(182, 26);
            this.salesSMI.Text = "Мои продажи";
            // 
            // catalogSMI
            // 
            this.catalogSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSMI,
            this.changeSMI,
            this.deleteSMI});
            this.catalogSMI.Name = "catalogSMI";
            this.catalogSMI.Size = new System.Drawing.Size(75, 28);
            this.catalogSMI.Text = "Каталог";
            // 
            // addSMI
            // 
            this.addSMI.Name = "addSMI";
            this.addSMI.Size = new System.Drawing.Size(216, 26);
            this.addSMI.Text = "Добавить запись";
            this.addSMI.Click += new System.EventHandler(this.addSMI_Click);
            // 
            // changeSMI
            // 
            this.changeSMI.Name = "changeSMI";
            this.changeSMI.Size = new System.Drawing.Size(216, 26);
            this.changeSMI.Text = "Изменить запись";
            this.changeSMI.Click += new System.EventHandler(this.changeSMI_Click);
            // 
            // deleteSMI
            // 
            this.deleteSMI.Name = "deleteSMI";
            this.deleteSMI.Size = new System.Drawing.Size(216, 26);
            this.deleteSMI.Text = "Удалить запись";
            this.deleteSMI.Click += new System.EventHandler(this.deleteSMI_Click);
            // 
            // statisticsSMI
            // 
            this.statisticsSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportSMI});
            this.statisticsSMI.Name = "statisticsSMI";
            this.statisticsSMI.Size = new System.Drawing.Size(96, 28);
            this.statisticsSMI.Text = "Статистика";
            // 
            // reportSMI
            // 
            this.reportSMI.Name = "reportSMI";
            this.reportSMI.Size = new System.Drawing.Size(180, 26);
            this.reportSMI.Text = "Создать отчёт";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "да",
            "нет"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(595, 105);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(145, 31);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(670, 12);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(70, 58);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Вход в систему";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // RealtyTypeComboBox
            // 
            this.RealtyTypeComboBox.FormattingEnabled = true;
            this.RealtyTypeComboBox.Items.AddRange(new object[] {
            "Квартира",
            "Комната",
            "Дом"});
            this.RealtyTypeComboBox.Location = new System.Drawing.Point(25, 112);
            this.RealtyTypeComboBox.Name = "RealtyTypeComboBox";
            this.RealtyTypeComboBox.Size = new System.Drawing.Size(174, 24);
            this.RealtyTypeComboBox.TabIndex = 3;
            this.RealtyTypeComboBox.Text = "Жилая недвижимость";
            // 
            // TradeTypeComboBox
            // 
            this.TradeTypeComboBox.FormattingEnabled = true;
            this.TradeTypeComboBox.Items.AddRange(new object[] {
            "Купить",
            "Снять",
            "Посуточно"});
            this.TradeTypeComboBox.Location = new System.Drawing.Point(205, 112);
            this.TradeTypeComboBox.Name = "TradeTypeComboBox";
            this.TradeTypeComboBox.Size = new System.Drawing.Size(149, 24);
            this.TradeTypeComboBox.TabIndex = 4;
            this.TradeTypeComboBox.Text = "Купить";
            // 
            // PriceMinTextBox
            // 
            this.PriceMinTextBox.Location = new System.Drawing.Point(360, 114);
            this.PriceMinTextBox.Name = "PriceMinTextBox";
            this.PriceMinTextBox.Size = new System.Drawing.Size(52, 22);
            this.PriceMinTextBox.TabIndex = 7;
            this.PriceMinTextBox.Text = "От";
            // 
            // PriceMaxTextBox
            // 
            this.PriceMaxTextBox.Location = new System.Drawing.Point(418, 114);
            this.PriceMaxTextBox.Name = "PriceMaxTextBox";
            this.PriceMaxTextBox.Size = new System.Drawing.Size(51, 22);
            this.PriceMaxTextBox.TabIndex = 9;
            this.PriceMaxTextBox.Text = "До";
            // 
            // AreaMinTextBox
            // 
            this.AreaMinTextBox.Location = new System.Drawing.Point(475, 114);
            this.AreaMinTextBox.Name = "AreaMinTextBox";
            this.AreaMinTextBox.Size = new System.Drawing.Size(52, 22);
            this.AreaMinTextBox.TabIndex = 10;
            this.AreaMinTextBox.Text = "От";
            // 
            // AreaMaxTextBox
            // 
            this.AreaMaxTextBox.Location = new System.Drawing.Point(533, 114);
            this.AreaMaxTextBox.Name = "AreaMaxTextBox";
            this.AreaMaxTextBox.Size = new System.Drawing.Size(51, 22);
            this.AreaMaxTextBox.TabIndex = 11;
            this.AreaMaxTextBox.Text = "До";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(365, 91);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(43, 17);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = "Цена";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(478, 89);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(68, 17);
            this.AreaLabel.TabIndex = 13;
            this.AreaLabel.Text = "Площадь";
            // 
            // DistrictComboBox
            // 
            this.DistrictComboBox.FormattingEnabled = true;
            this.DistrictComboBox.Location = new System.Drawing.Point(26, 144);
            this.DistrictComboBox.Name = "DistrictComboBox";
            this.DistrictComboBox.Size = new System.Drawing.Size(173, 24);
            this.DistrictComboBox.TabIndex = 14;
            this.DistrictComboBox.Text = "Район";
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
            this.comboBox1.Location = new System.Drawing.Point(274, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Количество комнат";
            // 
            // LandAreaLabel
            // 
            this.LandAreaLabel.AutoSize = true;
            this.LandAreaLabel.Location = new System.Drawing.Point(478, 147);
            this.LandAreaLabel.Name = "LandAreaLabel";
            this.LandAreaLabel.Size = new System.Drawing.Size(124, 17);
            this.LandAreaLabel.TabIndex = 18;
            this.LandAreaLabel.Text = "Площадь участка";
            // 
            // LandAreaTextBox2
            // 
            this.LandAreaTextBox2.Location = new System.Drawing.Point(533, 172);
            this.LandAreaTextBox2.Name = "LandAreaTextBox2";
            this.LandAreaTextBox2.Size = new System.Drawing.Size(51, 22);
            this.LandAreaTextBox2.TabIndex = 17;
            this.LandAreaTextBox2.Text = "До";
            // 
            // LandAreaTextBox1
            // 
            this.LandAreaTextBox1.Location = new System.Drawing.Point(475, 172);
            this.LandAreaTextBox1.Name = "LandAreaTextBox1";
            this.LandAreaTextBox1.Size = new System.Drawing.Size(52, 22);
            this.LandAreaTextBox1.TabIndex = 16;
            this.LandAreaTextBox1.Text = "От";
            // 
            // AdvancedSearchButton
            // 
            this.AdvancedSearchButton.Location = new System.Drawing.Point(595, 163);
            this.AdvancedSearchButton.Name = "AdvancedSearchButton";
            this.AdvancedSearchButton.Size = new System.Drawing.Size(145, 62);
            this.AdvancedSearchButton.TabIndex = 19;
            this.AdvancedSearchButton.Text = "Расширенный поиск";
            this.AdvancedSearchButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(756, 366);
            this.dataGridView1.TabIndex = 20;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 609);
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
            this.Controls.Add(this.menuStrip1);
            this.Name = "ManagerForm";
            this.Text = "Estate Agency Manager";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalogSMI;
        private System.Windows.Forms.ToolStripMenuItem personSMI;
        private System.Windows.Forms.ToolStripMenuItem statisticsSMI;
        private System.Windows.Forms.ToolStripMenuItem addSMI;
        private System.Windows.Forms.ToolStripMenuItem changeSMI;
        private System.Windows.Forms.ToolStripMenuItem deleteSMI;
        private System.Windows.Forms.ToolStripMenuItem accountSMI;
        private System.Windows.Forms.ToolStripMenuItem salesSMI;
        private System.Windows.Forms.ToolStripMenuItem reportSMI;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.ComboBox RealtyTypeComboBox;
        private System.Windows.Forms.ComboBox TradeTypeComboBox;
        private System.Windows.Forms.TextBox PriceMinTextBox;
        private System.Windows.Forms.TextBox PriceMaxTextBox;
        private System.Windows.Forms.TextBox AreaMinTextBox;
        private System.Windows.Forms.TextBox AreaMaxTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.ComboBox DistrictComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LandAreaLabel;
        private System.Windows.Forms.TextBox LandAreaTextBox2;
        private System.Windows.Forms.TextBox LandAreaTextBox1;
        private System.Windows.Forms.Button AdvancedSearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

