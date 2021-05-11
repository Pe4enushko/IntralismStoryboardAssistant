using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntraSbConstructor
{
    public partial class AutoGradient : Form
    {
        public AutoGradient()
        {
            InitializeComponent();
            ToolTip tp1 = new ToolTip();
        }
        public Color[] TwoColors = new Color[2];
        public string ObjEv;
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Choose1_Click(object sender, EventArgs e)
        {
            Bitmap map1 = new Bitmap(Pb_Demo1.Width,Pb_Demo1.Height);
            Bitmap map2 = new Bitmap(Pb_Demo2.Width, Pb_Demo2.Height);
            Graphics graph1 = Graphics.FromImage(map1);
            Graphics graph2 = Graphics.FromImage(map2);
            ColorDialog CD = new ColorDialog();
            for (int i = 0; i < 2; i++)
            {
                if (CD.ShowDialog() == DialogResult.OK)
                {
                    TwoColors[i] = CD.Color;
                }
            }
            graph1.Clear(TwoColors[0]);
            Pb_Demo1.Image = map1;
            graph2.Clear(TwoColors[1]);
            Pb_Demo2.Image = map2;
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
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

        private void Cmb_TypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AutoGradient_Load(object sender, EventArgs e)
        {

        }
    }
}
