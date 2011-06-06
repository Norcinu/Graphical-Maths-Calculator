using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphical_Math_Calculator
{
    public partial class Form1 : Form
    {
        //private int valueOne = 0;
      //  private int valueTwo = 0;
        private MathType valueOne;
        private MathType valueTwo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoOperation_Click( object sender, EventArgs e )
        {
           // valueOne = LoopThroughGroupControls( grpValueTypeOne );
            //valueTwo = LoopThroughGroupControls( grpValueTypeTwo );

            if (valueOne == MathType.NONE || valueTwo == MathType.NONE)
            {
                Console.WriteLine( "Error, please select a value." );
            }
            else
            {
                Console.WriteLine( "1 = " + valueOne);
                Console.WriteLine( "2 = " + valueTwo );
            }
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
    }
}
