using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MEnu : Form
    {
        MenuMaker menu;
        public MEnu()
        {
            InitializeComponent();
            menu = new MenuMaker() { Randomizer = new Random() };
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void makeManu_Click(object sender, EventArgs e)
        {
            MenuPosition1.Text = menu.GetMenuItem();
            MenuPosition2.Text = menu.GetMenuItem();
            MenuPosition3.Text = menu.GetMenuItem();
            MenuPosition4.Text = menu.GetMenuItem();
            MenuPosition5.Text = menu.GetMenuItem();
            MenuPosition6.Text = menu.GetMenuItem();
        }
    }
}
