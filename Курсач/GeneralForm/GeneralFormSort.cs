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
    partial class GeneralForm:Form
    {
        private void SortDataGridViewClientLastName()
        {
            
            if (point == SortOrder.Asc)
            {
                var sortClient = data.GetClientViewModels().OrderBy(u => u.LastName).ToList();
                ctlClientDataGridViewClients.DataSource = sortClient;
                point = SortOrder.Desc;
            }
            else
            {
                var sortClient = data.GetClientViewModels().OrderByDescending(u => u.LastName).ToList();
                ctlClientDataGridViewClients.DataSource = sortClient;
                point = SortOrder.Asc;
            }
            ctlClientDataGridViewClients.AutoGenerateColumns = false;
        }
        private enum SortOrder
        {
            Asc,
            Desc
        }
        private SortOrder point = SortOrder.Asc;
        private void SortNameOfAscendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.SortFirstNameClient(true);
            UpdateClientGrid();
        }

        private void SortNameOfDescendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data.SortFirstNameClient(false);
            UpdateClientGrid();
        }

        private void SortLastNameofAscendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            data.SortLastName(true);
            UpdateClientGrid();
        }

        private void SortLastNameOfDescendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            data.SortLastName(false);
            UpdateClientGrid();
        }

        private void SortIdOfAscendingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            data.SortById();
            UpdateClientGrid();
        }
    }
}
