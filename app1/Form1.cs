using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;


namespace app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            
            scroll scroll1 = new scroll(1, "пиво", 10);
            product product1 = new product(1, "Балтика", scroll1, 0.5, 70, "Балтика продакшн");
            List<product> listproduct = new List<product>();
            listproduct.Add(product1);
            lstproduct.DataSource = listproduct;
            //product1.info();
        }
    }
}
