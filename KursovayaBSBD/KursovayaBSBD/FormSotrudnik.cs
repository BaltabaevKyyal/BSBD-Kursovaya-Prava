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
    public partial class FormSotrudnik : Form
    {
        public FormSotrudnik()
        {
            InitializeComponent();
        }

        private void sotrudnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sotrudnikBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pravaDataSet);
            }
            catch
            {
                MessageBox.Show("Ошибка, введены некорректные данные");
            }
        }

        private void FormSotrudnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pravaDataSet.Sotrudnik". При необходимости она может быть перемещена или удалена.
            this.sotrudnikTableAdapter.Fill(this.pravaDataSet.Sotrudnik);

        }
    }
}
