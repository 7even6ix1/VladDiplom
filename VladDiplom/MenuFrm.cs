using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VladDiplom
{
    public partial class MenuFrm : Form
    {
        private string login;
        private string role;
        public MenuFrm(string login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void MenuFrm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VladCheremDiplom.mssql.somee.com;Initial Catalog=VladCheremDiplom;User ID=VladCherem_SQLLogin_1;Password=gn6l2nwhw4");
            SqlDataAdapter sda = new SqlDataAdapter("Select Surname, Name, Patronymic from Workers where Id='" + login + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter sda2 = new SqlDataAdapter("Select Post from Workers where Id='" + login + "'", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            string post = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("Select Name from Posts where Id='" + post + "'", con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            label1.Text = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString() + ", " + dt3.Rows[0][0].ToString();
            if(label1.Text.Contains("Директор") || label1.Text.Contains("Управляющий"))
            {
                addSpravochnik.Visible = true;
            }
        }

        private void workersBtn_Click(object sender, EventArgs e)
        {
            WorkersInfoFrm workersInfoFrm = new WorkersInfoFrm(login);
            this.Hide();
            workersInfoFrm.Show();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка. Обратитесь к сисадмину.");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AuthorisationFrm authorisationFrm = new AuthorisationFrm();
            this.Hide();
            authorisationFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SdelkiFrm sdelkiFrm = new SdelkiFrm(login);
            this.Hide();
            sdelkiFrm.Show();
        }

        private void carsBtn_Click(object sender, EventArgs e)
        {
            CarsFrm carsFrm = new CarsFrm(login);
            this.Hide();
            carsFrm.Show();
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            ClientsFrm clientsFrm = new ClientsFrm(login);
            this.Hide();
            clientsFrm.Show();
        }

        private void addSpravochnik_Click(object sender, EventArgs e)
        {
            AddSpravochnikFrm addSpravochnikFrm = new AddSpravochnikFrm(login);
            this.Hide();
            addSpravochnikFrm.Show();
        }
    }
}
