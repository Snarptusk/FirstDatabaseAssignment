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
            lstContacts.Items.Clear();

            using (var db = new AdressContext())
            {
                var persons = (from p in db.Persons
                               orderby p.PersonId
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

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            //SelectedPerson = people[lstContacts.SelectedIndex];

            //SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //cn.Open();
            //SqlCommand cmd = cn.CreateCommand();
            //cmd.CommandText = "UPDATE People(Name, Adress, PostNr, City, PhoneNr, Email, Birthday) VALUES(" + txtName.Text + ", " + txtAdress.Text + ", " + txtPostNr.Text + ", " + txtCity.Text + ", " + txtPhoneNr.Text + ", " + dtpBirthday + "WHERE People.Name = " + SelectedPerson.Name;

            //cn.Close();

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
        }

        private void lstContacts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                //Search(txtSearch.Text, people);

                txtName.Text = people[lstContacts.SelectedIndex].Name;
                txtAdress.Text = people[lstContacts.SelectedIndex].Adress;
                txtPostNr.Text = people[lstContacts.SelectedIndex].PostNr;
                txtCity.Text = people[lstContacts.SelectedIndex].City;
                txtPhoneNr.Text = people[lstContacts.SelectedIndex].PhoneNr;
                txtEmail.Text = people[lstContacts.SelectedIndex].Email;
                dtpBirthday.Value = people[lstContacts.SelectedIndex].Birthday;

                SelectedPerson = people[lstContacts.SelectedIndex];
            }
            catch { }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            Search(txtSearch.Text, people);
        }

        private void Search(string search, List<Person> people)
        {
            lstContacts.Items.Clear();

            //using (var db = new AdressContext())
            //{
            //    var persons = (from p in db.Persons
            //                   orderby p.PersonId
            //                   select p).ToList();

            foreach (var item in people)
            {
                if (item.Name.Contains(search))
                {
                    //lstContacts.Items.Add(item.Name);
                    searchList.Add(item);

                    lstContacts.DataSource = searchList;
                }
            }
            //}
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
