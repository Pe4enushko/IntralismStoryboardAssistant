using System;
using System.Windows.Forms;

namespace IntraSbConstructor
{
    public partial class GridForm : Form
    {
        public string ObjType;
        public double Area
        { 
            get
            {
                return Area;
            }
            set
            {
                if(value > 0)
                {
                    Area = value;
                }
            }
        }
        public GridForm()
        {
            InitializeComponent();
        }

        private void Btn_Enter_Click(object sender, EventArgs e)
        {
        }
        public void SetArea() 
        {
            Area = (double)(UpDn_GridWidth.Value * UpDn_GridHeight.Value);
        }

        private void UpDn_GridDensity_ValueChanged(object sender, EventArgs e)
        {

        }
        public decimal GetRowsCountX() => Math.Round(UpDn_GridWidth.Value / UpDn_XSpace.Value);
        public decimal GetRowsCountY() => Math.Round(UpDn_GridHeight.Value / UpDn_YSpace.Value);

        private void UpDn_GridHeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjType = Cmb_Type.SelectedIndex.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Chb_WeldToSatellite_CheckedChanged(object sender, EventArgs e)
        {
            Lb_SatName.Enabled = Chb_WeldToSatellite.Checked;
            Txt_SatName.Enabled = Chb_WeldToSatellite.Checked;
        }
    }
}
