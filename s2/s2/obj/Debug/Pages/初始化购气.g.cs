﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\初始化购气.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F86623C11A064474687A05CFB8D6F388"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class 初始化购气 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.NewGeneralICCard card;
        
        internal Com.Aote.ObjectTools.GeneralObject users;
        
        internal Com.Aote.ObjectTools.PagedObjectList pipelineslist;
        
        internal System.Windows.Controls.DockPanel pipelinesearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid pipelines;
        
        internal System.Windows.Controls.Grid userfile;
        
        internal System.Windows.Controls.Button save;
        
        internal System.Windows.Controls.Button cancel;
        
        internal System.Windows.Controls.TextBox f_userid;
        
        internal System.Windows.Controls.DataPager pager;
        
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
                        "nent/Pages/%E5%88%9D%E5%A7%8B%E5%8C%96%E8%B4%AD%E6%B0%94.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.card = ((Com.Aote.ObjectTools.NewGeneralICCard)(this.FindName("card")));
            this.users = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("users")));
            this.pipelineslist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("pipelineslist")));
            this.pipelinesearch = ((System.Windows.Controls.DockPanel)(this.FindName("pipelinesearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.pipelines = ((System.Windows.Controls.DataGrid)(this.FindName("pipelines")));
            this.userfile = ((System.Windows.Controls.Grid)(this.FindName("userfile")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.cancel = ((System.Windows.Controls.Button)(this.FindName("cancel")));
            this.f_userid = ((System.Windows.Controls.TextBox)(this.FindName("f_userid")));
            this.pager = ((System.Windows.Controls.DataPager)(this.FindName("pager")));
        }
    }
}

