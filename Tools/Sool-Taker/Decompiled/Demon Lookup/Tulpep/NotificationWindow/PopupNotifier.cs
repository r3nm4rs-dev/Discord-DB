using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using UY3BiEArlp6B4GPt9k;

namespace Tulpep.NotificationWindow
{
	// Token: 0x020004C9 RID: 1225
	[ToolboxBitmap(typeof(PopupNotifier), "Icon.ico")]
	[DefaultEvent("Click")]
	public class PopupNotifier : Component
	{
		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06002CCD RID: 11469 RVA: 0x00027628 File Offset: 0x00025828
		// (remove) Token: 0x06002CCE RID: 11470 RVA: 0x00027638 File Offset: 0x00025838
		public event EventHandler Click
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x14000043 RID: 67
		// (add) Token: 0x06002CCF RID: 11471 RVA: 0x00027648 File Offset: 0x00025848
		// (remove) Token: 0x06002CD0 RID: 11472 RVA: 0x00027658 File Offset: 0x00025858
		public event EventHandler Close
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x14000044 RID: 68
		// (add) Token: 0x06002CD1 RID: 11473 RVA: 0x00027668 File Offset: 0x00025868
		// (remove) Token: 0x06002CD2 RID: 11474 RVA: 0x00027678 File Offset: 0x00025878
		public event EventHandler Appear
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x14000045 RID: 69
		// (add) Token: 0x06002CD3 RID: 11475 RVA: 0x00027688 File Offset: 0x00025888
		// (remove) Token: 0x06002CD4 RID: 11476 RVA: 0x00027698 File Offset: 0x00025898
		public event EventHandler Disappear
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x000276A8 File Offset: 0x000258A8
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x000276B4 File Offset: 0x000258B4
		[Category("Header")]
		[Description("Color of the window header.")]
		[DefaultValue(typeof(Color), "ControlDark")]
		public Color HeaderColor
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Color)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06002CD7 RID: 11479 RVA: 0x000276BC File Offset: 0x000258BC
		// (set) Token: 0x06002CD8 RID: 11480 RVA: 0x000276C8 File Offset: 0x000258C8
		[Category("Appearance")]
		[Description("Color of the window background.")]
		[DefaultValue(typeof(Color), "Control")]
		public Color BodyColor
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Color)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x000276D0 File Offset: 0x000258D0
		// (set) Token: 0x06002CDA RID: 11482 RVA: 0x000276DC File Offset: 0x000258DC
		[Category("Title")]
		[Description("Color of the title text.")]
		[DefaultValue(typeof(Color), "Gray")]
		public Color TitleColor
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Color)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x000276E4 File Offset: 0x000258E4
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x000276F0 File Offset: 0x000258F0
		[Description("Color of the content text.")]
		[Category("Content")]
		[DefaultValue(typeof(Color), "ControlText")]
		public Color ContentColor
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Color)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x000276F8 File Offset: 0x000258F8
		// (set) Token: 0x06002CDE RID: 11486 RVA: 0x00027704 File Offset: 0x00025904
		[DefaultValue(typeof(Color), "WindowFrame")]
		[Description("Color of the window border.")]
		[Category("Appearance")]
		public Color BorderColor
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Color)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x0002770C File Offset: 0x0002590C
		// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x00027718 File Offset: 0x00025918
		[DefaultValue(typeof(Color), "WindowFrame")]
		[Category("Buttons")]
		[Description("Border color of the close and options buttons when the mouse is over them.")]
		public Color ButtonBorderColor
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Color)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x00027720 File Offset: 0x00025920
		// (set) Token: 0x06002CE2 RID: 11490 RVA: 0x0002772C File Offset: 0x0002592C
		[Category("Buttons")]
		[Description("Background color of the close and options buttons when the mouse is over them.")]
		[DefaultValue(typeof(Color), "Highlight")]
		public Color ButtonHoverColor
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Color)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x00027734 File Offset: 0x00025934
		// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x00027740 File Offset: 0x00025940
		[DefaultValue(typeof(Color), "HotTrack")]
		[Category("Content")]
		[Description("Color of the content text when the mouse is hovering over it.")]
		public Color ContentHoverColor
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Color)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x00027748 File Offset: 0x00025948
		// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x00027750 File Offset: 0x00025950
		[Description("Gradient of window background color.")]
		[Category("Appearance")]
		[DefaultValue(50)]
		public int GradientPower
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x00027758 File Offset: 0x00025958
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x00027760 File Offset: 0x00025960
		[Description("Font of the content text.")]
		[Category("Content")]
		public Font ContentFont
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x00027768 File Offset: 0x00025968
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x00027770 File Offset: 0x00025970
		[Category("Title")]
		[Description("Font of the title.")]
		public Font TitleFont
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x00027778 File Offset: 0x00025978
		// (set) Token: 0x06002CEC RID: 11500 RVA: 0x00027784 File Offset: 0x00025984
		[Description("Size of the icon image.")]
		[Category("Image")]
		public Size ImageSize
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Size)null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x0002778C File Offset: 0x0002598C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetImageSize()
		{
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00027794 File Offset: 0x00025994
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeImageSize()
		{
			return true;
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x0002779C File Offset: 0x0002599C
		// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x000277A4 File Offset: 0x000259A4
		[Category("Image")]
		[Description("Icon image to display.")]
		public Image Image
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x000277AC File Offset: 0x000259AC
		// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x000277B4 File Offset: 0x000259B4
		[Description("Whether to show a 'grip' image within the window header.")]
		[DefaultValue(true)]
		[Category("Header")]
		public bool ShowGrip
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x000277BC File Offset: 0x000259BC
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x000277C4 File Offset: 0x000259C4
		[Category("Behavior")]
		[DefaultValue(true)]
		[Description("Whether to scroll the window or only fade it.")]
		public bool Scroll
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06002CF5 RID: 11509 RVA: 0x000277CC File Offset: 0x000259CC
		// (set) Token: 0x06002CF6 RID: 11510 RVA: 0x000277D4 File Offset: 0x000259D4
		[Category("Content")]
		[Description("Content text to display.")]
		public string ContentText
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06002CF7 RID: 11511 RVA: 0x000277DC File Offset: 0x000259DC
		// (set) Token: 0x06002CF8 RID: 11512 RVA: 0x000277E4 File Offset: 0x000259E4
		[Description("Title text to display.")]
		[Category("Title")]
		public string TitleText
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06002CF9 RID: 11513 RVA: 0x000277EC File Offset: 0x000259EC
		// (set) Token: 0x06002CFA RID: 11514 RVA: 0x000277F8 File Offset: 0x000259F8
		[Category("Title")]
		[Description("Padding of title text.")]
		public Padding TitlePadding
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Padding)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x00027800 File Offset: 0x00025A00
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void gtcxO5rSsqP()
		{
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00027808 File Offset: 0x00025A08
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeTitlePadding()
		{
			return true;
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06002CFD RID: 11517 RVA: 0x00027818 File Offset: 0x00025A18
		// (set) Token: 0x06002CFE RID: 11518 RVA: 0x00027824 File Offset: 0x00025A24
		[Description("Padding of content text.")]
		[Category("Content")]
		public Padding ContentPadding
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Padding)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x0002782C File Offset: 0x00025A2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void vj9xOWJvjM3()
		{
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x00027834 File Offset: 0x00025A34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeContentPadding()
		{
			return true;
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x00027844 File Offset: 0x00025A44
		// (set) Token: 0x06002D02 RID: 11522 RVA: 0x00027850 File Offset: 0x00025A50
		[Description("Padding of icon image.")]
		[Category("Image")]
		public Padding ImagePadding
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Padding)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x00027858 File Offset: 0x00025A58
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void lW7xOsKCV7s()
		{
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x00027860 File Offset: 0x00025A60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool ShouldSerializeImagePadding()
		{
			return true;
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x00027870 File Offset: 0x00025A70
		// (set) Token: 0x06002D06 RID: 11526 RVA: 0x00027878 File Offset: 0x00025A78
		[Description("Height of window header.")]
		[Category("Header")]
		[DefaultValue(9)]
		public int HeaderHeight
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06002D07 RID: 11527 RVA: 0x00027880 File Offset: 0x00025A80
		// (set) Token: 0x06002D08 RID: 11528 RVA: 0x00027888 File Offset: 0x00025A88
		[DefaultValue(true)]
		[Category("Buttons")]
		[Description("Whether to show the close button.")]
		public bool ShowCloseButton
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x00027890 File Offset: 0x00025A90
		// (set) Token: 0x06002D0A RID: 11530 RVA: 0x00027898 File Offset: 0x00025A98
		[DefaultValue(false)]
		[Category("Buttons")]
		[Description("Whether to show the options button.")]
		public bool ShowOptionsButton
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002D0B RID: 11531 RVA: 0x000278A0 File Offset: 0x00025AA0
		// (set) Token: 0x06002D0C RID: 11532 RVA: 0x000278A8 File Offset: 0x00025AA8
		[Description("Context menu to open when clicking on the options button.")]
		[Category("Behavior")]
		public ContextMenuStrip OptionsMenu
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002D0D RID: 11533 RVA: 0x000278B0 File Offset: 0x00025AB0
		// (set) Token: 0x06002D0E RID: 11534 RVA: 0x000278B8 File Offset: 0x00025AB8
		[DefaultValue(3000)]
		[Category("Behavior")]
		[Description("Time in milliseconds the window is displayed.")]
		public int Delay
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06002D0F RID: 11535 RVA: 0x000278C0 File Offset: 0x00025AC0
		// (set) Token: 0x06002D10 RID: 11536 RVA: 0x000278C8 File Offset: 0x00025AC8
		[Description("Time in milliseconds needed to make the window appear or disappear.")]
		[DefaultValue(1000)]
		[Category("Behavior")]
		public int AnimationDuration
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06002D11 RID: 11537 RVA: 0x000278D0 File Offset: 0x00025AD0
		// (set) Token: 0x06002D12 RID: 11538 RVA: 0x000278D8 File Offset: 0x00025AD8
		[DefaultValue(10)]
		[Category("Behavior")]
		[Description("Interval in milliseconds used to draw the animation.")]
		public int AnimationInterval
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x000278E0 File Offset: 0x00025AE0
		// (set) Token: 0x06002D14 RID: 11540 RVA: 0x000278EC File Offset: 0x00025AEC
		[Description("Size of the window.")]
		[Category("Appearance")]
		public Size Size
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return (Size)null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x000278F4 File Offset: 0x00025AF4
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x000278FC File Offset: 0x00025AFC
		[Category("Content")]
		[Description("Show Content Right To Left,نمایش پیغام چپ به راست فعال شود")]
		public bool IsRightToLeft
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x00027904 File Offset: 0x00025B04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PopupNotifier()
		{
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00027914 File Offset: 0x00025B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Popup()
		{
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00027924 File Offset: 0x00025B24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x0002792C File Offset: 0x00025B2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void fXTxOkeECOf(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00027934 File Offset: 0x00025B34
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void N04xOeL7nND(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x0002793C File Offset: 0x00025B3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GC6xOoLYCD7(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00027944 File Offset: 0x00025B44
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UM1xOAYs96s(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x0002794C File Offset: 0x00025B4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DybxOEY0w5P(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x0002795C File Offset: 0x00025B5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void r66xOK3YPT9(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x0002796C File Offset: 0x00025B6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FnUxOD6oehi(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00027974 File Offset: 0x00025B74
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void V2NxOZLCii2(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x00027984 File Offset: 0x00025B84
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void hNHxOhlMw67(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x00027994 File Offset: 0x00025B94
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x0002799C File Offset: 0x00025B9C
		static PopupNotifier()
		{
			nCP5vtxT3QjsSeuiK3.SLMriFgIx();
		}

		// Token: 0x0400132E RID: 4910
		private EventHandler yTXxOQUruFG;

		// Token: 0x0400132F RID: 4911
		private EventHandler EsyxO3Atdm2;

		// Token: 0x04001330 RID: 4912
		private EventHandler pyXxOSRK2cq;

		// Token: 0x04001331 RID: 4913
		private EventHandler Y3ixOTnJOXX;

		// Token: 0x04001332 RID: 4914
		private bool kHBxOR89X2U;

		// Token: 0x04001333 RID: 4915
		private PopupNotifierForm VLrxOwcVsJm;

		// Token: 0x04001334 RID: 4916
		private Timer OY5xOBpXogs;

		// Token: 0x04001335 RID: 4917
		private Timer mRFxOJvJw0Z;

		// Token: 0x04001336 RID: 4918
		private bool xjhxOzmRm9o;

		// Token: 0x04001337 RID: 4919
		private bool I4FxvtPrL8l;

		// Token: 0x04001338 RID: 4920
		private int fOhxvxbVlGm;

		// Token: 0x04001339 RID: 4921
		private double jnaxvcJgDqu;

		// Token: 0x0400133A RID: 4922
		private int tWDxvH6DHB6;

		// Token: 0x0400133B RID: 4923
		private int nlCxvYpG0cK;

		// Token: 0x0400133C RID: 4924
		private double rP6xvPfwGr8;

		// Token: 0x0400133D RID: 4925
		private double pOAxvrM5K6I;

		// Token: 0x0400133E RID: 4926
		private int q2WxvpyVtrg;

		// Token: 0x0400133F RID: 4927
		private Stopwatch DmnxvMY2EVY;

		// Token: 0x04001340 RID: 4928
		private Size z3kxvOENTEO;

		// Token: 0x04001341 RID: 4929
		[CompilerGenerated]
		private Color tRXxvvZaMyh;

		// Token: 0x04001342 RID: 4930
		[CompilerGenerated]
		private Color u86xvF8GHtR;

		// Token: 0x04001343 RID: 4931
		[CompilerGenerated]
		private Color UeJxv0s5uME;

		// Token: 0x04001344 RID: 4932
		[CompilerGenerated]
		private Color daOxvubSI4N;

		// Token: 0x04001345 RID: 4933
		[CompilerGenerated]
		private Color Q5Jxv7GEvuN;

		// Token: 0x04001346 RID: 4934
		[CompilerGenerated]
		private Color plkxv1c1qPL;

		// Token: 0x04001347 RID: 4935
		[CompilerGenerated]
		private Color EPvxviKGtRM;

		// Token: 0x04001348 RID: 4936
		[CompilerGenerated]
		private Color OXmxvUK6akE;

		// Token: 0x04001349 RID: 4937
		[CompilerGenerated]
		private int X2oxvIBbV2W;

		// Token: 0x0400134A RID: 4938
		[CompilerGenerated]
		private Font k8AxvNuki0L;

		// Token: 0x0400134B RID: 4939
		[CompilerGenerated]
		private Font IFfxvm6qCya;

		// Token: 0x0400134C RID: 4940
		[CompilerGenerated]
		private Image U25xvVRcY3p;

		// Token: 0x0400134D RID: 4941
		[CompilerGenerated]
		private bool yNjxv9Z7gFJ;

		// Token: 0x0400134E RID: 4942
		[CompilerGenerated]
		private bool vy1xv2vogWi;

		// Token: 0x0400134F RID: 4943
		[CompilerGenerated]
		private string ikYxvgsSaVA;

		// Token: 0x04001350 RID: 4944
		[CompilerGenerated]
		private string CsDxvCvH84W;

		// Token: 0x04001351 RID: 4945
		[CompilerGenerated]
		private Padding EWPxv67Lbl6;

		// Token: 0x04001352 RID: 4946
		[CompilerGenerated]
		private Padding JhPxvlynIId;

		// Token: 0x04001353 RID: 4947
		[CompilerGenerated]
		private Padding TysxvqDW2Ku;

		// Token: 0x04001354 RID: 4948
		[CompilerGenerated]
		private int nr6xvLBZddt;

		// Token: 0x04001355 RID: 4949
		[CompilerGenerated]
		private bool F8Hxv8Ae6CB;

		// Token: 0x04001356 RID: 4950
		[CompilerGenerated]
		private bool WfJxvbIJBVC;

		// Token: 0x04001357 RID: 4951
		[CompilerGenerated]
		private ContextMenuStrip vpfxv4V20xs;

		// Token: 0x04001358 RID: 4952
		[CompilerGenerated]
		private int EQxxvXIQ9kp;

		// Token: 0x04001359 RID: 4953
		[CompilerGenerated]
		private int qejxvGULToY;

		// Token: 0x0400135A RID: 4954
		[CompilerGenerated]
		private int twvxvdPxmcJ;

		// Token: 0x0400135B RID: 4955
		[CompilerGenerated]
		private Size DQNxvjE5A1X;

		// Token: 0x0400135C RID: 4956
		[CompilerGenerated]
		private bool sFtxvyCgSyN;
	}
}
