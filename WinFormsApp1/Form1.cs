using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataProvider;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public PersonRepository rep = new DataProvider.PersonRepository();
        public Form1()
        {
            InitializeComponent();
        }


        private List<Person> _persons;
        private int _currentIndex;
        private void Form1_Load(object sender, EventArgs e)
        {
            _persons = rep.GetAll().ToList();
            foreach (Person per in _persons)
            {
                listBox1.Items.Add(per.FirstName + ' ' + per.LastName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentIndex = listBox1.SelectedIndex;
            textBox1.Text = _persons[_currentIndex].FirstName;
            textBox2.Text = _persons[_currentIndex].LastName;
            textBox3.Text = _persons[_currentIndex].Age.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rep.Update(_persons[_currentIndex].PersonId, textBox1.Text, _persons[_currentIndex].LastName, _persons[_currentIndex].Age);
            _persons = rep.GetAll().ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            rep.Update(_persons[_currentIndex].PersonId, _persons[_currentIndex].FirstName, textBox2.Text, _persons[_currentIndex].Age);
            _persons = rep.GetAll().ToList();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            rep.Update(_persons[_currentIndex].PersonId, _persons[_currentIndex].FirstName, _persons[_currentIndex].LastName, Int16.Parse(textBox3.Text));
            _persons = rep.GetAll().ToList();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                _currentIndex = 0;
                listBox1.Items.Clear();
                foreach (Person per in _persons)
                {
                    listBox1.Items.Add(per.FirstName + ' ' + per.LastName);
                }
            }
        }
    }
}
