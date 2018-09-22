using System;
using Plugin.Share.Abstractions;

namespace ChatMatch.Core.Common {
    public static class AppTheme {
        #region Variables

        #endregion

        #region Initialization

        #endregion


        #region Private API
      

        #endregion


        #region Public API
        public static string MainColor() {
            return "#42859f";
        }

        public static ShareColor BrowserNavColor() {
            return new ShareColor {
                A = 255,
                R = 72,
                G = 98,
                B = 163
            };
        }
        public static string DefaultTextColor() {
            return "#ffffff";
        }

        public static string DefaultBakcgroundColor() {
            return "#42859f";
        }
        #endregion

    }
}
