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
        public string Description { get; set; }

        public SceneObj()
        {
            SceneID = Guid.NewGuid();
        }

    }
}
