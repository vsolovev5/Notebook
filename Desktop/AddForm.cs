using API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class AddForm : Form
    {
        const string _baseAddress = "http://localhost:5000/";

        public AddForm()
        {
            InitializeComponent();
        }
        private void Add(Person p)
        {
            Person newReport = new Person() { Firstname = "Коля", BirthDay = DateTime.Parse("01.02.2003") };


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/People", p).Result;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Firstname = Firstname.Text;
            p.Secondname = Secondname.Text;
            p.BirthDay = BirthDay.Value.Date;
            p.Contacts = null;
            
            Add(p);
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            AddForm a = new AddForm();
            a.Close();
            
        }
    }
}
