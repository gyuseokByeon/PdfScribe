﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;


namespace PdfScribe
{
    public class ActivityNotificationPresenter
    {
        public ActivityNotificationPresenter()
        {

        }

        
        private Application activityWindow = null;

        /// <summary>
        /// 
        /// </summary>
        public void ShowActivityNotificationWindow()
        {
            if (activityWindow == null)
            {
                this.activityWindow = new Application();
                var activityWindowThread = new Thread(new ThreadStart(() =>
                {
                    activityWindow = new Application();
                    activityWindow.ShutdownMode = ShutdownMode.OnExplicitShutdown;
                    activityWindow.Run(new ActivityNotification());
                }
                ));
                activityWindowThread.SetApartmentState(ApartmentState.STA);
                activityWindowThread.Start();
            }
        }

        /// <summary>
        /// Shuts down the thread showing
        /// the ActivityNotification WPF window
        /// </summary>
        public void CloseActivityNotificationWindow()
        {
            if (activityWindow != null)
                activityWindow.Dispatcher.InvokeShutdown();
        }

    }
}
