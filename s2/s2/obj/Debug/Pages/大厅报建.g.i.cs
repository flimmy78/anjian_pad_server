﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\大厅报建.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AB4619BA9984DDB63D9A96E25CEC4246"
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
    
    
    public partial class 大厅报建 : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.ObjectList userlist;
        
        internal Com.Aote.Behaviors.HQLAction DeleteAction;
        
        internal System.Windows.Controls.StackPanel personsearch;
        
        internal System.Windows.Controls.Button searchbutton;
        
        internal System.Windows.Controls.DataGrid persons;
        
        internal Com.Aote.ObjectTools.ObjectList personslist;
        
        internal System.Windows.Controls.DockPanel person;
        
        internal Com.Aote.ObjectTools.GeneralObject persongo;
        
        internal System.Windows.Controls.Button save;
        
        internal System.Windows.Controls.Button test;
        
        internal System.Windows.Controls.TextBox testname;
        
        internal System.Windows.Controls.TextBox age;
        
        internal System.Windows.Controls.ComboBox sex;
        
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
                        "nent/Pages/%E5%A4%A7%E5%8E%85%E6%8A%A5%E5%BB%BA.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.userlist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("userlist")));
            this.DeleteAction = ((Com.Aote.Behaviors.HQLAction)(this.FindName("DeleteAction")));
            this.personsearch = ((System.Windows.Controls.StackPanel)(this.FindName("personsearch")));
            this.searchbutton = ((System.Windows.Controls.Button)(this.FindName("searchbutton")));
            this.persons = ((System.Windows.Controls.DataGrid)(this.FindName("persons")));
            this.personslist = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("personslist")));
            this.person = ((System.Windows.Controls.DockPanel)(this.FindName("person")));
            this.persongo = ((Com.Aote.ObjectTools.GeneralObject)(this.FindName("persongo")));
            this.save = ((System.Windows.Controls.Button)(this.FindName("save")));
            this.test = ((System.Windows.Controls.Button)(this.FindName("test")));
            this.testname = ((System.Windows.Controls.TextBox)(this.FindName("testname")));
            this.age = ((System.Windows.Controls.TextBox)(this.FindName("age")));
            this.sex = ((System.Windows.Controls.ComboBox)(this.FindName("sex")));
        }
    }
}

