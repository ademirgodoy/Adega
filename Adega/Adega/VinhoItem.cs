using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adega
{
    public class VinhoItem
    {
        readonly SQLiteAsyncConnection bancoDados;

        public VinhoItem(string diretorio)
        {
            bancoDados = new SQLiteAsyncConnection(diretorio);
            bancoDados.CreateTableAsync<Vinho>().Wait();
        }

        internal Task<List<Vinho>> GetItemsAsync()
        {
            return bancoDados.Table<Vinho>().ToListAsync();
        }

        internal Task<Vinho> GetItemAsync(uint id)
        {
            return bancoDados.Table<Vinho>().Where(i => i.Id== id).FirstOrDefaultAsync();
        }

        internal Task<int> SaveItemAsync(Vinho item)
        {
            if (item.Id == 0)
            {

                return bancoDados.InsertAsync(item);
            }

            return bancoDados.UpdateAsync(item);
        }

        internal Task<int> DeleteItemAsync(Vinho item)
        {
            return bancoDados.DeleteAsync(item);
        }

    }
}
