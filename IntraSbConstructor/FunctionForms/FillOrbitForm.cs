using System;
using System.Windows.Forms;

namespace IntraSbConstructor
{
    public partial class FillOrbitForm : Form
    {
        public FillOrbitForm()
        {
            InitializeComponent();
            SunNameTip.SetToolTip(Txt_SunName,"If you write here \"Sun\", suns will be called like \"Sun0\", \"Sun1\", \"Sun2\"...");
            UpDn_Emission.Increment = 0.5M;
        }

        private void SunNameTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FillOrbitForm_Load(object sender, EventArgs e)
        {

        }

        private void UpDn_Emission_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Chb_Stack_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
