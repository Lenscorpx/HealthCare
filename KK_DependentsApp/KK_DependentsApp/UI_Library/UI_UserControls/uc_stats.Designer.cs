namespace KK_DependentsApp.UI_Library.UI_UserControls
{
    partial class uc_stats
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_stats));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_titre2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_nombre_agents = new System.Windows.Forms.Label();
            this.lbl_nombre_enfant = new System.Windows.Forms.Label();
            this.lbl_conjoints = new System.Windows.Forms.Label();
            this.lbl_dependants = new System.Windows.Forms.Label();
            this.lbl_dep_feminins = new System.Windows.Forms.Label();
            this.lbl_dep_masculins = new System.Windows.Forms.Label();
            this.gauge_enfant = new Bunifu.Framework.UI.BunifuGauge();
            this.gauge_conjoint = new Bunifu.Framework.UI.BunifuGauge();
            this.gauge_dep_fem = new Bunifu.Framework.UI.BunifuGauge();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_familles = new System.Windows.Forms.Label();
            this.gauge_dep_masc = new Bunifu.Framework.UI.BunifuGauge();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.gauge_sans_dependant = new Bunifu.Framework.UI.BunifuGauge();
            this.lbl_sans_dependant = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titre2
            // 
            this.lbl_titre2.AutoSize = true;
            this.lbl_titre2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titre2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre2.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_titre2.Location = new System.Drawing.Point(32, 17);
            this.lbl_titre2.Name = "lbl_titre2";
            this.lbl_titre2.Size = new System.Drawing.Size(162, 19);
            this.lbl_titre2.TabIndex = 7;
            this.lbl_titre2.Text = "Nombre d\'agents :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(328, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de dependants :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(549, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dependants masculins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(352, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dependants feminins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(222, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Conjoints";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(58, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enfants";
            // 
            // lbl_nombre_agents
            // 
            this.lbl_nombre_agents.AutoSize = true;
            this.lbl_nombre_agents.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombre_agents.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_agents.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_nombre_agents.Location = new System.Drawing.Point(194, 17);
            this.lbl_nombre_agents.Name = "lbl_nombre_agents";
            this.lbl_nombre_agents.Size = new System.Drawing.Size(20, 22);
            this.lbl_nombre_agents.TabIndex = 13;
            this.lbl_nombre_agents.Text = "0";
            // 
            // lbl_nombre_enfant
            // 
            this.lbl_nombre_enfant.AutoSize = true;
            this.lbl_nombre_enfant.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_enfant.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombre_enfant.Location = new System.Drawing.Point(81, 87);
            this.lbl_nombre_enfant.Name = "lbl_nombre_enfant";
            this.lbl_nombre_enfant.Size = new System.Drawing.Size(20, 22);
            this.lbl_nombre_enfant.TabIndex = 14;
            this.lbl_nombre_enfant.Text = "0";
            // 
            // lbl_conjoints
            // 
            this.lbl_conjoints.AutoSize = true;
            this.lbl_conjoints.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conjoints.ForeColor = System.Drawing.Color.Black;
            this.lbl_conjoints.Location = new System.Drawing.Point(254, 90);
            this.lbl_conjoints.Name = "lbl_conjoints";
            this.lbl_conjoints.Size = new System.Drawing.Size(20, 22);
            this.lbl_conjoints.TabIndex = 15;
            this.lbl_conjoints.Text = "0";
            // 
            // lbl_dependants
            // 
            this.lbl_dependants.AutoSize = true;
            this.lbl_dependants.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dependants.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dependants.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_dependants.Location = new System.Drawing.Point(542, 17);
            this.lbl_dependants.Name = "lbl_dependants";
            this.lbl_dependants.Size = new System.Drawing.Size(20, 22);
            this.lbl_dependants.TabIndex = 16;
            this.lbl_dependants.Text = "0";
            // 
            // lbl_dep_feminins
            // 
            this.lbl_dep_feminins.AutoSize = true;
            this.lbl_dep_feminins.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dep_feminins.ForeColor = System.Drawing.Color.Black;
            this.lbl_dep_feminins.Location = new System.Drawing.Point(440, 89);
            this.lbl_dep_feminins.Name = "lbl_dep_feminins";
            this.lbl_dep_feminins.Size = new System.Drawing.Size(20, 22);
            this.lbl_dep_feminins.TabIndex = 17;
            this.lbl_dep_feminins.Text = "0";
            // 
            // lbl_dep_masculins
            // 
            this.lbl_dep_masculins.AutoSize = true;
            this.lbl_dep_masculins.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dep_masculins.ForeColor = System.Drawing.Color.Black;
            this.lbl_dep_masculins.Location = new System.Drawing.Point(640, 90);
            this.lbl_dep_masculins.Name = "lbl_dep_masculins";
            this.lbl_dep_masculins.Size = new System.Drawing.Size(20, 22);
            this.lbl_dep_masculins.TabIndex = 18;
            this.lbl_dep_masculins.Text = "0";
            // 
            // gauge_enfant
            // 
            this.gauge_enfant.BackColor = System.Drawing.Color.Transparent;
            this.gauge_enfant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gauge_enfant.BackgroundImage")));
            this.gauge_enfant.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_enfant.ForeColor = System.Drawing.Color.Crimson;
            this.gauge_enfant.Location = new System.Drawing.Point(5, 115);
            this.gauge_enfant.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gauge_enfant.Name = "gauge_enfant";
            this.gauge_enfant.ProgressBgColor = System.Drawing.Color.White;
            this.gauge_enfant.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(20)))));
            this.gauge_enfant.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(20)))));
            this.gauge_enfant.Size = new System.Drawing.Size(163, 118);
            this.gauge_enfant.TabIndex = 43;
            this.gauge_enfant.Thickness = 30;
            this.gauge_enfant.Value = 0;
            // 
            // gauge_conjoint
            // 
            this.gauge_conjoint.BackColor = System.Drawing.Color.Transparent;
            this.gauge_conjoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gauge_conjoint.BackgroundImage")));
            this.gauge_conjoint.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_conjoint.ForeColor = System.Drawing.Color.Crimson;
            this.gauge_conjoint.Location = new System.Drawing.Point(177, 119);
            this.gauge_conjoint.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gauge_conjoint.Name = "gauge_conjoint";
            this.gauge_conjoint.ProgressBgColor = System.Drawing.Color.White;
            this.gauge_conjoint.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(20)))));
            this.gauge_conjoint.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(20)))));
            this.gauge_conjoint.Size = new System.Drawing.Size(163, 118);
            this.gauge_conjoint.TabIndex = 44;
            this.gauge_conjoint.Thickness = 30;
            this.gauge_conjoint.Value = 0;
            // 
            // gauge_dep_fem
            // 
            this.gauge_dep_fem.BackColor = System.Drawing.Color.Transparent;
            this.gauge_dep_fem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gauge_dep_fem.BackgroundImage")));
            this.gauge_dep_fem.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_dep_fem.ForeColor = System.Drawing.Color.Crimson;
            this.gauge_dep_fem.Location = new System.Drawing.Point(362, 118);
            this.gauge_dep_fem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gauge_dep_fem.Name = "gauge_dep_fem";
            this.gauge_dep_fem.ProgressBgColor = System.Drawing.Color.White;
            this.gauge_dep_fem.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(20)))));
            this.gauge_dep_fem.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(20)))));
            this.gauge_dep_fem.Size = new System.Drawing.Size(163, 118);
            this.gauge_dep_fem.TabIndex = 45;
            this.gauge_dep_fem.Thickness = 30;
            this.gauge_dep_fem.Value = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_familles);
            this.panel1.Controls.Add(this.lbl_titre2);
            this.panel1.Controls.Add(this.lbl_nombre_agents);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_dependants);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 61);
            this.panel1.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(660, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre de familles :";
            // 
            // lbl_familles
            // 
            this.lbl_familles.AutoSize = true;
            this.lbl_familles.BackColor = System.Drawing.Color.Transparent;
            this.lbl_familles.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_familles.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_familles.Location = new System.Drawing.Point(855, 17);
            this.lbl_familles.Name = "lbl_familles";
            this.lbl_familles.Size = new System.Drawing.Size(20, 22);
            this.lbl_familles.TabIndex = 18;
            this.lbl_familles.Text = "0";
            // 
            // gauge_dep_masc
            // 
            this.gauge_dep_masc.BackColor = System.Drawing.Color.Transparent;
            this.gauge_dep_masc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gauge_dep_masc.BackgroundImage")));
            this.gauge_dep_masc.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_dep_masc.ForeColor = System.Drawing.Color.Crimson;
            this.gauge_dep_masc.Location = new System.Drawing.Point(572, 118);
            this.gauge_dep_masc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gauge_dep_masc.Name = "gauge_dep_masc";
            this.gauge_dep_masc.ProgressBgColor = System.Drawing.Color.White;
            this.gauge_dep_masc.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(20)))));
            this.gauge_dep_masc.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(20)))));
            this.gauge_dep_masc.Size = new System.Drawing.Size(163, 118);
            this.gauge_dep_masc.TabIndex = 47;
            this.gauge_dep_masc.Thickness = 30;
            this.gauge_dep_masc.Value = 0;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            chartArea1.Area3DStyle.Inclination = 5;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            chartArea1.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Crimson;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            legend1.TitleFont = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 262);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))))};
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Dependants par agent";
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(947, 244);
            this.chart1.TabIndex = 48;
            this.chart1.Text = "Total d\'agents avec dependants";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::KK_DependentsApp.Properties.Resources.data_backup_512;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(379, 512);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(98, 55);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 49;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // gauge_sans_dependant
            // 
            this.gauge_sans_dependant.BackColor = System.Drawing.Color.Transparent;
            this.gauge_sans_dependant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gauge_sans_dependant.BackgroundImage")));
            this.gauge_sans_dependant.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gauge_sans_dependant.ForeColor = System.Drawing.Color.Crimson;
            this.gauge_sans_dependant.Location = new System.Drawing.Point(772, 118);
            this.gauge_sans_dependant.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gauge_sans_dependant.Name = "gauge_sans_dependant";
            this.gauge_sans_dependant.ProgressBgColor = System.Drawing.Color.White;
            this.gauge_sans_dependant.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(20)))));
            this.gauge_sans_dependant.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(24)))), ((int)(((byte)(20)))));
            this.gauge_sans_dependant.Size = new System.Drawing.Size(163, 118);
            this.gauge_sans_dependant.TabIndex = 52;
            this.gauge_sans_dependant.Thickness = 30;
            this.gauge_sans_dependant.Value = 0;
            // 
            // lbl_sans_dependant
            // 
            this.lbl_sans_dependant.AutoSize = true;
            this.lbl_sans_dependant.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sans_dependant.ForeColor = System.Drawing.Color.Black;
            this.lbl_sans_dependant.Location = new System.Drawing.Point(840, 90);
            this.lbl_sans_dependant.Name = "lbl_sans_dependant";
            this.lbl_sans_dependant.Size = new System.Drawing.Size(20, 22);
            this.lbl_sans_dependant.TabIndex = 51;
            this.lbl_sans_dependant.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(782, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Sans dépendants";
            // 
            // uc_stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(201)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.gauge_sans_dependant);
            this.Controls.Add(this.lbl_sans_dependant);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.gauge_dep_masc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gauge_dep_fem);
            this.Controls.Add(this.gauge_conjoint);
            this.Controls.Add(this.gauge_enfant);
            this.Controls.Add(this.lbl_dep_masculins);
            this.Controls.Add(this.lbl_dep_feminins);
            this.Controls.Add(this.lbl_conjoints);
            this.Controls.Add(this.lbl_nombre_enfant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "uc_stats";
            this.Size = new System.Drawing.Size(953, 568);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titre2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_nombre_agents;
        private System.Windows.Forms.Label lbl_nombre_enfant;
        private System.Windows.Forms.Label lbl_conjoints;
        private System.Windows.Forms.Label lbl_dependants;
        private System.Windows.Forms.Label lbl_dep_feminins;
        private System.Windows.Forms.Label lbl_dep_masculins;
        private Bunifu.Framework.UI.BunifuGauge gauge_enfant;
        private Bunifu.Framework.UI.BunifuGauge gauge_conjoint;
        private Bunifu.Framework.UI.BunifuGauge gauge_dep_fem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_familles;
        private Bunifu.Framework.UI.BunifuGauge gauge_dep_masc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuGauge gauge_sans_dependant;
        private System.Windows.Forms.Label lbl_sans_dependant;
        private System.Windows.Forms.Label label8;
    }
}
