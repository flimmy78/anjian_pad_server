﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\获取计划.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B486F8A07BB50EADA43FDBB2DC1EFD72"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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
    
    
    public partial class 获取计划 : Com.Aote.Controls.CustomChildWindow {
        
        internal Com.Aote.Controls.CustomChildWindow child;
        
        internal System.Windows.Controls.Grid Layout;
        
        internal System.Windows.Controls.DockPanel searchPanel;
        
        internal System.Windows.Controls.DataGrid planGrid;
        
        internal Com.Aote.ObjectTools.ObjectList planList;
        
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
                        "nent/Pages/%E8%8E%B7%E5%8F%96%E8%AE%A1%E5%88%92.xaml", System.UriKind.Relative));
            this.child = ((Com.Aote.Controls.CustomChildWindow)(this.FindName("child")));
            this.Layout = ((System.Windows.Controls.Grid)(this.FindName("Layout")));
            this.searchPanel = ((System.Windows.Controls.DockPanel)(this.FindName("searchPanel")));
            this.planGrid = ((System.Windows.Controls.DataGrid)(this.FindName("planGrid")));
            this.planList = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("planList")));
        }
    }
}

