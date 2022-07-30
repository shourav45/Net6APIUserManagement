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
    public class ProfileService
    {
        public async Task<BankingInfo> AddUpdateBankingInfo(BankingInfoDTO dtodata)
        {
            BankingInfo data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<BankingInfoDTO, BankingInfo>())).Map<BankingInfoDTO, BankingInfo>(dtodata);

            if (data.Id == 0) // Insert
            {
                return await new GenericRepository<BankingInfo>().Insert(data);
            }
            else // Update
            {
                BankingInfo ExistingData = await new GenericRepository<BankingInfo>().FindOne(b=>b.Id == data.Id);
                List<string> Updatedproperties = ObjectComparison.GetChangedProperties(data, ExistingData);

                foreach(string propertyName in Updatedproperties)
                {
                    var ExistingPropertyInfo = ExistingData.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    var UpdatePropertyValue = data.GetType().GetProperty(propertyName).GetValue(data, null);
                    ExistingPropertyInfo.SetValue(ExistingData, UpdatePropertyValue, null);
                }

                return await new GenericRepository<BankingInfo>().Update(ExistingData, b => b.Id == ExistingData.Id);
            }
        }

        public async Task<CertificationInfo> AddUpdateCertificationInfo(CertificationInfoDTO dtodata)
        {
            CertificationInfo data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CertificationInfoDTO, CertificationInfo>()))
                .Map<CertificationInfoDTO, CertificationInfo>(dtodata);

            if (data.Id == 0) // Insert
            {
                return await new GenericRepository<CertificationInfo>().Insert(data);
            }
            else // Update
            {
                CertificationInfo ExistingData = await new GenericRepository<CertificationInfo>().FindOne(b => b.Id == data.Id);
                List<string> Updatedproperties = ObjectComparison.GetChangedProperties(data, ExistingData);

                foreach (string propertyName in Updatedproperties)
                {
                    var ExistingPropertyInfo = ExistingData.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    var UpdatePropertyValue = data.GetType().GetProperty(propertyName).GetValue(data, null);
                    ExistingPropertyInfo.SetValue(ExistingData, UpdatePropertyValue, null);
                }

                return await new GenericRepository<CertificationInfo>().Update(ExistingData, b => b.Id == ExistingData.Id);
            }
        }

        public async Task<ContactInfo> AddUpdateContactInfo(ContactInfoDTO dtodata)
        {
            ContactInfo data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ContactInfoDTO, ContactInfo>()))
                .Map<ContactInfoDTO, ContactInfo>(dtodata);

            if (data.Id == 0) // Insert
            {
                return await new GenericRepository<ContactInfo>().Insert(data);
            }
            else // Update
            {
                var ExistingData = await new GenericRepository<ContactInfo>().FindOne(b => b.Id == data.Id);
                List<string> Updatedproperties = ObjectComparison.GetChangedProperties(data, ExistingData);

                foreach (string propertyName in Updatedproperties)
                {
                    var ExistingPropertyInfo = ExistingData.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    var UpdatePropertyValue = data.GetType().GetProperty(propertyName).GetValue(data, null);
                    ExistingPropertyInfo.SetValue(ExistingData, UpdatePropertyValue, null);
                }

                return await new GenericRepository<ContactInfo>().Update(ExistingData, b => b.Id == ExistingData.Id);
            }
        }

        public async Task<EducationalInfo> AddUpdateEducationalInfo(EducationalInfoDTO dtodata)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<EducationalInfoDTO, EducationalInfo>()))
                .Map<EducationalInfoDTO, EducationalInfo>(dtodata);

            if (data.Id == 0) // Insert
            {
                return await new GenericRepository<EducationalInfo>().Insert(data);
            }
            else // Update
            {
                var ExistingData = await new GenericRepository<EducationalInfo>().FindOne(b => b.Id == data.Id);
                List<string> Updatedproperties = ObjectComparison.GetChangedProperties(data, ExistingData);

                foreach (string propertyName in Updatedproperties)
                {
                    var ExistingPropertyInfo = ExistingData.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    var UpdatePropertyValue = data.GetType().GetProperty(propertyName).GetValue(data, null);
                    ExistingPropertyInfo.SetValue(ExistingData, UpdatePropertyValue, null);
                }

                return await new GenericRepository<EducationalInfo>().Update(ExistingData, b => b.Id == ExistingData.Id);
            }
        }

        public async Task<EmployementInfo> AddUpdateEmployementInfo(EmployementInfoDTO dtodata)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<EmployementInfoDTO, EmployementInfo>()))
                .Map<EmployementInfoDTO, EmployementInfo>(dtodata);

            if (data.Id == 0) // Insert
            {
                return await new GenericRepository<EmployementInfo>().Insert(data);
            }
            else // Update
            {
                var ExistingData = await new GenericRepository<EmployementInfo>().FindOne(b => b.Id == data.Id);
                List<string> Updatedproperties = ObjectComparison.GetChangedProperties(data, ExistingData);

                foreach (string propertyName in Updatedproperties)
                {
                    var ExistingPropertyInfo = ExistingData.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    var UpdatePropertyValue = data.GetType().GetProperty(propertyName).GetValue(data, null);
                    ExistingPropertyInfo.SetValue(ExistingData, UpdatePropertyValue, null);
                }

                return await new GenericRepository<EmployementInfo>().Update(ExistingData, b => b.Id == ExistingData.Id);
            }
        }

        public async Task<NoteInfo> AddUpdateNoteInfo(NoteInfoDTO dtodata)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<NoteInfoDTO, NoteInfo>()))
                .Map<NoteInfoDTO, NoteInfo>(dtodata);

            if (data.Id == 0) // Insert
            {
                return await new GenericRepository<NoteInfo>().Insert(data);
            }
            else // Update
            {
                var ExistingData = await new GenericRepository<NoteInfo>().FindOne(b => b.Id == data.Id);
                List<string> Updatedproperties = ObjectComparison.GetChangedProperties(data, ExistingData);

                foreach (string propertyName in Updatedproperties)
                {
                    var ExistingPropertyInfo = ExistingData.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
                    var UpdatePropertyValue = data.GetType().GetProperty(propertyName).GetValue(data, null);
                    ExistingPropertyInfo.SetValue(ExistingData, UpdatePropertyValue, null);
                }

                return await new GenericRepository<NoteInfo>().Update(ExistingData, b => b.Id == ExistingData.Id);
            }
        }
    }
}
