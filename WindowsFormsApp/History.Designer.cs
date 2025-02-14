namespace WindowsFormsApp
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.home_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.history_box = new System.Windows.Forms.TextBox();
            this.clear_hist_button = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
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
            this.home_button.TabIndex = 1;
            this.home_button.Text = "Home";
            this.home_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // history_button
            // 
            this.history_button.Image = ((System.Drawing.Image)(resources.GetObject("history_button.Image")));
            this.history_button.Location = new System.Drawing.Point(735, 15);
            this.history_button.Name = "history_button";
            this.history_button.Size = new System.Drawing.Size(39, 35);
            this.history_button.TabIndex = 2;
            this.history_button.UseVisualStyleBackColor = true;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.top_panel.Controls.Add(this.history_button);
            this.top_panel.Location = new System.Drawing.Point(-2, -3);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(799, 62);
            this.top_panel.TabIndex = 3;
            // 
            // history_box
            // 
            this.history_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history_box.Enabled = false;
            this.history_box.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history_box.Location = new System.Drawing.Point(37, 98);
            this.history_box.Multiline = true;
            this.history_box.Name = "history_box";
            this.history_box.Size = new System.Drawing.Size(720, 394);
            this.history_box.TabIndex = 4;
            // 
            // clear_hist_button
            // 
            this.clear_hist_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_hist_button.Location = new System.Drawing.Point(24, 514);
            this.clear_hist_button.Name = "clear_hist_button";
            this.clear_hist_button.Size = new System.Drawing.Size(75, 23);
            this.clear_hist_button.TabIndex = 5;
            this.clear_hist_button.Text = "Clear History";
            this.clear_hist_button.UseVisualStyleBackColor = true;
            this.clear_hist_button.Click += new System.EventHandler(this.clear_hist_button_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.clear_hist_button);
            this.Controls.Add(this.history_box);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.top_panel);
            this.Name = "History";
            this.Text = "History";
            this.top_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.TextBox history_box;
        private System.Windows.Forms.Button clear_hist_button;
    }
}