using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntraSbConstructor
{
    public partial class CubeForm : Form
    {
        public CubeForm()
        {
            InitializeComponent();
            ToolTip tp1 = new ToolTip(), tp2 = new ToolTip();
            tp1.SetToolTip(Btn_Help, "It will be name of satellite to which the cube(all the suns) will be attached \n" +
                " all suns will have additional \"S\" in names like \"Sat, SatS0, SatS1 ...\"");
            tp2.SetToolTip(UpDn_TimeStart,"When will we spawn a cube?");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cube_Load(object sender, EventArgs e)
        {

        }
    }
}
