﻿#pragma checksum "..\..\Demo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D6B6426C43C68C1C3DC99C689D4E9DCE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4200
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AvalonDock;
using AvalonDockTest;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace AvalonDockTest {
    
    
    /// <summary>
    /// Demo
    /// </summary>
    public partial class Demo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 90 "..\..\Demo.xaml"
        internal System.Windows.Controls.MenuItem ShowDockingManager;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\Demo.xaml"
        internal System.Windows.Controls.ContentControl TestContainer;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\Demo.xaml"
        internal AvalonDock.DockingManager _dockingManager;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\Demo.xaml"
        internal AvalonDock.DockableContent _propertiesWindow;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\Demo.xaml"
        internal AvalonDock.DocumentPane _documentsHost;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\Demo.xaml"
        internal AvalonDock.DocumentContent docHome;
        
        #line default
        #line hidden
        
        
        #line 194 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink NewDocuments;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowProperties;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowProperties_AutoHide;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowProperties_FloatingWindow;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowExplorer;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowExplorer_AutoHide;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowExplorer_FloatingWindow;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowEventsLog;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowEventsLog_AutoHide;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowEventsLog_FloatingWindow;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowEventsLog_DockRight;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowProperty;
        
        #line default
        #line hidden
        
        
        #line 210 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowProperty_AutoHide;
        
        #line default
        #line hidden
        
        
        #line 211 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowProperty_FloatingWindow;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink ShowProperty_DockRight;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink SaveLayout;
        
        #line default
        #line hidden
        
        
        #line 215 "..\..\Demo.xaml"
        internal System.Windows.Documents.Hyperlink RestoreLayout;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\Demo.xaml"
        internal AvalonDock.DockableContent _objectExplorerHost;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\Demo.xaml"
        internal AvalonDockTest.ErrorListContent _errorList;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\Demo.xaml"
        internal AvalonDock.DockableContent _eventsLogWindow;
        
        #line default
        #line hidden
        
        
        #line 257 "..\..\Demo.xaml"
        internal System.Windows.Controls.TextBox _txtLog;
        
        #line default
        #line hidden
        
        
        #line 265 "..\..\Demo.xaml"
        internal AvalonDock.DockableContent _explorerWindow;
        
        #line default
        #line hidden
        
        
        #line 269 "..\..\Demo.xaml"
        internal System.Windows.Controls.TabControl tabControl;
        
        #line default
        #line hidden
        
        
        #line 271 "..\..\Demo.xaml"
        internal System.Windows.Controls.Button ButtonDefault;
        
        #line default
        #line hidden
        
        
        #line 275 "..\..\Demo.xaml"
        internal System.Windows.Controls.Button ButtonDefault2;
        
        #line default
        #line hidden
        
        
        #line 276 "..\..\Demo.xaml"
        internal System.Windows.Controls.Button ButtonDefault3;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/AvalonDockTest;component/demo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Demo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 6 "..\..\Demo.xaml"
            ((AvalonDockTest.Demo)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            
            #line 6 "..\..\Demo.xaml"
            ((AvalonDockTest.Demo)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ShowDockingManager = ((System.Windows.Controls.MenuItem)(target));
            
            #line 90 "..\..\Demo.xaml"
            this.ShowDockingManager.Click += new System.Windows.RoutedEventHandler(this.ShowDockingManager_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 91 "..\..\Demo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeColor_Clicked);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 92 "..\..\Demo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeColor_Clicked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 93 "..\..\Demo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeColor_Clicked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 94 "..\..\Demo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeColor_Clicked);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 95 "..\..\Demo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeColor_Clicked);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 96 "..\..\Demo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeColor_Clicked);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 97 "..\..\Demo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeColor_Clicked);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 99 "..\..\Demo.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ResetColors_Clicked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.TestContainer = ((System.Windows.Controls.ContentControl)(target));
            return;
            case 12:
            this._dockingManager = ((AvalonDock.DockingManager)(target));
            return;
            case 13:
            this._propertiesWindow = ((AvalonDock.DockableContent)(target));
            return;
            case 14:
            this._documentsHost = ((AvalonDock.DocumentPane)(target));
            return;
            case 15:
            this.docHome = ((AvalonDock.DocumentContent)(target));
            
            #line 124 "..\..\Demo.xaml"
            this.docHome.Closing += new System.EventHandler<System.ComponentModel.CancelEventArgs>(this.doc_Closing);
            
            #line default
            #line hidden
            return;
            case 16:
            this.NewDocuments = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 194 "..\..\Demo.xaml"
            this.NewDocuments.Click += new System.Windows.RoutedEventHandler(this.NewDocuments_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.ShowProperties = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 196 "..\..\Demo.xaml"
            this.ShowProperties.Click += new System.Windows.RoutedEventHandler(this.ShowProperties_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.ShowProperties_AutoHide = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 197 "..\..\Demo.xaml"
            this.ShowProperties_AutoHide.Click += new System.Windows.RoutedEventHandler(this.ShowProperties_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            this.ShowProperties_FloatingWindow = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 198 "..\..\Demo.xaml"
            this.ShowProperties_FloatingWindow.Click += new System.Windows.RoutedEventHandler(this.ShowProperties_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.ShowExplorer = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 200 "..\..\Demo.xaml"
            this.ShowExplorer.Click += new System.Windows.RoutedEventHandler(this.ShowExplorer_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.ShowExplorer_AutoHide = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 201 "..\..\Demo.xaml"
            this.ShowExplorer_AutoHide.Click += new System.Windows.RoutedEventHandler(this.ShowExplorer_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.ShowExplorer_FloatingWindow = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 202 "..\..\Demo.xaml"
            this.ShowExplorer_FloatingWindow.Click += new System.Windows.RoutedEventHandler(this.ShowExplorer_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.ShowEventsLog = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 204 "..\..\Demo.xaml"
            this.ShowEventsLog.Click += new System.Windows.RoutedEventHandler(this.ShowEventsLog_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            this.ShowEventsLog_AutoHide = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 205 "..\..\Demo.xaml"
            this.ShowEventsLog_AutoHide.Click += new System.Windows.RoutedEventHandler(this.ShowEventsLog_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            this.ShowEventsLog_FloatingWindow = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 206 "..\..\Demo.xaml"
            this.ShowEventsLog_FloatingWindow.Click += new System.Windows.RoutedEventHandler(this.ShowEventsLog_Click);
            
            #line default
            #line hidden
            return;
            case 26:
            this.ShowEventsLog_DockRight = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 207 "..\..\Demo.xaml"
            this.ShowEventsLog_DockRight.Click += new System.Windows.RoutedEventHandler(this.ShowEventsLog_Click);
            
            #line default
            #line hidden
            return;
            case 27:
            this.ShowProperty = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 209 "..\..\Demo.xaml"
            this.ShowProperty.Click += new System.Windows.RoutedEventHandler(this.ShowProperty_Click);
            
            #line default
            #line hidden
            return;
            case 28:
            this.ShowProperty_AutoHide = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 210 "..\..\Demo.xaml"
            this.ShowProperty_AutoHide.Click += new System.Windows.RoutedEventHandler(this.ShowProperty_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            this.ShowProperty_FloatingWindow = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 211 "..\..\Demo.xaml"
            this.ShowProperty_FloatingWindow.Click += new System.Windows.RoutedEventHandler(this.ShowProperty_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            this.ShowProperty_DockRight = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 212 "..\..\Demo.xaml"
            this.ShowProperty_DockRight.Click += new System.Windows.RoutedEventHandler(this.ShowProperty_Click);
            
            #line default
            #line hidden
            return;
            case 31:
            this.SaveLayout = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 214 "..\..\Demo.xaml"
            this.SaveLayout.Click += new System.Windows.RoutedEventHandler(this.SaveLayout_Click);
            
            #line default
            #line hidden
            return;
            case 32:
            this.RestoreLayout = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 215 "..\..\Demo.xaml"
            this.RestoreLayout.Click += new System.Windows.RoutedEventHandler(this.RestoreLayout_Click);
            
            #line default
            #line hidden
            return;
            case 33:
            this._objectExplorerHost = ((AvalonDock.DockableContent)(target));
            return;
            case 34:
            this._errorList = ((AvalonDockTest.ErrorListContent)(target));
            return;
            case 35:
            this._eventsLogWindow = ((AvalonDock.DockableContent)(target));
            return;
            case 36:
            this._txtLog = ((System.Windows.Controls.TextBox)(target));
            return;
            case 37:
            this._explorerWindow = ((AvalonDock.DockableContent)(target));
            return;
            case 38:
            this.tabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 39:
            this.ButtonDefault = ((System.Windows.Controls.Button)(target));
            
            #line 271 "..\..\Demo.xaml"
            this.ButtonDefault.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 40:
            this.ButtonDefault2 = ((System.Windows.Controls.Button)(target));
            
            #line 275 "..\..\Demo.xaml"
            this.ButtonDefault2.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 41:
            this.ButtonDefault3 = ((System.Windows.Controls.Button)(target));
            
            #line 276 "..\..\Demo.xaml"
            this.ButtonDefault3.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
