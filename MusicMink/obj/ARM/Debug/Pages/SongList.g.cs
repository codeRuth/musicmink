﻿

#pragma checksum "C:\Users\clucky\Documents\Visual Studio 2013\Projects\MusicMink\MusicMink\Pages\SongList.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4EF1CA9B098B95A677695AA7EA23364A"
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
    partial class SongList : global::MusicMink.Pages.BasePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 38 "..\..\..\Pages\SongList.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.SongListItem_Tapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


