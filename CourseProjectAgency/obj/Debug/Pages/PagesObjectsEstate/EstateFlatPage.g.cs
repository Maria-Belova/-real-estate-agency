﻿#pragma checksum "..\..\..\..\Pages\PagesObjectsEstate\EstateFlatPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5B5319BFC23C704B783ED281046A79B4F3D86A8F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseProjectAgency;
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


namespace CourseProjectAgency {
    
    
    /// <summary>
    /// EstateFlatPage
    /// </summary>
    public partial class EstateFlatPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\Pages\PagesObjectsEstate\EstateFlatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid popupMessageGrid;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\PagesObjectsEstate\EstateFlatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock popupMessage;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Pages\PagesObjectsEstate\EstateFlatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EstateFlatGrid;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\Pages\PagesObjectsEstate\EstateFlatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EstateFlatGrid2;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\Pages\PagesObjectsEstate\EstateFlatPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton TBActive;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseProjectAgency;component/pages/pagesobjectsestate/estateflatpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\PagesObjectsEstate\EstateFlatPage.xaml"
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
            this.popupMessageGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.popupMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.EstateFlatGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.EstateFlatGrid2 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.TBActive = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 75 "..\..\..\..\Pages\PagesObjectsEstate\EstateFlatPage.xaml"
            this.TBActive.Click += new System.Windows.RoutedEventHandler(this.TBActive_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

