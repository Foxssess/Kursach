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
    public partial class FormCreatePriem : Form
    {
        private DbContextData dbContext;

        private DbContextDataFillialOne dbContextOne = new DbContextDataFillialOne();

        private DbContextDataFillialTwo dbContextTwo = new DbContextDataFillialTwo();

        string connectionString;

        public FormCreatePriem(string connection)
        {
            connectionString = connection;
            InitializeComponent();
        }

        private void buttonMoveCreatePatient_Click(object sender, EventArgs e)
        {
            FormCreatePatient formCreatePatient = new FormCreatePatient(connectionString);
            formCreatePatient.ShowDialog();
        }

        private void FormCreatePriem_Load(object sender, EventArgs e)
        {
            dbContext = new DbContextData(connectionString);
            dataGridViewPriem.DataSource = dbContext.Receptions.ToArray(); 
            var doctors = dbContext.Doctors.ToList();
            for (int i = 0; doctors.Count > i; i++)
            {
                comboBoxListDoctors.Items.Add(doctors[i].SecondNameDoctor);
            }
            var patients = dbContext.Patients.ToList();
            for (int i = 0; patients.Count > i; i++)
            {
                comboBoxPatients.Items.Add(patients[i].SecondName);
            }
            var room = dbContext.Rooms.ToList();
            for (int i = 0; room.Count > i; i++)
            {
                comboBoxRoom.Items.Add(room[i].NameRoom);
            }
            if (connectionString == "Host=localhost;Port=5432;Database=MainOffice;Username=postgres;Password=Microla412") 
            {
                buttonShowAll.Visible = true;
            }
            else
            {
                buttonShowAll.Visible = false;
            }

        }

        private void buttonCreatePriem_Click(object sender, EventArgs e)
        {
            dbContext = new DbContextData(connectionString);
            Reception reception = new Reception { Cost = textBoxCost.Text, Room = comboBoxRoom.Text, Doctor = comboBoxListDoctors.Text, Data = DateOnly.FromDateTime(dateTimePickerPriem.Value), Patient = comboBoxPatients.Text, Time = textBoxPriemTime.Text};
           
            dbContext.Receptions.Add(reception);
            
            dbContext.SaveChanges();
        }

        private void buttonMoveListDoctors_Click(object sender, EventArgs e)
        {
            FormListDoctors formListDoctors = new FormListDoctors(connectionString);
            formListDoctors.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

             dataGridViewPriem.DataSource = dbContext.Receptions.ToArray();

            
        }

        private void buttonSearchPriem_Click(object sender, EventArgs e)
        {
            var searchResult = dbContext.Receptions.Where(d => d.NameService.Contains(textBoxSearchPriem.Text) || d.Room.Contains(textBoxSearchPriem.Text) || d.Doctor.Contains(textBoxSearchPriem.Text)
||          d.Patient.Contains(textBoxSearchPriem.Text) || d.Time.Contains(textBoxSearchPriem.Text));
            dataGridViewPriem.DataSource = searchResult.ToList();
            dataGridViewPriem.Columns.RemoveAt(0);
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            var receptions = dbContext.Receptions.ToList();

            receptions.AddRange(dbContextOne.Receptions.ToList());

            receptions.AddRange(dbContextTwo.Receptions.ToList());

            dataGridViewPriem.DataSource = receptions ;
        }

        private void buttonMoveTimeWork_Click(object sender, EventArgs e)
        {
            FormTimeWork formTimeWork = new FormTimeWork(connectionString);
            formTimeWork.ShowDialog();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }
    }
}
