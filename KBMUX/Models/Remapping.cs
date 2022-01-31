using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBMUX
{
    public class Remapping
    {
        public List<string> OriginalKeys { get; set; }
        public List<string> RemappedKeys { get; set; }
        public bool IsAllApps { get; set; } = true;
        public string AppName { get; set; } = "All apps";
        public bool IsEnabled { get; set; } = true;
    }
}
