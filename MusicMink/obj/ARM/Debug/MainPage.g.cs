﻿

#pragma checksum "C:\Users\clucky\Documents\Visual Studio 2013\Projects\MusicMink\MusicMink\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B39E2354AFCE11E8674E4F88C4BB280C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicMink
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 115 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Media.Animation.Timeline)(target)).Completed += this.PlayQueueHiddenCompleted;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 75 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Media.Animation.Timeline)(target)).Completed += this.PlayQueueOutCompleted;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 392 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.HandlePullDownArrowContainerClick;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 416 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.HandleHomeContainerClick;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 351 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).ManipulationStarted += this.HandlePlayerControlProgressBarBezzelManipulationStarted;
                 #line default
                 #line hidden
                #line 352 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).ManipulationDelta += this.HandlePlayerControlProgressBarBezzelManipulationDelta;
                 #line default
                 #line hidden
                #line 353 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).ManipulationCompleted += this.HandlePlayerControlProgressBarBezzelManipulationCompleted;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 224 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Holding += this.HandlePlayqueueListHolding;
                 #line default
                 #line hidden
                #line 225 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).DoubleTapped += this.HandlePlayqueueListDoubleTapped;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 206 "..\..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.HandlePlayQueueReorderAppBarToggleButtonTapped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


