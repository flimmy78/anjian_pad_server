﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\民用业务受理.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "83777F54327CD92C3552D0F641B04C20"
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
    
    
    public partial class 民用业务受理 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.GeneralObject userfilego;
        
        internal Com.Aote.ObjectTools.GeneralObject areas;
        
        internal Com.Aote.Behaviors.BatchExcuteAction SaveAction;
        
        internal System.Windows.Controls.Grid userfilesearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid userfiles;
        
        internal Com.Aote.ObjectTools.PagedObjectList userfileslist;
        
        internal System.Windows.Controls.Button save;
        
        internal System.Windows.Controls.DockPanel areafilesearch;
        
        internal System.Windows.Controls.Button areasearchbutton;
        
        internal System.Windows.Controls.DataGrid areafiles;
        
        internal Com.Aote.ObjectTools.ObjectList areafileslist;
        
        internal System.Windows.Controls.Grid userfile;
        
        internal System.Windows.Controls.ComboBox CoboxGas;
        
        internal System.Windows.Controls.ComboBox yqxz;
        
        internal System.Windows.Controls.ComboBox qjlx;
        
        internal System.Windows.Controls.ComboBox qbpp;
        
        internal System.Windows.Controls.ComboBox qbxh;
        
        internal System.Windows.Controls.DataPager pager;
        
        internal Com.Aote.Controls.PrintObj print;
        
        internal System.Windows.Controls.Grid Feiprint;
        
        internal Com.Aote.ObjectTools.GeneralObject F;
        
        internal System.Windows.Controls.TextBlock 用户姓名;
        
        internal System.Windows.Controls.TextBlock 受理编号;
        
        internal System.Windows.Controls.TextBlock 楼号;
        
        internal System.Windows.Controls.DatePicker 签合同日期;
        
        internal System.Windows.Controls.TextBlock 电话;
        
        internal System.Windows.Controls.TextBlock 合同编号;
        
        internal System.Windows.Controls.TextBlock 受理凭证;
        
        internal System.Windows.Controls.TextBlock 小区;
        
        internal System.Windows.Controls.TextBlock 单元;
        
        internal System.Windows.Controls.TextBlock 室;
        
        internal System.Windows.Controls.TextBlock 受理人;
        
        internal System.Windows.Controls.TextBlock 受理备注;
        
        internal Com.Aote.Controls.MessageTipObj savedone;
        
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
                        "nent/Pages/%E6%B0%91%E7%94%A8%E4%B8%9A%E5%8A%A1%E5%8F%97%E7%90%86.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.userfilego = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("userfilego")));
            this.areas = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("areas")));
            this.SaveAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("SaveAction")));
            this.userfilesearch = ((System.Windows.Controls.Grid)(this.FindName("userfilesearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.userfiles = ((System.Windows.Controls.DataGrid)(this.FindName("userfiles")));
            this.userfileslist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("userfileslist")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.areafilesearch = ((System.Windows.Controls.DockPanel)(this.FindName("areafilesearch")));
            this.areasearchbutton = ((System.Windows.Controls.Button)(this.FindName("areasearchbutton")));
            this.areafiles = ((System.Windows.Controls.DataGrid)(this.FindName("areafiles")));
            this.areafileslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("areafileslist")));
            this.userfile = ((System.Windows.Controls.Grid)(this.FindName("userfile")));
            this.CoboxGas = ((System.Windows.Controls.ComboBox)(this.FindName("CoboxGas")));
            this.yqxz = ((System.Windows.Controls.ComboBox)(this.FindName("yqxz")));
            this.qjlx = ((System.Windows.Controls.ComboBox)(this.FindName("qjlx")));
            this.qbpp = ((System.Windows.Controls.ComboBox)(this.FindName("qbpp")));
            this.qbxh = ((System.Windows.Controls.ComboBox)(this.FindName("qbxh")));
            this.pager = ((System.Windows.Controls.DataPager)(this.FindName("pager")));
            this.print = ((Com.Aote.Controls.PrintObj)(this.FindName("print")));
            this.Feiprint = ((System.Windows.Controls.Grid)(this.FindName("Feiprint")));
            this.F = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("F")));
            this.用户姓名 = ((System.Windows.Controls.TextBlock)(this.FindName("用户姓名")));
            this.受理编号 = ((System.Windows.Controls.TextBlock)(this.FindName("受理编号")));
            this.楼号 = ((System.Windows.Controls.TextBlock)(this.FindName("楼号")));
            this.签合同日期 = ((System.Windows.Controls.DatePicker)(this.FindName("签合同日期")));
            this.电话 = ((System.Windows.Controls.TextBlock)(this.FindName("电话")));
            this.合同编号 = ((System.Windows.Controls.TextBlock)(this.FindName("合同编号")));
            this.受理凭证 = ((System.Windows.Controls.TextBlock)(this.FindName("受理凭证")));
            this.小区 = ((System.Windows.Controls.TextBlock)(this.FindName("小区")));
            this.单元 = ((System.Windows.Controls.TextBlock)(this.FindName("单元")));
            this.室 = ((System.Windows.Controls.TextBlock)(this.FindName("室")));
            this.受理人 = ((System.Windows.Controls.TextBlock)(this.FindName("受理人")));
            this.受理备注 = ((System.Windows.Controls.TextBlock)(this.FindName("受理备注")));
            this.savedone = ((Com.Aote.Controls.MessageTipObj)(this.FindName("savedone")));
        }
    }
}

