namespace Wuzzuf
{
    partial class view_applications
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
            this.applications_gridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.show_btn = new System.Windows.Forms.Button();
            this.PID_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.applications_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // applications_gridView
            // 
            this.applications_gridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.applications_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applications_gridView.Location = new System.Drawing.Point(12, 24);
            this.applications_gridView.Name = "applications_gridView";
            this.applications_gridView.RowHeadersWidth = 51;
            this.applications_gridView.RowTemplate.Height = 24;
            this.applications_gridView.Size = new System.Drawing.Size(1233, 542);
            this.applications_gridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Applicant ID to show their application :";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(632, 594);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(75, 22);
            this.id_txt.TabIndex = 2;
            // 
            // show_btn
            // 
            this.show_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(749, 590);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(85, 63);
            this.show_btn.TabIndex = 3;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // PID_txt
            // 
            this.PID_txt.Location = new System.Drawing.Point(632, 629);
            this.PID_txt.Name = "PID_txt";
            this.PID_txt.Size = new System.Drawing.Size(75, 22);
            this.PID_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(379, 627);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Job / Intern ID :";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(37, 605);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(100, 32);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // view_applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1257, 669);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.PID_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applications_gridView);
            this.Name = "view_applications";
            this.Text = "view_applications";
            this.Load += new System.EventHandler(this.view_applications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applications_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView applications_gridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.TextBox PID_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_btn;
    }
}