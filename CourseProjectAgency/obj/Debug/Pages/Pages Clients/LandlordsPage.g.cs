﻿#pragma checksum "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DB5772572C8EDC0A9A242C8E66AE9814799232BF"
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
    /// LandlordsPage
    /// </summary>
    public partial class LandlordsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid popupMessageGrid;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock popupMessage;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid LandlordsGrid;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid LandlordsGrid2;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton TBActive;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddLandlord;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDeleteLandlord;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonEditLandlord;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseProjectAgency;component/pages/pages%20clients/landlordspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
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
            this.LandlordsGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 49 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
            this.LandlordsGrid.PreviewMouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LandlordsGrid_DC);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LandlordsGrid2 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 59 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
            this.LandlordsGrid2.PreviewMouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LandlordsGrid_DC);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TBActive = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 70 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
            this.TBActive.Click += new System.Windows.RoutedEventHandler(this.TBActive_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonAddLandlord = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
            this.ButtonAddLandlord.Click += new System.Windows.RoutedEventHandler(this.ButtonAddLandlord_CLick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ButtonDeleteLandlord = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
            this.ButtonDeleteLandlord.Click += new System.Windows.RoutedEventHandler(this.ButtonDeleteLandlord_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonEditLandlord = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\..\Pages\Pages Clients\LandlordsPage.xaml"
            this.ButtonEditLandlord.Click += new System.Windows.RoutedEventHandler(this.ButtonEditLandlord_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

