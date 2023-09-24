using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Models;

namespace Proyecto.Datos
{
    public class Data
    {
        SQLiteAsyncConnection BaseDeDatos;

        public Data()
        {

        }

        async Task Init()
        {
            if (BaseDeDatos is not null)
                return;

            BaseDeDatos = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await BaseDeDatos.CreateTableAsync<Variables>();
        }

        public async Task<List<Variables>> GetItemsAsync()
        {
            await Init();
            return await BaseDeDatos.Table<Variables>().ToListAsync();
        }

        public async Task<Variables> GetItemAsync(int id)
        {
            await Init();
            return await BaseDeDatos.Table<Variables>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(Variables item)
        {
            await Init();
            if (item.ID != 0)
            {
                return await BaseDeDatos.UpdateAsync(item);
            }
            else
            {
                return await BaseDeDatos.InsertAsync(item);
            }
        }
    }
}