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
    partial class GeneralForm: Form
    {
        
        private void AddClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddClient();
        }
        private void AddClientToolStripContextMenuItem_Click(object sender, EventArgs e)
        {
            AddClient();
        }
        private void EditDataClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClient(GetClientID());
        }
        private void EditClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClient(GetClientID());
        }
        private void BtnCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DeleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteClient(GetClientID());
        }
        private void DeleteClientToolStripMenuContextMenuStripItem_Click(object sender, EventArgs e)
        {
            DeleteClient(GetClientID());
        }

    }
}
