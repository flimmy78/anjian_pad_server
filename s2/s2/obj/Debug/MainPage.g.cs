﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A8476A2B1DC5884BED0474CFF470C5CA"
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
    
    
    public partial class MainPage : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.UserControl mainpage;
        
        internal System.Windows.Media.Animation.Storyboard MainCanvasStoryboardIn;
        
        internal System.Windows.Media.Animation.Storyboard MainCanvasStoryboardOut;
        
        internal System.Windows.Media.Animation.Storyboard MainCanvasrightStoryboardIn;
        
        internal System.Windows.Media.Animation.Storyboard MainCanvasrightStoryboardOut;
        
        internal System.Windows.Media.Animation.Storyboard CanvasBottomStoryboard;
        
        internal System.Windows.Media.Animation.DoubleAnimation da;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.ObjectTools.ChildWindowObj openchild;
        
        internal Com.Aote.ObjectTools.ObjectList selects;
        
        internal System.Windows.Controls.Canvas canvasleft;
        
        internal System.Windows.Controls.Canvas canvasbottom;
        
        internal System.Windows.Controls.Grid frame;
        
        internal Microsoft.Expression.Controls.PathListBox menus;
        
        internal Microsoft.Expression.Controls.LayoutPath plblp;
        
        internal System.Windows.Shapes.Path path;
        
        internal System.Windows.Controls.Canvas loginUserInfo;
        
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
                        "nent/MainPage.xaml", System.UriKind.Relative));
            this.mainpage = ((System.Windows.Controls.UserControl)(this.FindName("mainpage")));
            this.MainCanvasStoryboardIn = ((System.Windows.Media.Animation.Storyboard)(this.FindName("MainCanvasStoryboardIn")));
            this.MainCanvasStoryboardOut = ((System.Windows.Media.Animation.Storyboard)(this.FindName("MainCanvasStoryboardOut")));
            this.MainCanvasrightStoryboardIn = ((System.Windows.Media.Animation.Storyboard)(this.FindName("MainCanvasrightStoryboardIn")));
            this.MainCanvasrightStoryboardOut = ((System.Windows.Media.Animation.Storyboard)(this.FindName("MainCanvasrightStoryboardOut")));
            this.CanvasBottomStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("CanvasBottomStoryboard")));
            this.da = ((System.Windows.Media.Animation.DoubleAnimation)(this.FindName("da")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.openchild = ((Com.Aote.ObjectTools.ChildWindowObj)(this.FindName("openchild")));
            this.selects = ((Com.Aote.ObjectTools.ObjectList)(this.FindName("selects")));
            this.canvasleft = ((System.Windows.Controls.Canvas)(this.FindName("canvasleft")));
            this.canvasbottom = ((System.Windows.Controls.Canvas)(this.FindName("canvasbottom")));
            this.frame = ((System.Windows.Controls.Grid)(this.FindName("frame")));
            this.menus = ((Microsoft.Expression.Controls.PathListBox)(this.FindName("menus")));
            this.plblp = ((Microsoft.Expression.Controls.LayoutPath)(this.FindName("plblp")));
            this.path = ((System.Windows.Shapes.Path)(this.FindName("path")));
            this.loginUserInfo = ((System.Windows.Controls.Canvas)(this.FindName("loginUserInfo")));
        }
    }
}

