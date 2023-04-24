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
            this.label5 = new System.Windows.Forms.Label();
            this.SceneDescriptions = new System.Windows.Forms.TextBox();
            this.SceneCount = new System.Windows.Forms.NumericUpDown();
            this.MakeSceneList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MovieTextCompiled = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ScenesList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieHintText = new System.Windows.Forms.TextBox();
            this.ScenesTab = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.SceneText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SceneHint = new System.Windows.Forms.TextBox();
            this.SceneInScenesList = new System.Windows.Forms.ListBox();
            this.CharactersTab = new System.Windows.Forms.TabPage();
            this.Locations = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SelectGPT35 = new System.Windows.Forms.RadioButton();
            this.SelectGPT4 = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.MovieTitle = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.Parameters = new System.Windows.Forms.TabPage();
            this.SentencesInSceneHint = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Movie.SuspendLayout();
            this.MovieTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SceneCount)).BeginInit();
            this.ScenesTab.SuspendLayout();
            this.Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SentencesInSceneHint)).BeginInit();
            this.SuspendLayout();
            // 
            // Movie
            // 
            this.Movie.Controls.Add(this.MovieTab);
            this.Movie.Controls.Add(this.ScenesTab);
            this.Movie.Controls.Add(this.CharactersTab);
            this.Movie.Controls.Add(this.Locations);
            this.Movie.Controls.Add(this.Parameters);
            this.Movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie.Location = new System.Drawing.Point(44, 24);
            this.Movie.Name = "Movie";
            this.Movie.SelectedIndex = 0;
            this.Movie.Size = new System.Drawing.Size(1780, 619);
            this.Movie.TabIndex = 0;
            // 
            // MovieTab
            // 
            this.MovieTab.Controls.Add(this.label5);
            this.MovieTab.Controls.Add(this.SceneDescriptions);
            this.MovieTab.Controls.Add(this.SceneCount);
            this.MovieTab.Controls.Add(this.MakeSceneList);
            this.MovieTab.Controls.Add(this.label4);
            this.MovieTab.Controls.Add(this.MovieTextCompiled);
            this.MovieTab.Controls.Add(this.button2);
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
            this.MovieTab.Size = new System.Drawing.Size(1772, 575);
            this.MovieTab.TabIndex = 0;
            this.MovieTab.Text = "Movie";
            this.MovieTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Screen Descriptions";
            // 
            // SceneDescriptions
            // 
            this.SceneDescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneDescriptions.Location = new System.Drawing.Point(231, 299);
            this.SceneDescriptions.Multiline = true;
            this.SceneDescriptions.Name = "SceneDescriptions";
            this.SceneDescriptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SceneDescriptions.Size = new System.Drawing.Size(289, 253);
            this.SceneDescriptions.TabIndex = 14;
            // 
            // SceneCount
            // 
            this.SceneCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneCount.Location = new System.Drawing.Point(24, 535);
            this.SceneCount.Name = "SceneCount";
            this.SceneCount.Size = new System.Drawing.Size(69, 29);
            this.SceneCount.TabIndex = 13;
            this.SceneCount.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // MakeSceneList
            // 
            this.MakeSceneList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeSceneList.Location = new System.Drawing.Point(24, 484);
            this.MakeSceneList.Name = "MakeSceneList";
            this.MakeSceneList.Size = new System.Drawing.Size(183, 40);
            this.MakeSceneList.TabIndex = 12;
            this.MakeSceneList.Text = "Make Scenes";
            this.MakeSceneList.UseVisualStyleBackColor = true;
            this.MakeSceneList.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Compiled Text";
            // 
            // MovieTextCompiled
            // 
            this.MovieTextCompiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTextCompiled.Location = new System.Drawing.Point(231, 55);
            this.MovieTextCompiled.Multiline = true;
            this.MovieTextCompiled.Name = "MovieTextCompiled";
            this.MovieTextCompiled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MovieTextCompiled.Size = new System.Drawing.Size(291, 197);
            this.MovieTextCompiled.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(561, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Compile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.MovieText.Size = new System.Drawing.Size(513, 251);
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
            this.MovieHintText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MovieHintText.Size = new System.Drawing.Size(519, 153);
            this.MovieHintText.TabIndex = 0;
            this.MovieHintText.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ScenesTab
            // 
            this.ScenesTab.Controls.Add(this.button6);
            this.ScenesTab.Controls.Add(this.SceneText);
            this.ScenesTab.Controls.Add(this.label6);
            this.ScenesTab.Controls.Add(this.SceneHint);
            this.ScenesTab.Controls.Add(this.SceneInScenesList);
            this.ScenesTab.Location = new System.Drawing.Point(4, 40);
            this.ScenesTab.Name = "ScenesTab";
            this.ScenesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ScenesTab.Size = new System.Drawing.Size(1123, 575);
            this.ScenesTab.TabIndex = 1;
            this.ScenesTab.Text = "Scenes";
            this.ScenesTab.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(579, 194);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(218, 39);
            this.button6.TabIndex = 4;
            this.button6.Text = "Make Scene Text";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // SceneText
            // 
            this.SceneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneText.Location = new System.Drawing.Point(579, 290);
            this.SceneText.Multiline = true;
            this.SceneText.Name = "SceneText";
            this.SceneText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SceneText.Size = new System.Drawing.Size(385, 227);
            this.SceneText.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(582, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Scene Hint";
            // 
            // SceneHint
            // 
            this.SceneHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneHint.Location = new System.Drawing.Point(577, 38);
            this.SceneHint.Multiline = true;
            this.SceneHint.Name = "SceneHint";
            this.SceneHint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SceneHint.Size = new System.Drawing.Size(379, 150);
            this.SceneHint.TabIndex = 1;
            this.SceneHint.TextChanged += new System.EventHandler(this.SceneHint_TextChanged);
            // 
            // SceneInScenesList
            // 
            this.SceneInScenesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneInScenesList.FormattingEnabled = true;
            this.SceneInScenesList.ItemHeight = 20;
            this.SceneInScenesList.Location = new System.Drawing.Point(24, 18);
            this.SceneInScenesList.Name = "SceneInScenesList";
            this.SceneInScenesList.Size = new System.Drawing.Size(220, 404);
            this.SceneInScenesList.TabIndex = 0;
            this.SceneInScenesList.SelectedIndexChanged += new System.EventHandler(this.SceneInScenesList_SelectedIndexChanged);
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
            // Locations
            // 
            this.Locations.Location = new System.Drawing.Point(4, 40);
            this.Locations.Name = "Locations";
            this.Locations.Padding = new System.Windows.Forms.Padding(3);
            this.Locations.Size = new System.Drawing.Size(1123, 575);
            this.Locations.TabIndex = 3;
            this.Locations.Text = "Locations";
            this.Locations.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1052, 662);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 45);
            this.button4.TabIndex = 9;
            this.button4.Text = "New Movie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // SelectGPT35
            // 
            this.SelectGPT35.AutoSize = true;
            this.SelectGPT35.Checked = true;
            this.SelectGPT35.Location = new System.Drawing.Point(182, 667);
            this.SelectGPT35.Name = "SelectGPT35";
            this.SelectGPT35.Size = new System.Drawing.Size(96, 17);
            this.SelectGPT35.TabIndex = 2;
            this.SelectGPT35.TabStop = true;
            this.SelectGPT35.Text = "GPT 3.5 Turbo";
            this.SelectGPT35.UseVisualStyleBackColor = true;
            this.SelectGPT35.CheckedChanged += new System.EventHandler(this.SelectGPT35_CheckedChanged);
            // 
            // SelectGPT4
            // 
            this.SelectGPT4.AutoSize = true;
            this.SelectGPT4.Location = new System.Drawing.Point(182, 690);
            this.SelectGPT4.Name = "SelectGPT4";
            this.SelectGPT4.Size = new System.Drawing.Size(56, 17);
            this.SelectGPT4.TabIndex = 3;
            this.SelectGPT4.Text = "GPT-4";
            this.SelectGPT4.UseVisualStyleBackColor = true;
            this.SelectGPT4.CheckedChanged += new System.EventHandler(this.SelectGPT4_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(305, 662);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 44);
            this.button7.TabIndex = 10;
            this.button7.Text = "Make Title";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MovieTitle
            // 
            this.MovieTitle.AutoSize = true;
            this.MovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitle.Location = new System.Drawing.Point(459, 670);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(46, 20);
            this.MovieTitle.TabIndex = 11;
            this.MovieTitle.Text = "Title: ";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage.Location = new System.Drawing.Point(57, 725);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(26, 24);
            this.ErrorMessage.TabIndex = 12;
            this.ErrorMessage.Text = "\"\"";
            // 
            // Parameters
            // 
            this.Parameters.Controls.Add(this.label7);
            this.Parameters.Controls.Add(this.SentencesInSceneHint);
            this.Parameters.Location = new System.Drawing.Point(4, 40);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(1123, 575);
            this.Parameters.TabIndex = 5;
            this.Parameters.Text = "Parameters";
            this.Parameters.UseVisualStyleBackColor = true;
            // 
            // SentencesInSceneHint
            // 
            this.SentencesInSceneHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentencesInSceneHint.Location = new System.Drawing.Point(26, 32);
            this.SentencesInSceneHint.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SentencesInSceneHint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SentencesInSceneHint.Name = "SentencesInSceneHint";
            this.SentencesInSceneHint.Size = new System.Drawing.Size(29, 26);
            this.SentencesInSceneHint.TabIndex = 0;
            this.SentencesInSceneHint.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sentences in Scene Hints";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 752);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.SelectGPT4);
            this.Controls.Add(this.SelectGPT35);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Movie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Movie.ResumeLayout(false);
            this.MovieTab.ResumeLayout(false);
            this.MovieTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SceneCount)).EndInit();
            this.ScenesTab.ResumeLayout(false);
            this.ScenesTab.PerformLayout();
            this.Parameters.ResumeLayout(false);
            this.Parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SentencesInSceneHint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Movie;
        private System.Windows.Forms.TabPage MovieTab;
        private System.Windows.Forms.TabPage ScenesTab;
        private System.Windows.Forms.TabPage CharactersTab;
        private System.Windows.Forms.TabPage Locations;
        private System.Windows.Forms.TextBox MovieHintText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MovieText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox ScenesList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton SelectGPT35;
        private System.Windows.Forms.RadioButton SelectGPT4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MovieTextCompiled;
        private System.Windows.Forms.Button MakeSceneList;
        private System.Windows.Forms.NumericUpDown SceneCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SceneDescriptions;
        private System.Windows.Forms.ListBox SceneInScenesList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SceneHint;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox SceneText;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label MovieTitle;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.TabPage Parameters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown SentencesInSceneHint;
    }
}

