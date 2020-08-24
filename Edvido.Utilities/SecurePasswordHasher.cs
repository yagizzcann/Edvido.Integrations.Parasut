using System;
using System.Security.Cryptography;

namespace Edvido.Utilities
{
	// Token: 0x0200000A RID: 10
	public sealed class SecurePasswordHasher
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002320 File Offset: 0x00000520
		public static string Hash(string password, int iterations)
		{
			byte[] array;
			new RNGCryptoServiceProvider().GetBytes(array = new byte[16]);
			Array bytes = new Rfc2898DeriveBytes(password, array, iterations).GetBytes(20);
			byte[] array2 = new byte[36];
			Array.Copy(array, 0, array2, 0, 16);
			Array.Copy(bytes, 0, array2, 16, 20);
			string arg = Convert.ToBase64String(array2);
			return string.Format(".peak.v1.{0}.{1}", iterations, arg);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002385 File Offset: 0x00000585
		public static string Hash(string password)
		{
			return SecurePasswordHasher.Hash(password, 10000);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002392 File Offset: 0x00000592
		public static bool IsHashSupported(string hashString)
		{
			return hashString != null && hashString.Contains(".peak.v1.");
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000023A4 File Offset: 0x000005A4
		public static bool Verify(string password, string hashedPassword)
		{
			if (password == null || hashedPassword == null)
			{
				return false;
			}
			if (!SecurePasswordHasher.IsHashSupported(hashedPassword))
			{
				throw new NotSupportedException("The hashtype is not supported");
			}
			string[] array = hashedPassword.Replace(".peak.v1.", "").Split(new char[] { '.' }, StringSplitOptions.None);
			int iterations = int.Parse(array[0]);
			byte[] array2 = Convert.FromBase64String(array[1]);
			byte[] array3 = new byte[16];
			Array.Copy(array2, 0, array3, 0, 16);
			byte[] bytes = new Rfc2898DeriveBytes(password, array3, iterations).GetBytes(20);
			for (int i = 0; i < 20; i++)
			{
				if (array2[i + 16] != bytes[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000001 RID: 1
		private const int SaltSize = 16;

		// Token: 0x04000002 RID: 2
		private const int HashSize = 20;
	}
}
