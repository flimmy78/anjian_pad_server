﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\民用机表建档.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9E94AC9263F5F163A7D334C69DB38F3A"
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
    
    
    public partial class 民用机表建档 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.ObjectList pinpailist;
        
        internal Com.Aote.ObjectTools.ObjectList usegaslist;
        
        internal Com.Aote.ObjectTools.ObjectList qblxlist;
        
        internal Com.Aote.ObjectTools.ChildWindowObj openkafei;
        
        internal Com.Aote.ObjectTools.ChildWindowObj openxiangou;
        
        internal Com.Aote.ObjectTools.GeneralObject userfilego;
        
        internal Com.Aote.ObjectTools.GeneralObject areas;
        
        internal Com.Aote.ObjectTools.GeneralObject ksnumobj1;
        
        internal Com.Aote.ObjectTools.GeneralObject whfobj;
        
        internal Com.Aote.ObjectTools.GeneralObject mxggasobj;
        
        internal Com.Aote.Behaviors.BatchExcuteAction DeleteAction;
        
        internal Com.Aote.Behaviors.HQLAction DeleteApply;
        
        internal Com.Aote.Behaviors.BatchExcuteAction BatchSave;
        
        internal Com.Aote.Behaviors.HQLAction SubmitAction;
        
        internal Com.Aote.ObjectTools.GeneralObject areas1;
        
        internal Com.Aote.Behaviors.SyncActionFactory SaveAction;
        
        internal Com.Aote.Behaviors.CallMethodAction getbianhao;
        
        internal Com.Aote.Behaviors.CallMethodAction saveu;
        
        internal System.Windows.Controls.Grid userfilesearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid userfiles;
        
        internal Com.Aote.ObjectTools.PagedObjectList userfileslist;
        
        internal System.Windows.Controls.Button save;
        
        internal System.Windows.Controls.Grid userfile;
        
        internal System.Windows.Controls.ComboBox CoboxGasPro;
        
        internal System.Windows.Controls.ComboBox CoboxGas;
        
        internal System.Windows.Controls.ComboBox CoboxPinpai;
        
        internal System.Windows.Controls.ComboBox DaXiaoKa;
        
        internal System.Windows.Controls.DockPanel areafilesearch;
        
        internal System.Windows.Controls.Button areasearchbutton;
        
        internal System.Windows.Controls.DataGrid areafiles;
        
        internal Com.Aote.ObjectTools.ObjectList areafileslist;
        
        internal System.Windows.Controls.DataPager pager;
        
        internal Com.Aote.Controls.MessageTipObj submittip;
        
        internal Com.Aote.Controls.MessageTipObj deletettip;
        
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
                        "nent/Pages/%E6%B0%91%E7%94%A8%E6%9C%BA%E8%A1%A8%E5%BB%BA%E6%A1%A3.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pinpailist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("pinpailist")));
            this.usegaslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("usegaslist")));
            this.qblxlist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("qblxlist")));
            this.openkafei = ((Com.Aote.ObjectTools.ChildWindowObj)(this.FindName("openkafei")));
            this.openxiangou = ((Com.Aote.ObjectTools.ChildWindowObj)(this.FindName("openxiangou")));
            this.userfilego = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("userfilego")));
            this.areas = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("areas")));
            this.ksnumobj1 = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("ksnumobj1")));
            this.whfobj = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("whfobj")));
            this.mxggasobj = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("mxggasobj")));
            this.DeleteAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("DeleteAction")));
            this.DeleteApply = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteApply")));
            this.BatchSave = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("BatchSave")));
            this.SubmitAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("SubmitAction")));
            this.areas1 = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("areas1")));
            this.SaveAction = ((Com.Aote.Behaviors.SyncActionFactory)(this.FindName("SaveAction")));
            this.getbianhao = ((Com.Aote.Behaviors.CallMethodAction)(this.FindName("getbianhao")));
            this.saveu = ((Com.Aote.Behaviors.CallMethodAction)(this.FindName("saveu")));
            this.userfilesearch = ((System.Windows.Controls.Grid)(this.FindName("userfilesearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.userfiles = ((System.Windows.Controls.DataGrid)(this.FindName("userfiles")));
            this.userfileslist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("userfileslist")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.userfile = ((System.Windows.Controls.Grid)(this.FindName("userfile")));
            this.CoboxGasPro = ((System.Windows.Controls.ComboBox)(this.FindName("CoboxGasPro")));
            this.CoboxGas = ((System.Windows.Controls.ComboBox)(this.FindName("CoboxGas")));
            this.CoboxPinpai = ((System.Windows.Controls.ComboBox)(this.FindName("CoboxPinpai")));
            this.DaXiaoKa = ((System.Windows.Controls.ComboBox)(this.FindName("DaXiaoKa")));
            this.areafilesearch = ((System.Windows.Controls.DockPanel)(this.FindName("areafilesearch")));
            this.areasearchbutton = ((System.Windows.Controls.Button)(this.FindName("areasearchbutton")));
            this.areafiles = ((System.Windows.Controls.DataGrid)(this.FindName("areafiles")));
            this.areafileslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("areafileslist")));
            this.pager = ((System.Windows.Controls.DataPager)(this.FindName("pager")));
            this.submittip = ((Com.Aote.Controls.MessageTipObj)(this.FindName("submittip")));
            this.deletettip = ((Com.Aote.Controls.MessageTipObj)(this.FindName("deletettip")));
            this.savedone = ((Com.Aote.Controls.MessageTipObj)(this.FindName("savedone")));
        }
    }
}

