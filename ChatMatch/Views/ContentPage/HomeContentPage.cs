using System;
using ChatMatch.Core.ViewModels;
using ChatMatch.Core.Views.Base;

namespace ChatMatch.Core.Views {
    public class HomeContentPage : BaseContentPage<HomeViewModel> {
        #region Variables

        #endregion

        #region Initialization
        public HomeContentPage() {
            this.SetupContent();
        }

        protected override void OnAppearing() {
            base.OnAppearing();
        }

        protected override void OnDisappearing() {
            base.OnDisappearing();
        }
        #endregion

        #region Private API
        private void SetupContent() {
            this.Title = "Home";
        }
        #endregion

        #region Public API

        #endregion

        #region Delegates

        #endregion
    }
}
