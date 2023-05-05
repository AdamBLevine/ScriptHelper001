using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptHelper
{
    public class NotesMovieText
    {
        public string myMovieText { get; set; }
        public string myNote { get; set; }

        public string myLabel { get; set; } 

        public NotesMovieText(string x,string y, string z)
        {
            myMovieText = x;
            myNote = y;
            myLabel = z;
        }
    }
}
