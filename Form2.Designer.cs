namespace AFEFWFV05221018
{
    partial class Form2
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
            this.a = new System.Windows.Forms.TextBox();
            this.lbExtracionDatosUltragrid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbF1Tb = new System.Windows.Forms.TextBox();
            this.btExtDatosUG = new System.Windows.Forms.Button();
            this.btExtDatosTB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(229, 58);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 22);
            this.a.TabIndex = 0;
            // 
            // lbExtracionDatosUltragrid
            // 
            this.lbExtracionDatosUltragrid.AutoSize = true;
            this.lbExtracionDatosUltragrid.Location = new System.Drawing.Point(52, 58);
            this.lbExtracionDatosUltragrid.Name = "lbExtracionDatosUltragrid";
            this.lbExtracionDatosUltragrid.Size = new System.Drawing.Size(157, 17);
            this.lbExtracionDatosUltragrid.TabIndex = 1;
            this.lbExtracionDatosUltragrid.Text = "ExtracionDatosUltragrid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ExtracionDatosTextBox";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbF1Tb
            // 
            this.tbF1Tb.Location = new System.Drawing.Point(229, 106);
            this.tbF1Tb.Name = "tbF1Tb";
            this.tbF1Tb.Size = new System.Drawing.Size(100, 22);
            this.tbF1Tb.TabIndex = 2;
            this.tbF1Tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btExtDatosUG
            // 
            this.btExtDatosUG.Location = new System.Drawing.Point(419, 58);
            this.btExtDatosUG.Name = "btExtDatosUG";
            this.btExtDatosUG.Size = new System.Drawing.Size(106, 23);
            this.btExtDatosUG.TabIndex = 4;
            this.btExtDatosUG.Text = "ExtDatosUG";
            this.btExtDatosUG.UseVisualStyleBackColor = true;
            // 
            // btExtDatosTB
            // 
            this.btExtDatosTB.Location = new System.Drawing.Point(419, 106);
            this.btExtDatosTB.Name = "btExtDatosTB";
            this.btExtDatosTB.Size = new System.Drawing.Size(106, 23);
            this.btExtDatosTB.TabIndex = 5;
            this.btExtDatosTB.Text = "ExtDatosTB";
            this.btExtDatosTB.UseVisualStyleBackColor = true;
            this.btExtDatosTB.Click += new System.EventHandler(this.btExtDatosTB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExtDatosTB);
            this.Controls.Add(this.btExtDatosUG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbF1Tb);
            this.Controls.Add(this.lbExtracionDatosUltragrid);
            this.Controls.Add(this.a);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label lbExtracionDatosUltragrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbF1Tb;
        private System.Windows.Forms.Button btExtDatosUG;
        private System.Windows.Forms.Button btExtDatosTB;
    }
}