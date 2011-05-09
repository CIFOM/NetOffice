//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface ICTPFactory SupportByLibrary OF12 OF14 
	///</summary>
	[SupportByLibrary("OF12","OF14")]
	public class ICTPFactory : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICTPFactory(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICTPFactory(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICTPFactory(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICTPFactory()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="CTPAxID">string CTPAxID</param>
		/// <param name="CTPTitle">string CTPTitle</param>
		/// <param name="CTPParentWindow">optional object CTPParentWindow</param>
		[SupportByLibrary("OF12","OF14")]
		public NetOffice.OfficeApi._CustomTaskPane CreateCTP(string cTPAxID, string cTPTitle, object cTPParentWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cTPAxID, cTPTitle, cTPParentWindow);
			object returnItem = Invoker.MethodReturn(this, "CreateCTP", paramsArray);
			NetOffice.OfficeApi._CustomTaskPane newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi._CustomTaskPane;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="CTPAxID">string CTPAxID</param>
		/// <param name="CTPTitle">string CTPTitle</param>
		[SupportByLibrary("OF12","OF14")]
		public NetOffice.OfficeApi._CustomTaskPane CreateCTP(string cTPAxID, string cTPTitle)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cTPAxID, cTPTitle);
			object returnItem = Invoker.MethodReturn(this, "CreateCTP", paramsArray);
			NetOffice.OfficeApi._CustomTaskPane newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi._CustomTaskPane;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}