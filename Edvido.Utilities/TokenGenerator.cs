using System;
using System.Security.Cryptography;

namespace Edvido.Utilities
{
	// Token: 0x0200000C RID: 12
	public static class TokenGenerator
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002824 File Offset: 0x00000A24
		public static string Generate(int length = 64)
		{
			char[] array = new char[length];
			byte[] array2 = new byte[length];
			using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
			{
				rngcryptoServiceProvider.GetBytes(array2);
			}
			for (int i = 0; i < array.Length; i++)
			{
				int num = (int)array2[i] % TokenGenerator.AvailableCharacters.Length;
				array[i] = TokenGenerator.AvailableCharacters[num];
			}
			return new string(array);
		}

		// Token: 0x04000005 RID: 5
		private static readonly char[] AvailableCharacters = new char[]
		{
			'A',
			'B',
			'C',
			'D',
			'E',
			'F',
			'G',
			'H',
			'I',
			'J',
			'K',
			'L',
			'M',
			'N',
			'O',
			'P',
			'Q',
			'R',
			'S',
			'T',
			'U',
			'V',
			'W',
			'X',
			'Y',
			'Z',
			'a',
			'b',
			'c',
			'd',
			'e',
			'f',
			'g',
			'h',
			'i',
			'j',
			'k',
			'l',
			'm',
			'n',
			'o',
			'p',
			'q',
			'r',
			's',
			't',
			'u',
			'v',
			'w',
			'x',
			'y',
			'z',
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9'
		};
	}
}
