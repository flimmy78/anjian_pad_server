﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\档案修改字段.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "397BF02BC4B127F127144FD182BEBF93"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Com.Aote.Behaviors;
using Com.Aote.ObjectTools;
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
    
    
    public partial class 档案修改字段 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.Behaviors.HQLAction DeleteAction;
        
        internal Com.Aote.Behaviors.HQLAction SubmitAction;
        
        internal System.Windows.Controls.DockPanel userfilesearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid userfiles;
        
        internal Com.Aote.ObjectTools.ObjectList userfileslist;
        
        internal System.Windows.Controls.Button save;
        
        internal System.Windows.Controls.Grid userfile;
        
        internal Com.Aote.ObjectTools.GeneralObject userfilego;
        
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
                        "nent/Pages/%E6%A1%A3%E6%A1%88%E4%BF%AE%E6%94%B9%E5%AD%97%E6%AE%B5.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.DeleteAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteAction")));
            this.SubmitAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("SubmitAction")));
            this.userfilesearch = ((System.Windows.Controls.DockPanel)(this.FindName("userfilesearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.userfiles = ((System.Windows.Controls.DataGrid)(this.FindName("userfiles")));
            this.userfileslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("userfileslist")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.userfile = ((System.Windows.Controls.Grid)(this.FindName("userfile")));
            this.userfilego = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("userfilego")));
        }
    }
}

