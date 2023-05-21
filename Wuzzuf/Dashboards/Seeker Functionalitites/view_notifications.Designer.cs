namespace Wuzzuf.Dashboards.Seeker_Functionalitites
{
    partial class view_notifications
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
            this.notifications_grid_view = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.notifications_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // notifications_grid_view
            // 
            this.notifications_grid_view.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.notifications_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notifications_grid_view.Location = new System.Drawing.Point(12, 51);
            this.notifications_grid_view.Name = "notifications_grid_view";
            this.notifications_grid_view.RowHeadersWidth = 51;
            this.notifications_grid_view.RowTemplate.Height = 24;
            this.notifications_grid_view.Size = new System.Drawing.Size(1073, 496);
            this.notifications_grid_view.TabIndex = 0;
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(112, 33);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // view_notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1097, 570);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.notifications_grid_view);
            this.Name = "view_notifications";
            this.Text = "view_notifications";
            this.Load += new System.EventHandler(this.view_notifications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.notifications_grid_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView notifications_grid_view;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button back_btn;
    }
}