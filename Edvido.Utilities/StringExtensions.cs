using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Edvido.Utilities.Enums;

namespace Edvido.Utilities
{
	// Token: 0x0200000B RID: 11
	public static class StringExtensions
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002441 File Offset: 0x00000641
		public static bool IsNullOrEmpty(this string self)
		{
			return string.IsNullOrEmpty(self);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002449 File Offset: 0x00000649
		public static bool IsNullOrWhiteSpace(this string self)
		{
			return string.IsNullOrWhiteSpace(self);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002454 File Offset: 0x00000654
		public static int ToInt(this string self)
		{
			int result = 0;
			int.TryParse(self, out result);
			return result;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002470 File Offset: 0x00000670
		public static double ToDouble(this string self)
		{
			double result = 0.0;
			double.TryParse(self, out result);
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002494 File Offset: 0x00000694
		public static DateTime ToDateTime(this string self)
		{
			DateTime minValue = DateTime.MinValue;
			DateTime.TryParse(self, out minValue);
			return minValue;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024B4 File Offset: 0x000006B4
		public static DateTimeOffset ToDateTimeOffset(this string self)
		{
			DateTimeOffset minValue = DateTimeOffset.MinValue;
			DateTimeOffset.TryParse(self, out minValue);
			return minValue;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000024D4 File Offset: 0x000006D4
		public static T To<T>(this string self)
		{
			Func<string, object> func = StringExtensions.Converters.TryGetValue(typeof(T));
			if (func == null)
			{
				throw new NotSupportedException();
			}
			return func(self).As(delegate(object o)
			{
				if (o != null)
				{
					return (T)((object)o);
				}
				return default(T);
			});
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002528 File Offset: 0x00000728
		public static string HMAC(this string self, string key, HashType hashType = HashType.MD5)
		{
			switch (hashType)
			{
			case HashType.RPEMD160:
				return self.HMACAsRPEMD160(key);
			case HashType.MD5:
				return self.HMACAsMD5(key);
			case HashType.SHA1:
				return self.HMACAsSHA1(key);
			case HashType.SHA256:
				return self.HMACAsSHA256(key);
			case HashType.SHA384:
				return self.HMACAsSHA384(key);
			case HashType.SHA512:
				return self.HMACAsSHA512(key);
			default:
				return self.HMACAsMD5(key);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000258C File Offset: 0x0000078C
		public static string HMACAsRPEMD160(this string self, string key)
		{
			StringExtensions.encoding.GetBytes(key);
			return string.Empty;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025A0 File Offset: 0x000007A0
		public static string HMACAsMD5(this string self, string key)
		{
			string result;
			using (HMACMD5 hmacmd = new HMACMD5(StringExtensions.encoding.GetBytes(key)))
			{
				hmacmd.ComputeHash(StringExtensions.encoding.GetBytes(self));
				result = hmacmd.Hash.ConvertString().ToLower();
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002600 File Offset: 0x00000800
		public static string HMACAsSHA1(this string self, string key)
		{
			string result;
			using (HMACSHA1 hmacsha = new HMACSHA1(StringExtensions.encoding.GetBytes(key)))
			{
				hmacsha.ComputeHash(StringExtensions.encoding.GetBytes(self));
				result = hmacsha.Hash.ConvertString().ToLower();
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002660 File Offset: 0x00000860
		public static string HMACAsSHA256(this string self, string key)
		{
			string result;
			using (HMACSHA256 hmacsha = new HMACSHA256(StringExtensions.encoding.GetBytes(key)))
			{
				hmacsha.ComputeHash(StringExtensions.encoding.GetBytes(self));
				result = hmacsha.Hash.ConvertString().ToLower();
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000026C0 File Offset: 0x000008C0
		public static string HMACAsSHA384(this string self, string key)
		{
			string result;
			using (HMACSHA384 hmacsha = new HMACSHA384(StringExtensions.encoding.GetBytes(key)))
			{
				hmacsha.ComputeHash(StringExtensions.encoding.GetBytes(self));
				result = hmacsha.Hash.ConvertString().ToLower();
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002720 File Offset: 0x00000920
		public static string HMACAsSHA512(this string self, string key)
		{
			string result;
			using (HMACSHA512 hmacsha = new HMACSHA512(StringExtensions.encoding.GetBytes(key)))
			{
				hmacsha.ComputeHash(StringExtensions.encoding.GetBytes(self));
				result = hmacsha.Hash.ConvertString().ToLower();
			}
			return result;
		}

		// Token: 0x04000003 RID: 3
		private static readonly Encoding encoding = Encoding.UTF8;

		// Token: 0x04000004 RID: 4
		private static Dictionary<Type, Func<string, object>> Converters = new Dictionary<Type, Func<string, object>>
		{
			{
				typeof(int),
				(string s) => s.ToInt()
			},
			{
				typeof(double),
				(string s) => s.ToDouble()
			},
			{
				typeof(DateTime),
				(string s) => s.ToDateTime()
			},
			{
				typeof(DateTimeOffset),
				(string s) => s.ToDateTimeOffset()
			}
		};
	}
}
