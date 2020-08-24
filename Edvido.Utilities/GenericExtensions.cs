using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Edvido.Utilities
{
	// Token: 0x02000008 RID: 8
	public static class GenericExtensions
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002204 File Offset: 0x00000404
		public static Dictionary<string, string> GetPropertiesWithDescription<T>(this T model) where T : class
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
			{
				object[] customAttributes = propertyInfo.GetCustomAttributes(true);
				for (int j = 0; j < customAttributes.Length; j++)
				{
					DescriptionAttribute descriptionAttribute = customAttributes[j] as DescriptionAttribute;
					if (descriptionAttribute != null)
					{
						string name = propertyInfo.Name;
						string description = descriptionAttribute.Description;
						dictionary.Add(name, description);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002281 File Offset: 0x00000481
		public static T SetPropertyValue<T, M>(this T model, M value, string propertyName)
		{
			PropertyInfo property = typeof(T).GetProperty(propertyName);
			if (property == null)
			{
				throw new Exception("Property not found!");
			}
			property.SetValue(model, value);
			return model;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000022B9 File Offset: 0x000004B9
		public static Type GetTypeWithPropetyName<T>(this T model, string propertyName)
		{
			PropertyInfo property = typeof(T).GetProperty(propertyName);
			if (property == null)
			{
				throw new Exception("Property not found!");
			}
			return property.PropertyType;
		}
	}
}
