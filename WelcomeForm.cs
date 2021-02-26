using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centralizare_absente
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            ProfesorForm profesorForm = new ProfesorForm();
            this.Hide();
            profesorForm.ShowDialog();
            this.Close();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.ShowDialog();
            this.Close();
        }

       
    }
}
