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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursach_2._0
{
    public partial class LoginForm : Form
    {
        private SqlConnection sql;
        SqlCommand cmd;
        SqlDataReader dr;
        private TeoryForm F;
        public LoginForm(TeoryForm f)
        {
            F = f;
            sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\kursach 2.0\kursach 2.0\LoginDB.mdf"";Integrated Security=True");
            InitializeComponent();
            f.setRoot(false);
            f.Hide();
        }
        // add fileasdasdasd
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text != "" || PasswordTB.Text != "")
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                sql.Open();
                cmd = new SqlCommand("SELECT Login FROM [Users] WHERE Login = N'" + LoginTB.Text + "' AND Password = N'" + PasswordTB.Text + "'", sql);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    string login;
                    login = "SELECT Login, FIO FROM [Users] WHERE Login = N'" + LoginTB.Text + "' AND Password = '" + PasswordTB.Text + "'";
                    dataAdapter.SelectCommand = new SqlCommand(login, sql);
                    dataAdapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        string lg = Convert.ToString(dt.Rows[0][0].ToString());
                        string FIO = Convert.ToString(dt.Rows[0][1].ToString());
                        F.AutoRIz(lg,FIO);
                        Close();
                    }
                    dt.Clear();
                }
                else
                {
                    dr.Close();
                    ErrorLabel.Text = "Такого аккаунта не существует!";
                }
                sql.Close();
            }
            else
            {
                ErrorLabel.Text = "Введите данные";
            }
        }

        private void ClosePB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
