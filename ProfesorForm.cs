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
    public partial class ProfesorForm : Form
    {
        Student student;
        StudentCollection studenti;
        AbsentaCollection absente;

        public ProfesorForm()
        {
            InitializeComponent();
        }

        private void ProfesorForm_Load(object sender, EventArgs e)
        {
            studenti = new StudentCollection();
         
            lbStudentiUpdate();
        }

        //Se parcurge lista de studenti din StudentCollection cu scopul de a o introduce in list box
        private void lbStudentiUpdate()
        {
            lbStudenti.Items.Clear(); //se curata Text Boxul cu scopul de a se incarca lista Updatata
            foreach (Student student in studenti.GetStudents())
            {
                lbStudenti.Items.Add(student.Nume + " " + student.Prenume + " " + student.Facultate);
            }
        }

        private void btnAdaugaStudent_Click(object sender, EventArgs e)
        {
            student = new Student();
            student.Nume = tbNume.Text;
            student.Prenume = tbPrenume.Text;
            student.Facultate = tbFacultate.Text;
            student.Cnp = tbCNP.Text;

            absente = new AbsentaCollection();
            student.Absente = absente;

            studenti.addStudent(student);
            lbStudentiUpdate();

        }

        private void btnAfisareStudenti_Click(object sender, EventArgs e)
        {       
            rtbStudenti.Text = studenti.ToString();
        }

        private void btnAdaugaAbsenta_Click(object sender, EventArgs e)
        {
            Absenta absentaDeAdaugat = new Absenta();
            absente = new AbsentaCollection();

            absentaDeAdaugat.Activitate = tbActivitate.Text;
            absentaDeAdaugat.Data = dtpData.Value;

            studenti.addAbsenta(absentaDeAdaugat, lbStudenti.SelectedIndex);

            Console.WriteLine(absentaDeAdaugat);

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            this.Hide();
            welcomeForm.ShowDialog();
            this.Close();
        }
    }
}
