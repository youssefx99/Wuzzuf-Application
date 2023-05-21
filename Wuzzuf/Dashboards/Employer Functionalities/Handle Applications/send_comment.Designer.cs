namespace Wuzzuf.Dashboards.Employer_Functionalities.Handle_Applications
{
    partial class send_comment
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
            this.comment_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comment_txt
            // 
            this.comment_txt.Location = new System.Drawing.Point(62, 79);
            this.comment_txt.Multiline = true;
            this.comment_txt.Name = "comment_txt";
            this.comment_txt.Size = new System.Drawing.Size(436, 153);
            this.comment_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your comment (optional) :";
            // 
            // send_btn
            // 
            this.send_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_btn.Location = new System.Drawing.Point(213, 262);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(138, 37);
            this.send_btn.TabIndex = 2;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // send_comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(576, 326);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comment_txt);
            this.Name = "send_comment";
            this.Text = "send_comment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox comment_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button send_btn;
    }
}