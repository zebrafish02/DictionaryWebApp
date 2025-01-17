namespace WindowsFormsApp
{
    partial class Definition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Definition));
            this.home_button = new System.Windows.Forms.Button();
            this.history_button = new System.Windows.Forms.Button();
            this.top_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.word_box = new System.Windows.Forms.TextBox();
            this.favorite_button = new System.Windows.Forms.Button();
            this.definition_box = new System.Windows.Forms.TextBox();
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
            this.top_panel.Controls.Add(this.button1);
            this.top_panel.Location = new System.Drawing.Point(-2, -3);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(799, 62);
            this.top_panel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(735, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 35);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
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
            this.search_button.TabIndex = 4;
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
            this.search_box.TabIndex = 5;
            // 
            // word_box
            // 
            this.word_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.word_box.Enabled = false;
            this.word_box.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word_box.Location = new System.Drawing.Point(41, 164);
            this.word_box.Name = "word_box";
            this.word_box.Size = new System.Drawing.Size(708, 28);
            this.word_box.TabIndex = 6;
            // 
            // favorite_button
            // 
            this.favorite_button.Image = ((System.Drawing.Image)(resources.GetObject("favorite_button.Image")));
            this.favorite_button.Location = new System.Drawing.Point(715, 158);
            this.favorite_button.Name = "favorite_button";
            this.favorite_button.Size = new System.Drawing.Size(34, 34);
            this.favorite_button.TabIndex = 7;
            this.favorite_button.UseVisualStyleBackColor = true;
            // 
            // definition_box
            // 
            this.definition_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.definition_box.Enabled = false;
            this.definition_box.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.definition_box.ForeColor = System.Drawing.SystemColors.WindowText;
            this.definition_box.Location = new System.Drawing.Point(41, 211);
            this.definition_box.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.definition_box.Name = "definition_box";
            this.definition_box.Size = new System.Drawing.Size(708, 22);
            this.definition_box.TabIndex = 8;
            // 
            // Definition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.definition_box);
            this.Controls.Add(this.favorite_button);
            this.Controls.Add(this.word_box);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.history_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.top_panel);
            this.Name = "Definition";
            this.Text = "Definition";
            this.top_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button history_button;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.TextBox word_box;
        private System.Windows.Forms.Button favorite_button;
        private System.Windows.Forms.TextBox definition_box;
    }
}