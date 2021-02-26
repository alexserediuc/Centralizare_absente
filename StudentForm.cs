using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Centralizare_absente
{
    public partial class StudentForm : Form
    {
        StudentCollection studenti;

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            studenti = new StudentCollection();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            this.Hide();
            welcomeForm.ShowDialog();
            this.Close();
        }

        private void btnAfiseazaAbsente_Click(object sender, EventArgs e)
        {

            Student deAfisat = studenti.getStudentByID(tbIdentificator.Text);
            if (deAfisat == null)
                lblIdInexistent.Visible = true;
            else
            {
                if (deAfisat.Absente.isEmpty())
                    rtbAfisareAbsente.Text = "Nu exista absente.";
                else
                {
                    rtbAfisareAbsente.Text = deAfisat.Absente.ToString();
                    lblIdInexistent.Visible = false;
                }
            }
        }
    }
}
