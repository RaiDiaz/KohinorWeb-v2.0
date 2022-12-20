using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace KohinorData.Logger
{
    public class LogHelper
    {

        private static readonly log4net.ILog _dbLog = log4net.LogManager.GetLogger("DBInfoAppender");
        public static log4net.ILog GetLogger([CallerFilePath] string filename = "")
        {
            return log4net.LogManager.GetLogger(filename);
        }

        public static string DBLogger(string sqlStatement, string connectionString = "")
        {
            _dbLog.Info("Ejecutando: " + sqlStatement + " en " + connectionString);
            return sqlStatement;
        }

    }
}
