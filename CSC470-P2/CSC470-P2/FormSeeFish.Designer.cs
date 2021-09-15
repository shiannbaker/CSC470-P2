
namespace CSC470_P2
{
    public partial class FormSeeFish
    {
        private System.ComponentModel.IContainer components = null;
        
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonThrowItBack = new System.Windows.Forms.Button();
            this.buttonKeepIt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CSC470_P2.Properties.Resources.Walleye;
            this.pictureBox1.Location = new System.Drawing.Point(76, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(76, 416);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 42);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonThrowItBack
            // 
            this.buttonThrowItBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThrowItBack.Location = new System.Drawing.Point(248, 416);
            this.buttonThrowItBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThrowItBack.Name = "buttonThrowItBack";
            this.buttonThrowItBack.Size = new System.Drawing.Size(157, 42);
            this.buttonThrowItBack.TabIndex = 2;
            this.buttonThrowItBack.Text = "Throw It Back";
            this.buttonThrowItBack.UseVisualStyleBackColor = true;
            // 
            // buttonKeepIt
            // 
            this.buttonKeepIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeepIt.Location = new System.Drawing.Point(464, 416);
            this.buttonKeepIt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeepIt.Name = "buttonKeepIt";
            this.buttonKeepIt.Size = new System.Drawing.Size(100, 42);
            this.buttonKeepIt.TabIndex = 3;
            this.buttonKeepIt.Text = "Keep It";
            this.buttonKeepIt.UseVisualStyleBackColor = true;
            // 
            // FormSeeFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 506);
            this.Controls.Add(this.buttonKeepIt);
            this.Controls.Add(this.buttonThrowItBack);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSeeFish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keep it or let it go";
            this.Load += new System.EventHandler(this.FormSeeFish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonThrowItBack;
        private System.Windows.Forms.Button buttonKeepIt;
    }
}