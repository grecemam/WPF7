﻿#pragma checksum "..\..\visitors.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "810E20E9ED0357666FB1904B516F6797B0D326637041B1758A79A7919B2CF6AD"
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
    /// visitors
    /// </summary>
    public partial class visitors : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\visitors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid visDataGrid;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\visitors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surnamebl;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\visitors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox namebl;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\visitors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mnbl;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\visitors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox usercb;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\visitors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbtn;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\visitors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addbtn;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\visitors.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button updatebtn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\visitors.xaml"
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
            System.Uri resourceLocater = new System.Uri("/10labaa;component/visitors.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\visitors.xaml"
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
            this.visDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 30 "..\..\visitors.xaml"
            this.visDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.surnamebl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.namebl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.mnbl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.usercb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.backbtn = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\visitors.xaml"
            this.backbtn.Click += new System.Windows.RoutedEventHandler(this.backbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.addbtn = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\visitors.xaml"
            this.addbtn.Click += new System.Windows.RoutedEventHandler(this.addbtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.updatebtn = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\visitors.xaml"
            this.updatebtn.Click += new System.Windows.RoutedEventHandler(this.updatebtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.delbtn = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\visitors.xaml"
            this.delbtn.Click += new System.Windows.RoutedEventHandler(this.delbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

