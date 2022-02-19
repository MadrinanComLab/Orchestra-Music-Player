namespace OrchestraMusicPlayer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblVolume = new System.Windows.Forms.Label();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMusicStart = new System.Windows.Forms.Label();
            this.lblMusicLength = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.trkVolume = new Siticone.UI.WinForms.SiticoneTrackBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.trkMusic1 = new Siticone.UI.WinForms.SiticoneTrackBar();
            this.dataGridView1 = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnNumThreeHover2 = new System.Windows.Forms.Button();
            this.btnNumThreeHover1 = new System.Windows.Forms.Button();
            this.btnNumThreeHover0 = new System.Windows.Forms.Button();
            this.btnNumTwoHover1 = new System.Windows.Forms.Button();
            this.btnNumTwoHover2 = new System.Windows.Forms.Button();
            this.btnNumTwoHover0 = new System.Windows.Forms.Button();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.btnRecent = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowOption = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.btnDefault2 = new System.Windows.Forms.Button();
            this.btnDefault1 = new System.Windows.Forms.Button();
            this.btnDefault0 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.Orange;
            this.lblVolume.Location = new System.Drawing.Point(812, 633);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(161, 16);
            this.lblVolume.TabIndex = 14;
            this.lblVolume.Text = "Volume";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(12, 506);
            this.axVLCPlugin21.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(63, 63);
            this.axVLCPlugin21.TabIndex = 4;
            this.axVLCPlugin21.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMusicStart
            // 
            this.lblMusicStart.AutoSize = true;
            this.lblMusicStart.BackColor = System.Drawing.Color.Orange;
            this.lblMusicStart.Location = new System.Drawing.Point(16, 594);
            this.lblMusicStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusicStart.Name = "lblMusicStart";
            this.lblMusicStart.Size = new System.Drawing.Size(44, 17);
            this.lblMusicStart.TabIndex = 34;
            this.lblMusicStart.Text = "00:00";
            // 
            // lblMusicLength
            // 
            this.lblMusicLength.AutoSize = true;
            this.lblMusicLength.BackColor = System.Drawing.Color.Orange;
            this.lblMusicLength.Location = new System.Drawing.Point(928, 594);
            this.lblMusicLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMusicLength.Name = "lblMusicLength";
            this.lblMusicLength.Size = new System.Drawing.Size(44, 17);
            this.lblMusicLength.TabIndex = 35;
            this.lblMusicLength.Text = "00:00";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(91, 623);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(455, 61);
            this.lblTitle.TabIndex = 46;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trkVolume
            // 
            this.trkVolume.BackColor = System.Drawing.Color.Orange;
            this.trkVolume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.trkVolume.HoveredState.Parent = this.trkVolume;
            this.trkVolume.IndicateFocus = false;
            this.trkVolume.LargeChange = 0;
            this.trkVolume.Location = new System.Drawing.Point(812, 647);
            this.trkVolume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkVolume.MouseWheelBarPartitions = 50;
            this.trkVolume.Name = "trkVolume";
            this.trkVolume.Size = new System.Drawing.Size(161, 28);
            this.trkVolume.SmallChange = 0;
            this.trkVolume.TabIndex = 48;
            this.trkVolume.ThumbColor = System.Drawing.Color.Green;
            this.trkVolume.Value = 0;
            this.trkVolume.ValueChanged += new System.EventHandler(this.trkVolume_ValueChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // trkMusic1
            // 
            this.trkMusic1.BackColor = System.Drawing.Color.Orange;
            this.trkMusic1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.trkMusic1.HoveredState.Parent = this.trkMusic1;
            this.trkMusic1.IndicateFocus = false;
            this.trkMusic1.Location = new System.Drawing.Point(69, 590);
            this.trkMusic1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trkMusic1.Name = "trkMusic1";
            this.trkMusic1.Size = new System.Drawing.Size(851, 28);
            this.trkMusic1.TabIndex = 49;
            this.trkMusic1.ThumbColor = System.Drawing.Color.Green;
            this.trkMusic1.Value = 0;
            this.trkMusic1.ValueChanged += new System.EventHandler(this.trkMusic1_ValueChanged);
            this.trkMusic1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trkMusic1_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(899, 510);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove_1);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick_1);
            this.dataGridView1.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave_1);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.FillWeight = 194.9239F;
            this.Column3.HeaderText = "Title";
            this.Column3.Name = "Column3";
            this.Column3.Width = 575;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 5.076141F;
            this.Column4.HeaderText = "Length";
            this.Column4.Name = "Column4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(461, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 503);
            this.panel1.TabIndex = 51;
            this.panel1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 22);
            this.textBox1.TabIndex = 45;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(367, 76);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(67, 62);
            this.button16.TabIndex = 44;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(367, 7);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(67, 62);
            this.button15.TabIndex = 40;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Orange;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(4, 421);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(429, 62);
            this.button13.TabIndex = 43;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Orange;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(4, 352);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(429, 62);
            this.button12.TabIndex = 42;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Orange;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(4, 283);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(429, 62);
            this.button11.TabIndex = 41;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Orange;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(4, 214);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(429, 62);
            this.button10.TabIndex = 40;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(4, 145);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(429, 62);
            this.button5.TabIndex = 39;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnNumThreeHover2
            // 
            this.btnNumThreeHover2.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.FavoritesTopButton;
            this.btnNumThreeHover2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNumThreeHover2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumThreeHover2.Location = new System.Drawing.Point(302, 15);
            this.btnNumThreeHover2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumThreeHover2.Name = "btnNumThreeHover2";
            this.btnNumThreeHover2.Size = new System.Drawing.Size(147, 55);
            this.btnNumThreeHover2.TabIndex = 57;
            this.btnNumThreeHover2.UseVisualStyleBackColor = true;
            this.btnNumThreeHover2.Visible = false;
            this.btnNumThreeHover2.MouseLeave += new System.EventHandler(this.btnNumThreeHover2_MouseLeave);
            // 
            // btnNumThreeHover1
            // 
            this.btnNumThreeHover1.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.PlaylistTopButtonOrange;
            this.btnNumThreeHover1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNumThreeHover1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumThreeHover1.Location = new System.Drawing.Point(171, 26);
            this.btnNumThreeHover1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumThreeHover1.Name = "btnNumThreeHover1";
            this.btnNumThreeHover1.Size = new System.Drawing.Size(123, 44);
            this.btnNumThreeHover1.TabIndex = 56;
            this.btnNumThreeHover1.UseVisualStyleBackColor = true;
            this.btnNumThreeHover1.Visible = false;
            // 
            // btnNumThreeHover0
            // 
            this.btnNumThreeHover0.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.MusicTopButtonWhite;
            this.btnNumThreeHover0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNumThreeHover0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumThreeHover0.Location = new System.Drawing.Point(16, 15);
            this.btnNumThreeHover0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumThreeHover0.Name = "btnNumThreeHover0";
            this.btnNumThreeHover0.Size = new System.Drawing.Size(147, 55);
            this.btnNumThreeHover0.TabIndex = 55;
            this.btnNumThreeHover0.UseVisualStyleBackColor = true;
            this.btnNumThreeHover0.Visible = false;
            // 
            // btnNumTwoHover1
            // 
            this.btnNumTwoHover1.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.PlaylistTopButton;
            this.btnNumTwoHover1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNumTwoHover1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumTwoHover1.Location = new System.Drawing.Point(171, 15);
            this.btnNumTwoHover1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumTwoHover1.Name = "btnNumTwoHover1";
            this.btnNumTwoHover1.Size = new System.Drawing.Size(147, 55);
            this.btnNumTwoHover1.TabIndex = 54;
            this.btnNumTwoHover1.UseVisualStyleBackColor = true;
            this.btnNumTwoHover1.Visible = false;
            this.btnNumTwoHover1.Click += new System.EventHandler(this.btnNumTwoHover1_Click);
            this.btnNumTwoHover1.MouseLeave += new System.EventHandler(this.btnNumTwoHover1_MouseLeave);
            // 
            // btnNumTwoHover2
            // 
            this.btnNumTwoHover2.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.FavoritesTopButtonOrange;
            this.btnNumTwoHover2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNumTwoHover2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumTwoHover2.Location = new System.Drawing.Point(326, 26);
            this.btnNumTwoHover2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumTwoHover2.Name = "btnNumTwoHover2";
            this.btnNumTwoHover2.Size = new System.Drawing.Size(123, 44);
            this.btnNumTwoHover2.TabIndex = 53;
            this.btnNumTwoHover2.UseVisualStyleBackColor = true;
            this.btnNumTwoHover2.Visible = false;
            // 
            // btnNumTwoHover0
            // 
            this.btnNumTwoHover0.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.MusicTopButtonWhite;
            this.btnNumTwoHover0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNumTwoHover0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumTwoHover0.Location = new System.Drawing.Point(16, 15);
            this.btnNumTwoHover0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNumTwoHover0.Name = "btnNumTwoHover0";
            this.btnNumTwoHover0.Size = new System.Drawing.Size(147, 55);
            this.btnNumTwoHover0.TabIndex = 52;
            this.btnNumTwoHover0.UseVisualStyleBackColor = true;
            this.btnNumTwoHover0.Visible = false;
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.PlaylistBorder30;
            this.btnAddPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlaylist.Location = new System.Drawing.Point(907, 276);
            this.btnAddPlaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(67, 62);
            this.btnAddPlaylist.TabIndex = 44;
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.MouseEnter += new System.EventHandler(this.btnAddPlaylist_MouseEnter);
            this.btnAddPlaylist.MouseLeave += new System.EventHandler(this.btnAddPlaylist_MouseLeave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.SearchBorder30;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(907, 138);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 62);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.MouseEnter += new System.EventHandler(this.btnSearch_MouseEnter);
            this.btnSearch.MouseLeave += new System.EventHandler(this.btnSearch_MouseLeave);
            // 
            // btnFavorites
            // 
            this.btnFavorites.BackColor = System.Drawing.Color.Black;
            this.btnFavorites.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.FavortesBorder30;
            this.btnFavorites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFavorites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavorites.Location = new System.Drawing.Point(907, 345);
            this.btnFavorites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(67, 62);
            this.btnFavorites.TabIndex = 42;
            this.btnFavorites.UseVisualStyleBackColor = false;
            this.btnFavorites.MouseEnter += new System.EventHandler(this.btnFavorites_MouseEnter);
            this.btnFavorites.MouseLeave += new System.EventHandler(this.btnFavorites_MouseLeave);
            // 
            // btnRecent
            // 
            this.btnRecent.BackColor = System.Drawing.Color.Black;
            this.btnRecent.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.RecentBorder30;
            this.btnRecent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecent.Location = new System.Drawing.Point(907, 482);
            this.btnRecent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.Size = new System.Drawing.Size(67, 62);
            this.btnRecent.TabIndex = 41;
            this.btnRecent.UseVisualStyleBackColor = false;
            this.btnRecent.MouseEnter += new System.EventHandler(this.btnRecent_MouseEnter);
            this.btnRecent.MouseLeave += new System.EventHandler(this.btnRecent_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.DeleteBorder30;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(907, 414);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 62);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnShowOption
            // 
            this.btnShowOption.BackColor = System.Drawing.Color.Black;
            this.btnShowOption.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.OptionBorder30;
            this.btnShowOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowOption.Location = new System.Drawing.Point(907, 69);
            this.btnShowOption.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowOption.Name = "btnShowOption";
            this.btnShowOption.Size = new System.Drawing.Size(67, 62);
            this.btnShowOption.TabIndex = 37;
            this.btnShowOption.UseVisualStyleBackColor = false;
            this.btnShowOption.MouseEnter += new System.EventHandler(this.btnShowOption_MouseEnter);
            this.btnShowOption.MouseLeave += new System.EventHandler(this.btnShowOption_MouseLeave);
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.Orange;
            this.btnVolume.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.VolumeHighButtonDefault;
            this.btnVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.Location = new System.Drawing.Point(737, 623);
            this.btnVolume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(67, 62);
            this.btnVolume.TabIndex = 28;
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            this.btnVolume.MouseEnter += new System.EventHandler(this.btnVolume_MouseEnter);
            this.btnVolume.MouseLeave += new System.EventHandler(this.btnVolume_MouseLeave);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Orange;
            this.btnPlay.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.PlayButtonDefault;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(612, 623);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(67, 62);
            this.btnPlay.TabIndex = 27;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.PlayerIcon;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(16, 623);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 61);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.MusicBorder30;
            this.btnAddMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMusic.Location = new System.Drawing.Point(907, 207);
            this.btnAddMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(67, 62);
            this.btnAddMusic.TabIndex = 24;
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            this.btnAddMusic.MouseEnter += new System.EventHandler(this.btnAddMusic_MouseEnter);
            this.btnAddMusic.MouseLeave += new System.EventHandler(this.btnAddMusic_MouseLeave);
            // 
            // btnDefault2
            // 
            this.btnDefault2.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.FavoritesTopButtonOrange;
            this.btnDefault2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefault2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault2.Location = new System.Drawing.Point(302, 26);
            this.btnDefault2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDefault2.Name = "btnDefault2";
            this.btnDefault2.Size = new System.Drawing.Size(123, 44);
            this.btnDefault2.TabIndex = 23;
            this.btnDefault2.UseVisualStyleBackColor = true;
            this.btnDefault2.MouseEnter += new System.EventHandler(this.btnDefault2_MouseEnter);
            // 
            // btnDefault1
            // 
            this.btnDefault1.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.PlaylistTopButtonOrange;
            this.btnDefault1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefault1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault1.Location = new System.Drawing.Point(171, 26);
            this.btnDefault1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDefault1.Name = "btnDefault1";
            this.btnDefault1.Size = new System.Drawing.Size(123, 44);
            this.btnDefault1.TabIndex = 22;
            this.btnDefault1.UseVisualStyleBackColor = true;
            this.btnDefault1.MouseEnter += new System.EventHandler(this.btnDefault1_MouseEnter);
            // 
            // btnDefault0
            // 
            this.btnDefault0.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.MusicTopButtonWhite;
            this.btnDefault0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefault0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault0.Location = new System.Drawing.Point(16, 15);
            this.btnDefault0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDefault0.Name = "btnDefault0";
            this.btnDefault0.Size = new System.Drawing.Size(147, 55);
            this.btnDefault0.TabIndex = 21;
            this.btnDefault0.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Orange;
            this.btnNext.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.NextButtonDefault;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(681, 633);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(47, 43);
            this.btnNext.TabIndex = 11;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Orange;
            this.btnPrev.BackgroundImage = global::OrchestraMusicPlayer.Properties.Resources.PrevButtonDefault;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(563, 633);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(47, 43);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            this.btnPrev.MouseEnter += new System.EventHandler(this.btnPrev_MouseEnter);
            this.btnPrev.MouseLeave += new System.EventHandler(this.btnPrev_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orange;
            this.pictureBox1.Location = new System.Drawing.Point(0, 586);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(989, 113);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(989, 699);
            this.Controls.Add(this.btnNumThreeHover2);
            this.Controls.Add(this.btnNumThreeHover1);
            this.Controls.Add(this.btnNumThreeHover0);
            this.Controls.Add(this.btnNumTwoHover1);
            this.Controls.Add(this.btnNumTwoHover2);
            this.Controls.Add(this.btnNumTwoHover0);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.trkMusic1);
            this.Controls.Add(this.trkVolume);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnFavorites);
            this.Controls.Add(this.btnRecent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowOption);
            this.Controls.Add(this.lblMusicLength);
            this.Controls.Add(this.lblMusicStart);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnAddMusic);
            this.Controls.Add(this.btnDefault2);
            this.Controls.Add(this.btnDefault1);
            this.Controls.Add(this.btnDefault0);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.axVLCPlugin21);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orchestra Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnDefault0;
        private System.Windows.Forms.Button btnDefault1;
        private System.Windows.Forms.Button btnDefault2;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Label lblMusicStart;
        private System.Windows.Forms.Label lblMusicLength;
        private System.Windows.Forms.Button btnShowOption;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRecent;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.Label lblTitle;
        private Siticone.UI.WinForms.SiticoneTrackBar trkVolume;
        private System.Windows.Forms.Timer timer2;
        private Siticone.UI.WinForms.SiticoneTrackBar trkMusic1;
        private Siticone.UI.WinForms.SiticoneDataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnNumTwoHover2;
        private System.Windows.Forms.Button btnNumTwoHover0;
        private System.Windows.Forms.Button btnNumTwoHover1;
        private System.Windows.Forms.Button btnNumThreeHover2;
        private System.Windows.Forms.Button btnNumThreeHover1;
        private System.Windows.Forms.Button btnNumThreeHover0;
    }
}

