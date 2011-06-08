using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicalMathCalculator
{
    public partial class Form1 : Form
    {
        private string valueOne;
        private string valueTwo;
        private Dictionary<string, int> typeMap = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            
            ComboBox.ObjectCollection c = cmbInputOne.Items;
            int count = 2;
            for (int i = 0; i < c.Count; i++)
            {
                typeMap.Add( c[i].ToString(), count );
                if (count < 4)
                {
                    ++count;
                }
                else
                {
                    count = 2;
                }
            }

            foreach (KeyValuePair<string, int> pair in typeMap)
            {
                Console.WriteLine( pair );
            }
        }

        private void btnDoOperation_Click( object sender, EventArgs e )
        {
        }

        private void cmbInputOne_SelectedIndexChanged( object sender, EventArgs e )
        {
            valueOne = cmbInputOne.SelectedItem.ToString();
            Console.WriteLine( valueOne );
            //Console.WriteLine( "str=" + str );
        }

        private void cmbInputTwo_SelectedIndexChanged( object sender, EventArgs e )
        {
            valueTwo = cmbInputTwo.SelectedItem.ToString();
            Console.WriteLine( valueTwo );
            //Console.WriteLine( "str=" + str );
        }
    }
}
