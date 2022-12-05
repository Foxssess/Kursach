using Kursach.DbContextDate;
using Kursach.models;
using Microsoft.EntityFrameworkCore;
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

        int selectedDoctor;

        int selectedPatient;

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
            var receptions = dbContext.Receptions.ToArray();
            dataGridViewPriem.DataSource = receptions;
            dataGridViewPriem.Columns.Add("Doctor", "Doctor");
            dataGridViewPriem.Columns.Add("Patient", "Patient");
            dataGridViewPriem.Columns[0].Visible = false;
            dataGridViewPriem.Columns[2].Visible = false;
            dataGridViewPriem.Columns[7].Visible = false;
            for (int i = 0; i < receptions.Length; i++)
            {
                var doctors = dbContext.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells[2].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameDoctor;
                var pattiens = dbContext.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells[7].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }
            dataGridViewListDoctors.DataSource = dbContext.Doctors.ToArray();
            dataGridViewListPatients.DataSource = dbContext.Patients.ToArray();
            dataGridViewListDoctors.Columns[0].Visible = false;
            dataGridViewListPatients.Columns[0].Visible = false;
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
            Reception reception = new Reception { Cost = textBoxCost.Text, Room = comboBoxRoom.Text, DoctorId = selectedDoctor, Data = DateOnly.FromDateTime(dateTimePickerPriem.Value), PatientId = selectedPatient, Time = textBoxPriemTime.Text};
           
            dbContext.Receptions.Add(reception);
            
            dbContext.SaveChanges();

            dataGridViewPriem.DataSource = dbContext.Receptions.ToArray();

            var receptions = dbContext.Receptions.ToArray();
            dataGridViewPriem.DataSource = receptions;
            for (int i = 0; i < receptions.Length; i++)
            {
                var doctors = dbContext.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["DoctorId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameDoctor;
                var pattiens = dbContext.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["PatientId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }
        }

        private void buttonMoveListDoctors_Click(object sender, EventArgs e)
        {
            FormListDoctors formListDoctors = new FormListDoctors(connectionString);
            formListDoctors.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            var receptions = dbContext.Receptions.ToArray();
            dataGridViewPriem.DataSource = receptions;
            for (int i = 0; i < receptions.Length; i++)
            {
                var doctors = dbContext.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["DoctorId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameDoctor;
                var pattiens = dbContext.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["PatientId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }

        }

        private void buttonSearchPriem_Click(object sender, EventArgs e)
        {
            var searchResult = dbContext.Receptions.Where(d => d.NameService.Contains(textBoxSearchPriem.Text) || d.Room.Contains(textBoxSearchPriem.Text)|| d.Time.Contains(textBoxSearchPriem.Text));
            dataGridViewPriem.DataSource = searchResult.ToList();
            for (int i = 0; i < searchResult.Count(); i++)
            {
                var doctors = dbContext.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["DoctorId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameDoctor;
                var pattiens = dbContext.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["PatientId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }
            //dataGridViewPriem.Columns.RemoveAt(0);
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            var receptions = dbContext.Receptions.ToList();

            receptions.AddRange(dbContextOne.Receptions.ToList());

            receptions.AddRange(dbContextTwo.Receptions.ToList());

            dataGridViewPriem.DataSource = receptions ;

            var receptionsMain = dbContext.Receptions.ToArray();

            for (int i = 0; i < receptionsMain.Length; i++)
            {
                var doctors = dbContext.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["DoctorId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameDoctor;
                var pattiens = dbContext.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["PatientId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }

            var receptionsFilialOne = dbContextOne.Receptions.ToArray();
            for (int i = receptionsMain.Length; i < receptionsFilialOne.Length + receptionsMain.Length; i++)
            {
                var doctors = dbContextOne.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["DoctorId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameDoctor;
                var pattiens = dbContextOne.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["PatientId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }

            var receptionsFilialTwo = dbContextTwo.Receptions.ToArray();
            for (int i = receptionsMain.Length + receptionsFilialTwo.Length; i < receptionsFilialOne.Length + receptionsMain.Length + receptionsFilialTwo.Length; i++)
            {
                var doctors = dbContextTwo.Doctors.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["DoctorId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Doctor"].Value = doctors[0].SecondNameDoctor;
                var pattiens = dbContextTwo.Patients.Where(p => p.Id == ((int)dataGridViewPriem.Rows[i].Cells["PatientId"].Value)).ToArray();
                dataGridViewPriem.Rows[i].Cells["Patient"].Value = pattiens[0].SecondName;
            }
        }

        private void buttonMoveTimeWork_Click(object sender, EventArgs e)
        {
            FormTimeWork formTimeWork = new FormTimeWork(connectionString);
            formTimeWork.ShowDialog();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
            dbContextOne.SaveChanges();
            dbContextTwo.SaveChanges();
        }

        private void dataGridViewListPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedPatient = (int)dataGridViewListPatients.Rows[e.RowIndex].Cells[0].Value;
            }
            catch { 
            }
        }

        private void dataGridViewListDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedDoctor = (int)dataGridViewListDoctors.Rows[e.RowIndex].Cells[0].Value;
            }
            catch
            {
            }
        }
    }
}
