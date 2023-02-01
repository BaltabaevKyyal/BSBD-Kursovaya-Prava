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
    public partial class FormPeople : Form
    {
        public FormPeople()
        {
            InitializeComponent();
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.peopleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.pravaDataSet);
                MessageBox.Show("Данные обновлены!");
            }
            catch
            {
                MessageBox.Show("Ошибка, введены некорректные данные");
            }
        }

        private void FormPeople_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pravaDataSet.People". При необходимости она может быть перемещена или удалена.
            this.peopleTableAdapter.Fill(this.pravaDataSet.People);

        }
        string GetSelectedFieldName()
        {
            return peopleDataGridView.Columns[peopleDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolstripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
                peopleBindingSource.Find(GetSelectedFieldName(),
                toolstripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                peopleBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                peopleBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolstripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        peopleBindingSource.Filter =
                        GetSelectedFieldName() + "='" + toolstripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                peopleBindingSource.Filter = "";
            if (peopleBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                peopleBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
    }
}
