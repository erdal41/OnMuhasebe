using Muhasebe.Dal.Interfaces;
using Muhasebe.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Runtime.InteropServices;
using System.Security;
using DevExpress.Utils.Extensions;
using Muhasebe.Dal.Base;

namespace Muhasebe.Bll.Functions
{
    public static class GeneralFunctions
    {
        #region Functions

        public static List<string> DegisenAlanlariGetir<T>(this T oldEntity, T newEntity)
        {
            List<string> alanlar = new List<string>();

            foreach (var prop in newEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;

                var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
                var newValue = prop.GetValue(newEntity) ?? string.Empty;

                //Resim eklerken alanları karşılatırıyoruz
                if (prop.PropertyType == typeof(byte[]))
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(newValue.ToString()))
                        newValue = new byte[] { 0 };

                    if (((byte[])oldValue).Length != ((byte[])newValue).Length)
                        alanlar.Add(prop.Name);
                }

                else if (prop.PropertyType == typeof(SecureString))
                {
                    var oldString = ((SecureString)oldValue).ConvertToUnSecureString();
                    var newString = ((SecureString)newValue).ConvertToUnSecureString();

                    if (!oldString.Equals(newString))
                        alanlar.Add(prop.Name);
                }
                else if (!newValue.Equals(oldValue))
                    alanlar.Add(prop.Name);
            }
            return alanlar;
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MuhasebeContext"].ConnectionString;
        }

        private static TContext CreateContext<TContext>() where TContext : DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }

        public static void CreateUnitOfWork<T, TContext>(ref IUnitOfWork<T> unitOfWork) where T : class, IBaseEntity where TContext : DbContext
        {
            unitOfWork?.Dispose();
            unitOfWork = new UnitOfWork<T>(CreateContext<TContext>());
        }

        public static SecureString ConvertToSecureString(this string value)
        {
            var secureString = new SecureString();

            if (value.Length > 0)
            {
                value.ToCharArray().ForEach(x => secureString.AppendChar(x));
            }

            secureString.MakeReadOnly();
            return secureString;
        }

        public static string ConvertToUnSecureString(this SecureString value)
        {
            var result = Marshal.SecureStringToBSTR(value);
            return Marshal.PtrToStringAuto(result);
        } 

        #endregion
    }
}