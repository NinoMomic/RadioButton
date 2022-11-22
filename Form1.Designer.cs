namespace RadioButton
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
            this.radioButtonAvion = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.radioButtonVlastitiPrijevoz = new System.Windows.Forms.RadioButton();
            this.radioButtonAutobus = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRezerviraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonAvion
            // 
            this.radioButtonAvion.AutoSize = true;
            this.radioButtonAvion.Location = new System.Drawing.Point(317, 127);
            this.radioButtonAvion.Name = "radioButtonAvion";
            this.radioButtonAvion.Size = new System.Drawing.Size(52, 17);
            this.radioButtonAvion.TabIndex = 0;
            this.radioButtonAvion.TabStop = true;
            this.radioButtonAvion.Text = "Avion";
            this.radioButtonAvion.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(314, 87);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(127, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Odaberite vrstu prijevoza:";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButtonVlastitiPrijevoz
            // 
            this.radioButtonVlastitiPrijevoz.AutoSize = true;
            this.radioButtonVlastitiPrijevoz.Location = new System.Drawing.Point(317, 205);
            this.radioButtonVlastitiPrijevoz.Name = "radioButtonVlastitiPrijevoz";
            this.radioButtonVlastitiPrijevoz.Size = new System.Drawing.Size(94, 17);
            this.radioButtonVlastitiPrijevoz.TabIndex = 2;
            this.radioButtonVlastitiPrijevoz.TabStop = true;
            this.radioButtonVlastitiPrijevoz.Text = "Vlastiti prijevoz";
            this.radioButtonVlastitiPrijevoz.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutobus
            // 
            this.radioButtonAutobus.AutoSize = true;
            this.radioButtonAutobus.Location = new System.Drawing.Point(317, 167);
            this.radioButtonAutobus.Name = "radioButtonAutobus";
            this.radioButtonAutobus.Size = new System.Drawing.Size(64, 17);
            this.radioButtonAutobus.TabIndex = 3;
            this.radioButtonAutobus.TabStop = true;
            this.radioButtonAutobus.Text = "Autobus";
            this.radioButtonAutobus.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(168, 162);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 282);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 42);
            this.textBox1.TabIndex = 5;
            // 
            // buttonRezerviraj
            // 
            this.buttonRezerviraj.Location = new System.Drawing.Point(336, 242);
            this.buttonRezerviraj.Name = "buttonRezerviraj";
            this.buttonRezerviraj.Size = new System.Drawing.Size(75, 23);
            this.buttonRezerviraj.TabIndex = 6;
            this.buttonRezerviraj.Text = "Rezerviraj";
            this.buttonRezerviraj.UseVisualStyleBackColor = true;
            this.buttonRezerviraj.Click += new System.EventHandler(this.buttonRezerviraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRezerviraj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.radioButtonAutobus);
            this.Controls.Add(this.radioButtonVlastitiPrijevoz);
            this.Controls.Add(this.label);
            this.Controls.Add(this.radioButtonAvion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAvion;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RadioButton radioButtonVlastitiPrijevoz;
        private System.Windows.Forms.RadioButton radioButtonAutobus;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRezerviraj;
    }
}

