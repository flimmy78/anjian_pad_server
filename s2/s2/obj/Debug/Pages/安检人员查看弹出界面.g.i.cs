﻿#pragma checksum "E:\workspace3.5\anjian\s2\s2\Pages\安检人员查看弹出界面.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CE1EB06871B59609FB218E582C25B8E3"
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
using Com.Aote.Marks;
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
    
    
    public partial class 安检人员查看弹出界面 : Com.Aote.Controls.CustomChildWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Com.Aote.Marks.ResourceLoad pageResource;
        
        internal Com.Aote.ObjectTools.PagedList repairManList;
        
        internal System.Windows.Controls.TextBox CurrentArchiveAddress;
        
        internal System.Windows.Controls.ComboBox WARM;
        
        internal System.Windows.Controls.TextBox WARM_OTHER;
        
        internal System.Windows.Controls.StackPanel MeterDefectsPane;
        
        internal System.Windows.Controls.CheckBox RQB;
        
        internal System.Windows.Controls.ComboBox JB_METER_NAME;
        
        internal System.Windows.Controls.TextBox JB_METER_NAME_OTHER;
        
        internal System.Windows.Controls.ComboBox IC_METER_NAME;
        
        internal System.Windows.Controls.TextBox IC_METER_NAME_OTHER;
        
        internal System.Windows.Controls.StackPanel PlumbingDefectsPane;
        
        internal System.Windows.Controls.CheckBox STANDPIPE;
        
        internal System.Windows.Controls.CheckBox cbEroded;
        
        internal System.Windows.Controls.RadioButton rbErodedSevere;
        
        internal System.Windows.Controls.RadioButton rbErodedModerate;
        
        internal System.Windows.Controls.RadioButton rbErodedSlight;
        
        internal System.Windows.Controls.StackPanel PlumbingProofPane;
        
        internal System.Windows.Controls.CheckBox cbRIGIDITYNormal;
        
        internal System.Windows.Controls.CheckBox cbRIGIDITYLeakage;
        
        internal System.Windows.Controls.StackPanel PlumbingPressurePane;
        
        internal System.Windows.Controls.CheckBox cbPressureNormal;
        
        internal System.Windows.Controls.CheckBox cbPressureAbnormal;
        
        internal System.Windows.Controls.StackPanel PlumbingMeterValvePane;
        
        internal System.Windows.Controls.CheckBox TABLE_TAP;
        
        internal System.Windows.Controls.StackPanel PlumbingCookerValvePane;
        
        internal System.Windows.Controls.CheckBox COOK_TAP;
        
        internal System.Windows.Controls.StackPanel PlumbingAutomaticValvePane;
        
        internal System.Windows.Controls.CheckBox CLOSE_TAP;
        
        internal System.Windows.Controls.StackPanel PlumbingPipePane;
        
        internal System.Windows.Controls.CheckBox INDOOR;
        
        internal System.Windows.Controls.StackPanel PlumbingLeakagePane;
        
        internal System.Windows.Controls.CheckBox cbLEAKAGE_COOKER;
        
        internal System.Windows.Controls.CheckBox cbLEAKAGE_HEATER;
        
        internal System.Windows.Controls.CheckBox cbLEAKAGE_BOILER;
        
        internal System.Windows.Controls.CheckBox cbLEAKAGE_NOTIFIED;
        
        internal System.Windows.Controls.StackPanel CookerPipePane;
        
        internal System.Windows.Controls.CheckBox COOKPIPE_NORMAL;
        
        internal System.Windows.Controls.StackPanel BoilerPipePane;
        
        internal System.Windows.Controls.CheckBox WATER_PIPE;
        
        internal System.Windows.Controls.StackPanel BoilerDefectsPane;
        
        internal System.Windows.Controls.CheckBox WATER_HIDDEN;
        
        internal System.Windows.Controls.StackPanel WHEDefectsPane;
        
        internal System.Windows.Controls.CheckBox WHE_HIDDEN;
        
        internal System.Windows.Controls.CheckBox NEEDS_REPAIR;
        
        internal System.Windows.Controls.ComboBox cmbRepair;
        
        internal System.Windows.Controls.WrapPanel precautionCheckPane;
        
        internal System.Windows.Controls.Image picture1;
        
        internal System.Windows.Controls.Image picture2;
        
        internal System.Windows.Controls.Image picture3;
        
        internal System.Windows.Controls.Image picture4;
        
        internal System.Windows.Controls.Image picture5;
        
        internal System.Windows.Controls.Image picture6;
        
        internal System.Windows.Controls.Image picture7;
        
        internal System.Windows.Controls.Image bigPic;
        
        internal System.Windows.Controls.Image image;
        
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
                        "nent/Pages/%E5%AE%89%E6%A3%80%E4%BA%BA%E5%91%98%E6%9F%A5%E7%9C%8B%E5%BC%B9%E5%87" +
                        "%BA%E7%95%8C%E9%9D%A2.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pageResource = ((Com.Aote.Marks.ResourceLoad)(this.FindName("pageResource")));
            this.repairManList = ((Com.Aote.ObjectTools.PagedList)(this.FindName("repairManList")));
            this.CurrentArchiveAddress = ((System.Windows.Controls.TextBox)(this.FindName("CurrentArchiveAddress")));
            this.WARM = ((System.Windows.Controls.ComboBox)(this.FindName("WARM")));
            this.WARM_OTHER = ((System.Windows.Controls.TextBox)(this.FindName("WARM_OTHER")));
            this.MeterDefectsPane = ((System.Windows.Controls.StackPanel)(this.FindName("MeterDefectsPane")));
            this.RQB = ((System.Windows.Controls.CheckBox)(this.FindName("RQB")));
            this.JB_METER_NAME = ((System.Windows.Controls.ComboBox)(this.FindName("JB_METER_NAME")));
            this.JB_METER_NAME_OTHER = ((System.Windows.Controls.TextBox)(this.FindName("JB_METER_NAME_OTHER")));
            this.IC_METER_NAME = ((System.Windows.Controls.ComboBox)(this.FindName("IC_METER_NAME")));
            this.IC_METER_NAME_OTHER = ((System.Windows.Controls.TextBox)(this.FindName("IC_METER_NAME_OTHER")));
            this.PlumbingDefectsPane = ((System.Windows.Controls.StackPanel)(this.FindName("PlumbingDefectsPane")));
            this.STANDPIPE = ((System.Windows.Controls.CheckBox)(this.FindName("STANDPIPE")));
            this.cbEroded = ((System.Windows.Controls.CheckBox)(this.FindName("cbEroded")));
            this.rbErodedSevere = ((System.Windows.Controls.RadioButton)(this.FindName("rbErodedSevere")));
            this.rbErodedModerate = ((System.Windows.Controls.RadioButton)(this.FindName("rbErodedModerate")));
            this.rbErodedSlight = ((System.Windows.Controls.RadioButton)(this.FindName("rbErodedSlight")));
            this.PlumbingProofPane = ((System.Windows.Controls.StackPanel)(this.FindName("PlumbingProofPane")));
            this.cbRIGIDITYNormal = ((System.Windows.Controls.CheckBox)(this.FindName("cbRIGIDITYNormal")));
            this.cbRIGIDITYLeakage = ((System.Windows.Controls.CheckBox)(this.FindName("cbRIGIDITYLeakage")));
            this.PlumbingPressurePane = ((System.Windows.Controls.StackPanel)(this.FindName("PlumbingPressurePane")));
            this.cbPressureNormal = ((System.Windows.Controls.CheckBox)(this.FindName("cbPressureNormal")));
            this.cbPressureAbnormal = ((System.Windows.Controls.CheckBox)(this.FindName("cbPressureAbnormal")));
            this.PlumbingMeterValvePane = ((System.Windows.Controls.StackPanel)(this.FindName("PlumbingMeterValvePane")));
            this.TABLE_TAP = ((System.Windows.Controls.CheckBox)(this.FindName("TABLE_TAP")));
            this.PlumbingCookerValvePane = ((System.Windows.Controls.StackPanel)(this.FindName("PlumbingCookerValvePane")));
            this.COOK_TAP = ((System.Windows.Controls.CheckBox)(this.FindName("COOK_TAP")));
            this.PlumbingAutomaticValvePane = ((System.Windows.Controls.StackPanel)(this.FindName("PlumbingAutomaticValvePane")));
            this.CLOSE_TAP = ((System.Windows.Controls.CheckBox)(this.FindName("CLOSE_TAP")));
            this.PlumbingPipePane = ((System.Windows.Controls.StackPanel)(this.FindName("PlumbingPipePane")));
            this.INDOOR = ((System.Windows.Controls.CheckBox)(this.FindName("INDOOR")));
            this.PlumbingLeakagePane = ((System.Windows.Controls.StackPanel)(this.FindName("PlumbingLeakagePane")));
            this.cbLEAKAGE_COOKER = ((System.Windows.Controls.CheckBox)(this.FindName("cbLEAKAGE_COOKER")));
            this.cbLEAKAGE_HEATER = ((System.Windows.Controls.CheckBox)(this.FindName("cbLEAKAGE_HEATER")));
            this.cbLEAKAGE_BOILER = ((System.Windows.Controls.CheckBox)(this.FindName("cbLEAKAGE_BOILER")));
            this.cbLEAKAGE_NOTIFIED = ((System.Windows.Controls.CheckBox)(this.FindName("cbLEAKAGE_NOTIFIED")));
            this.CookerPipePane = ((System.Windows.Controls.StackPanel)(this.FindName("CookerPipePane")));
            this.COOKPIPE_NORMAL = ((System.Windows.Controls.CheckBox)(this.FindName("COOKPIPE_NORMAL")));
            this.BoilerPipePane = ((System.Windows.Controls.StackPanel)(this.FindName("BoilerPipePane")));
            this.WATER_PIPE = ((System.Windows.Controls.CheckBox)(this.FindName("WATER_PIPE")));
            this.BoilerDefectsPane = ((System.Windows.Controls.StackPanel)(this.FindName("BoilerDefectsPane")));
            this.WATER_HIDDEN = ((System.Windows.Controls.CheckBox)(this.FindName("WATER_HIDDEN")));
            this.WHEDefectsPane = ((System.Windows.Controls.StackPanel)(this.FindName("WHEDefectsPane")));
            this.WHE_HIDDEN = ((System.Windows.Controls.CheckBox)(this.FindName("WHE_HIDDEN")));
            this.NEEDS_REPAIR = ((System.Windows.Controls.CheckBox)(this.FindName("NEEDS_REPAIR")));
            this.cmbRepair = ((System.Windows.Controls.ComboBox)(this.FindName("cmbRepair")));
            this.precautionCheckPane = ((System.Windows.Controls.WrapPanel)(this.FindName("precautionCheckPane")));
            this.picture1 = ((System.Windows.Controls.Image)(this.FindName("picture1")));
            this.picture2 = ((System.Windows.Controls.Image)(this.FindName("picture2")));
            this.picture3 = ((System.Windows.Controls.Image)(this.FindName("picture3")));
            this.picture4 = ((System.Windows.Controls.Image)(this.FindName("picture4")));
            this.picture5 = ((System.Windows.Controls.Image)(this.FindName("picture5")));
            this.picture6 = ((System.Windows.Controls.Image)(this.FindName("picture6")));
            this.picture7 = ((System.Windows.Controls.Image)(this.FindName("picture7")));
            this.bigPic = ((System.Windows.Controls.Image)(this.FindName("bigPic")));
            this.image = ((System.Windows.Controls.Image)(this.FindName("image")));
        }
    }
}

