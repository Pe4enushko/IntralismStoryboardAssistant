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
                result += $"{{\"time\":{time + 0.0001},\"data\":[\"SetSatelliteSensitivity\",\"{cube.Txt_ObjName.Text},0\"]}},";
                result += $"{{\"time\":{time + 0.0001},\"data\":[\"SetSatelliteRadius\",\"{cube.Txt_ObjName.Text},0\"]}},";
                result += $"{{\"time\":{time + 0.0001},\"data\":[\"SetSatelliteRotationSpeed\",\"{cube.Txt_ObjName.Text},0\"]}},";
                result += $"{{\"time\":{time + 0.0001},\"data\":[\"SetSatelliteTrailWidth\",\"{cube.Txt_ObjName.Text},0\"]}},";
                // spawning suns
                for (int i = (int)cube.UpDn_FirstNum.Value; i < 12 + cube.UpDn_FirstNum.Value; i++)
                {
                    result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"0,{SunName + i}\"]}},";
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetParent\",\"{SunName + i},{cube.Txt_ObjName.Text}\"]}},";
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMaxSize\",\"{SunName + i},{SideL},{cube.UpDn_SideWidth.Value},{cube.UpDn_SideWidth.Value}\"]}},";
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMinSize\",\"{SunName + i},{SideL},{cube.UpDn_SideWidth.Value},{cube.UpDn_SideWidth.Value}\"]}},";
                }                                                                                             
                                                                                                              
                // building a cube                                                                       
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 0},{SidePos},{SidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 1},{SidePos},{-SidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 2},{SidePos},0,{SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 3},{SidePos},0,{-SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 4},{-SidePos},{SidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 5},{-SidePos},{-SidePos},0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 6},{-SidePos},0,{SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 7},{-SidePos},0,{-SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 8},0,{SidePos},{SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 9},0,{SidePos},{-SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 1},0,{-SidePos},{SidePos}\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetPosition\",\"{SunName}{cube.UpDn_FirstNum.Value + 1},0,{-SidePos},{-SidePos}\"]}},";
                // rotating parts                                                                                    
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName}{cube.UpDn_FirstNum.Value + 0},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName}{cube.UpDn_FirstNum.Value + 1},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName}{cube.UpDn_FirstNum.Value + 2},0,0,90\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName}{cube.UpDn_FirstNum.Value + 3},0,0,90\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName}{cube.UpDn_FirstNum.Value + 4},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName}{cube.UpDn_FirstNum.Value + 5},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName}{cube.UpDn_FirstNum.Value + 6},0,0,90\"]}},";
                result += $"{{\"time\":{time + 0.003},\"data\":[\"SetRotation\",\"{SunName}{cube.UpDn_FirstNum.Value + 7},0,0,90\"]}},";
                // done
                Txt_Result.Text += result;
            }
        }

        private void Btn_Pyramid_Click(object sender, EventArgs e)
        {
            PyramidForm pyramidForm = new PyramidForm();
            if (pyramidForm.ShowDialog() == DialogResult.OK)
            {
                string result = Txt_Result.Text;
                Pyramid pyramid = new Pyramid();
                pyramid.Length = (double)pyramidForm.UpDn_Length.Value;
                pyramid.Width = (double)pyramidForm.UpDn_Width.Value;
                pyramid.Height = (double)pyramidForm.UpDn_Height.Value;
                double time = (double)pyramidForm.UpDn_TimeStart.Value;
                string name = pyramidForm.Txt_ObjName.Text;
                string sunName = name + "S";
                //spawning satellite
                result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"1,{name}\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteSensitivity\",\"{name},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRadius\",\"{name},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRotationSpeed\",\"{name},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteTrailWidth\",\"{name},0\"]}},";
                // spawning suns
                for (int i = (int)pyramidForm.UpDn_FirstNum.Value; i < 4 + pyramidForm.UpDn_FirstNum.Value; i++)
                {
                    result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"0,{sunName + i}\"]}},";
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetParent\",\"{sunName + i},{name}\"]}},";
                }
                result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMaxSize\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 0},{pyramid.Width},0.5,0.5\"]}},";
                result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMaxSize\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 1},{pyramid.Width},0.5,0.5\"]}},";
                result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMaxSize\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 2},{pyramid.Length},0.5,0.5\"]}},";
                result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMaxSize\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 3},{pyramid.Length},0.5,0.5\"]}},";
                result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMinSize\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 0},{pyramid.Width},0.5,0.5\"]}},";
                result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMinSize\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 1},{pyramid.Width},0.5,0.5\"]}},";
                result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMinSize\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 2},{pyramid.Length},0.5,0.5\"]}},";
                result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMinSize\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 3},{pyramid.Length},0.5,0.5\"]}},";
                for (int i = 4 + (int)pyramidForm.UpDn_FirstNum.Value; i < 8 + pyramidForm.UpDn_FirstNum.Value; i++)
                {
                    result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"0,{sunName + (pyramidForm.UpDn_FirstNum.Value + i)}\"]}},";
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetParent\",\"{sunName + (pyramidForm.UpDn_FirstNum.Value + i)},{name}\"]}},";
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMaxSize\",\"{sunName + (pyramidForm.UpDn_FirstNum.Value + i)},{pyramid.GetSideLength()},0.5,0.5\"]}},";
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetSunMinSize\",\"{sunName + (pyramidForm.UpDn_FirstNum.Value + i)},{pyramid.GetSideLength()},0.5,0.5\"]}},";
                }
                // building pyramid
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetPosition\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 0},0,-{pyramid.GetCenterY()},-{pyramid.Length / 2}\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetPosition\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 1},0,-{pyramid.GetCenterY()},{pyramid.Length / 2}\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetPosition\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 2},{pyramid.Width / 2},-{pyramid.GetCenterY()},0\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetPosition\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 3},-{pyramid.Width / 2},-{pyramid.GetCenterY()},0\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetPosition\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 4},{pyramid.GetSidePosX()},0,{pyramid.Length / 2}\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetPosition\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 5},{pyramid.GetSidePosX()},0,-{pyramid.Length / 2}\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetPosition\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 6},-{pyramid.GetSidePosX()},0,{pyramid.Length / 2}\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetPosition\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 7},-{pyramid.GetSidePosX()},0,-{pyramid.Length / 2}\"]}},";
                // rotating parts
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetRotation\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 2},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetRotation\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 3},0,90,0\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetRotation\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 4},0,-{pyramid.GetDegreesY()},-{pyramid.GetDegreesZ()}\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetRotation\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 5},0,{pyramid.GetDegreesY()},-{pyramid.GetDegreesZ()}\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetRotation\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 6},0,{pyramid.GetDegreesY()},{pyramid.GetDegreesZ()}\"]}},";
                result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetRotation\",\"{sunName}{pyramidForm.UpDn_FirstNum.Value + 7},0,-{pyramid.GetDegreesY()},{pyramid.GetDegreesZ()}\"]}},";
                // done
                Txt_Result.Text += result;
            }
        }
    }
}
