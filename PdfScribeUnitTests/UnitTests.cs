﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using NUnit.Framework;

using PdfScribeCore;

namespace PdfScribeUnitTests
{
    [TestFixture]
    public class UnitTests
    {
        #region Ctor
        public UnitTests()
        { }
        #endregion

        #region PdfScribeCore Tests
        //[Test]
        public void Test_DeletePdfScribePort()
        {
            var scribeInstaller = new PdfScribeInstaller();
            scribeInstaller.DeletePdfScribePort();
        }

        //[Test]
        public void Test_RemovePdfScribeDriver()
        {
            var scribeInstaller = new PdfScribeInstaller();
            scribeInstaller.RemovePDFScribePrinterDriver();
        }

        //[Test]
        public void Test_InstallPdfScribePrinter()
        {
            var scribeInstaller = new PdfScribeInstaller();
            scribeInstaller.InstallSoftscanPrinter_Test();
        }

        //[Test]
        public void Test_UninstallPdfScribePrinter()
        {
            var scribeInstaller = new PdfScribeInstaller();
            scribeInstaller.UninstallPdfScribePrinter();
        }

        //[Test]
        public void Test_RemovePdfScribePortMonitor()
        {
            var scribeInstaller = new PdfScribeInstaller();
            scribeInstaller.RemovePdfScribePortMonitor();
        }

        #endregion

        //[Test]
        public void Test_ShowActivityWindows()
        {

        }
        
        [Test]
        public void Test_ShowSimpleError()
        {
            var errorDialog = new PdfScribe.ErrorDialogPresenter("Error Caption", "Error Instructions", "Message text");
        }
    }
}
