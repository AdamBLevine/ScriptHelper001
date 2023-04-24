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

namespace ScriptHelper
{

    public partial class Form1 : Form
    {

        public OpenAIAPI api = new OpenAIAPI("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");


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
            MovieText.Text = MovieHintText.Text;

            myMovie.movieHintText = MovieHintText.Text;
            myMovie.movieText = MovieHintText.Text;

            Movie.SelectedIndexChanged += Movie_SelectedIndexChanged;

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

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
                    SceneHint.Text = scenes[picked].Description;
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

            MovieText.Text = MovieHintText.Text + "\r\n \r\n" + gptModel + " awaiting reply...";
            string reply = await MyGPT.makeMovieText(api, MovieHintText.Text, gptModel);
            MovieText.Text = reply;
            myMovie.movieText = reply;

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

        private async void button2_Click(object sender, EventArgs e)
        {

            MovieTextCompiled.Text = Utils.makePendingMessage(gptModel);

            string reply = await MyGPT.gptCompress  (api, MovieText.Text, gptModel,500);

            MovieTextCompiled.Text = "model: " + gptModel + "+++ >" + reply;
            myMovie.movieTextCompiled = reply;

        }
 
        private string makePrototypeMovieHint()
        {
            string hint = @"a 19 year old man <Robert> meets a 39 year old married woman <Beth>, and they both fall in love.  A passionate affair ensues.  <Beth> is married to <Oscar> a successful but cold and harsh 55 year old lawyer.    <Sally> the 12 year old daughter of <Beth> and <Oscar> knows about <Beth>'s affair with <Robert> and pleads with <Beth> to end it.  <Sally> warns <Beth> that <Oscar> is dangerous.   The affair ends tragically when <Oscar> kills <Robert> and <Beth>.  As a prominenet citizen and using his skills as a lawyer, <Oscar> is not suspected by the police and he gets away with the crime.  But <Sally> knows that he did it, and torments him for the rest of his life including on his death bed 20 years later. ";
            return hint;
        }

        private async void button5_Click(object sender, EventArgs e)
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
                jsonString = await MyGPT.makeScenesFromMovieText(api, MovieText.Text, gptModel, (int)SceneCount.Value,(int)SentencesInSceneHint.Value);
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
                        errorKount += 1;
                        if (errorKount > 5)
                        {
                            Application.Exit();
                        }
                        SceneDescriptions.Text = "error - trying to repair JSON. kount = " + errorKount.ToString();
                        jsonString = await MyGPT.fixJSON(api, originalJSONString ,gptModel);
                        looper = true;
                    }
                }
                    
                           

                scenes = new List<SceneObj>();
                foreach (List<string> myScene in ListofLists)
                {

                    SceneObj scene = new SceneObj();
                    string myTitle = myScene[0];
                    string myDescription = myScene[1];
                    scene.Title = myTitle;
                    scene.Description = myDescription;
                    scenes.Add(scene);
                }
                ScenesList.DataSource = scenes;
                ScenesList.DisplayMember = "Title";


            }


        }

        private void SceneInScenesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int picked = SceneInScenesList.SelectedIndex;
            SceneHint.Text = scenes[picked].Description;
            Application.DoEvents();
        }

        private void SceneHint_TextChanged(object sender, EventArgs e)
        {
            
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            
            SceneText.Text = SceneHint.Text + "\r\n \r\n " + gptModel + " awaiting reply...";
            string reply =   await MyGPT.makeSceneText(api, gptModel,myMovie, scenes, SceneInScenesList.SelectedIndex + 1);
            SceneText.Text = reply;

            
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            string reply;
            
            if (myMovie.movieText.Length > 200)
            {
                MovieTitle.Text = "making title from long...";
                reply = await MyGPT.getTitle(api, myMovie.movieText, gptModel);
                reply = "from long: " + reply;
            }
            else 
            {
                MovieTitle.Text = "making title from hint...";
                reply = await MyGPT.getTitle(api, myMovie.movieHintText, gptModel);
                reply = "from hint: " + reply;
            }

            MovieTitle.Text = reply;
        }

        private async void button5_Click_1(object sender, EventArgs e)
        {
            BeatSheet.Text = "making beat sheet from scene descriptiom.... ";

        }
    }
}
