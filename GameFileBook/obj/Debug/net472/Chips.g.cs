﻿#pragma checksum "..\..\..\Chips.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F5B8C1F5B93DC9DAC2F975E774BF993D700C7D61"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace MaterialDesignDemo {
    
    
    /// <summary>
    /// Chips
    /// </summary>
    public partial class Chips : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 310 "..\..\..\Chips.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RadioButtonGroupChoiceChip;
        
        #line default
        #line hidden
        
        
        #line 321 "..\..\..\Chips.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RadioButtonGroupChoiceChipPrimary;
        
        #line default
        #line hidden
        
        
        #line 332 "..\..\..\Chips.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RadioButtonGroupChoiceChipSecondary;
        
        #line default
        #line hidden
        
        
        #line 346 "..\..\..\Chips.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RadioButtonGroupChoiceChipOutline;
        
        #line default
        #line hidden
        
        
        #line 357 "..\..\..\Chips.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RadioButtonGroupChoiceChipPrimaryOutline;
        
        #line default
        #line hidden
        
        
        #line 368 "..\..\..\Chips.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox RadioButtonGroupChoiceChipSecondaryOutline;
        
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
            System.Uri resourceLocater = new System.Uri("/GameFileBook;component/chips.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Chips.xaml"
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
            
            #line 69 "..\..\..\Chips.xaml"
            ((MaterialDesignThemes.Wpf.Chip)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonsDemoChip_OnClick);
            
            #line default
            #line hidden
            
            #line 71 "..\..\..\Chips.xaml"
            ((MaterialDesignThemes.Wpf.Chip)(target)).DeleteClick += new System.Windows.RoutedEventHandler(this.ButtonsDemoChip_OnDeleteClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RadioButtonGroupChoiceChip = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.RadioButtonGroupChoiceChipPrimary = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            this.RadioButtonGroupChoiceChipSecondary = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.RadioButtonGroupChoiceChipOutline = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.RadioButtonGroupChoiceChipPrimaryOutline = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.RadioButtonGroupChoiceChipSecondaryOutline = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

