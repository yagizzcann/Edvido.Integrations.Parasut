using System;
using System.ComponentModel;
using System.Reflection;

namespace Edvido.Utilities
{
	// Token: 0x02000006 RID: 6
	public static class EnumExtensions
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002174 File Offset: 0x00000374
		public static string GetDescription(this Enum value)
		{
			MemberInfo[] member = value.GetType().GetMember(value.ToString());
			if (member != null && member.Length != 0)
			{
				object[] customAttributes = member[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
				if (customAttributes != null && customAttributes.Length != 0)
				{
					return ((DescriptionAttribute)customAttributes[0]).Description;
				}
			}
			return value.ToString();
		}
	}
}
