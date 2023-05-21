namespace Wuzzuf
{
    partial class SignIn
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
            this.label7 = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employerRB = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.signBtn = new System.Windows.Forms.Button();
            this.show_hide_btn = new System.Windows.Forms.Button();
            this.sign_up_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(232, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Email";
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(412, 123);
            this.userEmail.Margin = new System.Windows.Forms.Padding(4);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(365, 22);
            this.userEmail.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(232, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Password";
            // 
            // userPass
            // 
            this.userPass.Location = new System.Drawing.Point(412, 202);
            this.userPass.Margin = new System.Windows.Forms.Padding(4);
            this.userPass.Name = "userPass";
            this.userPass.Size = new System.Drawing.Size(365, 22);
            this.userPass.TabIndex = 19;
            this.userPass.UseSystemPasswordChar = true;
            this.userPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 282);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "You are:";
            // 
            // employerRB
            // 
            this.employerRB.AutoSize = true;
            this.employerRB.Checked = true;
            this.employerRB.Location = new System.Drawing.Point(408, 282);
            this.employerRB.Margin = new System.Windows.Forms.Padding(4);
            this.employerRB.Name = "employerRB";
            this.employerRB.Size = new System.Drawing.Size(105, 20);
            this.employerRB.TabIndex = 22;
            this.employerRB.TabStop = true;
            this.employerRB.Text = "An Employer";
            this.employerRB.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(604, 280);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 20);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "A seeker";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // signBtn
            // 
            this.signBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signBtn.Location = new System.Drawing.Point(486, 345);
            this.signBtn.Margin = new System.Windows.Forms.Padding(4);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(114, 50);
            this.signBtn.TabIndex = 24;
            this.signBtn.Text = "Sign in";
            this.signBtn.UseVisualStyleBackColor = true;
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // show_hide_btn
            // 
            this.show_hide_btn.Location = new System.Drawing.Point(804, 201);
            this.show_hide_btn.Name = "show_hide_btn";
            this.show_hide_btn.Size = new System.Drawing.Size(129, 26);
            this.show_hide_btn.TabIndex = 25;
            this.show_hide_btn.Text = "Show / HIde";
            this.show_hide_btn.UseVisualStyleBackColor = true;
            this.show_hide_btn.Click += new System.EventHandler(this.show_hide_btn_Click);
            // 
            // sign_up_btn
            // 
            this.sign_up_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up_btn.Location = new System.Drawing.Point(585, 485);
            this.sign_up_btn.Name = "sign_up_btn";
            this.sign_up_btn.Size = new System.Drawing.Size(101, 36);
            this.sign_up_btn.TabIndex = 26;
            this.sign_up_btn.Text = "Sign Up";
            this.sign_up_btn.UseVisualStyleBackColor = true;
            this.sign_up_btn.Click += new System.EventHandler(this.sign_up_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Don\'t have an account ?";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sign_up_btn);
            this.Controls.Add(this.show_hide_btn);
            this.Controls.Add(this.signBtn);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.employerRB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userEmail);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignIn_FormClosing);
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton employerRB;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Button show_hide_btn;
        private System.Windows.Forms.Button sign_up_btn;
        private System.Windows.Forms.Label label3;
    }
}