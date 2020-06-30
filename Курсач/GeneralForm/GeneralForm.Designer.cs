namespace Kursach
{
    partial class GeneralForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralForm));
            this.ctlClientDataGridViewClients = new System.Windows.Forms.DataGridView();
            this.ctlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlPatronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlBd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CtlProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDataClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteClientToolStripMenuContextMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сSortNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortNameOfAscendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortNameOfDescendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortLastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortLastNameofAscendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SortLastNameOfDescendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SortIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortIdOfAscendingToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabGridView = new System.Windows.Forms.TabControl();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.ctldataProductGridView = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlNameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddProductToolStripContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EdditProductToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteProductToolContextStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ctlClientDataGridViewClients)).BeginInit();
            this.clientContextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabGridView.SuspendLayout();
            this.tabPageClient.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctldataProductGridView)).BeginInit();
            this.productContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlClientDataGridViewClients
            // 
            this.ctlClientDataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlClientDataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ctlId,
            this.ctlFirstName,
            this.cltLastName,
            this.ctlPatronymic,
            this.ctlBd,
            this.CtlProduct});
            this.ctlClientDataGridViewClients.ContextMenuStrip = this.clientContextMenuStrip1;
            this.ctlClientDataGridViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlClientDataGridViewClients.Location = new System.Drawing.Point(3, 3);
            this.ctlClientDataGridViewClients.Name = "ctlClientDataGridViewClients";
            this.ctlClientDataGridViewClients.Size = new System.Drawing.Size(653, 297);
            this.ctlClientDataGridViewClients.TabIndex = 0;
            this.ctlClientDataGridViewClients.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlClientDataGridViewClients_ColumnHeaderMouseClick);
            // 
            // ctlId
            // 
            this.ctlId.DataPropertyName = "ClientId";
            this.ctlId.HeaderText = "Id";
            this.ctlId.Name = "ctlId";
            this.ctlId.ReadOnly = true;
            this.ctlId.Width = 50;
            // 
            // ctlFirstName
            // 
            this.ctlFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ctlFirstName.DataPropertyName = "FirstName";
            this.ctlFirstName.HeaderText = "Имя";
            this.ctlFirstName.Name = "ctlFirstName";
            this.ctlFirstName.ReadOnly = true;
            // 
            // cltLastName
            // 
            this.cltLastName.DataPropertyName = "LastName";
            this.cltLastName.HeaderText = "Фамилия";
            this.cltLastName.Name = "cltLastName";
            this.cltLastName.ReadOnly = true;
            this.cltLastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ctlPatronymic
            // 
            this.ctlPatronymic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ctlPatronymic.DataPropertyName = "Patronymic";
            this.ctlPatronymic.HeaderText = "Отчество";
            this.ctlPatronymic.Name = "ctlPatronymic";
            this.ctlPatronymic.ReadOnly = true;
            // 
            // ctlBd
            // 
            this.ctlBd.DataPropertyName = "BirthDate";
            this.ctlBd.HeaderText = "Дата рождения";
            this.ctlBd.Name = "ctlBd";
            this.ctlBd.ReadOnly = true;
            this.ctlBd.Width = 132;
            // 
            // CtlProduct
            // 
            this.CtlProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CtlProduct.DataPropertyName = "Product";
            this.CtlProduct.HeaderText = "Продукт";
            this.CtlProduct.Name = "CtlProduct";
            this.CtlProduct.ReadOnly = true;
            // 
            // clientContextMenuStrip1
            // 
            this.clientContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem,
            this.EditDataClientToolStripMenuItem,
            this.DeleteClientToolStripMenuContextMenuStripItem});
            this.clientContextMenuStrip1.Name = "contextMenuStrip1";
            this.clientContextMenuStrip1.Size = new System.Drawing.Size(218, 70);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.AddToolStripMenuItem.Text = "добавить клиента";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddClientToolStripContextMenuItem_Click);
            // 
            // EditDataClientToolStripMenuItem
            // 
            this.EditDataClientToolStripMenuItem.Name = "EditDataClientToolStripMenuItem";
            this.EditDataClientToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.EditDataClientToolStripMenuItem.Text = "изменить данные клиента";
            this.EditDataClientToolStripMenuItem.Click += new System.EventHandler(this.EditDataClientToolStripMenuItem_Click);
            // 
            // DeleteClientToolStripMenuContextMenuStripItem
            // 
            this.DeleteClientToolStripMenuContextMenuStripItem.Name = "DeleteClientToolStripMenuContextMenuStripItem";
            this.DeleteClientToolStripMenuContextMenuStripItem.Size = new System.Drawing.Size(217, 22);
            this.DeleteClientToolStripMenuContextMenuStripItem.Text = "удалить клиента";
            this.DeleteClientToolStripMenuContextMenuStripItem.Click += new System.EventHandler(this.DeleteClientToolStripMenuContextMenuStripItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.FindClientToolStripMenuItem,
            this.SortToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnCloseToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // BtnCloseToolStripMenuItem
            // 
            this.BtnCloseToolStripMenuItem.Name = "BtnCloseToolStripMenuItem";
            this.BtnCloseToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.BtnCloseToolStripMenuItem.Text = "Закрыть Alt+ F4";
            this.BtnCloseToolStripMenuItem.Click += new System.EventHandler(this.BtnCloseToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClientToolStripMenuItem,
            this.AddProductToolStripMenuItem,
            this.EditClientToolStripMenuItem,
            this.EditProductToolStripMenuItem,
            this.DeleteClientToolStripMenuItem,
            this.DeleteProductToolStripMenuItem});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.изменитьToolStripMenuItem.Text = "&Изменить";
            // 
            // AddClientToolStripMenuItem
            // 
            this.AddClientToolStripMenuItem.Name = "AddClientToolStripMenuItem";
            this.AddClientToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.AddClientToolStripMenuItem.Text = "добавить клиента";
            this.AddClientToolStripMenuItem.Click += new System.EventHandler(this.AddClientToolStripMenuItem_Click);
            // 
            // AddProductToolStripMenuItem
            // 
            this.AddProductToolStripMenuItem.Name = "AddProductToolStripMenuItem";
            this.AddProductToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.AddProductToolStripMenuItem.Text = "добавить продукт";
            this.AddProductToolStripMenuItem.Click += new System.EventHandler(this.AddProductToolStripMenuItem_Click);
            // 
            // EditClientToolStripMenuItem
            // 
            this.EditClientToolStripMenuItem.Name = "EditClientToolStripMenuItem";
            this.EditClientToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.EditClientToolStripMenuItem.Text = "Изменить клиента";
            this.EditClientToolStripMenuItem.Click += new System.EventHandler(this.EditClientToolStripMenuItem_Click);
            // 
            // EditProductToolStripMenuItem
            // 
            this.EditProductToolStripMenuItem.Name = "EditProductToolStripMenuItem";
            this.EditProductToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.EditProductToolStripMenuItem.Text = "Изменить продукт";
            this.EditProductToolStripMenuItem.Click += new System.EventHandler(this.EditProductToolStripMenuItem_Click);
            // 
            // DeleteClientToolStripMenuItem
            // 
            this.DeleteClientToolStripMenuItem.Name = "DeleteClientToolStripMenuItem";
            this.DeleteClientToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.DeleteClientToolStripMenuItem.Text = "Удалить клиента";
            this.DeleteClientToolStripMenuItem.Click += new System.EventHandler(this.DeleteClientToolStripMenuItem_Click);
            // 
            // DeleteProductToolStripMenuItem
            // 
            this.DeleteProductToolStripMenuItem.Name = "DeleteProductToolStripMenuItem";
            this.DeleteProductToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.DeleteProductToolStripMenuItem.Text = "Удалить продукт";
            this.DeleteProductToolStripMenuItem.Click += new System.EventHandler(this.DeleteProductToolStripMenuItem_Click);
            // 
            // FindClientToolStripMenuItem
            // 
            this.FindClientToolStripMenuItem.Name = "FindClientToolStripMenuItem";
            this.FindClientToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.FindClientToolStripMenuItem.Text = "Поиск клиента";
            this.FindClientToolStripMenuItem.Click += new System.EventHandler(this.FindClientToolStripMenuItem_Click);
            // 
            // SortToolStripMenuItem
            // 
            this.SortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сSortNameToolStripMenuItem,
            this.SortLastNameToolStripMenuItem,
            this.SortIdToolStripMenuItem});
            this.SortToolStripMenuItem.Name = "SortToolStripMenuItem";
            this.SortToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.SortToolStripMenuItem.Text = "Сортировка";
            // 
            // сSortNameToolStripMenuItem
            // 
            this.сSortNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortNameOfAscendingToolStripMenuItem,
            this.SortNameOfDescendingToolStripMenuItem});
            this.сSortNameToolStripMenuItem.Name = "сSortNameToolStripMenuItem";
            this.сSortNameToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.сSortNameToolStripMenuItem.Text = "Сортировка по имени";
            // 
            // SortNameOfAscendingToolStripMenuItem
            // 
            this.SortNameOfAscendingToolStripMenuItem.Name = "SortNameOfAscendingToolStripMenuItem";
            this.SortNameOfAscendingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.SortNameOfAscendingToolStripMenuItem.Text = "по возрастанию";
            this.SortNameOfAscendingToolStripMenuItem.Click += new System.EventHandler(this.SortNameOfAscendingToolStripMenuItem_Click);
            // 
            // SortNameOfDescendingToolStripMenuItem
            // 
            this.SortNameOfDescendingToolStripMenuItem.Name = "SortNameOfDescendingToolStripMenuItem";
            this.SortNameOfDescendingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.SortNameOfDescendingToolStripMenuItem.Text = "по убыванию";
            this.SortNameOfDescendingToolStripMenuItem.Click += new System.EventHandler(this.SortNameOfDescendingToolStripMenuItem_Click);
            // 
            // SortLastNameToolStripMenuItem
            // 
            this.SortLastNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortLastNameofAscendingToolStripMenuItem1,
            this.SortLastNameOfDescendingToolStripMenuItem1});
            this.SortLastNameToolStripMenuItem.Name = "SortLastNameToolStripMenuItem";
            this.SortLastNameToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.SortLastNameToolStripMenuItem.Text = "Сортировка по фамилии";
            // 
            // SortLastNameofAscendingToolStripMenuItem1
            // 
            this.SortLastNameofAscendingToolStripMenuItem1.Name = "SortLastNameofAscendingToolStripMenuItem1";
            this.SortLastNameofAscendingToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.SortLastNameofAscendingToolStripMenuItem1.Text = "по возрастанию";
            this.SortLastNameofAscendingToolStripMenuItem1.Click += new System.EventHandler(this.SortLastNameofAscendingToolStripMenuItem1_Click);
            // 
            // SortLastNameOfDescendingToolStripMenuItem1
            // 
            this.SortLastNameOfDescendingToolStripMenuItem1.Name = "SortLastNameOfDescendingToolStripMenuItem1";
            this.SortLastNameOfDescendingToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.SortLastNameOfDescendingToolStripMenuItem1.Text = "по убыванию";
            this.SortLastNameOfDescendingToolStripMenuItem1.Click += new System.EventHandler(this.SortLastNameOfDescendingToolStripMenuItem1_Click);
            // 
            // SortIdToolStripMenuItem
            // 
            this.SortIdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortIdOfAscendingToolStripMenuItem2});
            this.SortIdToolStripMenuItem.Name = "SortIdToolStripMenuItem";
            this.SortIdToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.SortIdToolStripMenuItem.Text = "Сортировка по Id";
            // 
            // SortIdOfAscendingToolStripMenuItem2
            // 
            this.SortIdOfAscendingToolStripMenuItem2.Name = "SortIdOfAscendingToolStripMenuItem2";
            this.SortIdOfAscendingToolStripMenuItem2.Size = new System.Drawing.Size(163, 22);
            this.SortIdOfAscendingToolStripMenuItem2.Text = "по возрастанию";
            this.SortIdOfAscendingToolStripMenuItem2.Click += new System.EventHandler(this.SortIdOfAscendingToolStripMenuItem2_Click);
            // 
            // tabGridView
            // 
            this.tabGridView.Controls.Add(this.tabPageClient);
            this.tabGridView.Controls.Add(this.tabPageProduct);
            this.tabGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabGridView.Location = new System.Drawing.Point(0, 24);
            this.tabGridView.Name = "tabGridView";
            this.tabGridView.SelectedIndex = 0;
            this.tabGridView.Size = new System.Drawing.Size(671, 333);
            this.tabGridView.TabIndex = 3;
            // 
            // tabPageClient
            // 
            this.tabPageClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageClient.ContextMenuStrip = this.clientContextMenuStrip1;
            this.tabPageClient.Controls.Add(this.ctlClientDataGridViewClients);
            this.tabPageClient.Location = new System.Drawing.Point(4, 22);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(663, 307);
            this.tabPageClient.TabIndex = 0;
            this.tabPageClient.Text = "Клиенты";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.ctldataProductGridView);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(663, 307);
            this.tabPageProduct.TabIndex = 1;
            this.tabPageProduct.Text = "Продукты";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // ctldataProductGridView
            // 
            this.ctldataProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctldataProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ctlNameProduct,
            this.ctlDescription});
            this.ctldataProductGridView.ContextMenuStrip = this.productContextMenuStrip;
            this.ctldataProductGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctldataProductGridView.Location = new System.Drawing.Point(3, 3);
            this.ctldataProductGridView.Name = "ctldataProductGridView";
            this.ctldataProductGridView.Size = new System.Drawing.Size(657, 301);
            this.ctldataProductGridView.TabIndex = 0;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Id";
            this.ProductId.Name = "ProductId";
            // 
            // ctlNameProduct
            // 
            this.ctlNameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ctlNameProduct.DataPropertyName = "Title";
            this.ctlNameProduct.HeaderText = "Название";
            this.ctlNameProduct.Name = "ctlNameProduct";
            this.ctlNameProduct.Width = 307;
            // 
            // ctlDescription
            // 
            this.ctlDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ctlDescription.DataPropertyName = "Description";
            this.ctlDescription.HeaderText = "Описание";
            this.ctlDescription.Name = "ctlDescription";
            // 
            // productContextMenuStrip
            // 
            this.productContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProductToolStripContextMenuItem,
            this.EdditProductToolStripMenuItem1,
            this.DeleteProductToolContextStripMenuItem});
            this.productContextMenuStrip.Name = "contextMenuStrip2";
            this.productContextMenuStrip.Size = new System.Drawing.Size(202, 70);
            // 
            // AddProductToolStripContextMenuItem
            // 
            this.AddProductToolStripContextMenuItem.Name = "AddProductToolStripContextMenuItem";
            this.AddProductToolStripContextMenuItem.Size = new System.Drawing.Size(201, 22);
            this.AddProductToolStripContextMenuItem.Text = "Добавить продукт";
            this.AddProductToolStripContextMenuItem.Click += new System.EventHandler(this.AddProductToolStripContextMenuItem_Click);
            // 
            // EdditProductToolStripMenuItem1
            // 
            this.EdditProductToolStripMenuItem1.Name = "EdditProductToolStripMenuItem1";
            this.EdditProductToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.EdditProductToolStripMenuItem1.Text = "Редактировать продукт";
            this.EdditProductToolStripMenuItem1.Click += new System.EventHandler(this.EdditProductToolStripMenuItem1_Click);
            // 
            // DeleteProductToolContextStripMenuItem
            // 
            this.DeleteProductToolContextStripMenuItem.Name = "DeleteProductToolContextStripMenuItem";
            this.DeleteProductToolContextStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.DeleteProductToolContextStripMenuItem.Text = "Удалить продукт";
            this.DeleteProductToolContextStripMenuItem.Click += new System.EventHandler(this.DeleteProductToolContextStripMenuItem_Click);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 357);
            this.Controls.Add(this.tabGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "GeneralForm";
            this.Text = "Data Bank";
            ((System.ComponentModel.ISupportInitialize)(this.ctlClientDataGridViewClients)).EndInit();
            this.clientContextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabGridView.ResumeLayout(false);
            this.tabPageClient.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctldataProductGridView)).EndInit();
            this.productContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ctlClientDataGridViewClients;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnCloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddProductToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip clientContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EditDataClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteClientToolStripMenuContextMenuStripItem;
        private System.Windows.Forms.TabControl tabGridView;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.DataGridView ctldataProductGridView;
        private System.Windows.Forms.ToolStripMenuItem DeleteClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindClientToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctlNameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctlDescription;
        private System.Windows.Forms.ContextMenuStrip productContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddProductToolStripContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EdditProductToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeleteProductToolContextStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сSortNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortLastNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortNameOfAscendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortNameOfDescendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortLastNameofAscendingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SortLastNameOfDescendingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SortIdOfAscendingToolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctlId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctlFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctlPatronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctlBd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CtlProduct;
    }
}

