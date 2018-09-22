using System;
using ChatMatch.Core.Common;
using Xamarin.Forms;

namespace ChatMatch.Views {
    public class BaseNavigationPage : NavigationPage {
        public BaseNavigationPage() {
        }

        public BaseNavigationPage(Page root) : base(root) {
            BarBackgroundColor = Color.FromHex(AppTheme.MainColor());
            BarTextColor = Color.FromHex(AppTheme.DefaultTextColor());
        }
    }
}
