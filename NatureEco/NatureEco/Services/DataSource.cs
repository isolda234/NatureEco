using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NatureEco.Services
{
    public interface DataSource<T>
    {
        Task<bool> AddItemAsync(T user);
        Task<bool> UpdateItemAsync(T user);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
