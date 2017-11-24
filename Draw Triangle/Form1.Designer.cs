namespace Draw_Triangle
{
    partial class mainDisplay
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
            this.drawTri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawTri
            // 
            this.drawTri.Location = new System.Drawing.Point(154, 28);
            this.drawTri.Name = "drawTri";
            this.drawTri.Size = new System.Drawing.Size(152, 39);
            this.drawTri.TabIndex = 0;
            this.drawTri.Text = "Draw The Triangle";
            this.drawTri.UseVisualStyleBackColor = true;
            this.drawTri.Click += new System.EventHandler(this.drawTri_Click);
            // 
            // mainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 334);
            this.Controls.Add(this.drawTri);
            this.Name = "mainDisplay";
            this.Text = "Drawing Triangle ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawTri;
    }
}

