using System;
using System.Collections.Generic;
using System.Text;

namespace Edvido.Utilities
{
	// Token: 0x02000005 RID: 5
	public static class DictionaryExtensions
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000209C File Offset: 0x0000029C
		public static TValue TryGetValue<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key)
		{
			if (!self.ContainsKey(key))
			{
				return default(TValue);
			}
			return self[key];
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020C4 File Offset: 0x000002C4
		public static string ToQueryString(this Dictionary<string, string> dictionary)
		{
			if (dictionary.Count == 0)
			{
				return string.Empty;
			}
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			bool flag = false;
			foreach (string text in dictionary.Keys)
			{
				if (num == dictionary.Count - 1)
				{
					flag = true;
				}
				if (flag)
				{
					stringBuilder.AppendFormat("{0}={1}", text, dictionary[text]);
				}
				else
				{
					stringBuilder.AppendFormat("{0}={1}&", text, dictionary[text]);
				}
				num++;
			}
			return stringBuilder.ToString();
		}
	}
}
