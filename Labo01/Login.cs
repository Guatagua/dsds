using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Labo01
{
    public partial class frmLogin : Form
    {

        int xLoginChecked = 1;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void loadforminpaneletudiant(object form)
        {
            if (this.panelShow.Controls.Count > 0)
                this.panelShow.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelShow.Controls.Add(f);
            this.panelShow.Tag = f;
            f.Show();
        }
        public void loadforminpanelmenuprincipale(object form)
        {
            if (this.panelShow.Controls.Count > 0)
                this.panelShow.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelShow.Controls.Add(f);
            this.panelShow.Tag = f;
            f.Show();
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {

           
        }

        private void bt_Connect_MouseHover(object sender, EventArgs e)
        {
            bt_Connect.ForeColor = Color.DarkBlue; 
        }

        private void bt_Connect_MouseLeave(object sender, EventArgs e)
        {
            bt_Connect.ForeColor = Color.DarkRed;
        }

        private void txt_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void optEtudiant_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void optAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_Connect_Click_1(object sender, EventArgs e)
        {
            string Login, Pwd;
            Login = txt_Login.Text;
            Pwd = txt_PWD.Text;
            if (!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Pwd))
            {
                ClLogin login = new ClLogin();

                if (optAdmin.Checked && login.AuthentificationEtudiant(Login, Pwd))
                {
                    loadforminpaneletudiant(new Suivie());
                }
                else if (optEtudiant.Checked && login.AuthentificationAdmin(Login, Pwd))
                {
                    loadforminpanelmenuprincipale(new frmSpecialite());
                }
                else
                {
                    MessageBox.Show("Verifier votre login et mot de passe !", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tapez votre login et mot de passe!", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelShow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
