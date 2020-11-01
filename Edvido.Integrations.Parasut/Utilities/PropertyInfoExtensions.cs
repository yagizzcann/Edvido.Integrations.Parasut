using System;
using System.ComponentModel;
using System.Reflection;

namespace Edvido.Utilities
{
	// Token: 0x02000009 RID: 9
	public static class PropertyInfoExtensions
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000022E4 File Offset: 0x000004E4
		public static string GetDescription(this PropertyInfo prop)
		{
			object[] customAttributes = prop.GetCustomAttributes(true);
			for (int i = 0; i < customAttributes.Length; i++)
			{
				DescriptionAttribute descriptionAttribute = customAttributes[i] as DescriptionAttribute;
				if (descriptionAttribute != null)
				{
					return descriptionAttribute.Description;
				}
			}
			return string.Empty;
		}
	}
}
