namespace Kursach
{
    partial class FindClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindIndex = new System.Windows.Forms.TextBox();
            this.btnFindClinetnOk = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvFindClientForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvFindClientForm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите индекс клиента";
            // 
            // txtFindIndex
            // 
            this.txtFindIndex.Location = new System.Drawing.Point(164, 18);
            this.txtFindIndex.Name = "txtFindIndex";
            this.txtFindIndex.Size = new System.Drawing.Size(137, 20);
            this.txtFindIndex.TabIndex = 1;
            this.txtFindIndex.Validating += new System.ComponentModel.CancelEventHandler(this.txtFindIndex_Validating);
            this.txtFindIndex.Validated += new System.EventHandler(this.txtFindIndex_Validated);
            // 
            // btnFindClinetnOk
            // 
            this.btnFindClinetnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFindClinetnOk.Location = new System.Drawing.Point(145, 46);
            this.btnFindClinetnOk.Name = "btnFindClinetnOk";
            this.btnFindClinetnOk.Size = new System.Drawing.Size(75, 23);
            this.btnFindClinetnOk.TabIndex = 2;
            this.btnFindClinetnOk.Text = "Ok";
            this.btnFindClinetnOk.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(226, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorProvFindClientForm
            // 
            this.errorProvFindClientForm.ContainerControl = this;
            // 
            // FindClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 81);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFindClinetnOk);
            this.Controls.Add(this.txtFindIndex);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindClientForm";
            this.Text = "Поиск клиента";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvFindClientForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindIndex;
        private System.Windows.Forms.Button btnFindClinetnOk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvFindClientForm;
    }
}