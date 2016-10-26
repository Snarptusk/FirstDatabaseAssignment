using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAssignmentDatabases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            using (var db = new AdressContext())
            {
                var person = new Person { Name = txtName.Text, Adress = txtAdress.Text,
                    PostNr = txtPostNr.Text, City = txtCity.Text, PhoneNr = txtPhoneNr.Text,
                    Email = txtEmail.Text, Birthday = dtpBirthday.Value};

                db.Persons.Add(person);
                db.SaveChanges();
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PostNr { get; set; }
        public string City { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }
}
