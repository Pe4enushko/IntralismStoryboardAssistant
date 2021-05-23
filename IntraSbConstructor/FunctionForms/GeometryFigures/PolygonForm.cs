using System;
using System.Windows.Forms;

namespace IntraSbConstructor
{
    public partial class PolygonForm : Form
    {
        public PolygonForm()
        {
            InitializeComponent();
            ToolTip tp1 = new ToolTip();
            ToolTip tp2 = new ToolTip();
            tp1.SetToolTip(Lb_Size, "Size of polygon's diagonal");
            tp2.SetToolTip(UpDn_Size, "Size of polygon's diagonal");
        }

        public Polygon CreatePolygon()
        {
            return new Polygon((double)UpDn_Size.Value,(double)UpDn_Height.Value,(int)UpDn_AnglesCount.Value);
        }
    }
}
