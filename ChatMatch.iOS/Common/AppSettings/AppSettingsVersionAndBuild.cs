using System;
using System.Runtime.CompilerServices;
using ChatMatch.Core.Components.Common;
using ChatMatch.iOS.Common.AppSettings;
using Foundation;

[assembly: Xamarin.Forms.Dependency(typeof(AppSettingsVersionAndBuild))]
namespace ChatMatch.iOS.Common.AppSettings {
    public class AppSettingsVersionAndBuild : IAppSettingsVersionAndBuild {

        public string GetBuildNumber() {
            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString();  
        }

        public string GetVersionNumber() {
            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
        }
    }
}
