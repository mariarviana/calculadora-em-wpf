﻿#pragma checksum "..\..\HomeJanela.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EDFD047C7C6E218D27859D3298DC3A5CBA798B916D70E3547D7996527A2C1D49"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// HomeJanela
    /// </summary>
    public partial class HomeJanela : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\HomeJanela.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_N1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\HomeJanela.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_N2;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\HomeJanela.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Adicao;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\HomeJanela.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Subtracao;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\HomeJanela.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Divisao;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\HomeJanela.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Multiplicacao;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\HomeJanela.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Sair2;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/homejanela.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HomeJanela.xaml"
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
            this.txt_N1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_N2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.bt_Adicao = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\HomeJanela.xaml"
            this.bt_Adicao.Click += new System.Windows.RoutedEventHandler(this.Btn_Adicao_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bt_Subtracao = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\HomeJanela.xaml"
            this.bt_Subtracao.Click += new System.Windows.RoutedEventHandler(this.bt_Subtracao_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bt_Divisao = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\HomeJanela.xaml"
            this.bt_Divisao.Click += new System.Windows.RoutedEventHandler(this.bt_Divisao_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bt_Multiplicacao = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\HomeJanela.xaml"
            this.bt_Multiplicacao.Click += new System.Windows.RoutedEventHandler(this.bt_Multiplicacao_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Btn_Sair2 = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\HomeJanela.xaml"
            this.Btn_Sair2.Click += new System.Windows.RoutedEventHandler(this.Btn_Sair2_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
