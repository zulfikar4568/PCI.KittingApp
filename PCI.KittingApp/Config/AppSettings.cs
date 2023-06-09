﻿using Camstar.WCF.ObjectStack;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Config
{
    public static class AppSettings
    {
        public static string AssemblyName
        {
            get
            {
                return System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            }
        }

        #region CRON EXPRESSION
        public static string CheckConnectionCronExpression
        {
            get
            {
                return ConfigurationManager.AppSettings["CheckConnectionCronExpression"];
            }
        }
        #endregion

        #region TIME
        public static TimeSpan UTCOffset
        {
            get
            {
                string sUTCOffset = ConfigurationManager.AppSettings["UTCOffset"];
                string[] aUTCOffset = sUTCOffset.Split(':');
                return new TimeSpan(Int32.Parse(aUTCOffset[0]), Int32.Parse(aUTCOffset[1]), Int32.Parse(aUTCOffset[2]));
            }
        }
        #endregion

        #region CONFIG ACCOUNT ExCore
        public static string ExCoreHost
        {
            get
            {
                return ConfigurationManager.AppSettings["ExCoreHost"];
            }
        }
        public static string ExCorePort
        {
            get
            {
                return ConfigurationManager.AppSettings["ExCorePort"];
            }
        }
        private static string ExCoreUsername
        {
            get
            {
                return ConfigurationManager.AppSettings["ExCoreUsername"];
            }
        }
        private static string ExCorePassword
        {
            get
            {

                Simple3Des oSimple3Des = new Simple3Des(ConfigurationManager.AppSettings["ExCorePasswordKey"]);
                return oSimple3Des.DecryptData(ConfigurationManager.AppSettings["ExCorePassword"]);
            }
        }
        private static UserProfile _ExCoreUserProfile = null;
        public static UserProfile ExCoreUserProfile
        {
            get
            {
                if (_ExCoreUserProfile == null)
                {
                    _ExCoreUserProfile = new UserProfile(ExCoreUsername, ExCorePassword, UTCOffset);
                }
                if (_ExCoreUserProfile.Name != ExCoreUsername || _ExCoreUserProfile.Password.Value != ExCorePassword)
                {
                    _ExCoreUserProfile = new UserProfile(ExCoreUsername, ExCorePassword, UTCOffset);
                }
                return _ExCoreUserProfile;
            }
        }
        #endregion

        #region SQLite
        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        #endregion

        #region PRINTER CONFIG
        public static string PrinterName
        {
            get
            {
                return ConfigurationManager.AppSettings["PrinterName"];
            }
        }
        public static string FormatToBeReplaced
        {
            get
            {
                return ConfigurationManager.AppSettings["FormatToBeReplaced"];
            }
        }
        public static string TemplatePrinter
        {
            get
            {
                return ConfigurationManager.AppSettings["TemplatePrinter"];
            }
        }
        public static string DefaultPathPrinter
        {
            get
            {
                return ConfigurationManager.AppSettings["DefaultPathPrinter"];
            }
        }
        public static bool IsPrintingFileEnabled
        {
            get
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings["IsPrintingFileEnabled"]);
            }
        }
        public static bool IsPrintingDeviceEnabled
        {
            get
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings["IsPrintingDeviceEnabled"]);
            }
        }
        #endregion

        #region Capital Field
        public static bool ConvertToCapital
        {
            get
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings["ConvertToCapital"]);
            }
        }
        #endregion
    }
}
