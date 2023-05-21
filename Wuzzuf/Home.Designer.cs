namespace Wuzzuf
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.SignInOption = new System.Windows.Forms.Button();
            this.SignUpOption = new System.Windows.Forms.Button();
            this.statis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignInOption
            // 
            this.SignInOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInOption.Location = new System.Drawing.Point(561, 303);
            this.SignInOption.Margin = new System.Windows.Forms.Padding(4);
            this.SignInOption.Name = "SignInOption";
            this.SignInOption.Size = new System.Drawing.Size(159, 60);
            this.SignInOption.TabIndex = 0;
            this.SignInOption.Text = "Sign in";
            this.SignInOption.UseVisualStyleBackColor = true;
            this.SignInOption.Click += new System.EventHandler(this.SignInOption_Click);
            // 
            // SignUpOption
            // 
            this.SignUpOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpOption.Location = new System.Drawing.Point(221, 303);
            this.SignUpOption.Margin = new System.Windows.Forms.Padding(4);
            this.SignUpOption.Name = "SignUpOption";
            this.SignUpOption.Size = new System.Drawing.Size(159, 60);
            this.SignUpOption.TabIndex = 1;
            this.SignUpOption.Text = "Sign up";
            this.SignUpOption.UseVisualStyleBackColor = true;
            this.SignUpOption.Click += new System.EventHandler(this.SignUpOption_Click);
            // 
            // statis
            // 
            this.statis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statis.Location = new System.Drawing.Point(221, 426);
            this.statis.Margin = new System.Windows.Forms.Padding(4);
            this.statis.Name = "statis";
            this.statis.Size = new System.Drawing.Size(179, 48);
            this.statis.TabIndex = 2;
            this.statis.Text = "Salaries Report";
            this.statis.UseVisualStyleBackColor = true;
            this.statis.Click += new System.EventHandler(this.statis_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(541, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Statistics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statis);
            this.Controls.Add(this.SignUpOption);
            this.Controls.Add(this.SignInOption);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SignInOption;
        private System.Windows.Forms.Button SignUpOption;
        private System.Windows.Forms.Button statis;
        private System.Windows.Forms.Button button1;
    }
}

