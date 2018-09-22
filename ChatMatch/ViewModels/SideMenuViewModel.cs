using System;
using Xamarin.Forms;
using ChatMatch.Core.ViewModels.Base;
using System.Collections.Generic;
using ChatMatch.Core.Models.Local;
using ChatMatch.Core.Views;
using ChatMatch.Core.Constants;

namespace ChatMatch.Core.ViewModels {
    
    public class SideMenuViewModel : BaseViewModel {
        
        #region Variables
        private List<SideMenuItem> _SideMenuItems;
        public List<SideMenuItem> SideMenuItems {
            get {
                if (_SideMenuItems == null) {
                    _SideMenuItems = new List<SideMenuItem>();
                    _SideMenuItems.Add(new SideMenuItem {
                        Title = "Home",
                        IconSource = ImageSideMenu.Home,
                        TargetType = typeof(HomeContentPage)
                    });
                    _SideMenuItems.Add(new SideMenuItem {
                        Title = "Website",
                        IconSource = ImageSideMenu.Website,
                        TargetType = null
                    });
                }
                return _SideMenuItems;
            }
        }
        #endregion

        #region Initialization

        #endregion


        #region Private API


        #endregion


        #region Public API

        #endregion

        #region Delegates

        #endregion
    }
}
