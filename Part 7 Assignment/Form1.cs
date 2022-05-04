using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_7_Assignment
{
    public partial class Part7Lists : Form
    {

        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();
        Random generator = new Random();


        public Part7Lists()
        {
            InitializeComponent();
        }

        private void Part7Lists_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = numbers;
            heroes.Add("Super man");
            heroes.Add("Batman");
            lstHeroes.DataSource = heroes;

        }

        private void btnSortNumbers_Click(object sender, EventArgs e)
        {
           
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = ("Numbers sorted");
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = ("Heros sorted");
        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
            lblStatus.Text = ("New numbers list");
            btnRemove.Enabled = true;
        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("Super man");
            heroes.Add("Batman");
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
            lblStatus.Text = ("New heros list");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedIndex < 0)
            {
                lblStatus.Text = "No item selected";
            }
            else
            {
                numbers.RemoveAt((Int32)lstNumbers.SelectedIndex);
                lstNumbers.DataSource = null;
                lstNumbers.DataSource = numbers;
                lblStatus.Text = ("Number removed");
            }

            
            


        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            while (numbers.Remove(Int32) = true)
        }
    }
}
