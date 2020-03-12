﻿namespace EstateAgency
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.RequestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.reportSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.EnterButton = new System.Windows.Forms.Button();
            this.RealtyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TradeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.LandAreaLabel = new System.Windows.Forms.Label();
            this.AdvancedSearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DistrictCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.RoomsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DistrictLabel = new System.Windows.Forms.Label();
            this.RoomsLabel = new System.Windows.Forms.Label();
            this.paymentButton = new System.Windows.Forms.Button();
            this.LandAreaMaxTextBox = new Controls.MaxMinTextBox(this.components);
            this.LandAreaMinTextBox = new Controls.MaxMinTextBox(this.components);
            this.AreaMaxTextBox = new Controls.MaxMinTextBox(this.components);
            this.AreaMinTextBox = new Controls.MaxMinTextBox(this.components);
            this.PriceMaxTextBox = new Controls.MaxMinTextBox(this.components);
            this.PriceMinTextBox = new Controls.MaxMinTextBox(this.components);
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
            this.accountSMI});
            this.personSMI.Name = "personSMI";
            this.personSMI.Size = new System.Drawing.Size(137, 28);
            this.personSMI.Text = "Личный кабинет";
            // 
            // accountSMI
            // 
            this.accountSMI.Name = "accountSMI";
            this.accountSMI.Size = new System.Drawing.Size(166, 26);
            this.accountSMI.Text = "Мои заявки";
            this.accountSMI.Click += new System.EventHandler(this.accountSMI_Click);
            // 
            // catalogSMI
            // 
            this.catalogSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSMI,
            this.changeSMI,
            this.deleteSMI,
            this.RequestsToolStripMenuItem});
            this.catalogSMI.Name = "catalogSMI";
            this.catalogSMI.Size = new System.Drawing.Size(75, 28);
            this.catalogSMI.Text = "Каталог";
            // 
            // addSMI
            // 
            this.addSMI.Name = "addSMI";
            this.addSMI.Size = new System.Drawing.Size(205, 26);
            this.addSMI.Text = "Добавить запись";
            this.addSMI.Click += new System.EventHandler(this.addSMI_Click);
            // 
            // changeSMI
            // 
            this.changeSMI.Name = "changeSMI";
            this.changeSMI.Size = new System.Drawing.Size(205, 26);
            this.changeSMI.Text = "Изменить запись";
            this.changeSMI.Click += new System.EventHandler(this.changeSMI_Click);
            // 
            // deleteSMI
            // 
            this.deleteSMI.Name = "deleteSMI";
            this.deleteSMI.Size = new System.Drawing.Size(205, 26);
            this.deleteSMI.Text = "Удалить запись";
            this.deleteSMI.Click += new System.EventHandler(this.deleteSMI_Click);
            // 
            // RequestsToolStripMenuItem
            // 
            this.RequestsToolStripMenuItem.Name = "RequestsToolStripMenuItem";
            this.RequestsToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.RequestsToolStripMenuItem.Text = "Заявки";
            this.RequestsToolStripMenuItem.Click += new System.EventHandler(this.RequestsToolStripMenuItem_Click);
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
            this.reportSMI.Size = new System.Drawing.Size(216, 26);
            this.reportSMI.Text = "Создать отчёт";
            this.reportSMI.Click += new System.EventHandler(this.reportSMI_Click);
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
            this.SearchButton.Text = "Найти";
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
            this.RealtyTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RealtyTypeComboBox.FormattingEnabled = true;
            this.RealtyTypeComboBox.Items.AddRange(new object[] {
            "Квартира",
            "Комната",
            "Дом"});
            this.RealtyTypeComboBox.Location = new System.Drawing.Point(25, 112);
            this.RealtyTypeComboBox.Name = "RealtyTypeComboBox";
            this.RealtyTypeComboBox.Size = new System.Drawing.Size(174, 24);
            this.RealtyTypeComboBox.TabIndex = 3;
            this.RealtyTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.RealtyTypeComboBox_SelectedIndexChanged);
            this.RealtyTypeComboBox.TextChanged += new System.EventHandler(this.RealtyTypeComboBox_TextChanged);
            // 
            // TradeTypeComboBox
            // 
            this.TradeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TradeTypeComboBox.FormattingEnabled = true;
            this.TradeTypeComboBox.Items.AddRange(new object[] {
            "Купить",
            "Снять",
            "Посуточно"});
            this.TradeTypeComboBox.Location = new System.Drawing.Point(205, 112);
            this.TradeTypeComboBox.Name = "TradeTypeComboBox";
            this.TradeTypeComboBox.Size = new System.Drawing.Size(149, 24);
            this.TradeTypeComboBox.TabIndex = 4;
            this.TradeTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TradeTypeComboBox_SelectedIndexChanged);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(365, 91);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(43, 17);
            this.PriceLabel.TabIndex = 12;
            this.PriceLabel.Text = "Цена";
            this.PriceLabel.Click += new System.EventHandler(this.PriceLabel_Click);
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(478, 89);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(68, 17);
            this.AreaLabel.TabIndex = 13;
            this.AreaLabel.Text = "Площадь";
            this.AreaLabel.Click += new System.EventHandler(this.AreaLabel_Click);
            // 
            // LandAreaLabel
            // 
            this.LandAreaLabel.AutoSize = true;
            this.LandAreaLabel.Location = new System.Drawing.Point(478, 147);
            this.LandAreaLabel.Name = "LandAreaLabel";
            this.LandAreaLabel.Size = new System.Drawing.Size(124, 17);
            this.LandAreaLabel.TabIndex = 18;
            this.LandAreaLabel.Text = "Площадь участка";
            this.LandAreaLabel.Click += new System.EventHandler(this.LandAreaLabel_Click);
            // 
            // AdvancedSearchButton
            // 
            this.AdvancedSearchButton.Location = new System.Drawing.Point(595, 163);
            this.AdvancedSearchButton.Name = "AdvancedSearchButton";
            this.AdvancedSearchButton.Size = new System.Drawing.Size(145, 62);
            this.AdvancedSearchButton.TabIndex = 19;
            this.AdvancedSearchButton.Text = "Расширенный поиск";
            this.AdvancedSearchButton.UseVisualStyleBackColor = true;
            this.AdvancedSearchButton.Click += new System.EventHandler(this.AdvancedSearchButton_Click);
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
            // DistrictCheckedListBox
            // 
            this.DistrictCheckedListBox.FormattingEnabled = true;
            this.DistrictCheckedListBox.Location = new System.Drawing.Point(25, 163);
            this.DistrictCheckedListBox.Name = "DistrictCheckedListBox";
            this.DistrictCheckedListBox.Size = new System.Drawing.Size(173, 55);
            this.DistrictCheckedListBox.TabIndex = 21;
            this.DistrictCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.DistrictCheckedListBox_SelectedIndexChanged);
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
            this.RoomsCheckedListBox.Location = new System.Drawing.Point(274, 163);
            this.RoomsCheckedListBox.Name = "RoomsCheckedListBox";
            this.RoomsCheckedListBox.Size = new System.Drawing.Size(80, 55);
            this.RoomsCheckedListBox.TabIndex = 22;
            this.RoomsCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsCheckedListBox_SelectedIndexChanged);
            // 
            // DistrictLabel
            // 
            this.DistrictLabel.AutoSize = true;
            this.DistrictLabel.Location = new System.Drawing.Point(25, 143);
            this.DistrictLabel.Name = "DistrictLabel";
            this.DistrictLabel.Size = new System.Drawing.Size(49, 17);
            this.DistrictLabel.TabIndex = 23;
            this.DistrictLabel.Text = "Район";
            this.DistrictLabel.Click += new System.EventHandler(this.DistrictLabel_Click);
            // 
            // RoomsLabel
            // 
            this.RoomsLabel.AutoSize = true;
            this.RoomsLabel.Location = new System.Drawing.Point(274, 143);
            this.RoomsLabel.Name = "RoomsLabel";
            this.RoomsLabel.Size = new System.Drawing.Size(137, 17);
            this.RoomsLabel.TabIndex = 24;
            this.RoomsLabel.Text = "Количество комнат";
            this.RoomsLabel.Click += new System.EventHandler(this.RoomsLabel_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.Location = new System.Drawing.Point(12, 603);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(186, 23);
            this.paymentButton.TabIndex = 25;
            this.paymentButton.Text = "Заключить договор";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // LandAreaMaxTextBox
            // 
            this.LandAreaMaxTextBox.ForeColor = System.Drawing.Color.Red;
            this.LandAreaMaxTextBox.Location = new System.Drawing.Point(528, 186);
            this.LandAreaMaxTextBox.Min = false;
            this.LandAreaMaxTextBox.Name = "LandAreaMaxTextBox";
            this.LandAreaMaxTextBox.Size = new System.Drawing.Size(44, 22);
            this.LandAreaMaxTextBox.TabIndex = 31;
            this.LandAreaMaxTextBox.Text = "-";
            this.LandAreaMaxTextBox.Value = 1E+10F;
            this.LandAreaMaxTextBox.TextChanged += new System.EventHandler(this.LandAreaMaxTextBox_TextChanged);
            // 
            // LandAreaMinTextBox
            // 
            this.LandAreaMinTextBox.ForeColor = System.Drawing.Color.Red;
            this.LandAreaMinTextBox.Location = new System.Drawing.Point(481, 186);
            this.LandAreaMinTextBox.Min = false;
            this.LandAreaMinTextBox.Name = "LandAreaMinTextBox";
            this.LandAreaMinTextBox.Size = new System.Drawing.Size(41, 22);
            this.LandAreaMinTextBox.TabIndex = 30;
            this.LandAreaMinTextBox.Text = "-";
            this.LandAreaMinTextBox.Value = 1E+10F;
            this.LandAreaMinTextBox.TextChanged += new System.EventHandler(this.LandAreaMinTextBox_TextChanged);
            // 
            // AreaMaxTextBox
            // 
            this.AreaMaxTextBox.ForeColor = System.Drawing.Color.Red;
            this.AreaMaxTextBox.Location = new System.Drawing.Point(529, 113);
            this.AreaMaxTextBox.Min = false;
            this.AreaMaxTextBox.Name = "AreaMaxTextBox";
            this.AreaMaxTextBox.Size = new System.Drawing.Size(44, 22);
            this.AreaMaxTextBox.TabIndex = 29;
            this.AreaMaxTextBox.Text = "-";
            this.AreaMaxTextBox.Value = 1E+10F;
            this.AreaMaxTextBox.TextChanged += new System.EventHandler(this.AreaMaxTextBox_TextChanged);
            // 
            // AreaMinTextBox
            // 
            this.AreaMinTextBox.ForeColor = System.Drawing.Color.Red;
            this.AreaMinTextBox.Location = new System.Drawing.Point(481, 113);
            this.AreaMinTextBox.Min = false;
            this.AreaMinTextBox.Name = "AreaMinTextBox";
            this.AreaMinTextBox.Size = new System.Drawing.Size(41, 22);
            this.AreaMinTextBox.TabIndex = 28;
            this.AreaMinTextBox.Text = "-";
            this.AreaMinTextBox.Value = 1E+10F;
            this.AreaMinTextBox.TextChanged += new System.EventHandler(this.AreaMinTextBox_TextChanged);
            // 
            // PriceMaxTextBox
            // 
            this.PriceMaxTextBox.ForeColor = System.Drawing.Color.Red;
            this.PriceMaxTextBox.Location = new System.Drawing.Point(418, 113);
            this.PriceMaxTextBox.Min = false;
            this.PriceMaxTextBox.Name = "PriceMaxTextBox";
            this.PriceMaxTextBox.Size = new System.Drawing.Size(43, 22);
            this.PriceMaxTextBox.TabIndex = 27;
            this.PriceMaxTextBox.Text = "-";
            this.PriceMaxTextBox.Value = 1E+10F;
            this.PriceMaxTextBox.TextChanged += new System.EventHandler(this.PriceMaxTextBox_TextChanged);
            // 
            // PriceMinTextBox
            // 
            this.PriceMinTextBox.ForeColor = System.Drawing.Color.Red;
            this.PriceMinTextBox.Location = new System.Drawing.Point(361, 113);
            this.PriceMinTextBox.Min = false;
            this.PriceMinTextBox.Name = "PriceMinTextBox";
            this.PriceMinTextBox.Size = new System.Drawing.Size(47, 22);
            this.PriceMinTextBox.TabIndex = 26;
            this.PriceMinTextBox.Text = "-";
            this.PriceMinTextBox.Value = 1E+10F;
            this.PriceMinTextBox.TextChanged += new System.EventHandler(this.PriceMinTextBox_TextChanged);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 659);
            this.Controls.Add(this.LandAreaMaxTextBox);
            this.Controls.Add(this.LandAreaMinTextBox);
            this.Controls.Add(this.AreaMaxTextBox);
            this.Controls.Add(this.AreaMinTextBox);
            this.Controls.Add(this.PriceMaxTextBox);
            this.Controls.Add(this.PriceMinTextBox);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.RoomsLabel);
            this.Controls.Add(this.DistrictLabel);
            this.Controls.Add(this.RoomsCheckedListBox);
            this.Controls.Add(this.DistrictCheckedListBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AdvancedSearchButton);
            this.Controls.Add(this.LandAreaLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.PriceLabel);
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
        private System.Windows.Forms.ToolStripMenuItem reportSMI;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.ComboBox RealtyTypeComboBox;
        private System.Windows.Forms.ComboBox TradeTypeComboBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Label LandAreaLabel;
        private System.Windows.Forms.Button AdvancedSearchButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox DistrictCheckedListBox;
        private System.Windows.Forms.CheckedListBox RoomsCheckedListBox;
        private System.Windows.Forms.Label DistrictLabel;
        private System.Windows.Forms.Label RoomsLabel;
        private System.Windows.Forms.ToolStripMenuItem RequestsToolStripMenuItem;
        private System.Windows.Forms.Button paymentButton;
        private Controls.MaxMinTextBox PriceMinTextBox;
        private Controls.MaxMinTextBox PriceMaxTextBox;
        private Controls.MaxMinTextBox AreaMinTextBox;
        private Controls.MaxMinTextBox AreaMaxTextBox;
        private Controls.MaxMinTextBox LandAreaMinTextBox;
        private Controls.MaxMinTextBox LandAreaMaxTextBox;
    }
}

