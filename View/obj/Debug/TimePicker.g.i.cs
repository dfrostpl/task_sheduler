﻿#pragma checksum "..\..\TimePicker.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "56FC0C7BA0C36AEA5C4C8B8992091A85"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace View {
    
    
    /// <summary>
    /// TimePicker
    /// </summary>
    public partial class TimePicker : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AddHoursTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HourUpButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HourDownButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AddMinutesTextBox;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinutesUpButton;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinutesDownButton;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\TimePicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AmPmComboBox;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/timepicker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TimePicker.xaml"
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
            this.AddHoursTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.HourUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\TimePicker.xaml"
            this.HourUpButton.Click += new System.Windows.RoutedEventHandler(this.HourUpButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.HourDownButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\TimePicker.xaml"
            this.HourDownButton.Click += new System.Windows.RoutedEventHandler(this.HourDownButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddMinutesTextBox = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.MinutesUpButton = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\TimePicker.xaml"
            this.MinutesUpButton.Click += new System.Windows.RoutedEventHandler(this.MinutesUpButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MinutesDownButton = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\TimePicker.xaml"
            this.MinutesDownButton.Click += new System.Windows.RoutedEventHandler(this.MinutesDownButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AmPmComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

