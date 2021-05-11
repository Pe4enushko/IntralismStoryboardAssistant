using System;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntraSbConstructor
{
    public partial class MainStoryboardForm : Form
    {
        public MainStoryboardForm()
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en");
            ToolTip tp1 = new ToolTip();
            tp1.SetToolTip(Btn_Reset, "U just found an Undertale reeeeeeffffeeeeerrrrenceeeee");
        }

        private void Btn_FillOrbit_Click(object sender, EventArgs e)
        {
            FillOrbitForm FOF = new FillOrbitForm();
            if (FOF.ShowDialog() == DialogResult.Yes)
            {
                string result = Txt_Result.Text;
                string sunName = FOF.Txt_SunName.Text;
                double sunCount, speed, firstNum, time, degrees, radius,emission;
                sunCount = Convert.ToDouble(FOF.UpDn_SunsCount.Value);
                speed = (double)FOF.UpDn_CirclingSpeed.Value;
                emission = (double)FOF.UpDn_Emission.Value;
                firstNum = (int)FOF.UpDn_FirstNum.Value;
                time = Convert.ToDouble(FOF.UpDn_Time.Value);
                double timeChanger = 0.001;
                degrees = (360 / sunCount) * (Math.PI / 180);
                radius = Convert.ToDouble(FOF.UpDn_Radius.Value);
                bool stack = FOF.Chb_Stack.Checked;
                double[] x = new double[(int)sunCount + (int)firstNum];
                double[] y = new double[(int)sunCount + (int)firstNum];
                Console.WriteLine($" {sunCount} , {degrees} , {speed} , {time} , {radius}");
                time += 0.001;
                result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"1,{sunName + "Sat"}\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteSensitivity\",\"{sunName + "Sat"},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteRadius\",\"{sunName + "Sat"},0\"]}},";
                result += $"{{\"time\":{time + 0.001},\"data\":[\"SetSatelliteTrailWidth\",\"{sunName + "Sat"},0\"]}},";
                time += 0.001;
                if (stack)
                {
                    timeChanger = 0;
                }
                for (int i = 0; i < sunCount; i++)
                {
                    x[i] = Math.Round(radius * Math.Cos(degrees * i),3);
                    y[i] = Math.Round(radius * Math.Sin(degrees * i),3);
                }
                for (int i = (int)firstNum, n = 0; i < sunCount + firstNum ; i++)
                {
                    result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"0,{sunName + i}\"]}},";
                    time += timeChanger;
                    result += $"{{\"time\":{time + 0.0001},\"data\":[\"SetParent\",\"{sunName + i},{sunName + "Sat"}\"]}},";
                    time += timeChanger;
                    result += $"{{\"time\":{time + 0.0002},\"data\":[\"SetPosition\",\"{sunName + i},{x[n]},{y[n]},0\"]}},";
                    time += timeChanger;
                    result += $"{{\"time\":{time + 0.0003},\"data\":[\"SetSunEmission\",\"{sunName + i},{emission}\"]}},";
                    n++;
                }
                result += $"{{\"time\":{time},\"data\":[\"SetSatelliteRotationSpeed\",\"{sunName + "Sat"},{speed}\"]}},";
                Txt_Result.Text = result;
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Result.Text = "";
        }

       

        private void GradientColor_Click(object sender, EventArgs e)
        {
            IntervalColor GC = new IntervalColor();
            if (GC.ShowDialog() == DialogResult.OK)
            {
                string name = GC.Txt_ObjName.Text;
                double time1 = (double)GC.UpDn_TimeStart.Value, duration = (double)GC.UpDn_CycleDuration.Value;
                double count = (double)GC.UpDn_ObjCount.Value, laps = (double)GC.UpDn_LapCount.Value;
                double timescale = duration / count / laps;
                double firstNum = (double)GC.UpDn_FirstObjNum.Value;
                string[] HexColor = new string[0];
                Color[] TheColors = GC.ChosenColor;
                int n = 0;

                if (GC.Stacked)
                {
                    timescale = 0;
                }
                for (int c = 0; c < GC.ChosenColor.Length; c++)
                {
                    Array.Resize<string>(ref HexColor, HexColor.Length + 1);
                    HexColor[c] = TheColors[c].R.ToString("X2") + TheColors[c].G.ToString("X2") + TheColors[c].B.ToString("X2");
                    if (GC.ObjEv == "SetSunColors")
                    {
                        HexColor[c] = $"{HexColor[c]},#{HexColor[c]}";
                    }
                }
                for (double u = time1; u <= (duration + time1); u += duration / laps)
                {
                    Console.WriteLine(u);
                    if (n == HexColor.Length)
                    {
                        n = 0;
                    }
                    for (int i = (int)firstNum; i < count + firstNum; i++)
                    {
                        Txt_Result.Text += $"{{\"time\":{u + timescale},\"data\":[\"{GC.ObjEv}\",\"{name + i},#{HexColor[n]}\"]}},";
                        timescale += timescale;
                    }
                    n++;
                    
                }
            }
        }

        private void Btn_AutoGradient_Click(object sender, EventArgs e)
        {
            AutoGradient AG = new AutoGradient();
            if (AG.ShowDialog() == DialogResult.OK)
            {
                string result = Txt_Result.Text;
                double offset = (double)AG.UpDn_TimeStart.Value, duration = (double)AG.UpDn_FullDuration.Value;
                Color[] TwoCols = AG.TwoColors;
                bool check = false;
                
                double RedCoef = (duration / Math.Abs(Math.Max(TwoCols[0].R, TwoCols[1].R) - Math.Min(TwoCols[0].R, TwoCols[1].R))), GreenCoef = (duration / Math.Abs(Math.Max(TwoCols[0].G, TwoCols[1].G) - Math.Min(TwoCols[0].G, TwoCols[1].G))), BlueCoef = (duration / Math.Abs(Math.Max(TwoCols[0].B, TwoCols[1].B) - Math.Min(TwoCols[0].B, TwoCols[1].B)));
                double MainTimeScale = Math.Min(RedCoef,Math.Min(BlueCoef,GreenCoef));
                if (double.IsInfinity(RedCoef)) { RedCoef = 0; }
                if (double.IsInfinity(GreenCoef)) { GreenCoef = 0; }
                if (double.IsInfinity(BlueCoef)) { BlueCoef = 0; }
                int Rsign = 0, Gsign = 0, Bsign = 0;
                double TempRed, TempGreen, TempBlue; // med = mediato (посредник)
                int i = 0;
                string HexCol;
                if (TwoCols[0].R < TwoCols[1].R) { Rsign = 1; } else if (TwoCols[0].R > TwoCols[1].R) { Rsign = -1;}
                if (TwoCols[0].G < TwoCols[1].G) { Gsign = 1; } else if (TwoCols[0].G > TwoCols[1].G) { Gsign = -1;}
                if (TwoCols[0].B < TwoCols[1].B) { Bsign = 1; } else if (TwoCols[0].B > TwoCols[1].B) { Bsign = -1;}
                TempRed = TwoCols[0].R;
                TempGreen = TwoCols[0].G;
                TempBlue = TwoCols[0].B;
                while (check == false)
                {
                    if (offset >= duration + (double)AG.UpDn_TimeStart.Value)
                    {
                        check = true;
                        break;
                    }
                    if (i == AG.UpDn_ObjCount.Value)
                    {
                        if (((TempRed < TwoCols[1].R) && (Rsign == 1)) || (TempRed > TwoCols[1].R) && (Rsign == -1))
                        { TempRed += Rsign; } 
                        if (((TempGreen < TwoCols[1].G) && (Gsign == 1)) || (TempGreen > TwoCols[1].G) && (Gsign == -1))
                        { TempGreen += Gsign; }  
                        if (((TempBlue < TwoCols[1].B) && (Bsign == 1)) || (TempBlue > TwoCols[1].B) && (Bsign == -1))
                        { TempBlue += Bsign; } 
                        i = 0;
                        offset += MainTimeScale;
                        TwoCols[0] = Color.FromArgb((int)(TempRed), (int)(TempGreen),(int)(TempBlue));
                    }
                    HexCol = GetHex(TwoCols[0]);
                    if (AG.ObjEv == "SetSunColors")
                    {
                        HexCol = $"{HexCol} , #{HexCol}";
                    }
                    result += $"{{\"time\":{offset},\"data\":[\"{AG.ObjEv}\",\"{AG.Txt_ObjName.Text + i},#{HexCol}\"]}},";
                    i++;
                    Console.WriteLine($"{TwoCols[0].R} , {TwoCols[0].G} , {TwoCols[0].B} \n"
                    + $"{TwoCols[1].R} , {TwoCols[1].G} , {TwoCols[1].B} \n"
                        + MainTimeScale + "\n" +
                    $"Coefs: R {RedCoef} , G {GreenCoef} , B {BlueCoef} \n" +
                    $"rsign {Rsign} , gsign {Gsign} , bsign {Bsign}");
                }
                Txt_Result.Text = result;
            }
        }
        private string GetHex(Color col)
        {
            return col.R.ToString("X2") + col.G.ToString("X2") + col.B.ToString("X2");
        }

        private void Btn_GmFigures_Click(object sender, EventArgs e)
        {
            GeometryForm GF = new GeometryForm();

            if (GF.ShowDialog() == DialogResult.OK)
            {
                Txt_Result.Text += GF.Txt_Result.Text;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Grid_Click(object sender, EventArgs e)
        {
            GridForm gridForm = new GridForm();
            if (gridForm.ShowDialog() == DialogResult.OK)
            {
                string result = Txt_Result.Text;
                decimal time = gridForm.UpDn_Time.Value;
                string name = gridForm.Txt_Name.Text;
                var countY = gridForm.GetRowsCountY();
                var countX = gridForm.GetRowsCountX();
                decimal positionX = -gridForm.UpDn_GridWidth.Value / 2;
                decimal positionY = -gridForm.UpDn_GridHeight.Value / 2;
                for (decimal h = 0, i = 0; positionY <= gridForm.UpDn_GridHeight.Value / 2; h++) // Moving through all Y rows
                {
                    positionX = -gridForm.UpDn_GridWidth.Value / 2;
                    for (decimal w = 0; positionX <= gridForm.UpDn_GridWidth.Value / 2; w++,i++) // filling X row with suns
                    {
                        result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"{gridForm.ObjType},{name + i}\"]}},";
                        result += $"{{\"time\":{time + 0.0003M},\"data\":[\"SetPosition\",\"{name + i},{positionX},{positionY},1\"]}},";
                        positionX += gridForm.UpDn_XSpace.Value;
                    }
                    positionY += gridForm.UpDn_YSpace.Value;
                }
                if (gridForm.Chb_WeldToSatellite.Checked)
                {
                    result += $"{{\"time\":{time},\"data\":[\"AddEnvironmentObject\",\"1,{gridForm.Txt_SatName.Text}\"]}},";
                    result += $"{{\"time\":{time + 0.0001M},\"data\":[\"SetSatelliteSensitivity\",\"{gridForm.Txt_SatName.Text},0\"]}},";
                    result += $"{{\"time\":{time + 0.0001M},\"data\":[\"SetSatelliteRadius\",\"{gridForm.Txt_SatName.Text},0\"]}},";
                    result += $"{{\"time\":{time + 0.0001M},\"data\":[\"SetSatelliteTrailWidth\",\"{gridForm.Txt_SatName.Text},0\"]}},";
                    for (decimal h = 0, i = 0; h <= countY; h++) 
                    {

                        for (decimal w = 0; w <= countX; w++, i++)
                        {
                            result += $"{{\"time\":{time + 0.0002M},\"data\":[\"SetParent\",\"{name + i},{gridForm.Txt_SatName.Text}\"]}},";
                        }
                            
                    }
                }
                Txt_Result.Text += result;
            }
        }
    }
}
