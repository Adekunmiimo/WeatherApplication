namespace Weatherapplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.LabCondition = new System.Windows.Forms.Label();
            this.LabDetail = new System.Windows.Forms.Label();
            this.labSunr = new System.Windows.Forms.Label();
            this.LabSunrise = new System.Windows.Forms.Label();
            this.LabSunset = new System.Windows.Forms.Label();
            this.labSuns = new System.Windows.Forms.Label();
            this.LabPressure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabWindSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(117, 61);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(198, 31);
            this.TBCity.TabIndex = 1;
            this.TBCity.Text = " ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(354, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 44);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LabCondition
            // 
            this.LabCondition.AutoSize = true;
            this.LabCondition.BackColor = System.Drawing.Color.Transparent;
            this.LabCondition.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCondition.ForeColor = System.Drawing.Color.White;
            this.LabCondition.Location = new System.Drawing.Point(67, 190);
            this.LabCondition.Name = "LabCondition";
            this.LabCondition.Size = new System.Drawing.Size(85, 23);
            this.LabCondition.TabIndex = 3;
            this.LabCondition.Text = "Condition";
            // 
            // LabDetail
            // 
            this.LabDetail.AutoSize = true;
            this.LabDetail.BackColor = System.Drawing.Color.Transparent;
            this.LabDetail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDetail.ForeColor = System.Drawing.Color.White;
            this.LabDetail.Location = new System.Drawing.Point(67, 225);
            this.LabDetail.Name = "LabDetail";
            this.LabDetail.Size = new System.Drawing.Size(62, 23);
            this.LabDetail.TabIndex = 4;
            this.LabDetail.Text = "Details";
            // 
            // labSunr
            // 
            this.labSunr.AutoSize = true;
            this.labSunr.BackColor = System.Drawing.Color.Transparent;
            this.labSunr.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunr.ForeColor = System.Drawing.Color.White;
            this.labSunr.Location = new System.Drawing.Point(67, 259);
            this.labSunr.Name = "labSunr";
            this.labSunr.Size = new System.Drawing.Size(72, 23);
            this.labSunr.TabIndex = 5;
            this.labSunr.Text = "Sunrise:";
            // 
            // LabSunrise
            // 
            this.LabSunrise.AutoSize = true;
            this.LabSunrise.BackColor = System.Drawing.Color.Transparent;
            this.LabSunrise.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSunrise.ForeColor = System.Drawing.Color.White;
            this.LabSunrise.Location = new System.Drawing.Point(145, 259);
            this.LabSunrise.Name = "LabSunrise";
            this.LabSunrise.Size = new System.Drawing.Size(39, 23);
            this.LabSunrise.TabIndex = 6;
            this.LabSunrise.Text = "N/A";
            // 
            // LabSunset
            // 
            this.LabSunset.AutoSize = true;
            this.LabSunset.BackColor = System.Drawing.Color.Transparent;
            this.LabSunset.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSunset.ForeColor = System.Drawing.Color.White;
            this.LabSunset.Location = new System.Drawing.Point(145, 292);
            this.LabSunset.Name = "LabSunset";
            this.LabSunset.Size = new System.Drawing.Size(39, 23);
            this.LabSunset.TabIndex = 8;
            this.LabSunset.Text = "N/A";
            // 
            // labSuns
            // 
            this.labSuns.AutoSize = true;
            this.labSuns.BackColor = System.Drawing.Color.Transparent;
            this.labSuns.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSuns.ForeColor = System.Drawing.Color.White;
            this.labSuns.Location = new System.Drawing.Point(67, 292);
            this.labSuns.Name = "labSuns";
            this.labSuns.Size = new System.Drawing.Size(67, 23);
            this.labSuns.TabIndex = 7;
            this.labSuns.Text = "Sunset:";
            // 
            // LabPressure
            // 
            this.LabPressure.AutoSize = true;
            this.LabPressure.BackColor = System.Drawing.Color.Transparent;
            this.LabPressure.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabPressure.ForeColor = System.Drawing.Color.White;
            this.LabPressure.Location = new System.Drawing.Point(473, 223);
            this.LabPressure.Name = "LabPressure";
            this.LabPressure.Size = new System.Drawing.Size(39, 23);
            this.LabPressure.TabIndex = 12;
            this.LabPressure.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(350, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pressure:";
            // 
            // LabWindSpeed
            // 
            this.LabWindSpeed.AutoSize = true;
            this.LabWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.LabWindSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWindSpeed.ForeColor = System.Drawing.Color.White;
            this.LabWindSpeed.Location = new System.Drawing.Point(473, 190);
            this.LabWindSpeed.Name = "LabWindSpeed";
            this.LabWindSpeed.Size = new System.Drawing.Size(39, 23);
            this.LabWindSpeed.TabIndex = 10;
            this.LabWindSpeed.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(350, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wind Speed:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(71, 109);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.LabPressure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabWindSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabSunset);
            this.Controls.Add(this.labSuns);
            this.Controls.Add(this.LabSunrise);
            this.Controls.Add(this.labSunr);
            this.Controls.Add(this.LabDetail);
            this.Controls.Add(this.LabCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label LabCondition;
        private System.Windows.Forms.Label LabDetail;
        private System.Windows.Forms.Label labSunr;
        private System.Windows.Forms.Label LabSunrise;
        private System.Windows.Forms.Label LabSunset;
        private System.Windows.Forms.Label labSuns;
        private System.Windows.Forms.Label LabPressure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabWindSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picIcon;
    }
}

