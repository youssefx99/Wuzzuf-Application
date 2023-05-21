namespace Wuzzuf.Job_Search
{
    partial class search
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
            this.label1 = new System.Windows.Forms.Label();
            this.chosen_keyword = new System.Windows.Forms.ComboBox();
            this.posts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.chosen_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.IsIntern = new System.Windows.Forms.CheckBox();
            this.Back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.posts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a keyword to search with";
            // 
            // chosen_keyword
            // 
            this.chosen_keyword.FormattingEnabled = true;
            this.chosen_keyword.Location = new System.Drawing.Point(474, 66);
            this.chosen_keyword.Name = "chosen_keyword";
            this.chosen_keyword.Size = new System.Drawing.Size(138, 24);
            this.chosen_keyword.TabIndex = 3;
            // 
            // posts
            // 
            this.posts.AllowUserToAddRows = false;
            this.posts.AllowUserToDeleteRows = false;
            this.posts.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.posts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posts.Location = new System.Drawing.Point(178, 108);
            this.posts.Name = "posts";
            this.posts.ReadOnly = true;
            this.posts.RowHeadersWidth = 51;
            this.posts.Size = new System.Drawing.Size(672, 551);
            this.posts.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Show job/intern number:";
            // 
            // chosen_id
            // 
            this.chosen_id.Location = new System.Drawing.Point(540, 686);
            this.chosen_id.Name = "chosen_id";
            this.chosen_id.Size = new System.Drawing.Size(85, 22);
            this.chosen_id.TabIndex = 6;
            this.chosen_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(652, 681);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(867, 108);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(89, 62);
            this.SearchBtn.TabIndex = 10;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // IsIntern
            // 
            this.IsIntern.AutoSize = true;
            this.IsIntern.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsIntern.Location = new System.Drawing.Point(740, 66);
            this.IsIntern.Name = "IsIntern";
            this.IsIntern.Size = new System.Drawing.Size(110, 26);
            this.IsIntern.TabIndex = 11;
            this.IsIntern.Text = "Internship";
            this.IsIntern.UseVisualStyleBackColor = true;
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(12, 12);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(89, 31);
            this.Back_btn.TabIndex = 13;
            this.Back_btn.Text = "Back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1025, 746);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.IsIntern);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chosen_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.posts);
            this.Controls.Add(this.chosen_keyword);
            this.Controls.Add(this.label1);
            this.Name = "search";
            this.Text = "choose_keywords";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.choose_keywords_FormClosing);
            this.Load += new System.EventHandler(this.choose_keywords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox chosen_keyword;
        private System.Windows.Forms.DataGridView posts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox chosen_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.CheckBox IsIntern;
        private System.Windows.Forms.Button Back_btn;
    }
}