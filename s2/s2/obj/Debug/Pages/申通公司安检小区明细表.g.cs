﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\申通公司安检小区明细表.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "40A6ED405A7EE1E572BB0D370BA08E3E"
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


namespace s2.Pages {
    
    
    public partial class 申通公司安检小区明细表 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DatePicker start_time;
        
        internal System.Windows.Controls.DatePicker end_time;
        
        internal System.Windows.Controls.Button sou_tj;
        
        internal System.Windows.Controls.Grid data_row;
        
        internal System.Windows.Controls.DataGrid check_roplo;
        
        internal Com.Aote.ObjectTools.PagedList pl;
        
        internal System.Windows.Controls.Grid button_db;
        
        internal System.Windows.Controls.TextBox ansum_xj;
        
        internal System.Windows.Controls.TextBox oksum_xj;
        
        internal System.Windows.Controls.TextBox rzl_xj;
        
        internal System.Windows.Controls.TextBox lq_xj;
        
        internal System.Windows.Controls.TextBox lqfix_xj;
        
        internal System.Windows.Controls.TextBox rqb_xj;
        
        internal System.Windows.Controls.TextBox rqbfix_xj;
        
        internal System.Windows.Controls.TextBox rg_xj;
        
        internal System.Windows.Controls.TextBox rgfix_xj;
        
        internal System.Windows.Controls.TextBox gk_xj;
        
        internal System.Windows.Controls.TextBox gkfix_xj;
        
        internal System.Windows.Controls.TextBox zibifa_xj;
        
        internal System.Windows.Controls.TextBox zibifafix_xj;
        
        internal System.Windows.Controls.TextBox hnwz_xj;
        
        internal System.Windows.Controls.TextBox gfx_xj;
        
        internal System.Windows.Controls.TextBox tzd_xj;
        
        internal System.Windows.Controls.TextBox xczl_xj;
        
        internal System.Windows.Controls.TextBox bz_xj;
        
        internal Com.Aote.Controls.Excel toExcel;
        
        internal Com.Aote.Controls.DownLoad downLoad;
        
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
                        "nent/Pages/%E7%94%B3%E9%80%9A%E5%85%AC%E5%8F%B8%E5%AE%89%E6%A3%80%E5%B0%8F%E5%8C" +
                        "%BA%E6%98%8E%E7%BB%86%E8%A1%A8.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.start_time = ((System.Windows.Controls.DatePicker)(this.FindName("start_time")));
            this.end_time = ((System.Windows.Controls.DatePicker)(this.FindName("end_time")));
            this.sou_tj = ((System.Windows.Controls.Button)(this.FindName("sou_tj")));
            this.data_row = ((System.Windows.Controls.Grid)(this.FindName("data_row")));
            this.check_roplo = ((System.Windows.Controls.DataGrid)(this.FindName("check_roplo")));
            this.pl = ((Com.Aote.ObjectTools.PagedList)(this.FindName("pl")));
            this.button_db = ((System.Windows.Controls.Grid)(this.FindName("button_db")));
            this.ansum_xj = ((System.Windows.Controls.TextBox)(this.FindName("ansum_xj")));
            this.oksum_xj = ((System.Windows.Controls.TextBox)(this.FindName("oksum_xj")));
            this.rzl_xj = ((System.Windows.Controls.TextBox)(this.FindName("rzl_xj")));
            this.lq_xj = ((System.Windows.Controls.TextBox)(this.FindName("lq_xj")));
            this.lqfix_xj = ((System.Windows.Controls.TextBox)(this.FindName("lqfix_xj")));
            this.rqb_xj = ((System.Windows.Controls.TextBox)(this.FindName("rqb_xj")));
            this.rqbfix_xj = ((System.Windows.Controls.TextBox)(this.FindName("rqbfix_xj")));
            this.rg_xj = ((System.Windows.Controls.TextBox)(this.FindName("rg_xj")));
            this.rgfix_xj = ((System.Windows.Controls.TextBox)(this.FindName("rgfix_xj")));
            this.gk_xj = ((System.Windows.Controls.TextBox)(this.FindName("gk_xj")));
            this.gkfix_xj = ((System.Windows.Controls.TextBox)(this.FindName("gkfix_xj")));
            this.zibifa_xj = ((System.Windows.Controls.TextBox)(this.FindName("zibifa_xj")));
            this.zibifafix_xj = ((System.Windows.Controls.TextBox)(this.FindName("zibifafix_xj")));
            this.hnwz_xj = ((System.Windows.Controls.TextBox)(this.FindName("hnwz_xj")));
            this.gfx_xj = ((System.Windows.Controls.TextBox)(this.FindName("gfx_xj")));
            this.tzd_xj = ((System.Windows.Controls.TextBox)(this.FindName("tzd_xj")));
            this.xczl_xj = ((System.Windows.Controls.TextBox)(this.FindName("xczl_xj")));
            this.bz_xj = ((System.Windows.Controls.TextBox)(this.FindName("bz_xj")));
            this.toExcel = ((Com.Aote.Controls.Excel)(this.FindName("toExcel")));
            this.downLoad = ((Com.Aote.Controls.DownLoad)(this.FindName("downLoad")));
        }
    }
}

