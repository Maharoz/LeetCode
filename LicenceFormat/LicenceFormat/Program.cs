using System.Text;

namespace LicenceFormat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			LicenseKeyFormatting("---", 3);
		}

		public static string LicenseKeyFormatting(string s, int k)
		{
			s= s.Replace("-", "").ToUpper();
		    char[] sa= s.ToCharArray();
			StringBuilder sb = new StringBuilder();
			int clusterSize = sa.Length/k;
			int firstCluster = sa.Length % k;

			for(int i = 0;i< firstCluster; i++)
			{
				sb.Append(sa[i]);
			}
			if(firstCluster != 0) { sb.Append("-"); }
			
			for (int i = firstCluster; i < sa.Length; i = i + k)
			{
				for(int j = i; j < i + k; j++)
				{
					sb.Append(sa[j]);
				}
				
				sb.Append("-"); 
			}
			string ss = sb.ToString();
			return ss.Remove(sb.Length-1,1);

		}
	}
}