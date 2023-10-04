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
        /// <summary>
        /// Se declara una variable para realizar la conexión
        /// </summary>
        SQLiteAsyncConnection BaseDeDatos;

        /// <summary>
        /// Se instancia la clase
        /// </summary>
        public Data()
        {

        }

        /// <summary>
        /// Revisa si hay una base de datos, sino la crea, y crea la tabla que usaremos, basada en nuestra clase Variables
        /// </summary>
        /// <returns></returns>
        async Task Init()
        {
            if (BaseDeDatos is not null)
                return;

            BaseDeDatos = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await BaseDeDatos.CreateTableAsync<Variables>();
        }

        /// <summary>
        /// Método para guardar los items en una lista
        /// </summary>
        /// <returns></returns>
        public async Task<List<Variables>> GetItemsAsync()
        {
            await Init();
            return await BaseDeDatos.Table<Variables>().ToListAsync();
        }

        /// <summary>
        /// Sirve para mostrar los pedidos en la lista
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Variables> GetItemAsync(int id)
        {
            await Init();
            return await BaseDeDatos.Table<Variables>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        /// <summary>
        /// Guarda los items por medio dd este método, que usaremos en los botones, también sirve para actualizar  el pedido
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Método para borrar el pedido
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<int> DeleteItemAsync(Variables item)
        {
            await Init();
            return await BaseDeDatos.DeleteAsync(item);
        }
    }
}