using AutoMapper;
using DataAccess.DTOs;
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
    public class RoleAndPermissionService
    {
        #region Permission-Table
        public async Task<Permission> AddUpdatePermission(Permission data)
        {
           
            if (data.Id == 0) // Insert
            {
                return await new GenericRepository<Permission>().Insert(data);
            }
            else // Update
            {
                var ExistingData = await new GenericRepository<Permission>().FindOne(b => b.Id == data.Id);
                List<string> Updatedproperties = ObjectComparison.GetChangedProperties(data, ExistingData);

                foreach (string propertyName in Updatedproperties)
                {
                    var ExistingPropertyInfo = ExistingData.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    var UpdatePropertyValue = data.GetType().GetProperty(propertyName).GetValue(data, null);
                    ExistingPropertyInfo.SetValue(ExistingData, UpdatePropertyValue, null);
                }

                return await new GenericRepository<Permission>().Update(ExistingData, b => b.Id == ExistingData.Id);
            }
        }

        public async Task<List<Permission>> GetPermissionList()
        {
            return await new GenericRepository<Permission>().Find(p=>p.IsDeleted == false);
        }
        #endregion

        #region Role-Table
        public async Task<Role> AddUpdateRole(RoleDTO dtodata)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<RoleDTO, Role>()))
                .Map<RoleDTO, Role>(dtodata);

            if (data.Id == 0) // Insert
            {
                return await new GenericRepository<Role>().Insert(data);
            }
            else // Update
            {
                var ExistingData = await new GenericRepository<Role>().FindOne(b => b.Id == data.Id);
                List<string> Updatedproperties = ObjectComparison.GetChangedProperties(data, ExistingData);

                foreach (string propertyName in Updatedproperties)
                {
                    var ExistingPropertyInfo = ExistingData.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    var UpdatePropertyValue = data.GetType().GetProperty(propertyName).GetValue(data, null);
                    ExistingPropertyInfo.SetValue(ExistingData, UpdatePropertyValue, null);
                }

                return await new GenericRepository<Role>().Update(ExistingData, b => b.Id == ExistingData.Id);
            }
        }

        public async Task<List<Role>> GetRoleList()
        {
            return await new GenericRepository<Role>().Find(p => p.IsDeleted == false);
        }
        #endregion

        #region RolePermission-Table
        public async Task<RolePermission> AddUpdateRolePermission(RolePermission data)
        {
         
            if (data.Id == 0) // Insert
            {
                return await new GenericRepository<RolePermission>().Insert(data);
            }
            else // Update
            {
                var ExistingData = await new GenericRepository<RolePermission>().FindOne(b => b.Id == data.Id);
                List<string> Updatedproperties = ObjectComparison.GetChangedProperties(data, ExistingData);

                foreach (string propertyName in Updatedproperties)
                {
                    var ExistingPropertyInfo = ExistingData.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    var UpdatePropertyValue = data.GetType().GetProperty(propertyName).GetValue(data, null);
                    ExistingPropertyInfo.SetValue(ExistingData, UpdatePropertyValue, null);
                }

                return await new GenericRepository<RolePermission>().Update(ExistingData, b => b.Id == ExistingData.Id);
            }
        }

        public async Task<List<RolePermission>> GetRolePermissionListByRoleID(int ID)
        {
            return await new GenericRepository<RolePermission>().Find(p => p.RoleId == ID && p.IsDeleted == false  );
        }

     
        #endregion

        public async Task<UserPermission> AddUpdateUserPermission(UserPermission data)
        {

            if (data.Id == 0) // Insert
            {
                return await new GenericRepository<UserPermission>().Insert(data);
            }
            else // Update
            {
                var ExistingData = await new GenericRepository<UserPermission>().FindOne(b => b.Id == data.Id);
                List<string> Updatedproperties = ObjectComparison.GetChangedProperties(data, ExistingData);

                foreach (string propertyName in Updatedproperties)
                {
                    var ExistingPropertyInfo = ExistingData.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    var UpdatePropertyValue = data.GetType().GetProperty(propertyName).GetValue(data, null);
                    ExistingPropertyInfo.SetValue(ExistingData, UpdatePropertyValue, null);
                }

                return await new GenericRepository<UserPermission>().Update(ExistingData, b => b.Id == ExistingData.Id);
            }
        }
    }
}
