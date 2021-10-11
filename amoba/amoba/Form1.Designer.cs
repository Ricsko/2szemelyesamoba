
namespace amoba
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jatekos1_TBOX = new System.Windows.Forms.TextBox();
            this.jatekos2_TBOX = new System.Windows.Forms.TextBox();
            this.start_BTN = new System.Windows.Forms.Button();
            this.jatekos1_megjelenito_LBL = new System.Windows.Forms.Label();
            this.jatekos2_megjelenito_LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. játékos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. játékos:";
            // 
            // jatekos1_TBOX
            // 
            this.jatekos1_TBOX.Location = new System.Drawing.Point(162, 54);
            this.jatekos1_TBOX.Name = "jatekos1_TBOX";
            this.jatekos1_TBOX.Size = new System.Drawing.Size(100, 20);
            this.jatekos1_TBOX.TabIndex = 2;
            // 
            // jatekos2_TBOX
            // 
            this.jatekos2_TBOX.Location = new System.Drawing.Point(162, 103);
            this.jatekos2_TBOX.Name = "jatekos2_TBOX";
            this.jatekos2_TBOX.Size = new System.Drawing.Size(100, 20);
            this.jatekos2_TBOX.TabIndex = 3;
            // 
            // start_BTN
            // 
            this.start_BTN.Location = new System.Drawing.Point(124, 182);
            this.start_BTN.Name = "start_BTN";
            this.start_BTN.Size = new System.Drawing.Size(75, 23);
            this.start_BTN.TabIndex = 4;
            this.start_BTN.Text = "Start";
            this.start_BTN.UseVisualStyleBackColor = true;
            this.start_BTN.Click += new System.EventHandler(this.start_BTN_Click);
            // 
            // jatekos1_megjelenito_LBL
            // 
            this.jatekos1_megjelenito_LBL.AutoSize = true;
            this.jatekos1_megjelenito_LBL.Location = new System.Drawing.Point(39, 6);
            this.jatekos1_megjelenito_LBL.Name = "jatekos1_megjelenito_LBL";
            this.jatekos1_megjelenito_LBL.Size = new System.Drawing.Size(0, 13);
            this.jatekos1_megjelenito_LBL.TabIndex = 5;
            // 
            // jatekos2_megjelenito_LBL
            // 
            this.jatekos2_megjelenito_LBL.AutoSize = true;
            this.jatekos2_megjelenito_LBL.Location = new System.Drawing.Point(199, 6);
            this.jatekos2_megjelenito_LBL.Name = "jatekos2_megjelenito_LBL";
            this.jatekos2_megjelenito_LBL.Size = new System.Drawing.Size(0, 13);
            this.jatekos2_megjelenito_LBL.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(314, 241);
            this.Controls.Add(this.jatekos2_megjelenito_LBL);
            this.Controls.Add(this.jatekos1_megjelenito_LBL);
            this.Controls.Add(this.start_BTN);
            this.Controls.Add(this.jatekos2_TBOX);
            this.Controls.Add(this.jatekos1_TBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Amőba 10x10 2személy random kezd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jatekos1_TBOX;
        private System.Windows.Forms.TextBox jatekos2_TBOX;
        private System.Windows.Forms.Button start_BTN;
        private System.Windows.Forms.Label jatekos1_megjelenito_LBL;
        private System.Windows.Forms.Label jatekos2_megjelenito_LBL;
    }
}

