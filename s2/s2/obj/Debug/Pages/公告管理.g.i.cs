﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\公告管理.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "85D41F03D5D65336A896348A7D1FD652"
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
    
    
    public partial class 公告管理 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.Behaviors.HQLAction DeleteActionInfo;
        
        internal Com.Aote.ObjectTools.GeneralObject zonggongsi;
        
        internal Com.Aote.Behaviors.BatchExcuteAction SaveAction;
        
        internal Com.Aote.Behaviors.BatchExcuteAction DeleteAction;
        
        internal Com.Aote.ObjectTools.GeneralObject gonggao;
        
        internal Com.Aote.ObjectTools.ObjectList annexlist;
        
        internal System.Windows.Controls.DataPager pager;
        
        internal System.Windows.Controls.DockPanel pipelinesearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid pipelines;
        
        internal Com.Aote.ObjectTools.PagedObjectList pipelineslist;
        
        internal System.Windows.Controls.Grid pipeline;
        
        internal System.Windows.Controls.Button save;
        
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
                        "nent/Pages/%E5%85%AC%E5%91%8A%E7%AE%A1%E7%90%86.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.DeleteActionInfo = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteActionInfo")));
            this.zonggongsi = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("zonggongsi")));
            this.SaveAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("SaveAction")));
            this.DeleteAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("DeleteAction")));
            this.gonggao = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("gonggao")));
            this.annexlist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("annexlist")));
            this.pager = ((System.Windows.Controls.DataPager)(this.FindName("pager")));
            this.pipelinesearch = ((System.Windows.Controls.DockPanel)(this.FindName("pipelinesearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.pipelines = ((System.Windows.Controls.DataGrid)(this.FindName("pipelines")));
            this.pipelineslist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("pipelineslist")));
            this.pipeline = ((System.Windows.Controls.Grid)(this.FindName("pipeline")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
        }
    }
}

