namespace WindowsFormsApp
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
            this.home_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.search_button = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.favorite_words_panel = new System.Windows.Forms.Panel();
            this.favorite_words_label = new System.Windows.Forms.TextBox();
            this.favorite_words_box = new System.Windows.Forms.TextBox();
            this.top_panel.SuspendLayout();
            this.favorite_words_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // home_button
            // 
            this.home_button.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button.Image = ((System.Drawing.Image)(resources.GetObject("home_button.Image")));
            this.home_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_button.Location = new System.Drawing.Point(12, 7);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(114, 36);
            this.home_button.TabIndex = 0;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.home_button.UseVisualStyleBackColor = true;
            // 
            // history_button
            // 
            this.history_button.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_button.Image = ((System.Drawing.Image)(resources.GetObject("history_button.Image")));
            this.history_button.Location = new System.Drawing.Point(735, 15);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(39, 35);
            this.history_button.TabIndex = 1;
            this.history_button.UseVisualStyleBackColor = true;
            this.history_button.Click += new System.EventHandler(this.history_button_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.top_panel.Controls.Add(this.history_button);
            this.top_panel.Location = new System.Drawing.Point(-2, -3);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(799, 62);
            this.top_panel.TabIndex = 2;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.search_button.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Image = ((System.Drawing.Image)(resources.GetObject("search_button.Image")));
            this.search_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_button.Location = new System.Drawing.Point(41, 98);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(122, 39);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "Search";
            this.search_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_button.UseVisualStyleBackColor = false;
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_box.Location = new System.Drawing.Point(160, 103);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(589, 32);
            this.search_box.TabIndex = 4;
            // 
            // favorite_words_panel
            // 
            this.favorite_words_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.favorite_words_panel.Controls.Add(this.favorite_words_box);
            this.favorite_words_panel.Location = new System.Drawing.Point(41, 196);
            this.favorite_words_panel.Name = "favorite_words_panel";
            this.favorite_words_panel.Size = new System.Drawing.Size(708, 269);
            this.favorite_words_panel.TabIndex = 5;
            this.favorite_words_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.favorite_words_panel_Paint);
            // 
            // favorite_words_label
            // 
            this.favorite_words_label.Enabled = false;
            this.favorite_words_label.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorite_words_label.Location = new System.Drawing.Point(41, 162);
            this.favorite_words_label.Name = "favorite_words_label";
            this.favorite_words_label.Size = new System.Drawing.Size(708, 34);
            this.favorite_words_label.TabIndex = 0;
            this.favorite_words_label.Text = "Favorite Words";
            this.favorite_words_label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // favorite_words_box
            // 
            this.favorite_words_box.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorite_words_box.Location = new System.Drawing.Point(-1, -1);
            this.favorite_words_box.Name = "favorite_words_box";
            this.favorite_words_box.Size = new System.Drawing.Size(708, 46);
            this.favorite_words_box.TabIndex = 0;
            this.favorite_words_box.TextChanged += new System.EventHandler(this.favorite_words_box_TextChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.favorite_words_label);
            this.Controls.Add(this.favorite_words_panel);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.top_panel);
            this.Name = "Home";
            this.Text = "Home";
            this.top_panel.ResumeLayout(false);
            this.favorite_words_panel.ResumeLayout(false);
            this.favorite_words_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Panel favorite_words_panel;
        private System.Windows.Forms.TextBox favorite_words_label;
        private System.Windows.Forms.TextBox favorite_words_box;
    }
}

