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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
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

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pravaDataSet.People". При необходимости она может быть перемещена или удалена.
            this.peopleTableAdapter.Fill(this.pravaDataSet.People);

        }

        private void заявлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZayav zayav = new FormZayav();
            zayav.Show();
        }

        private void получающийПраваЧеловекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPeople people = new FormPeople();
            people.Show();
        }

        private void праваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrava prava = new FormPrava();
            prava.Show();
        }

        private void сотрудникГИБДДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSotrudnik sotrudnik = new FormSotrudnik();
            sotrudnik.Show();
        }
    }
}
