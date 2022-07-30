using DataAccess.Models;
using DataAcess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Service
{
    public class MenuService
    {
        public async Task<List<Menu>> GetMenuListByUserID(int id)
        {
            return await new GenericRepository<Menu>().Find(m => m.IsDeleted == false);
        }

        public async Task<List<Menu>> GetMenuList()
        {
            return await new GenericRepository<Menu>().Find(m=>m.IsDeleted == false);
        }
        public async Task<Menu> AddUpdateMenu(Menu data)
        {
          
            if (data.Id == 0) // Insert
            {
                return await new GenericRepository<Menu>().Insert(data);
            }
            else // Update
            {
                Menu ExistingData = await new GenericRepository<Menu>().FindOne(b => b.Id == data.Id);
                List<string> Updatedproperties = ObjectComparison.GetChangedProperties(data, ExistingData);

                foreach (string propertyName in Updatedproperties)
                {
                    var ExistingPropertyInfo = ExistingData.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    var UpdatePropertyValue = data.GetType().GetProperty(propertyName).GetValue(data, null);
                    ExistingPropertyInfo.SetValue(ExistingData, UpdatePropertyValue, null);
                }

                return await new GenericRepository<Menu>().Update(ExistingData, b => b.Id == ExistingData.Id);
            }
        }
    }
}
