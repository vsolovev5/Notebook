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
using API.Models;

namespace Desktop
{
    public partial class Form1 : Form
    {
        const string _baseAddress = "http://localhost:5000/";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddForm a = new AddForm();
            a.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                int id = (int)listView1.SelectedItems[0].Tag;

                Delete(id);

                Update();
            }
        }
        private void Update()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;
                try
                {
                    response = client.GetAsync("api/People").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Person[] reports = response.Content.ReadAsAsync<Person[]>().Result;
                        foreach (var p in reports)
                        {
                            var item = new ListViewItem(new[] { p.Firstname, p.Secondname, p.BirthDay.ToShortDateString() });
                            item.Tag = p.Id;
                            listView1.Items.Add(item);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось подключиться к серверу");
                }
                
                
            }
        }
        private void Delete(int delete)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5000/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.DeleteAsync("api/People/" + delete).Result;

            }
        }



    }
}
