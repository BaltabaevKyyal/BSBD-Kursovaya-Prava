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
    public partial class FormPrava : Form
    {
        public FormPrava()
        {
            InitializeComponent();
        }

        private void pravaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pravaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pravaDataSet);
                MessageBox.Show("Данные обновлены!");
            }
            catch
            {
                MessageBox.Show("Ошибка, введены некорректные данные");
            }
}

        private void FormPrava_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pravaDataSet.Prava". При необходимости она может быть перемещена или удалена.
            this.pravaTableAdapter.Fill(this.pravaDataSet.Prava);

        }
    }
}
