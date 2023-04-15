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

namespace ScriptHelper
{
    public partial class Form1 : Form
    {

        public OpenAIAPI api = new OpenAIAPI("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");

       
        List<SceneObj> scenes = new List<SceneObj>();

        
        
        

        // Set up the ListBox
        
        public Form1()
        {
            InitializeComponent();

            SceneObj scene = new SceneObj();
            scene.Title = "Before The Assault";
            scene.Description = @"several hundred COnfederate soldiers are forming up into a line in the woods, just west of the end of the Union line.  It is getting late in the afternoon, about 
5:00pm";

            scenes.Add(scene);

            scene = new SceneObj();

            scene.Title = "The Assault";
            scene.Description = @"several hundred COnfederate soldiers charge from the woods yelliung and shooting as the over run the left end of the Union Army who were completely
unprepared for the assualt.  The Union soldiers were cooking dinner and flee mostly without their weapons";


            scenes.Add(scene);


            scene = new SceneObj();

            scene.Title = "After The Assault";
            scene.Description = @"several hundred COnfederate soldiers are are picking through the tents and packs of hte Union soldiers who ran from the assault";


            scenes.Add(scene);


            ScenesList.DataSource = scenes;


            ScenesList.DisplayMember = "Title";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {
            

        }

        private async void Button1_Click_1(object sender, EventArgs e)
        {
            
            MovieText.Text = MovieHintText.Text + "\n awaiting reply...";
            string reply = await MyGPT.makeMovieText(api, MovieHintText.Text);
            MovieText.Text = reply;

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
    }
}
