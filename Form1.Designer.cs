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
            this.components = new System.ComponentModel.Container();
            this.Movie = new System.Windows.Forms.TabControl();
            this.MovieTab = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.MovieText = new System.Windows.Forms.RichTextBox();
            this.NotesList = new System.Windows.Forms.ListBox();
            this.ApplyMovieTextNote = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NotesForMovieText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TokensInSceneHint = new System.Windows.Forms.NumericUpDown();
            this.SceneCount = new System.Windows.Forms.NumericUpDown();
            this.MakeSceneList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ScenesList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieHintText = new System.Windows.Forms.TextBox();
            this.ScenesTab = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
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
            this.UITest = new System.Windows.Forms.TabPage();
            this.BoldBox = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.FullScript = new System.Windows.Forms.TabPage();
            this.FullMovieScript = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ErrorLogBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SceneDescriptions = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SelectGPT35 = new System.Windows.Forms.RadioButton();
            this.SelectGPT4 = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.MovieTitle = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.GPTError = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.movieTextNotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.Movie.SuspendLayout();
            this.MovieTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TokensInSceneHint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SceneCount)).BeginInit();
            this.ScenesTab.SuspendLayout();
            this.UITest.SuspendLayout();
            this.FullScript.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieTextNotesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Movie
            // 
            this.Movie.Controls.Add(this.MovieTab);
            this.Movie.Controls.Add(this.ScenesTab);
            this.Movie.Controls.Add(this.CharactersTab);
            this.Movie.Controls.Add(this.Locations);
            this.Movie.Controls.Add(this.Parameters);
            this.Movie.Controls.Add(this.UITest);
            this.Movie.Controls.Add(this.FullScript);
            this.Movie.Controls.Add(this.tabPage1);
            this.Movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie.Location = new System.Drawing.Point(44, 24);
            this.Movie.Name = "Movie";
            this.Movie.SelectedIndex = 0;
            this.Movie.Size = new System.Drawing.Size(1376, 619);
            this.Movie.TabIndex = 0;
            // 
            // MovieTab
            // 
            this.MovieTab.Controls.Add(this.button8);
            this.MovieTab.Controls.Add(this.MovieText);
            this.MovieTab.Controls.Add(this.NotesList);
            this.MovieTab.Controls.Add(this.ApplyMovieTextNote);
            this.MovieTab.Controls.Add(this.label4);
            this.MovieTab.Controls.Add(this.NotesForMovieText);
            this.MovieTab.Controls.Add(this.label10);
            this.MovieTab.Controls.Add(this.label7);
            this.MovieTab.Controls.Add(this.TokensInSceneHint);
            this.MovieTab.Controls.Add(this.SceneCount);
            this.MovieTab.Controls.Add(this.MakeSceneList);
            this.MovieTab.Controls.Add(this.label3);
            this.MovieTab.Controls.Add(this.ScenesList);
            this.MovieTab.Controls.Add(this.button1);
            this.MovieTab.Controls.Add(this.label2);
            this.MovieTab.Controls.Add(this.label1);
            this.MovieTab.Controls.Add(this.MovieHintText);
            this.MovieTab.Location = new System.Drawing.Point(4, 40);
            this.MovieTab.Name = "MovieTab";
            this.MovieTab.Padding = new System.Windows.Forms.Padding(3);
            this.MovieTab.Size = new System.Drawing.Size(1368, 575);
            this.MovieTab.TabIndex = 0;
            this.MovieTab.Text = "Movie";
            this.MovieTab.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(1164, 485);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(162, 79);
            this.button8.TabIndex = 24;
            this.button8.Text = "Full Auto";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // MovieText
            // 
            this.MovieText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieText.Location = new System.Drawing.Point(620, 46);
            this.MovieText.Margin = new System.Windows.Forms.Padding(2);
            this.MovieText.Name = "MovieText";
            this.MovieText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.MovieText.Size = new System.Drawing.Size(495, 522);
            this.MovieText.TabIndex = 23;
            this.MovieText.Text = "";
            // 
            // NotesList
            // 
            this.NotesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesList.FormattingEnabled = true;
            this.NotesList.ItemHeight = 20;
            this.NotesList.Location = new System.Drawing.Point(1132, 42);
            this.NotesList.Margin = new System.Windows.Forms.Padding(2);
            this.NotesList.Name = "NotesList";
            this.NotesList.ScrollAlwaysVisible = true;
            this.NotesList.Size = new System.Drawing.Size(223, 424);
            this.NotesList.TabIndex = 22;
            this.NotesList.SelectedIndexChanged += new System.EventHandler(this.NotesList_SelectedIndexChanged);
            // 
            // ApplyMovieTextNote
            // 
            this.ApplyMovieTextNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyMovieTextNote.Location = new System.Drawing.Point(461, 531);
            this.ApplyMovieTextNote.Margin = new System.Windows.Forms.Padding(2);
            this.ApplyMovieTextNote.Name = "ApplyMovieTextNote";
            this.ApplyMovieTextNote.Size = new System.Drawing.Size(140, 37);
            this.ApplyMovieTextNote.TabIndex = 21;
            this.ApplyMovieTextNote.Text = "Apply Note";
            this.ApplyMovieTextNote.UseVisualStyleBackColor = true;
            this.ApplyMovieTextNote.Click += new System.EventHandler(this.button5_Click_3);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Notes For Movie Text";
            // 
            // NotesForMovieText
            // 
            this.NotesForMovieText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesForMovieText.Location = new System.Drawing.Point(221, 403);
            this.NotesForMovieText.Margin = new System.Windows.Forms.Padding(2);
            this.NotesForMovieText.Multiline = true;
            this.NotesForMovieText.Name = "NotesForMovieText";
            this.NotesForMovieText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotesForMovieText.Size = new System.Drawing.Size(380, 114);
            this.NotesForMovieText.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(99, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 24);
            this.label10.TabIndex = 18;
            this.label10.Text = "Scenes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(98, 540);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tokens";
            // 
            // TokensInSceneHint
            // 
            this.TokensInSceneHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokensInSceneHint.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.TokensInSceneHint.Location = new System.Drawing.Point(24, 543);
            this.TokensInSceneHint.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TokensInSceneHint.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.TokensInSceneHint.Name = "TokensInSceneHint";
            this.TokensInSceneHint.Size = new System.Drawing.Size(69, 29);
            this.TokensInSceneHint.TabIndex = 16;
            this.TokensInSceneHint.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.TokensInSceneHint.ValueChanged += new System.EventHandler(this.SentencesInSceneHint_ValueChanged);
            // 
            // SceneCount
            // 
            this.SceneCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneCount.Location = new System.Drawing.Point(24, 508);
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
            this.MakeSceneList.Location = new System.Drawing.Point(24, 465);
            this.MakeSceneList.Name = "MakeSceneList";
            this.MakeSceneList.Size = new System.Drawing.Size(183, 40);
            this.MakeSceneList.TabIndex = 12;
            this.MakeSceneList.Text = "Make Scenes";
            this.MakeSceneList.UseVisualStyleBackColor = true;
            this.MakeSceneList.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 9);
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
            this.ScenesList.Location = new System.Drawing.Point(25, 42);
            this.ScenesList.Name = "ScenesList";
            this.ScenesList.Size = new System.Drawing.Size(183, 404);
            this.ScenesList.TabIndex = 5;
            this.ScenesList.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(217, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 31);
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
            this.label2.Location = new System.Drawing.Point(616, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movie Text";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Hint";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // MovieHintText
            // 
            this.MovieHintText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieHintText.Location = new System.Drawing.Point(221, 42);
            this.MovieHintText.Multiline = true;
            this.MovieHintText.Name = "MovieHintText";
            this.MovieHintText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MovieHintText.Size = new System.Drawing.Size(380, 330);
            this.MovieHintText.TabIndex = 0;
            this.MovieHintText.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // ScenesTab
            // 
            this.ScenesTab.Controls.Add(this.label11);
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
            this.ScenesTab.Location = new System.Drawing.Point(4, 40);
            this.ScenesTab.Name = "ScenesTab";
            this.ScenesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ScenesTab.Size = new System.Drawing.Size(1368, 575);
            this.ScenesTab.TabIndex = 1;
            this.ScenesTab.Text = "Scenes";
            this.ScenesTab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(578, 210);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 24);
            this.label11.TabIndex = 13;
            this.label11.Text = "Scene Text";
            // 
            // BeatSheetRichTextbox
            // 
            this.BeatSheetRichTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeatSheetRichTextbox.Location = new System.Drawing.Point(287, 39);
            this.BeatSheetRichTextbox.Name = "BeatSheetRichTextbox";
            this.BeatSheetRichTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.BeatSheetRichTextbox.Size = new System.Drawing.Size(255, 476);
            this.BeatSheetRichTextbox.TabIndex = 12;
            this.BeatSheetRichTextbox.Text = "";
            // 
            // SceneScriptRichTextbox
            // 
            this.SceneScriptRichTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneScriptRichTextbox.Location = new System.Drawing.Point(965, 39);
            this.SceneScriptRichTextbox.Name = "SceneScriptRichTextbox";
            this.SceneScriptRichTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.SceneScriptRichTextbox.Size = new System.Drawing.Size(388, 481);
            this.SceneScriptRichTextbox.TabIndex = 11;
            this.SceneScriptRichTextbox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(962, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Scene Script";
            // 
            // WriteSceneBtn
            // 
            this.WriteSceneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteSceneBtn.Location = new System.Drawing.Point(965, 532);
            this.WriteSceneBtn.Name = "WriteSceneBtn";
            this.WriteSceneBtn.Size = new System.Drawing.Size(225, 38);
            this.WriteSceneBtn.TabIndex = 8;
            this.WriteSceneBtn.Text = "Write Scene";
            this.WriteSceneBtn.UseVisualStyleBackColor = true;
            this.WriteSceneBtn.Click += new System.EventHandler(this.button5_Click_2);
            // 
            // MakeBeatSheet
            // 
            this.MakeBeatSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeBeatSheet.Location = new System.Drawing.Point(287, 521);
            this.MakeBeatSheet.Name = "MakeBeatSheet";
            this.MakeBeatSheet.Size = new System.Drawing.Size(212, 42);
            this.MakeBeatSheet.TabIndex = 7;
            this.MakeBeatSheet.Text = "Make Beat Sheet";
            this.MakeBeatSheet.UseVisualStyleBackColor = true;
            this.MakeBeatSheet.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(284, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Beat Sheet";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(571, 522);
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
            this.SceneText.Location = new System.Drawing.Point(575, 238);
            this.SceneText.Multiline = true;
            this.SceneText.Name = "SceneText";
            this.SceneText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SceneText.Size = new System.Drawing.Size(385, 279);
            this.SceneText.TabIndex = 3;
            this.SceneText.TextChanged += new System.EventHandler(this.SceneText_TextChanged);
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
            this.SceneInScenesList.Location = new System.Drawing.Point(25, 33);
            this.SceneInScenesList.Name = "SceneInScenesList";
            this.SceneInScenesList.Size = new System.Drawing.Size(220, 464);
            this.SceneInScenesList.TabIndex = 0;
            this.SceneInScenesList.SelectedIndexChanged += new System.EventHandler(this.SceneInScenesList_SelectedIndexChanged);
            // 
            // CharactersTab
            // 
            this.CharactersTab.Location = new System.Drawing.Point(4, 40);
            this.CharactersTab.Name = "CharactersTab";
            this.CharactersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CharactersTab.Size = new System.Drawing.Size(1368, 575);
            this.CharactersTab.TabIndex = 2;
            this.CharactersTab.Text = "Characters";
            this.CharactersTab.UseVisualStyleBackColor = true;
            // 
            // Locations
            // 
            this.Locations.Location = new System.Drawing.Point(4, 40);
            this.Locations.Name = "Locations";
            this.Locations.Padding = new System.Windows.Forms.Padding(3);
            this.Locations.Size = new System.Drawing.Size(1368, 575);
            this.Locations.TabIndex = 3;
            this.Locations.Text = "Locations";
            this.Locations.UseVisualStyleBackColor = true;
            // 
            // Parameters
            // 
            this.Parameters.Location = new System.Drawing.Point(4, 40);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(1368, 575);
            this.Parameters.TabIndex = 5;
            this.Parameters.Text = "Parameters";
            this.Parameters.UseVisualStyleBackColor = true;
            // 
            // UITest
            // 
            this.UITest.Controls.Add(this.BoldBox);
            this.UITest.Controls.Add(this.button5);
            this.UITest.Location = new System.Drawing.Point(4, 40);
            this.UITest.Margin = new System.Windows.Forms.Padding(2);
            this.UITest.Name = "UITest";
            this.UITest.Size = new System.Drawing.Size(1368, 575);
            this.UITest.TabIndex = 6;
            this.UITest.Text = "UI Test";
            this.UITest.UseVisualStyleBackColor = true;
            // 
            // BoldBox
            // 
            this.BoldBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoldBox.Location = new System.Drawing.Point(187, 62);
            this.BoldBox.Margin = new System.Windows.Forms.Padding(2);
            this.BoldBox.Name = "BoldBox";
            this.BoldBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.BoldBox.Size = new System.Drawing.Size(356, 187);
            this.BoldBox.TabIndex = 1;
            this.BoldBox.Text = "";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(59, 60);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 50);
            this.button5.TabIndex = 0;
            this.button5.Text = "run";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_4);
            // 
            // FullScript
            // 
            this.FullScript.Controls.Add(this.FullMovieScript);
            this.FullScript.Location = new System.Drawing.Point(4, 40);
            this.FullScript.Margin = new System.Windows.Forms.Padding(2);
            this.FullScript.Name = "FullScript";
            this.FullScript.Size = new System.Drawing.Size(1368, 575);
            this.FullScript.TabIndex = 7;
            this.FullScript.Text = "Full Script";
            this.FullScript.UseVisualStyleBackColor = true;
            // 
            // FullMovieScript
            // 
            this.FullMovieScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullMovieScript.Location = new System.Drawing.Point(58, 38);
            this.FullMovieScript.Margin = new System.Windows.Forms.Padding(2);
            this.FullMovieScript.Name = "FullMovieScript";
            this.FullMovieScript.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.FullMovieScript.Size = new System.Drawing.Size(740, 522);
            this.FullMovieScript.TabIndex = 0;
            this.FullMovieScript.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.ErrorLogBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.SceneDescriptions);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1368, 575);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "Debug";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ErrorLogBox
            // 
            this.ErrorLogBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLogBox.Location = new System.Drawing.Point(348, 58);
            this.ErrorLogBox.Name = "ErrorLogBox";
            this.ErrorLogBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ErrorLogBox.Size = new System.Drawing.Size(301, 482);
            this.ErrorLogBox.TabIndex = 17;
            this.ErrorLogBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Screen JSON";
            // 
            // SceneDescriptions
            // 
            this.SceneDescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SceneDescriptions.Location = new System.Drawing.Point(20, 58);
            this.SceneDescriptions.Multiline = true;
            this.SceneDescriptions.Name = "SceneDescriptions";
            this.SceneDescriptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SceneDescriptions.Size = new System.Drawing.Size(289, 482);
            this.SceneDescriptions.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1605, 673);
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
            this.button3.Location = new System.Drawing.Point(47, 652);
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
            this.button7.Location = new System.Drawing.Point(307, 650);
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
            this.MovieTitle.Location = new System.Drawing.Point(442, 662);
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.Size = new System.Drawing.Size(46, 20);
            this.MovieTitle.TabIndex = 11;
            this.MovieTitle.Text = "Title: ";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage.Location = new System.Drawing.Point(442, 705);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 24);
            this.ErrorMessage.TabIndex = 12;
            this.ErrorMessage.Click += new System.EventHandler(this.ErrorMessage_Click);
            // 
            // GPTError
            // 
            this.GPTError.AutoSize = true;
            this.GPTError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPTError.Location = new System.Drawing.Point(311, 708);
            this.GPTError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GPTError.Name = "GPTError";
            this.GPTError.Size = new System.Drawing.Size(89, 20);
            this.GPTError.TabIndex = 13;
            this.GPTError.Text = "GPT Error";
            this.GPTError.Click += new System.EventHandler(this.GPTError_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(46, 705);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(349, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "Error Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 752);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GPTError);
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
            ((System.ComponentModel.ISupportInitialize)(this.TokensInSceneHint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SceneCount)).EndInit();
            this.ScenesTab.ResumeLayout(false);
            this.ScenesTab.PerformLayout();
            this.UITest.ResumeLayout(false);
            this.FullScript.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieTextNotesBindingSource)).EndInit();
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
        private System.Windows.Forms.NumericUpDown TokensInSceneHint;
        private System.Windows.Forms.Label GPTError;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ApplyMovieTextNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NotesForMovieText;
        private System.Windows.Forms.ListBox NotesList;
        private System.Windows.Forms.BindingSource movieTextNotesBindingSource;
        private System.Windows.Forms.RichTextBox MovieText;
        private System.Windows.Forms.TabPage UITest;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabPage FullScript;
        private System.Windows.Forms.RichTextBox FullMovieScript;
        private System.Windows.Forms.RichTextBox BoldBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SceneDescriptions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox ErrorLogBox;
        private System.Windows.Forms.Label label12;
    }
}

