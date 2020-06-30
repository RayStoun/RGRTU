using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Kursach
{
    partial class AddClientForm:Form
    {
        private void ValidateDate(Control control, DateTime dt, string errorMessage, CancelEventArgs e)
        {
            if (dt == null || DateTime.Now.Year - 150 < dt.Year)
            {
                errorProvider1.SetError(control, errorMessage);
            }
            else
            {
                errorProvider1.SetError(txtBirthDate, string.Empty);
            }
        }
        private void Validate(Control control, string ctrValue,string ErrorMessage,CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrValue))
            {
                errorProvider1.SetError(control, ErrorMessage);
                e.Cancel=true;
            }
            else
            {
                errorProvider1.SetError(control, string.Empty);
                e.Cancel=false;
            }
        }
        private string DeleteAllBesidesWords(string str)
        {
            return Regex.Replace(str, "\\W", "");
        }
        private void txtLastName_Validated(object sender, EventArgs e)
        {
            LastName = DeleteAllBesidesWords(txtLastName.Text.Trim());
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtLastName, txtLastName.Text.Trim(), "Имя не может быть пустое", e);
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = DeleteAllBesidesWords(txtFirstName.Text.Trim());
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtFirstName, txtFirstName.Text.Trim(), "Имя не может быть пустое", e);
        }

        private void txtBirthDate_Validating(object sender, CancelEventArgs e)
        {
            ValidateDate(txtBirthDate, txtBirthDate.Value, "Возраст не может превышать 150 лет", e);
        }

        private void txtBirthDate_Validated(object sender, EventArgs e)
        {
            BirthDate = txtBirthDate.Value;
        }

        private void txtPatronymic_Validated(object sender, EventArgs e)
        {
            Patronymic = DeleteAllBesidesWords(txtPatronymic.Text.Trim());
        }

    }
}
