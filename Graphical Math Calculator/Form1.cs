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

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoOperation_Click( object sender, EventArgs e )
        {
            Vector2 v1 = new Vector2( 1, 1 );
            Vector2 v2 = new Vector2( 2, 2 );
            Vector2 v3 = new Vector2();
            
            v3 = v1.Add( v2 );
            
            Console.WriteLine( v3.x );
            Console.WriteLine( v3.y );
        }

        private MathType LoopThroughGroupControls(GroupBox gbx)
        {
            for (int i = 0; i < gbx.Controls.Count; i++)
            {
                RadioButton rb = (RadioButton)grpValueTypeOne.Controls[i];
                if (rb.Checked==true)
                {
                    MathType type = (MathType)i;
                    return type;
                }
            }
            return MathType.NONE;
        }

        private void cmbInputOne_SelectedIndexChanged( object sender, EventArgs e )
        {
            valueOne = cmbInputOne.SelectedItem.ToString();
            //Console.WriteLine( "str=" + str );
        }

        private void cmbInputTwo_SelectedIndexChanged( object sender, EventArgs e )
        {
            valueTwo = cmbInputTwo.SelectedItem.ToString();
            //Console.WriteLine( "str=" + str );
        }
    }
}
