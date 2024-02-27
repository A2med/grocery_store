using Gerocery.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerocery.DA
{
   public class category2Da:DbConst
    {
        public async Task<List<Category2>> GetCategorysAsync()
        {
            await Init();
            return await Database.Table<Category2>().ToListAsync();
        }
        public async Task<Category2> GetCategoryAsync(int categoryId)
        {
            await Init();
            return await Database.Table<Category2>().Where(i => i.id == categoryId).FirstOrDefaultAsync();
                
        }
        public async Task<int> saveItemAsync(Category2 category)
        {
            await Init();
            if (category.id != 0)
                return await Database.UpdateAsync(category);
            else
                return await Database.InsertAsync(category);
        }

        public async Task<int> BulkInsert(List<Category2> LstCategory)
        {
            await Init();
            return await Database.InsertAllAsync(LstCategory);
        }
        public async Task<int> DeleteCategoryAsync(Category2 category)
        {
            await Init();
            return await Database.DeleteAsync(category);
        }

        public async Task  ClearCategoryAsync()
        {
            await Init();
             await Database.CloseAsync();
        }



    }
}
