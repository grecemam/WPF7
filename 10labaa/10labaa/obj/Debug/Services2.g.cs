﻿#pragma checksum "..\..\Services2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "85F3F7833C2D4D5BF03BB474EBFBD82F3B92140C9AC3B7171AAFEE5F7943C5A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using _10labaa;


namespace _10labaa {
    
    
    /// <summary>
    /// Services2
    /// </summary>
    public partial class Services2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\Services2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid serposDataGrid;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Services2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox poscb;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Services2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox sercb;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\Services2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbtn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Services2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addbtn;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Services2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updatebtn;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Services2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button delbtn;
        
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
            System.Uri resourceLocater = new System.Uri("/10labaa;component/services2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Services2.xaml"
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
            this.serposDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 30 "..\..\Services2.xaml"
            this.serposDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.poscb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.sercb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.backbtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\Services2.xaml"
            this.backbtn.Click += new System.Windows.RoutedEventHandler(this.backbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addbtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\Services2.xaml"
            this.addbtn.Click += new System.Windows.RoutedEventHandler(this.addbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.updatebtn = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\Services2.xaml"
            this.updatebtn.Click += new System.Windows.RoutedEventHandler(this.updatebtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.delbtn = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\Services2.xaml"
            this.delbtn.Click += new System.Windows.RoutedEventHandler(this.delbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

