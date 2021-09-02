using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApplication2.Properties
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000068A3 File Offset: 0x00004AA3
		internal Resources()
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000068B0 File Offset: 0x00004AB0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("WindowsFormsApplication2.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000068F8 File Offset: 0x00004AF8
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000690F File Offset: 0x00004B0F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00006918 File Offset: 0x00004B18
		internal static Bitmap _042
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("042", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000047 RID: 71
		private static ResourceManager resourceMan;

		// Token: 0x04000048 RID: 72
		private static CultureInfo resourceCulture;
	}
}
