﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\抄表撤销.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0243D8CE1167264943B0D7D537A16459"
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
using Com.Aote.Controls;
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
    
    
    public partial class 抄表撤销 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.GeneralObject recordcancel;
        
        internal Com.Aote.ObjectTools.GeneralObject scbdw;
        
        internal Com.Aote.ObjectTools.GeneralObject sellgas;
        
        internal Com.Aote.Behaviors.BatchExcuteAction SaveAction;
        
        internal Com.Aote.ObjectTools.SearchObject search;
        
        internal Com.Aote.ObjectTools.PagedObjectList userfileslist;
        
        internal System.Windows.Controls.DockPanel userfilesearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataPager pager;
        
        internal System.Windows.Controls.DataGrid userfiles;
        
        internal System.Windows.Controls.Grid BigUnit;
        
        internal System.Windows.Controls.Grid handUserUnit;
        
        internal System.Windows.Controls.TextBox f_userid;
        
        internal System.Windows.Controls.TextBox dishu;
        
        internal System.Windows.Controls.TextBox chaobiaoren;
        
        internal System.Windows.Controls.TextBox yuefen;
        
        internal System.Windows.Controls.DatePicker chaobiaoriqi_Copy1;
        
        internal System.Windows.Controls.Grid reason;
        
        internal System.Windows.Controls.Button save;
        
        internal System.Windows.Controls.Button cancel;
        
        internal Com.Aote.Controls.MessageTipObj nouser;
        
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
                        "nent/Pages/%E6%8A%84%E8%A1%A8%E6%92%A4%E9%94%80.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.recordcancel = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("recordcancel")));
            this.scbdw = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("scbdw")));
            this.sellgas = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("sellgas")));
            this.SaveAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("SaveAction")));
            this.search = ((Com.Aote.ObjectTools.SearchObject)(this.FindName("search")));
            this.userfileslist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("userfileslist")));
            this.userfilesearch = ((System.Windows.Controls.DockPanel)(this.FindName("userfilesearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.pager = ((System.Windows.Controls.DataPager)(this.FindName("pager")));
            this.userfiles = ((System.Windows.Controls.DataGrid)(this.FindName("userfiles")));
            this.BigUnit = ((System.Windows.Controls.Grid)(this.FindName("BigUnit")));
            this.handUserUnit = ((System.Windows.Controls.Grid)(this.FindName("handUserUnit")));
            this.f_userid = ((System.Windows.Controls.TextBox)(this.FindName("f_userid")));
            this.dishu = ((System.Windows.Controls.TextBox)(this.FindName("dishu")));
            this.chaobiaoren = ((System.Windows.Controls.TextBox)(this.FindName("chaobiaoren")));
            this.yuefen = ((System.Windows.Controls.TextBox)(this.FindName("yuefen")));
            this.chaobiaoriqi_Copy1 = ((System.Windows.Controls.DatePicker)(this.FindName("chaobiaoriqi_Copy1")));
            this.reason = ((System.Windows.Controls.Grid)(this.FindName("reason")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.cancel = ((System.Windows.Controls.Button)(this.FindName("cancel")));
            this.nouser = ((Com.Aote.Controls.MessageTipObj)(this.FindName("nouser")));
        }
    }
}

