using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenAI_API;
using OpenAI_API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace ScriptHelper
{

    public partial class Form1 : Form
    {

        public OpenAIAPI api = new OpenAIAPI("Your Open AI key here");

        int NotesTextKount = 0;
        List<SceneObj> scenes;
        List<SceneObj> scenesinscenes;
        SceneObj scene;

        MovieObj myMovie = new MovieObj();

        string gptModel = "gpt-3.5-turbo";

        // Set up the ListBox

        public Form1()
        {
            InitializeComponent();

            SelectGPT35.Checked = true;

            // makeProtoTypeScenes();


            ScenesList.DataSource = scenes;
            SceneInScenesList.DataSource = scenesinscenes;

            ScenesList.DisplayMember = "Title";


            MovieHintText.Text = makePrototypeMovieHint();
            

            myMovie.movieHintText = MovieHintText.Text;
            

            Movie.SelectedIndexChanged += Movie_SelectedIndexChanged;

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // UtilsGPT module = new UtilsGPT();
            // module.UpdateError(this);
        }

        private void Movie_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            if (tabControl != null)
            {
                int selectedIndex = tabControl.SelectedIndex;
                if (selectedIndex == 1)
                {

                    SceneInScenesList.DataSource = scenes;
                    SceneInScenesList.DisplayMember = "Title";
                    Application.DoEvents();

                    int picked = SceneInScenesList.SelectedIndex;
                    SceneHint.Text = scenes[picked].Hint;
                    Application.DoEvents();

                }
                // Perform your desired actions based on the selected index.
                // MessageBox.Show($"Selected tab index: {selectedIndex}");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MovieHintText_TextChanged(object sender, EventArgs e)
        {

        }


        private void Label2_Click(object sender, EventArgs e)
        {

        }



        private async void Button1_Click_1(object sender, EventArgs e)
        {


            MovieText.Text = gptModel + " awaiting reply...\r\n \r\n" + MovieHintText.Text;
            string reply = await doMakeMovieText(MovieHintText.Text);
            MovieText.Text = reply;
            myMovie.movieText = reply;
            myMovie.myNoteTextList.Add(new NotesMovieText(MovieText.Text, "", "-Base-"));
            NotesList.DataSource = myMovie.myNoteTextList;
            NotesList.DisplayMember = "myLabel";
            Application.DoEvents();


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MovieObj movie = new MovieObj();
            MovieHintText.Text = movie.movieHintText;
        }

        private void SelectGPT35_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectGPT35.Checked)
            {
                gptModel = "gpt-3.5-turbo";
                SelectGPT4.Checked = false;

            }

        }

        private void SelectGPT4_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectGPT4.Checked)
            {
                gptModel = "gpt-4";
                SelectGPT35.Checked = false;
            }

        }



        private string makePrototypeMovieHint()
        {
            string hint = @"a 19 year old man <Robert> meets a 39 year old married woman <Beth>, and they both fall in love.  A passionate affair ensues.  <Beth> is married to <Oscar> a successful but cold and harsh 55 year old lawyer.    <Sally> the 12 year old daughter of <Beth> and <Oscar> knows about <Beth>'s affair with <Robert> and pleads with <Beth> to end it.  <Sally> warns <Beth> that <Oscar> is dangerous.   The affair ends tragically when <Oscar> kills <Robert> and <Beth>.  As a prominent citizen and using his skills as a lawyer, <Oscar> is not suspected by the police and he gets away with the crime.  But <Sally> knows that he did it, and torments him for the rest of his life including on his death bed 20 years later. ";
            return hint;
        }

        private async void button5_Click(object sender, EventArgs e)
        {

            doMakeScenesFromMovieText();




        }

        private void SceneInScenesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int picked = SceneInScenesList.SelectedIndex;
            SceneHint.Text = scenes[picked].Hint;
            Application.DoEvents();
        }

        private void SceneHint_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button6_Click(object sender, EventArgs e)
        {


            doMakeSceneText();



        }

        private async void button7_Click(object sender, EventArgs e)
        {
            string reply;

            if (myMovie.movieText.Length > 200)
            {
                MovieTitle.Text = "making title from long...";
                reply = await MyGPT.getTitle(api, myMovie.movieText, gptModel, this);
                reply = "from long: " + reply;
            }
            else
            {
                MovieTitle.Text = "making title from hint...";
                reply = await MyGPT.getTitle(api, myMovie.movieHintText, gptModel, this);
                reply = "from hint: " + reply;
            }

            MovieTitle.Text = reply;
        }

        private async void button5_Click_1(object sender, EventArgs e)
        {
            doMakeBeatSheet();



        }

        private async void button5_Click_2(object sender, EventArgs e)
        {

            doWriteSceneScript();

            
        }

        private void SceneText_TextChanged(object sender, EventArgs e)
        {

        }



        private void GPTError_Click(object sender, EventArgs e)
        {

        }


        private void ErrorMessage_Click(object sender, EventArgs e)
        {

        }

        public void updateGPTErrorMsg(string input)
        {
            ErrorMessage.Text = input;
            Application.DoEvents();

        }

        private async void button5_Click_3(object sender, EventArgs e)
        {

            if (NotesForMovieText.Text.Length > 20)
            {
                string originalMovieText = myMovie.movieText;
                string originalNote = NotesForMovieText.Text;
                int sourceIndex = NotesList.SelectedIndex;

                MovieText.Text = gptModel + " applying Notes to Text....\r\n \r\n" + MovieText.Text;
                string response = await MyGPT.NotesForMovieText(api, gptModel, MovieText.Text, NotesForMovieText.Text, this);
                MovieText.Text = response;
                myMovie.movieText = response;
                NotesTextKount += 1;
                myMovie.myNoteTextList.Add(new NotesMovieText(myMovie.movieText, NotesForMovieText.Text, Utils.rightOfArrow(myMovie.myNoteTextList[sourceIndex].myLabel) + " -> Note #" + NotesTextKount.ToString()));
                NotesList.DataSource = null;
                NotesList.DisplayMember = null;
                NotesList.DataSource = myMovie.myNoteTextList;
                NotesList.DisplayMember = "myLabel";
                NotesList.SelectedIndex = NotesTextKount;
                Application.DoEvents();
            }
            else
            {

                MessageBox.Show("Not Enough Text Notes.  Need at least 20 characters ");
            }









        }

        private void NotesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NotesList.SelectedIndex >= 0 && NotesList.SelectedIndex <= myMovie.myNoteTextList.Count)
            {
                MovieText.Text = myMovie.myNoteTextList[NotesList.SelectedIndex].myMovieText;
                NotesForMovieText.Text = myMovie.myNoteTextList[NotesList.SelectedIndex].myNote;
            }


        }

        private void SentencesInSceneHint_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_4(object sender, EventArgs e)
        {
            
            Font boldFont = new Font(BoldBox.Font, FontStyle.Bold);
            Font regularFont = new Font(BoldBox.Font, FontStyle.Regular);
            
            
            BoldBox.Focus();
            BoldBox.AppendText("123 456 789");
            BoldBox.Select(0, 11);
            BoldBox.SelectionFont = boldFont;
            

            BoldBox.Text += "\r\nabc def ghi";
        }

        public async Task<string> doMakeMovieText(string input)
        {
            
            string reply = await MyGPT.makeMovieText(api, input, gptModel, this);

            return reply.ToString();
        }

        public async void doMakeScenesFromMovieText()
        {
            List<List<string>> ListofLists = new List<List<string>>();

            if (MovieText.Text.Length < 200)
            {
                MessageBox.Show("Not Enough Movie Text.  Need at least 50 characters ");
            }

            else
            {

                SceneDescriptions.Clear();
                SceneDescriptions.Text = Utils.makePendingMessage(gptModel);


                bool looper = true;
                int errorKount = 0;
                string jsonString = "";
                string originalJSONString = "";
                jsonString = await MyGPT.makeScenesFromMovieText(api, MovieText.Text, gptModel, (int)SceneCount.Value, (int)TokensInSceneHint.Value, GPTError.Text, this);
                originalJSONString = jsonString;
                while (looper == true)
                {
                    try
                    {

                        ListofLists = JsonConvert.DeserializeObject<List<List<string>>>(jsonString);
                        SceneDescriptions.Text = jsonString;
                        looper = false;
                    }

                    catch (Exception ex)

                    {

                        if (errorKount == 0)

                        {
                            errorKount += 1;
                            jsonString = Utils.JSONFixer(originalJSONString);
                            Utils.nop();
                            looper = true;
                        }
                        else if (errorKount > 5)

                        {
                            Application.Exit();
                        }
                        else
                        {
                            errorKount += 1;
                            SceneDescriptions.Text = "error - trying to repair JSON. kount = " + errorKount.ToString() + "\r\n" + originalJSONString;
                            jsonString = await MyGPT.fixJSON(api, originalJSONString, gptModel, this);
                            looper = true;
                        }

                    }
                }



                scenes = new List<SceneObj>();
                foreach (List<string> myScene in ListofLists)
                {

                    SceneObj scene = new SceneObj();
                    string myTitle = myScene[0];
                    string Hint = myScene[1];
                    scene.Title = myTitle;
                    scene.Hint = Hint;
                    scenes.Add(scene);
                }
                ScenesList.DataSource = scenes;
                ScenesList.DisplayMember = "Title";


            }


        }

        public async void doMakeSceneText()
        {
            SceneText.Text = SceneHint.Text + "\r\n \r\n " + gptModel + " awaiting reply...";
            string reply = await MyGPT.makeSceneText(api, gptModel, myMovie, scenes, SceneInScenesList.SelectedIndex + 1, this);
            SceneText.Text = reply;
            scenes[SceneInScenesList.SelectedIndex].NarrativeText = reply;
        }

        public async void doMakeBeatSheet()
        {
            if (SceneText.Text.Length > 50)
            {
                BeatSheetRichTextbox.Text = "making beat sheet from scene descriptiom.... ";
                BeatSheetRichTextbox.Text = await MyGPT.makeBeatSheet(api, myMovie, SceneText.Text, gptModel, this);
                scenes[SceneInScenesList.SelectedIndex].BeatSheetText = BeatSheetRichTextbox.Text;
            }
            else
            {
                MessageBox.Show("Not Enough Scene Text.  Need at least 50 characters ");
            }
        }

        public async void doWriteSceneScript()
        {
            if (BeatSheetRichTextbox.Text.Length > 50)
            {
                SceneScriptRichTextbox.Text = gptModel + " working on scene script....";
                SceneScriptRichTextbox.Text = await MyGPT.makeSceneScript(api, myMovie, BeatSheetRichTextbox.Text, SceneText.Text, gptModel, this);
            }
            else
            {
                MessageBox.Show("Not Enough Beat Sheet.  Need at least 50 characters ");
            }

        }

        private async void button8_Click(object sender, EventArgs e)
        {
            // write a whole movie script from a movie text
            Font boldFont = new Font(FullMovieScript.Font, FontStyle.Bold);
            Font regularFont = new Font(FullMovieScript.Font, FontStyle.Regular);



            if (scenes == null || scenes.Count == 0)
            {
                MessageBox.Show("Scenes not yet made ");
                return;
            }
            string movieTitle = await MyGPT.getTitle(api, myMovie.movieText, gptModel, this);
            int sceneKount = 0;

            FullMovieScript.Font = boldFont;
            FullMovieScript.Text = "";
            FullMovieScript.Text = movieTitle + "\r\n\r\n";

            FullMovieScript.Font = regularFont;

            string mySceneText;
            string myBeatSheetText;
            string mySceneScriptText;


            foreach (SceneObj theScene in scenes)
            {
                sceneKount += 1;
                mySceneText = await MyGPT.makeSceneText(api, gptModel, myMovie, scenes, sceneKount, this);
                SceneText.Text = mySceneText;
                myBeatSheetText = await MyGPT.makeBeatSheet(api, myMovie, SceneText.Text, gptModel, this);
                BeatSheetRichTextbox.Text = myBeatSheetText;
                scenes[sceneKount -1].BeatSheetText = myBeatSheetText;

                mySceneScriptText = await MyGPT.makeSceneScript(api, myMovie, myBeatSheetText, mySceneText, gptModel, this);
                SceneScriptRichTextbox.Text = mySceneScriptText;
                scenes[sceneKount - 1].SceneScript = mySceneScriptText;

                FullMovieScript.Font = boldFont;
                FullMovieScript.Text += $"Scene #{sceneKount} - {scenes[sceneKount - 1].Title}" + "\r\n\r\n";
                FullMovieScript.Font = regularFont;
                FullMovieScript.Text += mySceneScriptText + "\r\n\r\n"; 

            }

            return;

        }
    }
}
