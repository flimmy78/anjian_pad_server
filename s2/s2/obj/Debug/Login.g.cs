﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "881239523359E4C3917B93B33CE9294E"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Com.Aote.Pages {
    
    
    public partial class Login : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.StackPanel LayoutRoot;
        
        internal System.Windows.Controls.Grid loginForm;
        
        internal System.Windows.Controls.TextBox name;
        
        internal System.Windows.Controls.PasswordBox password;
        
        internal System.Windows.Controls.Button okbutton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/%E5%A5%A5%E6%9E%AB%E7%87%83%E6%B0%94%E8%90%A5%E6%94%B6%E7%B3%BB%E7%BB%9FV3;compo" +
                        "nent/Login.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.StackPanel)(this.FindName("LayoutRoot")));
            this.loginForm = ((System.Windows.Controls.Grid)(this.FindName("loginForm")));
            this.name = ((System.Windows.Controls.TextBox)(this.FindName("name")));
            this.password = ((System.Windows.Controls.PasswordBox)(this.FindName("password")));
            this.okbutton = ((System.Windows.Controls.Button)(this.FindName("okbutton")));
        }
    }
}

