using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FirstAssignmentDatabases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> people = new List<Person>();
        List<Person> searchList = new List<Person>();

        Person SelectedPerson = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void LoadContacts()
        {
            lstContacts.DataSource = null;
            lstContacts.Items.Clear();

            using (var db = new AdressContext())
            {
                var persons = (from p in db.Persons
                               orderby p.PersonId
                               select p).ToArray();

                foreach (var item in persons)
                {
                    lstContacts.Items.Add(item);
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

            LoadContacts();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            using (var db = new AdressContext())
            {
                SelectedPerson = people[lstContacts.SelectedIndex];

                var editedPerson = db.Persons.Find(SelectedPerson.PersonId);

                editedPerson.Name = txtName.Text;
                editedPerson.Adress = txtAdress.Text;
                editedPerson.PostNr = txtPostNr.Text;
                editedPerson.City = txtCity.Text;
                editedPerson.PhoneNr = txtPhoneNr.Text;
                editedPerson.Email = txtEmail.Text;
                editedPerson.Birthday = dtpBirthday.Value;

                db.SaveChanges();
            }
            LoadContacts();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            using (var db = new AdressContext())
            {
                SelectedPerson = people[lstContacts.SelectedIndex];

                var deletedPerson = db.Persons.Find(SelectedPerson.PersonId);

                db.Persons.Remove(deletedPerson);

                db.SaveChanges();

                lstContacts.Items.Remove(SelectedPerson.Name);
            }
            LoadContacts();
        }

        private void lstContacts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                //Search(txtSearch.Text, people);

                //SelectedPerson = people[lstContacts.SelectedIndex];
                SelectedPerson = (Person)lstContacts.SelectedItem;

                txtName.Text = SelectedPerson.Name;
                txtAdress.Text = SelectedPerson.Adress;
                txtPostNr.Text = SelectedPerson.PostNr;
                txtCity.Text = SelectedPerson.City;
                txtPhoneNr.Text = SelectedPerson.PhoneNr;
                txtEmail.Text = SelectedPerson.Email;
                dtpBirthday.Value = SelectedPerson.Birthday;
            }
            catch { }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Search(txtSearch.Text, people, searchList);
        }

        private void Search(string search, List<Person> people, List<Person> searchList)
        {

            //searchList.Clear();
            lstContacts.Items.Clear();

            //using (var db = new AdressContext())
            //{
            //    var persons = (from p in db.Persons
            //                   orderby p.PersonId
            //                   select p).ToList();

            if (txtSearch.Text != "")
            {
                foreach (var item in people)
                {
                    if (item.Name.Contains(search) || item.City.Contains(search) || item.Adress.Contains(search))
                    {
                        lstContacts.Items.Add(item);
                        //searchList.Add(item);
                    }
                }
                //lstContacts.DataSource = searchList;
            }
            //}
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            //searchList.Clear();

            LoadContacts();
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

        public override string ToString()
        {
            return Name;
        }
    }
}
