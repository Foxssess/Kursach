using Kursach.DbContextDate;
using Kursach.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach.MainOffice
{
    public partial class FormListDoctors : Form
    {
        private DbContextData dbContext;

        string connectionString;
        public FormListDoctors(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }
        private void FormListDoctors_Load(object sender, EventArgs e)
        {
            dbContext = new DbContextData(connectionString);
            dataGridViewDoctors.DataSource = dbContext.Doctors.ToList();
            dataGridViewDoctors.Columns[0].Visible = false;
        }

        private void buttonAddDoctors_Click(object sender, EventArgs e)
        {
            
            Doctor doctor = new Doctor { FirstNameDoctor = textBoxFirstName.Text, SecondNameDoctor = textBoxSurname.Text, FatherNameDoctor = textBoxFatherName.Text, Adress = textBoxAddress.Text, BirthDay = DateOnly.FromDateTime(dateTimePickerBirthDay.Value), Experience = textBoxExperience.Text, Phone = textBoxPhone.Text,  Diploma = textBoxDiplom.Text, MilitaryTicket = textBoxWarTicket.Text, Passport = textBoxPassport.Text, Snils = textBoxSnils.Text  };

            dbContext.Doctors.Add(doctor);

            dbContext.SaveChanges();
        }

        private void buttonSearchDoctors_Click(object sender, EventArgs e)
        {
            var searchResult = dbContext.Doctors.Where(d => d.SecondNameDoctor.Contains(textBoxSearch.Text) || d.Adress.Contains(textBoxSearch.Text) || d.Phone.Contains(textBoxSearch.Text)
||           d.FirstNameDoctor.Contains(textBoxSearch.Text) || d.FatherNameDoctor.Contains(textBoxSearch.Text));
            dataGridViewDoctors.DataSource = searchResult.ToList();
            dataGridViewDoctors.Columns.RemoveAt(0);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewDoctors.DataSource = dbContext.Doctors.ToArray();
        }
    }
}
