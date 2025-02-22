using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HsZcU78F13T1yLWI1V;
using UY3BiEArlp6B4GPt9k;

namespace Xtreme_theme
{
	// Token: 0x020000E5 RID: 229
	public class HuraControlBox : Control
	{
		// Token: 0x060007D5 RID: 2005 RVA: 0x000098B0 File Offset: 0x00007AB0
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HuraControlBox()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			nCP5vtxT3QjsSeuiK3.AbqQ0f7fZ();
			WkMgYHbfSUMGdoITRx.SObPhkwzKrAeQ();
			HuraControlBox.TBS7E1VfQP = new List<WeakReference>();
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000098CC File Offset: 0x00007ACC
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void CAl7Auk4oD(object \u0020)
		{
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060007D7 RID: 2007 RVA: 0x000098EC File Offset: 0x00007AEC
		// (remove) Token: 0x060007D8 RID: 2008 RVA: 0x000098F4 File Offset: 0x00007AF4
		public event HuraControlBox.ColorSchemeChangedEventHandler ColorSchemeChanged
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			add
			{
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x000098FC File Offset: 0x00007AFC
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x00009910 File Offset: 0x00007B10
		public HuraControlBox.ColorSchemes ColorScheme
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (HuraControlBox.ColorSchemes)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00009920 File Offset: 0x00007B20
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnColorSchemeChanged()
		{
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00009930 File Offset: 0x00007B30
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00009944 File Offset: 0x00007B44
		public Color AccentColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Color)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0000994C File Offset: 0x00007B4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HuraControlBox()
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0000995C File Offset: 0x00007B5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnResize(EventArgs e)
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0000996C File Offset: 0x00007B6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseMove(MouseEventArgs e)
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0000997C File Offset: 0x00007B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPaint(PaintEventArgs e)
		{
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0000998C File Offset: 0x00007B8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseUp(MouseEventArgs e)
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0000999C File Offset: 0x00007B9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnMouseLeave(EventArgs e)
		{
		}

		// Token: 0x04000389 RID: 905
		private static List<WeakReference> TBS7E1VfQP;

		// Token: 0x0400038A RID: 906
		private HuraControlBox.ColorSchemeChangedEventHandler oDC7KesMxv;

		// Token: 0x0400038B RID: 907
		private HuraControlBox.ColorSchemes X6r7DcvNlF;

		// Token: 0x0400038C RID: 908
		private Color LUb7ZE2hfo;

		// Token: 0x0400038D RID: 909
		private HuraControlBox.ButtonHover dB87hJ9jBp;

		// Token: 0x020000E6 RID: 230
		public enum ColorSchemes
		{
			// Token: 0x0400038F RID: 911
			Dark
		}

		// Token: 0x020000E7 RID: 231
		public sealed class ColorSchemeChangedEventHandler : MulticastDelegate
		{
			// Token: 0x060007E4 RID: 2020
			public extern ColorSchemeChangedEventHandler(object TargetObject, IntPtr TargetMethod);

			// Token: 0x060007E5 RID: 2021
			public extern IAsyncResult BeginInvoke(AsyncCallback DelegateCallback, object DelegateAsyncState);

			// Token: 0x060007E6 RID: 2022
			public extern void EndInvoke(IAsyncResult DelegateAsyncResult);

			// Token: 0x060007E7 RID: 2023
			public extern void Invoke();

			// Token: 0x060007E8 RID: 2024 RVA: 0x0000A358 File Offset: 0x00008558
			static ColorSchemeChangedEventHandler()
			{
				nCP5vtxT3QjsSeuiK3.SLMriFgIx();
			}
		}

		// Token: 0x020000E8 RID: 232
		public enum ButtonHover
		{
			// Token: 0x04000391 RID: 913
			Minimize,
			// Token: 0x04000392 RID: 914
			Maximize,
			// Token: 0x04000393 RID: 915
			Close,
			// Token: 0x04000394 RID: 916
			None
		}
	}
}
