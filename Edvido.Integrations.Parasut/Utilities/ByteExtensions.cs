using System;

namespace Edvido.Utilities
{
	// Token: 0x02000003 RID: 3
	public static class ByteExtensions
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public static string ConvertString(this byte[] bytes)
		{
			string text = "";
			for (int i = 0; i < bytes.Length; i++)
			{
				text += bytes[i].ToString("X2");
			}
			return text;
		}
	}
}
