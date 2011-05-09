//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface SlideShowSettings SupportByLibrary PP09 PP10 PP11 PP12 PP14 
	///</summary>
	[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
	public class SlideShowSettings : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SlideShowSettings(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SlideShowSettings(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SlideShowSettings(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SlideShowSettings()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.ColorFormat PointerColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PointerColor", paramsArray);
				NetOffice.PowerPointApi.ColorFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.ColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.NamedSlideShows NamedSlideShows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NamedSlideShows", paramsArray);
				NetOffice.PowerPointApi.NamedSlideShows newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.NamedSlideShows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public Int32 StartingSlide
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StartingSlide", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StartingSlide", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public Int32 EndingSlide
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EndingSlide", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EndingSlide", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Enums.PpSlideShowAdvanceMode AdvanceMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AdvanceMode", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpSlideShowAdvanceMode)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AdvanceMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState LoopUntilStopped
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LoopUntilStopped", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LoopUntilStopped", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Enums.PpSlideShowType ShowType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowType", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpSlideShowType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState ShowWithNarration
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowWithNarration", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowWithNarration", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState ShowWithAnimation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowWithAnimation", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowWithAnimation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public string SlideShowName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SlideShowName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SlideShowName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.Enums.PpSlideShowRangeType RangeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RangeType", paramsArray);
				return (NetOffice.PowerPointApi.Enums.PpSlideShowRangeType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RangeType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState ShowScrollbar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowScrollbar", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowScrollbar", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState ShowPresenterView
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowPresenterView", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowPresenterView", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState ShowMediaControls
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowMediaControls", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowMediaControls", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.SlideShowWindow Run()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Run", paramsArray);
			NetOffice.PowerPointApi.SlideShowWindow newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.SlideShowWindow;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}