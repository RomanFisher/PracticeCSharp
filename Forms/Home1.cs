using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Інивідуальне_Завдання.Forms
{
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
            this.Text = "ГОЛОВНА";
            lblTitle.Text = "Цю програму створив студен II курсу\nВідділення програмної інженерії(121)\nГрупи ПІ-192\nРибак Роман";
        }

        private void Home1_Load(object sender, EventArgs e)
        {

        }
    }
}
