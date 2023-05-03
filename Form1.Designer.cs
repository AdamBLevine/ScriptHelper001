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
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SentencesInSceneHint = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.SceneDescriptions = new System.Windows.Forms.TextBox();
            this.SceneCount = new System.Windows.Forms.NumericUpDown();
            this.MakeSceneList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ScenesList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieHintText = new System.Windows.Forms.TextBox();
            this.ScenesTab = new System.Windows.Forms.TabPage();
            this.BeatSheetRichTextbox = new System.Windows.Forms.RichTextBox();
            this.SceneScriptRichTextbox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.WriteSceneBtn = new System.Windows.Forms.Button();
            this.MakeBeatSheet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SceneText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SceneHint = new System.Windows.Forms.TextBox();
            this.SceneInScenesList = new System.Windows.Forms.ListBox();
            this.CharactersTab = new System.Windows.Forms.TabPage();
            this.Locations = new System.Windows.Forms.TabPage();
            this.Parameters = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SelectGPT35 = new System.Windows.Forms.RadioButton();
            this.SelectGPT4 = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.MovieTitle = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.GPTError = new System.Windows.Forms.Label();
            this.Movie.SuspendLayout();
            this.MovieTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SentencesInSceneHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SceneCount)).BeginInit();
            this.ScenesTab.SuspendLayout();
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
            this.Movie.Location = new System.Drawing.Point(59, 30);
            this.Movie.Margin = new System.Windows.Forms.Padding(4);
            this.Movie.Name = "Movie";
            this.Movie.SelectedIndex = 0;
            this.Movie.Size = new System.Drawing.Size(2373, 762);
            this.Movie.TabIndex = 0;
            // 
            // MovieTab
            // 
            this.MovieTab.Controls.Add(this.button5);
            this.MovieTab.Controls.Add(this.label10);
            this.MovieTab.Controls.Add(this.label7);
            this.MovieTab.Controls.Add(this.SentencesInSceneHint);
            this.MovieTab.Controls.Add(this.label5);
            this.MovieTab.Controls.Add(this.SceneDescriptions);
            this.MovieTab.Controls.Add(this.SceneCount);
            this.MovieTab.Controls.Add(this.MakeSceneList);
            this.MovieTab.Controls.Add(this.label3);
            this.MovieTab.Controls.Add(this.ScenesList);
            this.MovieTab.Controls.Add(this.button1);
            this.MovieTab.Controls.Add(this.label2);
            this.MovieTab.Controls.Add(this.MovieText);
            this.MovieTab.Controls.Add(this.label1);
            this.MovieTab.Controls.Add(this.MovieHintText);
            this.MovieTab.Location = new System.Drawing.Point(4, 48);
            this.MovieTab.Margin = new System.Windows.Forms.Padding(4);
            this.MovieTab.Name = "MovieTab";
            this.MovieTab.Padding = new System.Windows.Forms.Padding(4);
            this.MovieTab.Size = new System.Drawing.Size(2365, 710);
            this.MovieTab.TabIndex = 0;
            this.MovieTab.Text = "Movie";
            this.MovieTab.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1486, 52);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(256, 100);
            this.button5.TabIndex = 19;
            this.button5.Text = "Test Label";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_3);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(132, 625);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "Scenes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(131, 665);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sentences";
            // 
            // SentencesInSceneHint
            // 
            this.SentencesInSceneHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentencesInSceneHint.Location = new System.Drawing.Point(32, 668);
            this.SentencesInSceneHint.Margin = new System.Windows.Forms.Padding(4);
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
            this.SentencesInSceneHint.Size = new System.Drawing.Size(92, 34);
            this.SentencesInSceneHint.TabIndex = 16;
            this.SentencesInSceneHint.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Screen Descriptions";
            // 
            // SceneDescriptions
            // 
            this.SceneDescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneDescriptions.Location = new System.Drawing.Point(317, 52);
            this.SceneDescriptions.Margin = new System.Windows.Forms.Padding(4);
            this.SceneDescriptions.Multiline = true;
            this.SceneDescriptions.Name = "SceneDescriptions";
            this.SceneDescriptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SceneDescriptions.Size = new System.Drawing.Size(384, 592);
            this.SceneDescriptions.TabIndex = 14;
            // 
            // SceneCount
            // 
            this.SceneCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneCount.Location = new System.Drawing.Point(32, 625);
            this.SceneCount.Margin = new System.Windows.Forms.Padding(4);
            this.SceneCount.Name = "SceneCount";
            this.SceneCount.Size = new System.Drawing.Size(92, 34);
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
            this.MakeSceneList.Location = new System.Drawing.Point(32, 572);
            this.MakeSceneList.Margin = new System.Windows.Forms.Padding(4);
            this.MakeSceneList.Name = "MakeSceneList";
            this.MakeSceneList.Size = new System.Drawing.Size(244, 49);
            this.MakeSceneList.TabIndex = 12;
            this.MakeSceneList.Text = "Make Scenes";
            this.MakeSceneList.UseVisualStyleBackColor = true;
            this.MakeSceneList.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scenes";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // ScenesList
            // 
            this.ScenesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScenesList.FormattingEnabled = true;
            this.ScenesList.ItemHeight = 25;
            this.ScenesList.Location = new System.Drawing.Point(32, 68);
            this.ScenesList.Margin = new System.Windows.Forms.Padding(4);
            this.ScenesList.Name = "ScenesList";
            this.ScenesList.Size = new System.Drawing.Size(243, 479);
            this.ScenesList.TabIndex = 5;
            this.ScenesList.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(748, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 38);
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
            this.label2.Location = new System.Drawing.Point(743, 303);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movie Text";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // MovieText
            // 
            this.MovieText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieText.Location = new System.Drawing.Point(748, 336);
            this.MovieText.Margin = new System.Windows.Forms.Padding(4);
            this.MovieText.Multiline = true;
            this.MovieText.Name = "MovieText";
            this.MovieText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MovieText.Size = new System.Drawing.Size(683, 308);
            this.MovieText.TabIndex = 2;
            this.MovieText.TextChanged += new System.EventHandler(this.MovieHintText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(735, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Text Hints";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // MovieHintText
            // 
            this.MovieHintText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieHintText.Location = new System.Drawing.Point(740, 44);
            this.MovieHintText.Margin = new System.Windows.Forms.Padding(4);
            this.MovieHintText.Multiline = true;
            this.MovieHintText.Name = "MovieHintText";
            this.MovieHintText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MovieHintText.Size = new System.Drawing.Size(691, 187);
            this.MovieHintText.TabIndex = 0;
            this.MovieHintText.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ScenesTab
            // 
            this.ScenesTab.Controls.Add(this.BeatSheetRichTextbox);
            this.ScenesTab.Controls.Add(this.SceneScriptRichTextbox);
            this.ScenesTab.Controls.Add(this.label9);
            this.ScenesTab.Controls.Add(this.WriteSceneBtn);
            this.ScenesTab.Controls.Add(this.MakeBeatSheet);
            this.ScenesTab.Controls.Add(this.label8);
            this.ScenesTab.Controls.Add(this.button6);
            this.ScenesTab.Controls.Add(this.SceneText);
            this.ScenesTab.Controls.Add(this.label6);
            this.ScenesTab.Controls.Add(this.SceneHint);
            this.ScenesTab.Controls.Add(this.SceneInScenesList);
            this.ScenesTab.Location = new System.Drawing.Point(4, 48);
            this.ScenesTab.Margin = new System.Windows.Forms.Padding(4);
            this.ScenesTab.Name = "ScenesTab";
            this.ScenesTab.Padding = new System.Windows.Forms.Padding(4);
            this.ScenesTab.Size = new System.Drawing.Size(2365, 710);
            this.ScenesTab.TabIndex = 1;
            this.ScenesTab.Text = "Scenes";
            this.ScenesTab.UseVisualStyleBackColor = true;
            // 
            // BeatSheetRichTextbox
            // 
            this.BeatSheetRichTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeatSheetRichTextbox.Location = new System.Drawing.Point(383, 48);
            this.BeatSheetRichTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.BeatSheetRichTextbox.Name = "BeatSheetRichTextbox";
            this.BeatSheetRichTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.BeatSheetRichTextbox.Size = new System.Drawing.Size(339, 585);
            this.BeatSheetRichTextbox.TabIndex = 12;
            this.BeatSheetRichTextbox.Text = "";
            // 
            // SceneScriptRichTextbox
            // 
            this.SceneScriptRichTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneScriptRichTextbox.Location = new System.Drawing.Point(1351, 48);
            this.SceneScriptRichTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.SceneScriptRichTextbox.Name = "SceneScriptRichTextbox";
            this.SceneScriptRichTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.SceneScriptRichTextbox.Size = new System.Drawing.Size(683, 586);
            this.SceneScriptRichTextbox.TabIndex = 11;
            this.SceneScriptRichTextbox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1355, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Scene Script";
            // 
            // WriteSceneBtn
            // 
            this.WriteSceneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteSceneBtn.Location = new System.Drawing.Point(1351, 647);
            this.WriteSceneBtn.Margin = new System.Windows.Forms.Padding(4);
            this.WriteSceneBtn.Name = "WriteSceneBtn";
            this.WriteSceneBtn.Size = new System.Drawing.Size(300, 47);
            this.WriteSceneBtn.TabIndex = 8;
            this.WriteSceneBtn.Text = "Write Scene";
            this.WriteSceneBtn.UseVisualStyleBackColor = true;
            this.WriteSceneBtn.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // MakeBeatSheet
            // 
            this.MakeBeatSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeBeatSheet.Location = new System.Drawing.Point(383, 641);
            this.MakeBeatSheet.Margin = new System.Windows.Forms.Padding(4);
            this.MakeBeatSheet.Name = "MakeBeatSheet";
            this.MakeBeatSheet.Size = new System.Drawing.Size(283, 52);
            this.MakeBeatSheet.TabIndex = 7;
            this.MakeBeatSheet.Text = "Make Beat Sheet";
            this.MakeBeatSheet.UseVisualStyleBackColor = true;
            this.MakeBeatSheet.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(379, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Beat Sheet";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(761, 643);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(291, 48);
            this.button6.TabIndex = 4;
            this.button6.Text = "Make Scene Text";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // SceneText
            // 
            this.SceneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneText.Location = new System.Drawing.Point(761, 256);
            this.SceneText.Margin = new System.Windows.Forms.Padding(4);
            this.SceneText.Multiline = true;
            this.SceneText.Name = "SceneText";
            this.SceneText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SceneText.Size = new System.Drawing.Size(512, 364);
            this.SceneText.TabIndex = 3;
            this.SceneText.TextChanged += new System.EventHandler(this.SceneText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(776, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Scene Hint";
            // 
            // SceneHint
            // 
            this.SceneHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneHint.Location = new System.Drawing.Point(769, 47);
            this.SceneHint.Margin = new System.Windows.Forms.Padding(4);
            this.SceneHint.Multiline = true;
            this.SceneHint.Name = "SceneHint";
            this.SceneHint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SceneHint.Size = new System.Drawing.Size(504, 184);
            this.SceneHint.TabIndex = 1;
            this.SceneHint.TextChanged += new System.EventHandler(this.SceneHint_TextChanged);
            // 
            // SceneInScenesList
            // 
            this.SceneInScenesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneInScenesList.FormattingEnabled = true;
            this.SceneInScenesList.ItemHeight = 25;
            this.SceneInScenesList.Location = new System.Drawing.Point(33, 41);
            this.SceneInScenesList.Margin = new System.Windows.Forms.Padding(4);
            this.SceneInScenesList.Name = "SceneInScenesList";
            this.SceneInScenesList.Size = new System.Drawing.Size(292, 579);
            this.SceneInScenesList.TabIndex = 0;
            this.SceneInScenesList.SelectedIndexChanged += new System.EventHandler(this.SceneInScenesList_SelectedIndexChanged);
            // 
            // CharactersTab
            // 
            this.CharactersTab.Location = new System.Drawing.Point(4, 48);
            this.CharactersTab.Margin = new System.Windows.Forms.Padding(4);
            this.CharactersTab.Name = "CharactersTab";
            this.CharactersTab.Padding = new System.Windows.Forms.Padding(4);
            this.CharactersTab.Size = new System.Drawing.Size(2365, 710);
            this.CharactersTab.TabIndex = 2;
            this.CharactersTab.Text = "Characters";
            this.CharactersTab.UseVisualStyleBackColor = true;
            // 
            // Locations
            // 
            this.Locations.Location = new System.Drawing.Point(4, 48);
            this.Locations.Margin = new System.Windows.Forms.Padding(4);
            this.Locations.Name = "Locations";
            this.Locations.Padding = new System.Windows.Forms.Padding(4);
            this.Locations.Size = new System.Drawing.Size(2365, 710);
            this.Locations.TabIndex = 3;
            this.Locations.Text = "Locations";
            this.Locations.UseVisualStyleBackColor = true;
            // 
            // Parameters
            // 
            this.Parameters.Location = new System.Drawing.Point(4, 48);
            this.Parameters.Margin = new System.Windows.Forms.Padding(4);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(2365, 710);
            this.Parameters.TabIndex = 5;
            this.Parameters.Text = "Parameters";
            this.Parameters.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1403, 815);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 55);
            this.button4.TabIndex = 9;
            this.button4.Text = "New Movie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(64, 815);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 52);
            this.button3.TabIndex = 1;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // SelectGPT35
            // 
            this.SelectGPT35.AutoSize = true;
            this.SelectGPT35.Checked = true;
            this.SelectGPT35.Location = new System.Drawing.Point(243, 821);
            this.SelectGPT35.Margin = new System.Windows.Forms.Padding(4);
            this.SelectGPT35.Name = "SelectGPT35";
            this.SelectGPT35.Size = new System.Drawing.Size(115, 20);
            this.SelectGPT35.TabIndex = 2;
            this.SelectGPT35.TabStop = true;
            this.SelectGPT35.Text = "GPT 3.5 Turbo";
            this.SelectGPT35.UseVisualStyleBackColor = true;
            this.SelectGPT35.CheckedChanged += new System.EventHandler(this.SelectGPT35_CheckedChanged);
            // 
            // SelectGPT4
            // 
            this.SelectGPT4.AutoSize = true;
            this.SelectGPT4.Location = new System.Drawing.Point(243, 849);
            this.SelectGPT4.Margin = new System.Windows.Forms.Padding(4);
            this.SelectGPT4.Name = "SelectGPT4";
            this.SelectGPT4.Size = new System.Drawing.Size(67, 20);
            this.SelectGPT4.TabIndex = 3;
            this.SelectGPT4.Text = "GPT-4";
            this.SelectGPT4.UseVisualStyleBackColor = true;
            this.SelectGPT4.CheckedChanged += new System.EventHandler(this.SelectGPT4_CheckedChanged);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(409, 800);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(163, 54);
            this.button7.TabIndex = 10;
            this.button7.Text = "Make Title";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MovieTitle
            // 
            this.MovieTitle.AutoSize = true;
            this.MovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitle.Location = new System.Drawing.Point(590, 815);
            this.MovieTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(60, 25);
            this.MovieTitle.TabIndex = 11;
            this.MovieTitle.Text = "Title: ";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage.Location = new System.Drawing.Point(1463, 888);
            this.ErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(31, 29);
            this.ErrorMessage.TabIndex = 12;
            this.ErrorMessage.Text = "\"\"";
            // 
            // GPTError
            // 
            this.GPTError.AutoSize = true;
            this.GPTError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPTError.Location = new System.Drawing.Point(415, 872);
            this.GPTError.Name = "GPTError";
            this.GPTError.Size = new System.Drawing.Size(109, 25);
            this.GPTError.TabIndex = 13;
            this.GPTError.Text = "GPT Error";
            this.GPTError.Click += new System.EventHandler(this.GPTError_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2509, 926);
            this.Controls.Add(this.GPTError);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.MovieTitle);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.SelectGPT4);
            this.Controls.Add(this.SelectGPT35);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Movie);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Movie.ResumeLayout(false);
            this.MovieTab.ResumeLayout(false);
            this.MovieTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SentencesInSceneHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SceneCount)).EndInit();
            this.ScenesTab.ResumeLayout(false);
            this.ScenesTab.PerformLayout();
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton SelectGPT35;
        private System.Windows.Forms.RadioButton SelectGPT4;
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
        private System.Windows.Forms.Button MakeBeatSheet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button WriteSceneBtn;
        private System.Windows.Forms.RichTextBox SceneScriptRichTextbox;
        private System.Windows.Forms.RichTextBox BeatSheetRichTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown SentencesInSceneHint;
        private System.Windows.Forms.Label GPTError;
        private System.Windows.Forms.Button button5;
    }
}

