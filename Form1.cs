using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheeseBurger cheeseBurger = new CheeseBurger();
            /* MessageBox.Show(cheeseBurger.getbun("Rey", "Wheat"));
             MessageBox.Show(cheeseBurger.getPatty());
             MessageBox.Show(cheeseBurger.getCheese());*/

            VeggieBurger vegg = new VeggieBurger();
            MessageBox.Show(vegg.getPatty());
           // MessageBox.Show()


            
            
        }
    }
}
