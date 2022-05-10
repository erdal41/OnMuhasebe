using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors;

namespace Muhasebe.Common.Functions
{
    public static class EnumFunctions
    {
        #region Functions

        private static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            if (value == null) return null;

            var memberInfo = value.GetType().GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return (T)attributes[0];
        }

        public static string ToName(this Enum value)
        {
            if (value == null) return null;

            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
        }

        public static ICollection GetEnumDescriptionList<T>()
        {
            return typeof(T).GetMembers()
                .SelectMany(x => x.GetCustomAttributes(typeof(DescriptionAttribute), true)
                .Cast<DescriptionAttribute>())
                .Select(x => x.Description).ToList();
        }

        public static void GetEnumDescriptionAndValueList<T>(LookUpEdit edit)
        {
            edit.Properties.DataSource = Enum.GetValues(typeof(T))
            .Cast<T>()
            .Select(p => new
            {
                Kod = Convert.ToInt32(p),
                Tip = (Attribute.GetCustomAttribute(p.GetType().GetField(p.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
            })
            .ToList();

            edit.Properties.ValueMember = "Kod";
            edit.Properties.DisplayMember = "Tip";
        }

        public static T GetEnum<T>(this string description)
        {
            if (Enum.IsDefined(typeof(T), description))
            {
                return (T)Enum.Parse(typeof(T), description, true);
            }
            var enumNames = Enum.GetNames(typeof(T));

            foreach (var e in enumNames.Select(x => Enum.Parse(typeof(T), x)).Where(y => description == ToName((Enum)y)))
            {
                return (T)e;
            }
            return default;
        } 

        #endregion
    }
}