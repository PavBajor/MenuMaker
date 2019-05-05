namespace WindowsFormsApp3
{
    partial class MEnu
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
            this.MenuPosition1 = new System.Windows.Forms.Label();
            this.MenuPosition2 = new System.Windows.Forms.Label();
            this.MenuPosition3 = new System.Windows.Forms.Label();
            this.MenuPosition4 = new System.Windows.Forms.Label();
            this.MenuPosition5 = new System.Windows.Forms.Label();
            this.MenuPosition6 = new System.Windows.Forms.Label();
            this.makeManu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuPosition1
            // 
            this.MenuPosition1.AutoSize = true;
            this.MenuPosition1.Location = new System.Drawing.Point(59, 64);
            this.MenuPosition1.Name = "MenuPosition1";
            this.MenuPosition1.Size = new System.Drawing.Size(77, 13);
            this.MenuPosition1.TabIndex = 0;
            this.MenuPosition1.Text = "MenuPosition1";
            this.MenuPosition1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuPosition2
            // 
            this.MenuPosition2.AutoSize = true;
            this.MenuPosition2.Location = new System.Drawing.Point(59, 77);
            this.MenuPosition2.Name = "MenuPosition2";
            this.MenuPosition2.Size = new System.Drawing.Size(77, 13);
            this.MenuPosition2.TabIndex = 1;
            this.MenuPosition2.Text = "MenuPosition2";
            // 
            // MenuPosition3
            // 
            this.MenuPosition3.AutoSize = true;
            this.MenuPosition3.Location = new System.Drawing.Point(59, 90);
            this.MenuPosition3.Name = "MenuPosition3";
            this.MenuPosition3.Size = new System.Drawing.Size(77, 13);
            this.MenuPosition3.TabIndex = 2;
            this.MenuPosition3.Text = "MenuPosition3";
            // 
            // MenuPosition4
            // 
            this.MenuPosition4.AutoSize = true;
            this.MenuPosition4.Location = new System.Drawing.Point(59, 103);
            this.MenuPosition4.Name = "MenuPosition4";
            this.MenuPosition4.Size = new System.Drawing.Size(77, 13);
            this.MenuPosition4.TabIndex = 3;
            this.MenuPosition4.Text = "MenuPosition4";
            // 
            // MenuPosition5
            // 
            this.MenuPosition5.AutoSize = true;
            this.MenuPosition5.Location = new System.Drawing.Point(59, 116);
            this.MenuPosition5.Name = "MenuPosition5";
            this.MenuPosition5.Size = new System.Drawing.Size(77, 13);
            this.MenuPosition5.TabIndex = 4;
            this.MenuPosition5.Text = "MenuPosition5";
            // 
            // MenuPosition6
            // 
            this.MenuPosition6.AutoSize = true;
            this.MenuPosition6.Location = new System.Drawing.Point(59, 129);
            this.MenuPosition6.Name = "MenuPosition6";
            this.MenuPosition6.Size = new System.Drawing.Size(77, 13);
            this.MenuPosition6.TabIndex = 5;
            this.MenuPosition6.Text = "MenuPosition6";
            // 
            // makeManu
            // 
            this.makeManu.Location = new System.Drawing.Point(177, 24);
            this.makeManu.Name = "makeManu";
            this.makeManu.Size = new System.Drawing.Size(75, 23);
            this.makeManu.TabIndex = 6;
            this.makeManu.Text = "MakeMenu";
            this.makeManu.UseVisualStyleBackColor = true;
            this.makeManu.Click += new System.EventHandler(this.makeManu_Click);
            // 
            // MEnu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 156);
            this.Controls.Add(this.makeManu);
            this.Controls.Add(this.MenuPosition6);
            this.Controls.Add(this.MenuPosition5);
            this.Controls.Add(this.MenuPosition4);
            this.Controls.Add(this.MenuPosition3);
            this.Controls.Add(this.MenuPosition2);
            this.Controls.Add(this.MenuPosition1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MEnu";
            this.Text = "Sloppy Joe\'s Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuPosition1;
        private System.Windows.Forms.Label MenuPosition2;
        private System.Windows.Forms.Label MenuPosition3;
        private System.Windows.Forms.Label MenuPosition4;
        private System.Windows.Forms.Label MenuPosition5;
        private System.Windows.Forms.Label MenuPosition6;
        private System.Windows.Forms.Button makeManu;
    }
}

