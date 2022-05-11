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
        int totalremove = 0;


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
            UpdateNumbers();
            lblStatus.Text = ("Numbers sorted");
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            UpdateHeroes();
            lblStatus.Text = ("Heros sorted");
        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));
            UpdateNumbers();
            lblStatus.Text = ("New numbers list");
        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();
            heroes.Add("Super man");
            heroes.Add("Batman");
            UpdateHeroes();
            lblStatus.Text = ("New heros list");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedIndex < 0)
                lblStatus.Text = "No item selected";
            else
            {
                numbers.RemoveAt((Int32)lstNumbers.SelectedIndex);
                UpdateNumbers();
                lblStatus.Text = ("Number removed");
            }

            
            


        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (lstNumbers.SelectedIndex < 0)
                lblStatus.Text = "No item selected";
            else
                while (numbers.Remove((Int32)lstNumbers.SelectedItem))
                {
                    totalremove = totalremove + 1;
                    lblStatus.Text = ($"Removed a total of{totalremove}");
                }
            totalremove = 0;

            UpdateNumbers();

        }
        private void btnHeroRemove_Click(object sender, EventArgs e)
        {
            if (heroes.Remove(txtRemove.Text))
            {
                UpdateHeroes();
                lblStatus.Text = ("Heroes removed");
            }
            else
                lblStatus.Text = ("Hero not in list");
        }
        private void UpdateNumbers()
        {
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;
        }
        private void UpdateHeroes()
        {
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
        }

        private void btnHeroAdd_Click(object sender, EventArgs e)
        {
            if (heroes.Contains(txtAdd.Text))
                lblStatus.Text = ("Hero already in the list");
            else 
                heroes.Add(txtAdd.Text);
                UpdateHeroes();
                lblStatus.Text = ("Heroes add");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            numbers.Reverse();
            UpdateNumbers();
        }

        private void btnLowerCase_Click(object sender, EventArgs e)
        {
            heroes = heroes.ConvertAll(low => low.ToLowerInvariant());
            UpdateHeroes();
        }

        private void btnUpperCase_Click(object sender, EventArgs e)
        {
            heroes = heroes.ConvertAll(low => low.ToUpperInvariant());
            UpdateHeroes();
        }
    }
}
