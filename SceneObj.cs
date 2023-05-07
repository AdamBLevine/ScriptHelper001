using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptHelper
{
    public class SceneObj
    {
        public Guid SceneID { get; set; }
        public string Title { get; set; }
        public string SettingKey { get; set; }
        public string Hint { get; set; }
        public string NarrativeText { get; set; }

        public string BeatSheetText { get; set; }

        public string SceneScript { get; set; }

        public SceneObj()
        {
            SceneID = Guid.NewGuid();
            Title = "";
            SettingKey = "";
            Hint = "";
            NarrativeText = "";
            BeatSheetText = "";
            SceneScript = "";

        }

    }
}
