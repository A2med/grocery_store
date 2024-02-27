using Gerocery.constant;
using Gerocery.data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery.DA
{
    public class DbConst
    {
        public SQLiteAsyncConnection Database;
        public DbConst()
        {

        }
        public async Task Init()
        {
            try
            {
                if (Database is not null)
                    return;

                Database = new SQLiteAsyncConnection(DataBaseConstants.DatabasePath, DataBaseConstants.Flags);
                var result = await Database.CreateTableAsync<Category2>();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
