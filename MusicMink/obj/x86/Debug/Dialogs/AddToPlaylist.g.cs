﻿

#pragma checksum "C:\Users\clucky\Documents\Visual Studio 2013\Projects\Chime81\Chime81\Dialogs\AddToPlaylist.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A7E636DD6C492996E0A18E4A435F6760"
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
    partial class AddToPlaylist : global::Windows.UI.Xaml.Controls.ContentDialog, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 10 "..\..\..\Dialogs\AddToPlaylist.xaml"
                ((global::Windows.UI.Xaml.Controls.ContentDialog)(target)).PrimaryButtonClick += this.HandleContentDialogPrimaryButtonClick;
                 #line default
                 #line hidden
                #line 11 "..\..\..\Dialogs\AddToPlaylist.xaml"
                ((global::Windows.UI.Xaml.Controls.ContentDialog)(target)).SecondaryButtonClick += this.HandleContentDialogSecondaryButtonClick;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


