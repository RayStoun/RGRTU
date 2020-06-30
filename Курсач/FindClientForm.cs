using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class FindClientForm : Form
    {
        public FindClientForm()
        {
            InitializeComponent();
        }
        public int ClienId;
        private void ValidateIndex()
        {
            
        }
        public void ThatClientDontExistMessage()
        {
            MessageBox.Show("Такого клиента не существует!");
            this.Close();
        }
        private void Validate(Control control, string ctrValue, string ErrorMessage, CancelEventArgs e)
        { 
            if (string.IsNullOrEmpty(ctrValue))
            {
                errorProvFindClientForm.SetError(control, ErrorMessage);
                e.Cancel = true;
            }
            else
            {
                errorProvFindClientForm.SetError(control, string.Empty);
                e.Cancel = false;
            }
        }
        private void txtFindIndex_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtFindIndex, txtFindIndex.Text, "Поле не может быть пустым", e);
        }

        private void txtFindIndex_Validated(object sender, EventArgs e)
        {
            ClienId = int.Parse(txtFindIndex.Text);
        }
    }
}
