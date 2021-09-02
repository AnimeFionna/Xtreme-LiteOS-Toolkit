using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
	// Token: 0x02000004 RID: 4
	internal static class Program
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00006888 File Offset: 0x00004A88
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new main());
		}
	}
}
