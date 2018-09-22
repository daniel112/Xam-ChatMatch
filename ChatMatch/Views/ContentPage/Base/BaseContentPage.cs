using System;
using System.ComponentModel;
using ChatMatch.Core.Common;
using Xamarin.Forms;

namespace ChatMatch.Core.Views.Base {

    public abstract class BaseContentPage<TVieModel> : ContentPage where TVieModel : INotifyPropertyChanged, new() {
        
        #region Variables
        protected TVieModel ViewModel = new TVieModel();
        #endregion


        #region Initialization
        protected BaseContentPage() {
            BindingContext = ViewModel;
        }



        protected override void OnSizeAllocated(double width, double height) {
            base.OnSizeAllocated(width, height);

           


        }


        #endregion


    }
}
