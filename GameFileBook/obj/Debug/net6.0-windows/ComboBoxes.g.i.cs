﻿#pragma checksum "..\..\..\ComboBoxes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "581F35E30CFE6D3D6731BF8B95DE4E52E9302192"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using GameFileBook;
using GameFileBook.Converters;
using GameFileBook.Domain;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using ShowMeTheXAML;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace GameFileBook {
    
    
    /// <summary>
    /// ComboBoxes
    /// </summary>
    public partial class ComboBoxes : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 111 "..\..\..\ComboBoxes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox DisplaySelectedItemCheckBox;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\ComboBoxes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ClassicModeCheckBox;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\ComboBoxes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilledComboBoxEnabledCheckBox;
        
        #line default
        #line hidden
        
        
        #line 238 "..\..\..\ComboBoxes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilledComboBox;
        
        #line default
        #line hidden
        
        
        #line 293 "..\..\..\ComboBoxes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox OutlinedComboBoxEnabledCheckBox;
        
        #line default
        #line hidden
        
        
        #line 305 "..\..\..\ComboBoxes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OutlinedComboBox;
        
        #line default
        #line hidden
        
        
        #line 348 "..\..\..\ComboBoxes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxClockwiseRotateContent;
        
        #line default
        #line hidden
        
        
        #line 423 "..\..\..\ComboBoxes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxCounterClockwiseRotateContent;
        
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
            System.Uri resourceLocater = new System.Uri("/GameFileBook;component/comboboxes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ComboBoxes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.DisplaySelectedItemCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.ClassicModeCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.FilledComboBoxEnabledCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            
            #line 233 "..\..\..\ComboBoxes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClearFilledComboBox_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FilledComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.OutlinedComboBoxEnabledCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            
            #line 300 "..\..\..\ComboBoxes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClearOutlinedComboBox_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.OutlinedComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.CheckBoxClockwiseRotateContent = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.CheckBoxCounterClockwiseRotateContent = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
