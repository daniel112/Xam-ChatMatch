using System;
using ChatMatch.Core.Common;
using ChatMatch.Core.Constants;
using ChatMatch.Core.Models.Local;
using ChatMatch.Core.ViewModels;
using ChatMatch.Core.Views.Base;
using ChatMatch.Views;
using Plugin.Share;
using Plugin.Share.Abstractions;
using Xamarin.Forms;

namespace ChatMatch.Core.Views {
    public class SideMenuContentPage : BaseContentPage<SideMenuViewModel> {



        #region Variables

        private ListView _SideMenuListView;
        private ListView SideMenuListView {
            get {

                if (_SideMenuListView == null) {

                    _SideMenuListView = new ListView();
                    _SideMenuListView.ItemsSource = this.ViewModel.SideMenuItems;
                    _SideMenuListView.ItemTapped += SideMenuListView_ItemTapped;
                    _SideMenuListView.BackgroundColor = Color.Transparent;
                    _SideMenuListView.SeparatorVisibility = SeparatorVisibility.None;

                    _SideMenuListView.ItemTemplate = new DataTemplate(() => {
                        FlexLayout contentFlexLayout = new FlexLayout {
                            Direction = FlexDirection.Row,
                            AlignItems = FlexAlignItems.Center,
                            JustifyContent = FlexJustify.Start,
                            BackgroundColor = Color.Transparent
                        };
                                            
                        // icon
                        var image = new Image {
                            Aspect = Aspect.AspectFit,
                            WidthRequest = 24,
                            HeightRequest = 24,
                            Margin = new Thickness(25, 0, 10, 0)
                        };
                        image.SetBinding(Image.SourceProperty, nameof(SideMenuItem.IconSource));

                        // label
                        var label = new Label {
                            VerticalOptions = LayoutOptions.FillAndExpand,
                            TextColor = Color.White,
                            BackgroundColor = Color.Transparent
                        };
                        label.SetBinding(Label.TextProperty, nameof(SideMenuItem.Title));

                        contentFlexLayout.Children.Add(image);
                        contentFlexLayout.Children.Add(label);

                        return new ViewCell { View = contentFlexLayout };
                    });

                }
                return _SideMenuListView;
            }
        }


        private Label _LabelHeader;
        private Label LabelHeader {
            get {
                if (_LabelHeader == null) {
                    _LabelHeader = new Label {
                        TextColor = Color.White,
                        FontSize = 18,
                        Margin = new Thickness(20,50,20,20),
                        HorizontalTextAlignment = TextAlignment.Center,
                        FontAttributes = FontAttributes.Bold,
                    };
                }
                return _LabelHeader;           
            }
        }

        private Label _LabelFooter;
        private Label LabelFooter {
            get {
                if (_LabelFooter == null) {
                    _LabelFooter = new Label {
                        TextColor = Color.White,
                        FontSize = 12,
                        Margin = new Thickness(20),
                        HorizontalTextAlignment = TextAlignment.Center
                    };
                }
                return _LabelFooter;
            }
        }

        #endregion

        #region Initialization

        public SideMenuContentPage() {
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
            this.Title = "Side Menu";
            this.BackgroundColor = Color.FromHex(AppTheme.DefaultBakcgroundColor());
            this.Icon = ImageNavigation.Menu;
            // header
            LabelHeader.Text = "ChatMatch";

            // footer
            LabelFooter.Text = $"Version {AppSettings.Instance.VersionNumber} Build {AppSettings.Instance.BuildNumber}";
            Content = new StackLayout {
                Children = {
                    LabelHeader,
                    SideMenuListView,
                    LabelFooter
                }
            };
        }
        private void OpenWebView(string url) {
            BrowserOptions options = new BrowserOptions {
                ChromeShowTitle = true,
                ChromeToolbarColor = AppTheme.BrowserNavColor(),
                SafariBarTintColor = AppTheme.BrowserNavColor(),
                UseSafariReaderMode = true,
                UseSafariWebViewController = true
            };

            // Android: opens in chrome custom tab if available
            // iOS open in SafariVC if available
            CrossShare.Current.OpenBrowser(url, options);
        }

        // UIResponder
        void SideMenuListView_ItemTapped(object sender, ItemTappedEventArgs e) {

            SideMenuItem item = (SideMenuItem)e.Item;
            BaseNavigationPage currentNavigationPage = (BaseNavigationPage)((MasterDetailPage)Application.Current.MainPage).Detail;
            if (item.Title == "Home") {
                ((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
                if (!(currentNavigationPage.RootPage is HomeContentPage)) {
                    ((MasterDetailPage)Application.Current.MainPage).Detail = new BaseNavigationPage(new HomeContentPage());
                }
            } else if (item.Title == "Website") {
                ((MasterDetailPage)Application.Current.MainPage).IsPresented = true;
                this.OpenWebView("https://chatmatch.me/");
            } 

            // deselect
            ListView lst = (ListView)sender;
            lst.SelectedItem = null;
        }

        #endregion


        #region Public API

        #endregion

        #region Delegates

        #endregion
    }
}
