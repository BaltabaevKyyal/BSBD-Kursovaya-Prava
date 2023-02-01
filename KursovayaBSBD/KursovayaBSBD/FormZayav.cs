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
    public partial class FormZayav : Form
    {
        public FormZayav()
        {
            InitializeComponent();
        }
        
        private void FormZayav_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pravaDataSet.Zayavlenie". При необходимости она может быть перемещена или удалена.
            this.zayavlenieTableAdapter.Fill(this.pravaDataSet.Zayavlenie);

        }
        
        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.zayavlenieBindingSource.EndEdit();
                this.zayavlenieTableAdapter.Update(this.pravaDataSet);
                MessageBox.Show("Данные обновлены!");
            }
            catch
            {
                MessageBox.Show("Ошибка, введены некорректные данные");
            }
        }
    }
}
