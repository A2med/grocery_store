using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery.constant
{
   public static class DataBaseConstants
    {
        public static string UpdateData = "update";
        #region DatabaseConst
        public const string DatabaseFilename = "PosSqLite.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
        #endregion
        public static string ApiServerUrl = "http://92.205.28.199:1459/";
    }
}
