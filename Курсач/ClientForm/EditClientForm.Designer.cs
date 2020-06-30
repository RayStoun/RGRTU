namespace Kursach
{
    partial class EditClientForm
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
            this.lblEditName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEditFirstName = new System.Windows.Forms.TextBox();
            this.txtEditLastName = new System.Windows.Forms.TextBox();
            this.txtEditPatronymic = new System.Windows.Forms.TextBox();
            this.txtEditDateTime = new System.Windows.Forms.DateTimePicker();
            this.checkedEditListBox = new System.Windows.Forms.CheckedListBox();
            this.errorProvEditForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEditClientOK = new System.Windows.Forms.Button();
            this.btnEditClientCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvEditForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditName
            // 
            this.lblEditName.AutoSize = true;
            this.lblEditName.Location = new System.Drawing.Point(13, 13);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(81, 13);
            this.lblEditName.TabIndex = 0;
            this.lblEditName.Text = "Изменить имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "изменить фамилию";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "изменить отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "изменить дату рождения";
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.Location = new System.Drawing.Point(154, 12);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(181, 20);
            this.txtEditFirstName.TabIndex = 1;
            this.txtEditFirstName.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtEditFirstName_Layout);
            this.txtEditFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditName_Validating);
            this.txtEditFirstName.Validated += new System.EventHandler(this.txtEditName_Validated);
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.Location = new System.Drawing.Point(154, 38);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(181, 20);
            this.txtEditLastName.TabIndex = 2;
            this.txtEditLastName.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtEditLastName_Layout);
            this.txtEditLastName.Leave += new System.EventHandler(this.txtEditLastName_Leave);
            this.txtEditLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEditLastName_Validating);
            this.txtEditLastName.Validated += new System.EventHandler(this.txtEditLastName_Validated);
            // 
            // txtEditPatronymic
            // 
            this.txtEditPatronymic.Location = new System.Drawing.Point(154, 64);
            this.txtEditPatronymic.Name = "txtEditPatronymic";
            this.txtEditPatronymic.Size = new System.Drawing.Size(181, 20);
            this.txtEditPatronymic.TabIndex = 3;
            this.txtEditPatronymic.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtEditPatronymic_Layout);
            this.txtEditPatronymic.Validated += new System.EventHandler(this.txtEditPatronymic_Validated);
            // 
            // txtEditDateTime
            // 
            this.txtEditDateTime.Location = new System.Drawing.Point(154, 94);
            this.txtEditDateTime.Name = "txtEditDateTime";
            this.txtEditDateTime.Size = new System.Drawing.Size(181, 20);
            this.txtEditDateTime.TabIndex = 4;
            this.txtEditDateTime.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtEditDateTime_Layout);
            this.txtEditDateTime.Leave += new System.EventHandler(this.txtEditDateTime_Leave);
            this.txtEditDateTime.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEditDateTime_Validating);
            this.txtEditDateTime.Validated += new System.EventHandler(this.TxtEditDateTime_Validated);
            // 
            // checkedEditListBox
            // 
            this.checkedEditListBox.FormattingEnabled = true;
            this.checkedEditListBox.Location = new System.Drawing.Point(23, 130);
            this.checkedEditListBox.Name = "checkedEditListBox";
            this.checkedEditListBox.Size = new System.Drawing.Size(312, 94);
            this.checkedEditListBox.TabIndex = 8;
            this.checkedEditListBox.Validated += new System.EventHandler(this.CheckListProduct_Validated);
            // 
            // errorProvEditForm
            // 
            this.errorProvEditForm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvEditForm.ContainerControl = this;
            // 
            // btnEditClientOK
            // 
            this.btnEditClientOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditClientOK.Location = new System.Drawing.Point(179, 230);
            this.btnEditClientOK.Name = "btnEditClientOK";
            this.btnEditClientOK.Size = new System.Drawing.Size(75, 23);
            this.btnEditClientOK.TabIndex = 9;
            this.btnEditClientOK.Text = "Ok";
            this.btnEditClientOK.UseVisualStyleBackColor = true;
            // 
            // btnEditClientCancel
            // 
            this.btnEditClientCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEditClientCancel.Location = new System.Drawing.Point(260, 230);
            this.btnEditClientCancel.Name = "btnEditClientCancel";
            this.btnEditClientCancel.Size = new System.Drawing.Size(75, 23);
            this.btnEditClientCancel.TabIndex = 10;
            this.btnEditClientCancel.Text = "Отмена";
            this.btnEditClientCancel.UseVisualStyleBackColor = true;
            // 
            // EditClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 270);
            this.Controls.Add(this.btnEditClientCancel);
            this.Controls.Add(this.btnEditClientOK);
            this.Controls.Add(this.checkedEditListBox);
            this.Controls.Add(this.txtEditDateTime);
            this.Controls.Add(this.txtEditPatronymic);
            this.Controls.Add(this.txtEditLastName);
            this.Controls.Add(this.txtEditFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEditName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditClientForm";
            this.Text = "Изменить данныые клиенте";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvEditForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEditFirstName;
        private System.Windows.Forms.TextBox txtEditLastName;
        private System.Windows.Forms.TextBox txtEditPatronymic;
        private System.Windows.Forms.DateTimePicker txtEditDateTime;
        private System.Windows.Forms.CheckedListBox checkedEditListBox;
        private System.Windows.Forms.ErrorProvider errorProvEditForm;
        private System.Windows.Forms.Button btnEditClientCancel;
        private System.Windows.Forms.Button btnEditClientOK;
    }
}