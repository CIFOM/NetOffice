//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// DispatchInterface IHTMLElementAppliedStyles SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IHTMLElementAppliedStyles : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IHTMLElementAppliedStyles);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLElementAppliedStyles(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLElementAppliedStyles(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLElementAppliedStyles(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLElementAppliedStyles() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLElementAppliedStyles(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IRulesAppliedCollection msGetRulesApplied()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "msGetRulesApplied", paramsArray);
			LateBindingApi.MSHTMLApi.IRulesAppliedCollection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IRulesAppliedCollection;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="varContext">optional object varContext</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IRulesAppliedCollection msGetRulesAppliedWithAncestor(object varContext)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(varContext);
			object returnItem = Invoker.MethodReturn(this, "msGetRulesAppliedWithAncestor", paramsArray);
			LateBindingApi.MSHTMLApi.IRulesAppliedCollection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IRulesAppliedCollection;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IRulesAppliedCollection msGetRulesAppliedWithAncestor()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "msGetRulesAppliedWithAncestor", paramsArray);
			LateBindingApi.MSHTMLApi.IRulesAppliedCollection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IRulesAppliedCollection;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}