﻿

#pragma checksum "C:\Users\clucky\Documents\Visual Studio 2013\Projects\MusicMink\MusicMink\Pages\HomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A612E7F87CB774E558F1CAF7355DC884"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicMink.Pages
{
    partial class HomePage : global::MusicMink.Pages.BasePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 36 "..\..\..\Pages\HomePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.HandleSongsNavigationItemTapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 49 "..\..\..\Pages\HomePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.HandleAlbumNavigationItemTapped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 61 "..\..\..\Pages\HomePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.HandleArtistsNavigationItemTapped;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 73 "..\..\..\Pages\HomePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.HandlePlaylistNavigationItemTapped;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 85 "..\..\..\Pages\HomePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.HandleLibraryNavigationItemTapped;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 97 "..\..\..\Pages\HomePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.HandleSettingsNavigationItemTapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


