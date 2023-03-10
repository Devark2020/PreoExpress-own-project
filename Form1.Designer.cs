namespace PreoExpress
{
    partial class Preo
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
            this.gbWorkers = new System.Windows.Forms.GroupBox();
            this.cbLoader = new System.Windows.Forms.CheckBox();
            this.cbDriver = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOutside = new System.Windows.Forms.RadioButton();
            this.rbStockholm = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDrivers = new System.Windows.Forms.TextBox();
            this.tbLoaders = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMiles = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.tbPriceForMiles = new System.Windows.Forms.TextBox();
            this.lblPriceForMile = new System.Windows.Forms.Label();
            this.tbVat = new System.Windows.Forms.TextBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.gbWorkers.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbWorkers
            // 
            this.gbWorkers.Controls.Add(this.cbLoader);
            this.gbWorkers.Controls.Add(this.cbDriver);
            this.gbWorkers.Location = new System.Drawing.Point(12, 12);
            this.gbWorkers.Name = "gbWorkers";
            this.gbWorkers.Size = new System.Drawing.Size(97, 100);
            this.gbWorkers.TabIndex = 0;
            this.gbWorkers.TabStop = false;
            this.gbWorkers.Text = "Välj";
            // 
            // cbLoader
            // 
            this.cbLoader.AutoSize = true;
            this.cbLoader.Location = new System.Drawing.Point(7, 66);
            this.cbLoader.Name = "cbLoader";
            this.cbLoader.Size = new System.Drawing.Size(84, 17);
            this.cbLoader.TabIndex = 1;
            this.cbLoader.Text = "Flyttarbetare";
            this.cbLoader.UseVisualStyleBackColor = true;
            // 
            // cbDriver
            // 
            this.cbDriver.AutoSize = true;
            this.cbDriver.Location = new System.Drawing.Point(6, 29);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(56, 17);
            this.cbDriver.TabIndex = 0;
            this.cbDriver.Text = "Förare";
            this.cbDriver.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.rbOutside);
            this.groupBox1.Controls.Add(this.rbStockholm);
            this.groupBox1.Location = new System.Drawing.Point(133, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plats";
            // 
            // rbOutside
            // 
            this.rbOutside.AutoSize = true;
            this.rbOutside.Location = new System.Drawing.Point(7, 65);
            this.rbOutside.Name = "rbOutside";
            this.rbOutside.Size = new System.Drawing.Size(60, 17);
            this.rbOutside.TabIndex = 1;
            this.rbOutside.TabStop = true;
            this.rbOutside.Text = "Utanför";
            this.rbOutside.UseVisualStyleBackColor = true;
            // 
            // rbStockholm
            // 
            this.rbStockholm.AutoSize = true;
            this.rbStockholm.Location = new System.Drawing.Point(7, 27);
            this.rbStockholm.Name = "rbStockholm";
            this.rbStockholm.Size = new System.Drawing.Size(75, 17);
            this.rbStockholm.TabIndex = 0;
            this.rbStockholm.TabStop = true;
            this.rbStockholm.Text = "Stockholm";
            this.rbStockholm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Antal förare:";
            // 
            // tbDrivers
            // 
            this.tbDrivers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDrivers.Location = new System.Drawing.Point(12, 136);
            this.tbDrivers.Name = "tbDrivers";
            this.tbDrivers.Size = new System.Drawing.Size(97, 20);
            this.tbDrivers.TabIndex = 3;
            this.tbDrivers.Text = "0";
            // 
            // tbLoaders
            // 
            this.tbLoaders.Location = new System.Drawing.Point(12, 176);
            this.tbLoaders.Name = "tbLoaders";
            this.tbLoaders.Size = new System.Drawing.Size(97, 20);
            this.tbLoaders.TabIndex = 5;
            this.tbLoaders.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Antal flyttarbetare:";
            // 
            // tbMiles
            // 
            this.tbMiles.Location = new System.Drawing.Point(137, 136);
            this.tbMiles.Name = "tbMiles";
            this.tbMiles.Size = new System.Drawing.Size(44, 20);
            this.tbMiles.TabIndex = 7;
            this.tbMiles.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Miltal:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Räkna priset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(137, 176);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(44, 20);
            this.tbHours.TabIndex = 11;
            this.tbHours.Text = "0";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(137, 159);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(44, 13);
            this.lblHours.TabIndex = 10;
            this.lblHours.Text = "Timmar:";
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(12, 252);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbDisplay.Size = new System.Drawing.Size(222, 145);
            this.tbDisplay.TabIndex = 12;
            this.tbDisplay.Text = "* ";
            // 
            // tbPriceForMiles
            // 
            this.tbPriceForMiles.Location = new System.Drawing.Point(191, 136);
            this.tbPriceForMiles.Name = "tbPriceForMiles";
            this.tbPriceForMiles.Size = new System.Drawing.Size(44, 20);
            this.tbPriceForMiles.TabIndex = 14;
            this.tbPriceForMiles.Text = "0";
            // 
            // lblPriceForMile
            // 
            this.lblPriceForMile.AutoSize = true;
            this.lblPriceForMile.Location = new System.Drawing.Point(191, 119);
            this.lblPriceForMile.Name = "lblPriceForMile";
            this.lblPriceForMile.Size = new System.Drawing.Size(44, 13);
            this.lblPriceForMile.TabIndex = 13;
            this.lblPriceForMile.Text = "Pris/mil:";
            // 
            // tbVat
            // 
            this.tbVat.Location = new System.Drawing.Point(191, 176);
            this.tbVat.Name = "tbVat";
            this.tbVat.Size = new System.Drawing.Size(44, 20);
            this.tbVat.TabIndex = 16;
            this.tbVat.Text = "1,25";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(191, 159);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(38, 13);
            this.lblVat.TabIndex = 15;
            this.lblVat.Text = "Moms:";
            // 
            // Preo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(248, 409);
            this.Controls.Add(this.tbVat);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.tbPriceForMiles);
            this.Controls.Add(this.lblPriceForMile);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbMiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLoaders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDrivers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbWorkers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Preo";
            this.Text = "PreoExpress";
            this.gbWorkers.ResumeLayout(false);
            this.gbWorkers.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWorkers;
        private System.Windows.Forms.CheckBox cbLoader;
        private System.Windows.Forms.CheckBox cbDriver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOutside;
        private System.Windows.Forms.RadioButton rbStockholm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDrivers;
        private System.Windows.Forms.TextBox tbLoaders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.TextBox tbPriceForMiles;
        private System.Windows.Forms.Label lblPriceForMile;
        private System.Windows.Forms.TextBox tbVat;
        private System.Windows.Forms.Label lblVat;
    }
}

