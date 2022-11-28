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
    public partial class FormChooseOffice : Form
    {
        public FormChooseOffice()
        {
            InitializeComponent();
        }

        private void buttonFillialOne_Click(object sender, EventArgs e)
        {
            FormMain mainOfficeForm = new FormMain("Host=localhost;Port=5432;Database=MainOfficeFillialOne;Username=postgres;Password=Microla412;");
            mainOfficeForm.ShowDialog();
        }
       

        private void buttonMainOffice_Click(object sender, EventArgs e)
        {
            FormMain mainOfficeForm = new FormMain("Host=localhost;Port=5432;Database=MainOffice;Username=postgres;Password=Microla412");
            mainOfficeForm.ShowDialog();
        }

        private void buttonFillialTwo_Click(object sender, EventArgs e)
        {
            FormMain mainOfficeForm = new FormMain("Host=localhost;Port=5432;Database=MainOfficeFillialTwo;Username=postgres;Password=Microla412");
            mainOfficeForm.ShowDialog();
        }
    }
}
