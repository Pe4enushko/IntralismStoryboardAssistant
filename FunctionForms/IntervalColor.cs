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
    public partial class IntervalColor : Form
    {
        public IntervalColor()
        {
            InitializeComponent();
            ChosenColor = new Color[0];
            Stacked = false;
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(Chb_Stack,"All your objects are changing color at the same time or one after another");
        }
        public Color[] ChosenColor;
        public string ObjEv;
        public bool Stacked;
        private void GradientColor_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Choose1_Click(object sender, EventArgs e)
        {
            Bitmap map = new Bitmap(Pb_Demo.Width, Pb_Demo.Height);
            Graphics graph = Graphics.FromImage(map);
            for (int g = 0; g < UpDn_ColCount.Value; g++)
            {
                ColorDialog CD = new ColorDialog();
                if (CD.ShowDialog() == DialogResult.OK)
                {

                    Array.Resize<Color>(ref ChosenColor, ChosenColor.Length + 1);
                    ChosenColor[g] = CD.Color;
                    graph.Clear(ChosenColor[g]);
                    Pb_Demo.Image = map;
                }
            }

                switch (Cmb_TypeList.SelectedIndex)
                {
                    case 0:
                        {
                            ObjEv = "SetSunColors";
                            break;
                        }
                    case 1:
                        {
                            ObjEv = "SetSatelliteColor";
                            break;
                        }
                    case 2:
                        {
                            ObjEv = "SetParticlesColor";
                            break;
                        }
                    default:
                        {
                            ObjEv = "SetSunColors";
                            break;
                        }
                }
            }
        

        private void Btn_CyclOK_Click(object sender, EventArgs e)
        {

        }

        private void UpDn_CycCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_Stack_CheckedChanged(object sender, EventArgs e)
        {
            Stacked = Chb_Stack.Checked;
        }
    }
}
