
namespace hello_world_win_form
{
    partial class calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hello_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hello_label
            // 
            this.hello_label.AutoSize = true;
            this.hello_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hello_label.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hello_label.Location = new System.Drawing.Point(12, 20);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(130, 35);
            this.hello_label.TabIndex = 0;
            this.hello_label.Text = "Click Here";
            this.hello_label.Click += new System.EventHandler(this.hello_click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 259);
            this.Controls.Add(this.hello_label);
            this.Name = "calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello_label;
    }
}

