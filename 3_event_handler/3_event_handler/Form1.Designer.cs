
namespace _3_event_handler
{
    partial class Form1
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
            this.num_1 = new System.Windows.Forms.TextBox();
            this.num_2 = new System.Windows.Forms.TextBox();
            this.do_sum = new System.Windows.Forms.Button();
            this.sum_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // num_1
            // 
            this.num_1.Location = new System.Drawing.Point(40, 39);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(125, 27);
            this.num_1.TabIndex = 0;
            // 
            // num_2
            // 
            this.num_2.Location = new System.Drawing.Point(171, 38);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(125, 27);
            this.num_2.TabIndex = 1;
            // 
            // do_sum
            // 
            this.do_sum.Location = new System.Drawing.Point(302, 38);
            this.do_sum.Name = "do_sum";
            this.do_sum.Size = new System.Drawing.Size(94, 29);
            this.do_sum.TabIndex = 2;
            this.do_sum.Text = "=";
            this.do_sum.UseMnemonic = false;
            this.do_sum.UseVisualStyleBackColor = true;
            this.do_sum.Click += new System.EventHandler(this.do_sum_Click);
            // 
            // sum_result
            // 
            this.sum_result.Location = new System.Drawing.Point(402, 38);
            this.sum_result.Name = "sum_result";
            this.sum_result.Size = new System.Drawing.Size(125, 27);
            this.sum_result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 320);
            this.Controls.Add(this.sum_result);
            this.Controls.Add(this.do_sum);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.num_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num_1;
        private System.Windows.Forms.TextBox num_2;
        private System.Windows.Forms.Button do_sum;
        private System.Windows.Forms.TextBox sum_result;
    }
}

