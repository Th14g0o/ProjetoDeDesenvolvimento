﻿#pragma checksum "..\..\..\ListarMembrosWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3D062C4BD408A4914AA755E081C0F9CAECBD356C"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using POOzap;
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


namespace POOzap {
    
    
    /// <summary>
    /// ListarMembrosWindow
    /// </summary>
    public partial class ListarMembrosWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\ListarMembrosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox todosMG1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\ListarMembrosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox todosMG2;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ListarMembrosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button listarMG;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\ListarMembrosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button removerMG;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\ListarMembrosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button promoverMG;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\ListarMembrosWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rebaixarMG;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/POOzap;component/listarmembroswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ListarMembrosWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.todosMG1 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.todosMG2 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.listarMG = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\ListarMembrosWindow.xaml"
            this.listarMG.Click += new System.Windows.RoutedEventHandler(this.listarMG_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.removerMG = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\ListarMembrosWindow.xaml"
            this.removerMG.Click += new System.Windows.RoutedEventHandler(this.removerMG_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.promoverMG = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\ListarMembrosWindow.xaml"
            this.promoverMG.Click += new System.Windows.RoutedEventHandler(this.promoverMG_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rebaixarMG = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\ListarMembrosWindow.xaml"
            this.rebaixarMG.Click += new System.Windows.RoutedEventHandler(this.rebaixarMG_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

