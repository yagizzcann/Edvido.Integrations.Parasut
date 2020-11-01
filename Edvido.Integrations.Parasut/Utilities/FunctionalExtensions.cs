using System;

namespace Edvido.Utilities
{
	// Token: 0x02000007 RID: 7
	public static class FunctionalExtensions
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000021C9 File Offset: 0x000003C9
		public static T With<T>(this T self, Action<T> job)
		{
			if (job != null)
			{
				job(self);
			}
			return self;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021D8 File Offset: 0x000003D8
		public static TTo As<TFrom, TTo>(this TFrom self, Func<TFrom, TTo> job)
		{
			if (job != null)
			{
				return job(self);
			}
			return default(TTo);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021F9 File Offset: 0x000003F9
		public static bool IsNull<T>(this T self) where T : class
		{
			return self == null;
		}
	}
}
