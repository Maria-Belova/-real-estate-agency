﻿#pragma checksum "..\..\..\Pages\ObjectsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47FEB63A6F836BD6063083E0B5A6DE8E10CDBB3F"
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
    /// ObjectsPage
    /// </summary>
    public partial class ObjectsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Pages\ObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem ButtonEstateAll;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\ObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem ButtonEstateFlat;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Pages\ObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem ButtonEstateHouse;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\ObjectsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameObjectsEstate;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseProjectAgency;component/pages/objectspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ObjectsPage.xaml"
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
            this.ButtonEstateAll = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 28 "..\..\..\Pages\ObjectsPage.xaml"
            this.ButtonEstateAll.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ButtonEstateAll_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonEstateFlat = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 35 "..\..\..\Pages\ObjectsPage.xaml"
            this.ButtonEstateFlat.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ButtonEstateFlat_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonEstateHouse = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 42 "..\..\..\Pages\ObjectsPage.xaml"
            this.ButtonEstateHouse.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ButtonEstateHouse_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FrameObjectsEstate = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

