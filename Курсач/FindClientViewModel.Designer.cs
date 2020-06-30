namespace Kursach
{
    partial class FindClientViewModel
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
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblLastName2 = new System.Windows.Forms.Label();
            this.lblFirstName2 = new System.Windows.Forms.Label();
            this.lblPatronymic2 = new System.Windows.Forms.Label();
            this.lblDataTime2 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProduct2 = new System.Windows.Forms.Label();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.BtnDeleteClient = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 9);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Фамилия";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(23, 37);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Имя";
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(23, 61);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(54, 13);
            this.lblPatronymic.TabIndex = 2;
            this.lblPatronymic.Text = "Отчество";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(2, 90);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(87, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Дата Рождения";
            // 
            // lblLastName2
            // 
            this.lblLastName2.AutoSize = true;
            this.lblLastName2.Location = new System.Drawing.Point(132, 9);
            this.lblLastName2.Name = "lblLastName2";
            this.lblLastName2.Size = new System.Drawing.Size(35, 13);
            this.lblLastName2.TabIndex = 4;
            this.lblLastName2.Text = "label5";
            // 
            // lblFirstName2
            // 
            this.lblFirstName2.AutoSize = true;
            this.lblFirstName2.Location = new System.Drawing.Point(132, 37);
            this.lblFirstName2.Name = "lblFirstName2";
            this.lblFirstName2.Size = new System.Drawing.Size(35, 13);
            this.lblFirstName2.TabIndex = 5;
            this.lblFirstName2.Text = "label6";
            // 
            // lblPatronymic2
            // 
            this.lblPatronymic2.AutoSize = true;
            this.lblPatronymic2.Location = new System.Drawing.Point(132, 61);
            this.lblPatronymic2.Name = "lblPatronymic2";
            this.lblPatronymic2.Size = new System.Drawing.Size(35, 13);
            this.lblPatronymic2.TabIndex = 6;
            this.lblPatronymic2.Text = "label7";
            // 
            // lblDataTime2
            // 
            this.lblDataTime2.AutoSize = true;
            this.lblDataTime2.Location = new System.Drawing.Point(132, 90);
            this.lblDataTime2.Name = "lblDataTime2";
            this.lblDataTime2.Size = new System.Drawing.Size(35, 13);
            this.lblDataTime2.TabIndex = 7;
            this.lblDataTime2.Text = "label8";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(13, 117);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(57, 13);
            this.lblProduct.TabIndex = 8;
            this.lblProduct.Text = "Продукты";
            // 
            // lblProduct2
            // 
            this.lblProduct2.AutoSize = true;
            this.lblProduct2.Location = new System.Drawing.Point(135, 116);
            this.lblProduct2.Name = "lblProduct2";
            this.lblProduct2.Size = new System.Drawing.Size(37, 13);
            this.lblProduct2.TabIndex = 9;
            this.lblProduct2.Text = "Пусто";
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(241, 12);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(119, 22);
            this.btnEditClient.TabIndex = 10;
            this.btnEditClient.Text = "Изменить клиента";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // BtnDeleteClient
            // 
            this.BtnDeleteClient.Location = new System.Drawing.Point(241, 41);
            this.BtnDeleteClient.Name = "BtnDeleteClient";
            this.BtnDeleteClient.Size = new System.Drawing.Size(119, 24);
            this.BtnDeleteClient.TabIndex = 11;
            this.BtnDeleteClient.Text = "Удалить клиента";
            this.BtnDeleteClient.UseVisualStyleBackColor = true;
            this.BtnDeleteClient.Click += new System.EventHandler(this.BtnDeleteClient_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(208, 152);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 24);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(289, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 24);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FindClientViewModel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(372, 185);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.BtnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.lblProduct2);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblDataTime2);
            this.Controls.Add(this.lblPatronymic2);
            this.Controls.Add(this.lblFirstName2);
            this.Controls.Add(this.lblLastName2);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindClientViewModel";
            this.Text = "Информация о клиенте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblLastName2;
        private System.Windows.Forms.Label lblFirstName2;
        private System.Windows.Forms.Label lblPatronymic2;
        private System.Windows.Forms.Label lblDataTime2;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProduct2;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button BtnDeleteClient;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}