using Muhasebe.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Muhasebe.Bll.Functions
{
    public static class Converts
    {
        #region Functions

        public static TTarget EntityConvert<TTarget>(this IBaseEntity source)
        {
            if (source == null) return default;

            var hedef = Activator.CreateInstance<TTarget>();
            var kaynakProperty = source.GetType().GetProperties();
            var hedefProperty = typeof(TTarget).GetProperties();

            foreach (var kp in kaynakProperty)
            {
                var value = kp.GetValue(source);
                var hp = hedefProperty.FirstOrDefault(x => x.Name == kp.Name);
                if (hp != null)
                {
                    hp.SetValue(hedef, ReferenceEquals(value, "") ? null : value);
                }
            }
            return hedef;
        }

        public static IEnumerable<TTarget> EntityListConvert<TTarget>(this IEnumerable<IBaseEntity> source)
        {
            return source?.Select(x => x.EntityConvert<TTarget>()).ToList();
        } 

        #endregion
    }
}