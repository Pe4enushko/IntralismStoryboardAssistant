
namespace IntraSbConstructor
{
    partial class GridForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.UpDn_GridHeight = new System.Windows.Forms.NumericUpDown();
            this.UpDn_GridWidth = new System.Windows.Forms.NumericUpDown();
            this.UpDn_XSpace = new System.Windows.Forms.NumericUpDown();
            this.UpDn_Time = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UpDn_YSpace = new System.Windows.Forms.NumericUpDown();
            this.Chb_WeldToSatellite = new System.Windows.Forms.CheckBox();
            this.Cmb_Type = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_SatName = new System.Windows.Forms.TextBox();
            this.Lb_SatName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_GridHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_GridWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_XSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_YSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.White;
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(47)))), ((int)(((byte)(32)))));
            this.Btn_Cancel.Location = new System.Drawing.Point(241, 96);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(81, 29);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // Btn_Enter
            // 
            this.Btn_Enter.BackColor = System.Drawing.Color.White;
            this.Btn_Enter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Enter.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Enter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(47)))), ((int)(((byte)(32)))));
            this.Btn_Enter.Location = new System.Drawing.Point(241, 54);
            this.Btn_Enter.Name = "Btn_Enter";
            this.Btn_Enter.Size = new System.Drawing.Size(81, 29);
            this.Btn_Enter.TabIndex = 9;
            this.Btn_Enter.Text = "Enter";
            this.Btn_Enter.UseVisualStyleBackColor = false;
            this.Btn_Enter.Click += new System.EventHandler(this.Btn_Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "Suns name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Area height";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Area width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(159, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "Space between suns";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(15, 29);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(88, 20);
            this.Txt_Name.TabIndex = 63;
            // 
            // UpDn_GridHeight
            // 
            this.UpDn_GridHeight.Location = new System.Drawing.Point(15, 139);
            this.UpDn_GridHeight.Name = "UpDn_GridHeight";
            this.UpDn_GridHeight.Size = new System.Drawing.Size(88, 20);
            this.UpDn_GridHeight.TabIndex = 64;
            this.UpDn_GridHeight.ValueChanged += new System.EventHandler(this.UpDn_GridHeight_ValueChanged);
            // 
            // UpDn_GridWidth
            // 
            this.UpDn_GridWidth.Location = new System.Drawing.Point(15, 189);
            this.UpDn_GridWidth.Name = "UpDn_GridWidth";
            this.UpDn_GridWidth.Size = new System.Drawing.Size(88, 20);
            this.UpDn_GridWidth.TabIndex = 65;
            // 
            // UpDn_XSpace
            // 
            this.UpDn_XSpace.DecimalPlaces = 2;
            this.UpDn_XSpace.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.UpDn_XSpace.Location = new System.Drawing.Point(120, 189);
            this.UpDn_XSpace.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDn_XSpace.Name = "UpDn_XSpace";
            this.UpDn_XSpace.Size = new System.Drawing.Size(88, 20);
            this.UpDn_XSpace.TabIndex = 66;
            this.UpDn_XSpace.ValueChanged += new System.EventHandler(this.UpDn_GridDensity_ValueChanged);
            // 
            // UpDn_Time
            // 
            this.UpDn_Time.Location = new System.Drawing.Point(120, 30);
            this.UpDn_Time.Name = "UpDn_Time";
            this.UpDn_Time.Size = new System.Drawing.Size(96, 20);
            this.UpDn_Time.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(146, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 69;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(117, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 71;
            this.label7.Text = "Horizontal (X)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(231, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 18);
            this.label8.TabIndex = 73;
            this.label8.Text = "Vertical (Y)";
            // 
            // UpDn_YSpace
            // 
            this.UpDn_YSpace.DecimalPlaces = 2;
            this.UpDn_YSpace.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.UpDn_YSpace.Location = new System.Drawing.Point(234, 189);
            this.UpDn_YSpace.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.UpDn_YSpace.Name = "UpDn_YSpace";
            this.UpDn_YSpace.Size = new System.Drawing.Size(88, 20);
            this.UpDn_YSpace.TabIndex = 72;
            // 
            // Chb_WeldToSatellite
            // 
            this.Chb_WeldToSatellite.AutoSize = true;
            this.Chb_WeldToSatellite.Location = new System.Drawing.Point(123, 70);
            this.Chb_WeldToSatellite.Name = "Chb_WeldToSatellite";
            this.Chb_WeldToSatellite.Size = new System.Drawing.Size(102, 17);
            this.Chb_WeldToSatellite.TabIndex = 74;
            this.Chb_WeldToSatellite.Text = "Weld to sattelite";
            this.Chb_WeldToSatellite.UseVisualStyleBackColor = true;
            this.Chb_WeldToSatellite.CheckedChanged += new System.EventHandler(this.Chb_WeldToSatellite_CheckedChanged);
            // 
            // Cmb_Type
            // 
            this.Cmb_Type.FormattingEnabled = true;
            this.Cmb_Type.Items.AddRange(new object[] {
            "Sun",
            "Satellite",
            "Particles"});
            this.Cmb_Type.Location = new System.Drawing.Point(15, 86);
            this.Cmb_Type.Name = "Cmb_Type";
            this.Cmb_Type.Size = new System.Drawing.Size(88, 21);
            this.Cmb_Type.TabIndex = 75;
            this.Cmb_Type.SelectedIndexChanged += new System.EventHandler(this.Cmb_Type_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 76;
            this.label9.Text = "Objects type";
            // 
            // Txt_SatName
            // 
            this.Txt_SatName.Enabled = false;
            this.Txt_SatName.Location = new System.Drawing.Point(123, 118);
            this.Txt_SatName.Name = "Txt_SatName";
            this.Txt_SatName.Size = new System.Drawing.Size(88, 20);
            this.Txt_SatName.TabIndex = 78;
            this.Txt_SatName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Lb_SatName
            // 
            this.Lb_SatName.AutoSize = true;
            this.Lb_SatName.Enabled = false;
            this.Lb_SatName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lb_SatName.ForeColor = System.Drawing.Color.Black;
            this.Lb_SatName.Location = new System.Drawing.Point(120, 92);
            this.Lb_SatName.Name = "Lb_SatName";
            this.Lb_SatName.Size = new System.Drawing.Size(94, 18);
            this.Lb_SatName.TabIndex = 77;
            this.Lb_SatName.Text = "Satellite name";
            this.Lb_SatName.Click += new System.EventHandler(this.Label5_Click);
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 229);
            this.Controls.Add(this.Txt_SatName);
            this.Controls.Add(this.Lb_SatName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cmb_Type);
            this.Controls.Add(this.Chb_WeldToSatellite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UpDn_YSpace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpDn_Time);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UpDn_XSpace);
            this.Controls.Add(this.UpDn_GridWidth);
            this.Controls.Add(this.UpDn_GridHeight);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Enter);
            this.Controls.Add(this.Btn_Cancel);
            this.Name = "GridForm";
            this.Text = "GridForm";
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_GridHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_GridWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_XSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDn_YSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown UpDn_GridHeight;
        public System.Windows.Forms.NumericUpDown UpDn_GridWidth;
        public System.Windows.Forms.NumericUpDown UpDn_XSpace;
        public System.Windows.Forms.NumericUpDown UpDn_Time;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown UpDn_YSpace;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox Cmb_Type;
        public System.Windows.Forms.CheckBox Chb_WeldToSatellite;
        public System.Windows.Forms.TextBox Txt_SatName;
        private System.Windows.Forms.Label Lb_SatName;
    }
}