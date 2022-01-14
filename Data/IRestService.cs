using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mechetiuc_Denisa_12.Models;

namespace Mechetiuc_Denisa_12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);

    }
}
