using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instructor
{
    /// <summary>
    /// The Main Form Class.
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// The Constructor.
        /// </summary>
        public Main()
        {
            //Initialize the forms components.
            InitializeComponent();
            SetupComponents();
        }

        /// <summary>
        /// Setup any other components.
        /// </summary>
        public void SetupComponents()
        {
            char symbol = '\u00F7';
            string divide = "" + symbol;
            //Add the menu items to the operator context menu.
            Input_Operator.Items.AddRange(new object[] { "+", "-", "x", divide});
        }
    }
}
