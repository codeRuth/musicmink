﻿

#pragma checksum "C:\Users\clucky\Documents\Visual Studio 2013\Projects\Chime81\Chime81\Dialogs\EditPlaylist.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "997AD2D8519EB6CBAD6D937369DEC77D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicMink.Dialogs
{
    partial class EditPlaylist : global::Windows.UI.Xaml.Controls.ContentDialog, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 10 "..\..\..\Dialogs\EditPlaylist.xaml"
                ((global::Windows.UI.Xaml.Controls.ContentDialog)(target)).PrimaryButtonClick += this.HandleContentDialogPrimaryButtonClick;
                 #line default
                 #line hidden
                #line 11 "..\..\..\Dialogs\EditPlaylist.xaml"
                ((global::Windows.UI.Xaml.Controls.ContentDialog)(target)).SecondaryButtonClick += this.HandleContentDialogSecondaryButtonClick;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 30 "..\..\..\Dialogs\EditPlaylist.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.HandleDeletePlaylistChecked;
                 #line default
                 #line hidden
                #line 31 "..\..\..\Dialogs\EditPlaylist.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Unchecked += this.HandleDeletePlaylistUnchecked;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


