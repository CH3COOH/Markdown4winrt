﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MarkdownTest.wp8.Resources;
using System.Threading;
using Microsoft.VisualStudio.TestPlatform.Core;
using vstest_executionengine_platformbridge;
using Microsoft.VisualStudio.TestPlatform.TestExecutor;
using System.Reflection;

namespace MarkdownTest.wp8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // コンストラクター
        public MainPage()
        {
            InitializeComponent();

            var wrapper = new TestExecutorServiceWrapper();
            new Thread(new ServiceMain((param0, param1) => wrapper.SendMessage((ContractName)param0, param1)).Run).Start();

        }
    }
}