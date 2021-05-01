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
    public partial class GeometryForm : Form
    {
        public GeometryForm()
        {
            InitializeComponent();
            ToolTip tp1 = new ToolTip();
            tp1.SetToolTip(Btn_Help, "That's something like buffer to contain figures only \n" +
            " so if you mess up with the figures you will not mess up all the text in the Mainform");
        }

        private void Btn_Cube_Click(object sender, EventArgs e)
        {
            CubeForm cube = new CubeForm();
            if (cube.ShowDialog() == DialogResult.OK)
            {
                string result = Txt_Result.Text;
                double SideL, SidePos, time = (double)cube.UpDn_TimeStart.Value;
                SideL = (double)cube.UpDn_SideLength.Value;
                SidePos = SideL / 2;
                string SunName = cube.Txt_ObjName.Text + "S";
                // spawning satellite
                result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"1,{cube.Txt_ObjName.Text}\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteSensitivity\",\"{cube.Txt_ObjName.Text},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRadius\",\"{cube.Txt_ObjName.Text},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRotationSpeed\",\"{cube.Txt_ObjName.Text},0\"]}},";
                // spawning suns
                for (int i = (int)cube.UpDn_FirstNum.Value; i < 12 + cube.UpDn_FirstNum.Value; i++)
                {
                    result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"0,{SunName + i}\"]}},";
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetParent\",\"{SunName + i},{cube.Txt_ObjName.Text}\"]}},";
                    result += $"{{\"time\":{time + 0.002},\"data\":[\"SetSunMaxSize\",\"{SunName + i},{SideL},{cube.UpDn_SideWidth.Value},{cube.UpDn_SideWidth.Value}\"]}},";
                    result += $"{{\"time\":{time + 0.002},\"data\":[\"SetSunMinSize\",\"{SunName + i},{SideL},{cube.UpDn_SideWidth.Value},{cube.UpDn_SideWidth.Value}\"]}},";
                }                                                                                             
                                                                                                              
                // building a cube                                                                       
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "0"},{SidePos},{SidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "1"},{SidePos},{-SidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "2"},{SidePos},0,{SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "3"},{SidePos},0,{-SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "4"},{-SidePos},{SidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "5"},{-SidePos},{-SidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "6"},{-SidePos},0,{SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "7"},{-SidePos},0,{-SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "8"},0,{SidePos},{SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "9"},0,{SidePos},{-SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "10"},0,{-SidePos},{SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName + "11"},0,{-SidePos},{-SidePos}\"]}},";
                // rotating parts                                                   
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName + "0"},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName + "1"},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName + "2"},0,0,90\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName + "3"},0,0,90\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName + "4"},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName + "5"},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName + "6"},0,0,90\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName + "7"},0,0,90\"]}},";
                // done
                Txt_Result.Text += result;
            }
        }
    }
}
