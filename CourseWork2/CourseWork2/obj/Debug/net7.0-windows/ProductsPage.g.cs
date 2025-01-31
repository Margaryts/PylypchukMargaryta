﻿#pragma checksum "..\..\..\ProductsPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9B94C53FE67C16934B93AB18E2DF09538704FF6C"
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
using System.Windows.Controls.Ribbon;
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


namespace CourseWork2 {
    
    
    /// <summary>
    /// ProductsPage
    /// </summary>
    public partial class ProductsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CategoriesListBox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProductsDataGrid;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProductNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProductBrandTextBlock;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProductPriceTextBlock;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProductStockTextBlock;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProductDescriptionTextBlock;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ViewOrdersButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\ProductsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddProductButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CourseWork2;component/productspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ProductsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CategoriesListBox = ((System.Windows.Controls.ListBox)(target));
            
            #line 18 "..\..\..\ProductsPage.xaml"
            this.CategoriesListBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CategoriesListBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ProductsDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 31 "..\..\..\ProductsPage.xaml"
            this.ProductsDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductsDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ProductNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.ProductBrandTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ProductPriceTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ProductStockTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ProductDescriptionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ViewOrdersButton = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\ProductsPage.xaml"
            this.ViewOrdersButton.Click += new System.Windows.RoutedEventHandler(this.ViewOrdersButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddProductButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\ProductsPage.xaml"
            this.AddProductButton.Click += new System.Windows.RoutedEventHandler(this.AddProductButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

