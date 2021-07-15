using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;

namespace WpfApp3
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        static App()
        {

            
            var theme = new Theme("NewTheme2");
            theme.AssemblyName = "DevExpress.Xpf.Themes.NewTheme2.v20.2";
            Theme.RegisterTheme(theme);
            ApplicationThemeHelper.ApplicationThemeName = "NewTheme2";
            




        }
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Window wnd = null;
            if (e.Args.Length > 2) {
                if (e.Args[0].Equals("minus"))
                {
                    switch (e.Args[1])
                    {
                        // GANTT
                        case "8000":
                            wnd = new WindowGanttSchedule(e.Args[2]);
                            break;
                    }
                    if (wnd != null)
                    {
                        wnd.Left = -3000; // 초기에 안보이게
                        wnd.WindowStyle = WindowStyle.None;
                        wnd.Tag = e.Args[0];
                        wnd.Title = "Window" + e.Args[1] ;
                        wnd.ShowInTaskbar = false;
                    }
                }
            }
            if (wnd == null)
            {
                wnd = new WindowGanttSchedule("MP20210415");
                wnd.WindowState = WindowState.Maximized;
                wnd.WindowStyle = WindowStyle.SingleBorderWindow;
            }
            wnd.Show();


        }
    }
}
