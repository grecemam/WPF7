﻿#pragma checksum "..\..\users.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1C4DC5BD6D6817319E823C88B61050C01F5989856FAD80F97D5DEA055965561F"
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
    /// users
    /// </summary>
    public partial class users : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridus;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox logintb;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordtb;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox rolecb;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbtn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addbtn;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbtn_Copy1;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\users.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backbtn_Copy2;
        
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
            System.Uri resourceLocater = new System.Uri("/10labaa;component/users.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\users.xaml"
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
            this.DataGridus = ((System.Windows.Controls.DataGrid)(target));
            
            #line 30 "..\..\users.xaml"
            this.DataGridus.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridus_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.logintb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.passwordtb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.rolecb = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.backbtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\users.xaml"
            this.backbtn.Click += new System.Windows.RoutedEventHandler(this.backbtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addbtn = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\users.xaml"
            this.addbtn.Click += new System.Windows.RoutedEventHandler(this.addbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.backbtn_Copy1 = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\users.xaml"
            this.backbtn_Copy1.Click += new System.Windows.RoutedEventHandler(this.backbtn_Copy1_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.backbtn_Copy2 = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\users.xaml"
            this.backbtn_Copy2.Click += new System.Windows.RoutedEventHandler(this.backbtn_Copy2_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

