namespace ScriptHelper
{
    partial class Form1
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
            this.Movie = new System.Windows.Forms.TabControl();
            this.MovieTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.ScenesList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieHintText = new System.Windows.Forms.TextBox();
            this.ScenesTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CharactersTab = new System.Windows.Forms.TabPage();
            this.Settings = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.Movie.SuspendLayout();
            this.MovieTab.SuspendLayout();
            this.ScenesTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Movie
            // 
            this.Movie.Controls.Add(this.MovieTab);
            this.Movie.Controls.Add(this.ScenesTab);
            this.Movie.Controls.Add(this.CharactersTab);
            this.Movie.Controls.Add(this.Settings);
            this.Movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie.Location = new System.Drawing.Point(44, 24);
            this.Movie.Name = "Movie";
            this.Movie.SelectedIndex = 0;
            this.Movie.Size = new System.Drawing.Size(1131, 619);
            this.Movie.TabIndex = 0;
            // 
            // MovieTab
            // 
            this.MovieTab.Controls.Add(this.label3);
            this.MovieTab.Controls.Add(this.ScenesList);
            this.MovieTab.Controls.Add(this.button1);
            this.MovieTab.Controls.Add(this.label2);
            this.MovieTab.Controls.Add(this.MovieText);
            this.MovieTab.Controls.Add(this.label1);
            this.MovieTab.Controls.Add(this.MovieHintText);
            this.MovieTab.Location = new System.Drawing.Point(4, 40);
            this.MovieTab.Name = "MovieTab";
            this.MovieTab.Padding = new System.Windows.Forms.Padding(3);
            this.MovieTab.Size = new System.Drawing.Size(1123, 575);
            this.MovieTab.TabIndex = 0;
            this.MovieTab.Text = "Movie";
            this.MovieTab.UseVisualStyleBackColor = true;
            this.MovieTab.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scenes";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // ScenesList
            // 
            this.ScenesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScenesList.FormattingEnabled = true;
            this.ScenesList.ItemHeight = 20;
            this.ScenesList.Location = new System.Drawing.Point(24, 55);
            this.ScenesList.Name = "ScenesList";
            this.ScenesList.Size = new System.Drawing.Size(183, 404);
            this.ScenesList.TabIndex = 5;
            this.ScenesList.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(561, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Make Movie Text                                                                  " +
    "                                                                                " +
    "    ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movie Text";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // MovieText
            // 
            this.MovieText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieText.Location = new System.Drawing.Point(561, 273);
            this.MovieText.Multiline = true;
            this.MovieText.Name = "MovieText";
            this.MovieText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MovieText.Size = new System.Drawing.Size(538, 251);
            this.MovieText.TabIndex = 2;
            this.MovieText.TextChanged += new System.EventHandler(this.MovieHintText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(551, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Text Hints";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // MovieHintText
            // 
            this.MovieHintText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieHintText.Location = new System.Drawing.Point(555, 36);
            this.MovieHintText.Multiline = true;
            this.MovieHintText.Name = "MovieHintText";
            this.MovieHintText.Size = new System.Drawing.Size(545, 153);
            this.MovieHintText.TabIndex = 0;
            this.MovieHintText.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ScenesTab
            // 
            this.ScenesTab.Controls.Add(this.tabControl1);
            this.ScenesTab.Location = new System.Drawing.Point(4, 40);
            this.ScenesTab.Name = "ScenesTab";
            this.ScenesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ScenesTab.Size = new System.Drawing.Size(1123, 575);
            this.ScenesTab.TabIndex = 1;
            this.ScenesTab.Text = "Scenes";
            this.ScenesTab.UseVisualStyleBackColor = true;
            this.ScenesTab.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(385, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(0, 0);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(0, 0);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CharactersTab
            // 
            this.CharactersTab.Location = new System.Drawing.Point(4, 40);
            this.CharactersTab.Name = "CharactersTab";
            this.CharactersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CharactersTab.Size = new System.Drawing.Size(1123, 575);
            this.CharactersTab.TabIndex = 2;
            this.CharactersTab.Text = "Characters";
            this.CharactersTab.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 40);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(1123, 575);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(48, 662);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 42);
            this.button3.TabIndex = 1;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 730);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Movie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Movie.ResumeLayout(false);
            this.MovieTab.ResumeLayout(false);
            this.MovieTab.PerformLayout();
            this.ScenesTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Movie;
        private System.Windows.Forms.TabPage MovieTab;
        private System.Windows.Forms.TabPage ScenesTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage CharactersTab;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TextBox MovieHintText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MovieText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox ScenesList;
        private System.Windows.Forms.Label label3;
    }
}

