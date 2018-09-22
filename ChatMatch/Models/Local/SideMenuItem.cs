using System;
namespace ChatMatch.Core.Models.Local {
    public class SideMenuItem {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}
