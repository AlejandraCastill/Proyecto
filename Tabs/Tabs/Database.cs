using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Tabs
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            //estableciendo la conexion
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Contact>().Wait();
        }
        //show the registers
        public Task<List<Contact>> GetPeopleAsync()
        {
            return _database.Table<Contact>().ToListAsync();
        }
        //save registers
        public Task<int> GetProductionAsync(Contact contact)
        {
            return _database.InsertAsync(contact);
        }
        //delete registers
        public Task<int> DeletePersonAsync(Contact contact)
        {
            return _database.DeleteAsync(contact);
        }
        //save registers
        public Task<int> UpdatePersonAsync(Contact contact)
        {
            return _database.UpdateAsync(contact);
        }
    }
}
