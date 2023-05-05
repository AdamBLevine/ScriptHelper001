using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptHelper
{
    
    public class MovieObj
    {

        public string title { get; set; }
        public string movieHintText { get; set; }
        public string movieText { get; set; }
        public string movieTextBackup { get; set; }
        public string movieTextCompiled { get; set; }

        public Guid id { get; set; }

        public List<NotesMovieText> myNoteTextList { get; set; }


        public MovieObj() 
        
        { 
            id= Guid.NewGuid();
            movieHintText = "put your ideas here";
            myNoteTextList = new List<NotesMovieText>();
            
        }

        




    }
}
