using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NatureEco.date
{
    public class TabelaUser
    {
        readonly SQLiteAsyncConnection database;

        public TabelaUser(string dbPath)
        {

            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<userModel>().Wait();

        }
        public Task<List<userModel>> GetNotesAsync()
        {
            return database.Table<userModel>().ToListAsync();
        }
      
      


        public Task<int> SaveNoteAsync(userModel dados)
        {


            return database.InsertAsync(dados);


        }
        public Task<int> DeleteNoteAsync(userModel dados)
        {
            return database.DeleteAsync(dados);
        }
    }
}
