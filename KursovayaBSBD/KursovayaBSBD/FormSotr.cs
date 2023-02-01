using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaBSBD
{
    public partial class FormSotr : Form
    {
        public FormSotr()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС,Балтабаев Кыял Миркамилович,группа 740-1,2023", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void заявленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZayavSotr ZayavSotr = new FormZayavSotr();
            ZayavSotr.Show();
        }

        private void праваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPravaSotr PravaSotr = new FormPravaSotr();
            PravaSotr.Show();
        }
    }
}
