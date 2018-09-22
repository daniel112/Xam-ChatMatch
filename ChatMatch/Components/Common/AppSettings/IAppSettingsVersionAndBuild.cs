using System;
namespace ChatMatch.Core.Components.Common {
    public interface IAppSettingsVersionAndBuild {  
        string GetVersionNumber();  
        string GetBuildNumber();  
    } 
}
