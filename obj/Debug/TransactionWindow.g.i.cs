﻿#pragma checksum "..\..\TransactionWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02A4B0B9BC8D361937939F9B61EE63D900387CC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Final_Project;
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


namespace Final_Project {
    
    
    /// <summary>
    /// TransactionWindow
    /// </summary>
    public partial class TransactionWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 105 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCustomer;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbJewelryType;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbJewelryQuality;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddCustomer;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddTransaction;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtWeight;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDiscount;
        
        #line default
        #line hidden
        
        
        #line 184 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtActualValue;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLoanAmount;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtInterest;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtOtherDetails;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\TransactionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker transDate;
        
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
            System.Uri resourceLocater = new System.Uri("/Final Project;component/transactionwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TransactionWindow.xaml"
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
            
            #line 9 "..\..\TransactionWindow.xaml"
            ((Final_Project.TransactionWindow)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbCustomer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cmbJewelryType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cmbJewelryQuality = ((System.Windows.Controls.ComboBox)(target));
            
            #line 131 "..\..\TransactionWindow.xaml"
            this.cmbJewelryQuality.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbJewelryQuality_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnAddCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\TransactionWindow.xaml"
            this.btnAddCustomer.Click += new System.Windows.RoutedEventHandler(this.BtnAddCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 146 "..\..\TransactionWindow.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAddTransaction = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\TransactionWindow.xaml"
            this.btnAddTransaction.Click += new System.Windows.RoutedEventHandler(this.BtnAddTransaction_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtWeight = ((System.Windows.Controls.TextBox)(target));
            
            #line 172 "..\..\TransactionWindow.xaml"
            this.txtWeight.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtWeight_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.txtDiscount = ((System.Windows.Controls.TextBox)(target));
            
            #line 179 "..\..\TransactionWindow.xaml"
            this.txtDiscount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDiscount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtActualValue = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.txtLoanAmount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.txtInterest = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.txtOtherDetails = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.transDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

