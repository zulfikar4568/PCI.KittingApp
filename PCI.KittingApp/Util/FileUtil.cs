﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Threading;
using System.Diagnostics;
using System.IO;
using Camstar.Util;
using PCI.KittingApp.Config;
using System.Reflection;

namespace PCI.KittingApp.Util
{
    public static class FileUtil
    {
        public static bool GenerateLabel(string Path, string BaseName, string TxnName, string Data, bool IgnoreException = true)
        {
            var nameFile = $"{BaseName}_{TxnName}_{DateTime.Now:yyyyMMdd}_{DateTime.Now:HHmmss}_{Thread.CurrentThread.ManagedThreadId}_{Process.GetCurrentProcess().Id}_{RandomString(5)}.txt";
            var fullPath = Path + nameFile;
            try
            {
                if (!File.Exists(fullPath)) File.Delete(fullPath);
                using (StreamWriter sw = File.CreateText(fullPath))
                {
                    sw.WriteLine(Data);
                }
                return true;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                if (!IgnoreException) throw ex;
                return false;
            }
        }
        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
