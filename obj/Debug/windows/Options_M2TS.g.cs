﻿#pragma checksum "..\..\..\windows\Options_M2TS.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2C942689668F683212A4CF2DEB06A897"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyUserControl;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace XviD4PSP {
    
    
    /// <summary>
    /// Options_M2TS
    /// </summary>
    public partial class Options_M2TS : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\windows\Options_M2TS.xaml"
        internal XviD4PSP.Options_M2TS Window;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.Grid grid_main;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.GroupBox group_muxing;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.Label label_split;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.ComboBox combo_split;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.CheckBox check_direct_remux;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.Label mkv_string_enter;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.Label mkv_string_warning;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.TextBox textbox_mkv_string;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.Grid grid_buttons;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.Button button_cancel;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\windows\Options_M2TS.xaml"
        internal System.Windows.Controls.Button button_ok;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/XviD4PSP;component/windows/options_m2ts.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\Options_M2TS.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Window = ((XviD4PSP.Options_M2TS)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.grid_main = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.group_muxing = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 5:
            this.label_split = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.combo_split = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\..\windows\Options_M2TS.xaml"
            this.combo_split.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.combo_split_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.check_direct_remux = ((System.Windows.Controls.CheckBox)(target));
            
            #line 16 "..\..\..\windows\Options_M2TS.xaml"
            this.check_direct_remux.Checked += new System.Windows.RoutedEventHandler(this.check_direct_remux_Checked);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\windows\Options_M2TS.xaml"
            this.check_direct_remux.Unchecked += new System.Windows.RoutedEventHandler(this.check_direct_remux_Unchecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mkv_string_enter = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.mkv_string_warning = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.textbox_mkv_string = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.grid_buttons = ((System.Windows.Controls.Grid)(target));
            return;
            case 12:
            this.button_cancel = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\windows\Options_M2TS.xaml"
            this.button_cancel.Click += new System.Windows.RoutedEventHandler(this.button_cancel_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.button_ok = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\windows\Options_M2TS.xaml"
            this.button_ok.Click += new System.Windows.RoutedEventHandler(this.button_ok_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
