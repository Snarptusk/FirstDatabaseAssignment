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

        List<Person> people = new List<Person>();

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void LoadContacts()
        {
            using (var db = new AdressContext())
            {
                var persons = (from p in db.Persons
                               orderby p.Name
                               select p).ToArray();

                foreach (var item in persons)
                {
                    lstContacts.Items.Add(item.Name);
                    people.Add(item);
                }
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            using (var db = new AdressContext())
            {
                var person = new Person
                {
                    Name = txtName.Text,
                    Adress = txtAdress.Text,
                    PostNr = txtPostNr.Text,
                    City = txtCity.Text,
                    PhoneNr = txtPhoneNr.Text,
                    Email = txtEmail.Text,
                    Birthday = dtpBirthday.Value
                };

                people.Add(person);

                db.Persons.Add(person);
                db.SaveChanges();

                lstContacts.Items.Add(person.Name);
            }

            txtName.Text = "";
            txtAdress.Text = "";
            txtPostNr.Text = "";
            txtCity.Text = "";
            txtPhoneNr.Text = "";
            txtEmail.Text = "";
            dtpBirthday.Value = DateTime.Now;
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = people[lstContacts.SelectedItems[0].Index].Name;
                txtAdress.Text = people[lstContacts.SelectedItems[0].Index].Adress;
                txtPostNr.Text = people[lstContacts.SelectedItems[0].Index].PostNr;
                txtCity.Text = people[lstContacts.SelectedItems[0].Index].City;
                txtPhoneNr.Text = people[lstContacts.SelectedItems[0].Index].PhoneNr;
                txtEmail.Text = people[lstContacts.SelectedItems[0].Index].Email;
                dtpBirthday.Value = people[lstContacts.SelectedItems[0].Index].Birthday;
            }
            catch { }
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            using (var db = new AdressContext())
            {
                var persons = from p in db.Persons
                              orderby p.Name
                              select p;

            }
        }
    }

    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PostNr { get; set; }
        public string City { get; set; }
        public string PhoneNr { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }
}
