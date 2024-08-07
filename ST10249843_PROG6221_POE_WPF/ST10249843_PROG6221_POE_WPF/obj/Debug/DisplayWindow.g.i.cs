﻿#pragma checksum "..\..\DisplayWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A5D415284CF08E7267637BD1A0A8B590721CC5D75BB1209931127F2A2FFD02EB"
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


namespace ST10249843_PROG6221_POE {
    
    
    /// <summary>
    /// DisplayWindow
    /// </summary>
    public partial class DisplayWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 72 "..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RecipeListBox;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RecipeNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl IngredientsListBox;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl StepsListBox;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TotalCaloriesTextBlock;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\DisplayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WarningTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/ST10249843_PROG6221_POE_WPF;component/displaywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DisplayWindow.xaml"
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
            this.RecipeListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 72 "..\..\DisplayWindow.xaml"
            this.RecipeListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RecipeListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RecipeNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.IngredientsListBox = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 4:
            this.StepsListBox = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 5:
            this.TotalCaloriesTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.WarningTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 127 "..\..\DisplayWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

