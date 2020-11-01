using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Edvido.Utilities.Helpers
{
	// Token: 0x0200000D RID: 13
	public class HttpHelper
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000028AD File Offset: 0x00000AAD
		public static HttpHelper Instance
		{
			get
			{
				return HttpHelper._instance ?? new HttpHelper();
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000028C0 File Offset: 0x00000AC0
		public async Task<string> GetAsync(string uriString, Dictionary<string, string> headers = null)
		{
			string result;
			using (HttpClient client = new HttpClient())
			{
				if (headers != null && (headers != null && headers.Count > 0))
				{
					foreach (KeyValuePair<string, string> keyValuePair in headers)
					{
						client.DefaultRequestHeaders.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
				HttpResponseMessage httpResponseMessage = await client.GetAsync(new Uri(uriString.ToString()));
				result = ((!httpResponseMessage.IsSuccessStatusCode) ? null : (await httpResponseMessage.Content.ReadAsStringAsync()));
			}
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002910 File Offset: 0x00000B10
		public async Task<string> PostAsync(string uriString, string postData, Dictionary<string, string> headers = null)
		{
			string result;
			using (HttpClient client = new HttpClient())
			{
				if (headers != null && (headers != null && headers.Count > 0))
				{
					foreach (KeyValuePair<string, string> keyValuePair in headers)
					{
						client.DefaultRequestHeaders.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
				HttpResponseMessage httpResponseMessage = await client.PostAsync(new Uri(uriString.ToString()), new StringContent(postData, Encoding.UTF8, "application/json"));
				result = ((!httpResponseMessage.IsSuccessStatusCode) ? string.Empty : (await httpResponseMessage.Content.ReadAsStringAsync()));
			}
			return result;
		}

		// Token: 0x04000006 RID: 6
		private static HttpHelper _instance;
	}
}
