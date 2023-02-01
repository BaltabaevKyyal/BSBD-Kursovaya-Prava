using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace KursovayaBSBD
{
    public partial class FormAuth : Form
    {
        public SqlConnection sqlconnection = null;
        public FormAuth()
        {
            InitializeComponent();
        }
        
        private void auth_Load(object sender, EventArgs e)
        {
            sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Connector"].ConnectionString);
            sqlconnection.Open();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            
            var login = textBoxLogin.Text;
            var pass = textBoxPassword.Text;

            SqlDataAdapter adapter_admin = new SqlDataAdapter();
            DataTable dt_admin = new DataTable();
            SqlDataAdapter adapter_sotrudnik = new SqlDataAdapter();
            DataTable dt_sotrudnik = new DataTable();

            string select_admin = $"select login, password from admin where login = '{login}' and " + $"password = '{pass}'";
            string select_sotr = $"select login, password from sotr where login = '{login}' and " + $"password = '{pass}'";

            SqlCommand select_admin_cmd = new SqlCommand(select_admin, sqlconnection);
            SqlCommand select_sotr_cmd = new SqlCommand(select_sotr, sqlconnection);

            adapter_admin.SelectCommand = select_admin_cmd;
            adapter_admin.Fill(dt_admin);
            adapter_sotrudnik.SelectCommand = select_sotr_cmd;
            adapter_sotrudnik.Fill(dt_sotrudnik);

            if (dt_admin.Rows.Count > 0)
            {
                MessageBox.Show("Выполнен вход от имени администратора");
                this.Hide();
                sqlconnection.Close();
                FormAdmin adm = new FormAdmin();
                adm.Show();
            }
            else if (dt_sotrudnik.Rows.Count > 0)
            {
                MessageBox.Show("Выполнен вход от имени сотрудника");
                this.Hide();
                sqlconnection.Close();
                FormSotr sotr = new FormSotr();
                sotr.Show();
            }
            else
            {
                MessageBox.Show("Не найден пользователь с такими данными");
            }    
            
        }
    }
}
