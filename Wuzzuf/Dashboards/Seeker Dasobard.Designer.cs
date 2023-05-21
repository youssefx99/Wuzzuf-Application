namespace Wuzzuf
{
    partial class Seeker_Dasobard
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
            this.search_btn = new System.Windows.Forms.Button();
            this.notifications_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(255, 248);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(232, 76);
            this.search_btn.TabIndex = 1;
            this.search_btn.Text = "Search For Jobs";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // notifications_btn
            // 
            this.notifications_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifications_btn.Location = new System.Drawing.Point(603, 248);
            this.notifications_btn.Margin = new System.Windows.Forms.Padding(4);
            this.notifications_btn.Name = "notifications_btn";
            this.notifications_btn.Size = new System.Drawing.Size(232, 76);
            this.notifications_btn.TabIndex = 2;
            this.notifications_btn.Text = "Notifications";
            this.notifications_btn.UseVisualStyleBackColor = true;
            this.notifications_btn.Click += new System.EventHandler(this.notifications_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(603, 402);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(232, 76);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.Text = "Log out";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // profile_btn
            // 
            this.profile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_btn.Location = new System.Drawing.Point(255, 402);
            this.profile_btn.Margin = new System.Windows.Forms.Padding(4);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(232, 76);
            this.profile_btn.TabIndex = 4;
            this.profile_btn.Text = "My Profile";
            this.profile_btn.UseVisualStyleBackColor = true;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(293, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome,";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelname
            // 
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.ForeColor = System.Drawing.Color.White;
            this.labelname.Location = new System.Drawing.Point(512, 125);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(142, 60);
            this.labelname.TabIndex = 6;
            this.labelname.Text = "name";
            // 
            // Seeker_Dasobard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1067, 661);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profile_btn);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.notifications_btn);
            this.Controls.Add(this.search_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Seeker_Dasobard";
            this.Text = "Seeker_Dasobard";
            this.Load += new System.EventHandler(this.Seeker_Dasobard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button notifications_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelname;
    }
}