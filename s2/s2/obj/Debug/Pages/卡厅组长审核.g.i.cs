﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\卡厅组长审核.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BB06C45ED264633A97487AD5B6962FD4"
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
    
    
    public partial class 卡厅组长审核 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.GeneralObject minshgasnum;
        
        internal Com.Aote.ObjectTools.GeneralObject feishgasnum;
        
        internal Com.Aote.Behaviors.HQLAction DeleteAction;
        
        internal Com.Aote.Behaviors.BatchExcuteAction SaveAction;
        
        internal Com.Aote.Behaviors.HQLAction SubmitAction;
        
        internal System.Windows.Controls.DockPanel pipelinesearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid pipelines;
        
        internal Com.Aote.ObjectTools.PagedObjectList pipelineslist;
        
        internal System.Windows.Controls.Grid pipeline;
        
        internal Com.Aote.ObjectTools.GeneralObject pipelinego;
        
        internal System.Windows.Controls.Button save;
        
        internal System.Windows.Controls.DataPager pager;
        
        internal Com.Aote.Controls.MessageTipObj submittip;
        
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
                        "nent/Pages/%E5%8D%A1%E5%8E%85%E7%BB%84%E9%95%BF%E5%AE%A1%E6%A0%B8.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.minshgasnum = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("minshgasnum")));
            this.feishgasnum = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("feishgasnum")));
            this.DeleteAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteAction")));
            this.SaveAction = ((Com.Aote.Behaviors.BatchExcuteAction)(this.FindName("SaveAction")));
            this.SubmitAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("SubmitAction")));
            this.pipelinesearch = ((System.Windows.Controls.DockPanel)(this.FindName("pipelinesearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.pipelines = ((System.Windows.Controls.DataGrid)(this.FindName("pipelines")));
            this.pipelineslist = ((Com.Aote.ObjectTools.PagedObjectList)(this.FindName("pipelineslist")));
            this.pipeline = ((System.Windows.Controls.Grid)(this.FindName("pipeline")));
            this.pipelinego = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("pipelinego")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.pager = ((System.Windows.Controls.DataPager)(this.FindName("pager")));
            this.submittip = ((Com.Aote.Controls.MessageTipObj)(this.FindName("submittip")));
        }
    }
}

