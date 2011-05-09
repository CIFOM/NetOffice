//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IDummy SupportByLibrary XL09 XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
	public class IDummy : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDummy(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDummy(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDummy(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IDummy()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public bool ShowSignaturesPane
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowSignaturesPane", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowSignaturesPane", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 _ActiveSheetOrChart()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "_ActiveSheetOrChart", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 RGB()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "RGB", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 ChDir()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ChDir", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 DoScript()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "DoScript", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 DirectObject()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "DirectObject", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL09 XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL09","XL10","XL11","XL12","XL14")]
		public Int32 RefreshDocument()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "RefreshDocument", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="SigProv">object SigProv</param>
		[SupportByLibrary("XL12","XL14")]
		public NetOffice.OfficeApi.Signature AddSignatureLine(object sigProv)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sigProv);
			object returnItem = Invoker.MethodReturn(this, "AddSignatureLine", paramsArray);
			NetOffice.OfficeApi.Signature newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.Signature;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		/// <param name="SigProv">object SigProv</param>
		[SupportByLibrary("XL12","XL14")]
		public NetOffice.OfficeApi.Signature AddNonVisibleSignature(object sigProv)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sigProv);
			object returnItem = Invoker.MethodReturn(this, "AddNonVisibleSignature", paramsArray);
			NetOffice.OfficeApi.Signature newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.Signature;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public Int32 ThemeFontScheme()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ThemeFontScheme", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public Int32 ThemeColorScheme()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ThemeColorScheme", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public Int32 ThemeEffectScheme()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ThemeEffectScheme", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public Int32 Load()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Load", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}