﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\申请登记工商.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ECAB3AD0798EE7474791FBE24AB64EA3"
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
    
    
    public partial class 申请登记工商 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.ObjectList devicename;
        
        internal Com.Aote.ObjectTools.ObjectList paylist;
        
        internal Com.Aote.ObjectTools.ObjectList devicelist;
        
        internal Com.Aote.ObjectTools.ObjectList imagelist;
        
        internal Com.Aote.Behaviors.BatchExcuteAction DeleteAction;
        
        internal Com.Aote.Behaviors.HQLAction DeleteApply;
        
        internal Com.Aote.Behaviors.HQLAction DeleteImage;
        
        internal Com.Aote.Behaviors.HQLAction DeleteDevice;
        
        internal Com.Aote.Behaviors.HQLAction DeleteDirty;
        
        internal Com.Aote.Behaviors.BatchExcuteAction BatchSave;
        
        internal Com.Aote.Behaviors.HQLAction SubmitAction;
        
        internal System.Windows.Controls.StackPanel personsearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid persons;
        
        internal Com.Aote.ObjectTools.ObjectList personslist;
        
        internal System.Windows.Controls.StackPanel ybpersonsearch;
        
        internal System.Windows.Controls.Button ybsearchbutton;
        
        internal System.Windows.Controls.DataGrid ybpersons;
        
        internal Com.Aote.ObjectTools.ObjectList ybpersonslist;
        
        internal System.Windows.Controls.Grid main;
        
        internal Com.Aote.ObjectTools.GeneralObject persongo;
        
        internal System.Windows.Controls.Button save;
        
        internal System.Windows.Controls.Grid 申请单;
        
        internal Com.Aote.Controls.MessageTipObj submittip;
        
        internal Com.Aote.Controls.MessageTipObj deletettip;
        
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
                        "nent/Pages/%E7%94%B3%E8%AF%B7%E7%99%BB%E8%AE%B0%E5%B7%A5%E5%95%86.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.devicename = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("devicename")));
            this.paylist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("paylist")));
            this.devicelist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("devicelist")));
            this.imagelist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("imagelist")));
            this.DeleteAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("DeleteAction")));
            this.DeleteApply = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteApply")));
            this.DeleteImage = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteImage")));
            this.DeleteDevice = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteDevice")));
            this.DeleteDirty = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteDirty")));
            this.BatchSave = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("BatchSave")));
            this.SubmitAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("SubmitAction")));
            this.personsearch = ((System.Windows.Controls.StackPanel)(this.FindName("personsearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.persons = ((System.Windows.Controls.DataGrid)(this.FindName("persons")));
            this.personslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("personslist")));
            this.ybpersonsearch = ((System.Windows.Controls.StackPanel)(this.FindName("ybpersonsearch")));
            this.ybsearchbutton = ((System.Windows.Controls.Button)(this.FindName("ybsearchbutton")));
            this.ybpersons = ((System.Windows.Controls.DataGrid)(this.FindName("ybpersons")));
            this.ybpersonslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("ybpersonslist")));
            this.main = ((System.Windows.Controls.Grid)(this.FindName("main")));
            this.persongo = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("persongo")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.申请单 = ((System.Windows.Controls.Grid)(this.FindName("申请单")));
            this.submittip = ((Com.Aote.Controls.MessageTipObj)(this.FindName("submittip")));
            this.deletettip = ((Com.Aote.Controls.MessageTipObj)(this.FindName("deletettip")));
        }
    }
}

