//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface HTMLDivision SupportByLibrary WD10 WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD10","WD11","WD12","WD14")]
	public class HTMLDivision : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLDivision(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLDivision(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLDivision(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLDivision()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Borders Borders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Borders", paramsArray);
				NetOffice.WordApi.Borders newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Borders;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public Single LeftIndent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LeftIndent", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LeftIndent", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public Single RightIndent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RightIndent", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RightIndent", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public Single SpaceBefore
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SpaceBefore", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SpaceBefore", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public Single SpaceAfter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SpaceAfter", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SpaceAfter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.HTMLDivisions HTMLDivisions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HTMLDivisions", paramsArray);
				NetOffice.WordApi.HTMLDivisions newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.HTMLDivisions;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="LevelsUp">ref optional object LevelsUp</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.HTMLDivision HTMLDivisionParent(ref object levelsUp)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(levelsUp);
			object returnItem = Invoker.MethodReturn(this, "HTMLDivisionParent", paramsArray, modifiers);
			NetOffice.WordApi.HTMLDivision newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.HTMLDivision;
			levelsUp = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.HTMLDivision HTMLDivisionParent()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "HTMLDivisionParent", paramsArray);
			NetOffice.WordApi.HTMLDivision newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.HTMLDivision;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}