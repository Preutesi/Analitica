namespace Analitica3R
{
    partial class DistanzaTraDuePunti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistanzaTraDuePunti));
            this.panel1 = new System.Windows.Forms.Panel();
            this.output = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yMax = new System.Windows.Forms.NumericUpDown();
            this.yMin = new System.Windows.Forms.NumericUpDown();
            this.xMax = new System.Windows.Forms.NumericUpDown();
            this.xMin = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.y2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panelGrafico = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.output);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.y2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.x2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.y1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.x1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 701);
            this.panel1.TabIndex = 0;
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.output.Location = new System.Drawing.Point(0, 352);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(303, 132);
            this.output.TabIndex = 16;
            this.output.Text = "label11";
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.output.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.yMax);
            this.groupBox1.Controls.Add(this.yMin);
            this.groupBox1.Controls.Add(this.xMax);
            this.groupBox1.Controls.Add(this.xMin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 484);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 217);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Area grafico";
            // 
            // yMax
            // 
            this.yMax.Location = new System.Drawing.Point(158, 16);
            this.yMax.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yMax.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.yMax.Name = "yMax";
            this.yMax.Size = new System.Drawing.Size(79, 29);
            this.yMax.TabIndex = 3;
            this.yMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yMax.ValueChanged += new System.EventHandler(this.yMax_ValueChanged);
            // 
            // yMin
            // 
            this.yMin.Location = new System.Drawing.Point(153, 182);
            this.yMin.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.yMin.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.yMin.Name = "yMin";
            this.yMin.Size = new System.Drawing.Size(79, 29);
            this.yMin.TabIndex = 2;
            this.yMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.yMin.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // xMax
            // 
            this.xMax.Location = new System.Drawing.Point(218, 82);
            this.xMax.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.xMax.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            -2147483648});
            this.xMax.Name = "xMax";
            this.xMax.Size = new System.Drawing.Size(79, 29);
            this.xMax.TabIndex = 1;
            this.xMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xMax.ValueChanged += new System.EventHandler(this.xMax_ValueChanged);
            // 
            // xMin
            // 
            this.xMin.Location = new System.Drawing.Point(4, 82);
            this.xMin.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.xMin.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.xMin.Name = "xMin";
            this.xMin.Size = new System.Drawing.Size(79, 29);
            this.xMin.TabIndex = 0;
            this.xMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.xMin.ValueChanged += new System.EventHandler(this.xMin_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "calcola distanza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "y2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "x2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = ")";
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(158, 137);
            this.y2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.y2.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(74, 29);
            this.y2.TabIndex = 10;
            this.y2.ValueChanged += new System.EventHandler(this.x1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(143, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = ";";
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(70, 136);
            this.x2.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.x2.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(74, 29);
            this.x2.TabIndex = 8;
            this.x2.ValueChanged += new System.EventHandler(this.x1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "P2 (";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "y1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "x1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = ")";
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(158, 58);
            this.y1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.y1.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(74, 29);
            this.y1.TabIndex = 3;
            this.y1.ValueChanged += new System.EventHandler(this.x1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = ";";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(70, 57);
            this.x1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.x1.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(74, 29);
            this.x1.TabIndex = 1;
            this.x1.ValueChanged += new System.EventHandler(this.x1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "P1 (";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Silver;
            this.panel11.Controls.Add(this.panelGrafico);
            this.panel11.Controls.Add(this.label11);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(303, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(981, 701);
            this.panel11.TabIndex = 1;
            // 
            // panelGrafico
            // 
            this.panelGrafico.BackColor = System.Drawing.Color.White;
            this.panelGrafico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrafico.Location = new System.Drawing.Point(0, 32);
            this.panelGrafico.Name = "panelGrafico";
            this.panelGrafico.Size = new System.Drawing.Size(981, 669);
            this.panelGrafico.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(981, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Pano cartesiano";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DistanzaTraDuePunti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DistanzaTraDuePunti";
            this.Text = "Distanza tra due punti";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown y2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown x2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown x1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.NumericUpDown xMax;
        private System.Windows.Forms.NumericUpDown xMin;
        private System.Windows.Forms.NumericUpDown yMin;
        private System.Windows.Forms.NumericUpDown yMax;
        private System.Windows.Forms.Panel panelGrafico;
        private System.Windows.Forms.Label label11;
    }
}