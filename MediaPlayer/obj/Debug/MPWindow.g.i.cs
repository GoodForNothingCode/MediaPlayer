﻿#pragma checksum "..\..\MPWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "07E5A306B4AD476808B0E15C5F89E376"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MediaPlayer.UI.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MediaPlayer.UI {
    
    
    /// <summary>
    /// MPWindow
    /// </summary>
    public partial class MPWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 4 "..\..\MPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MediaPlayer.UI.MPWindow MusicPlayer_Window;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\MPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Media_StackPanel;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\MPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MediaPlayer.UI.Views.MediaPanel MediaPanel;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\MPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Playback_StackPanel;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\MPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MediaPlayer.UI.Views.PlaybackPanel Playback_Control;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu MP_Menu;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Menu;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AddSong_MenuItem;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\MPWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem Exit_MenuItem;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MediaPlayer;component/mpwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MPWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MusicPlayer_Window = ((MediaPlayer.UI.MPWindow)(target));
            return;
            case 2:
            this.Media_StackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.MediaPanel = ((MediaPlayer.UI.Views.MediaPanel)(target));
            return;
            case 4:
            this.Playback_StackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.Playback_Control = ((MediaPlayer.UI.Views.PlaybackPanel)(target));
            return;
            case 6:
            this.MP_Menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 7:
            this.Menu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\MPWindow.xaml"
            this.Menu.Click += new System.Windows.RoutedEventHandler(this.Menu_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.AddSong_MenuItem = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 9:
            this.Exit_MenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\MPWindow.xaml"
            this.Exit_MenuItem.Click += new System.Windows.RoutedEventHandler(this.Exit_MenuItem_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

