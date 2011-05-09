//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface _AdditionalData SupportByLibrary AC11 AC12 AC14 
	///</summary>
	[SupportByLibrary("AC11","AC12","AC14")]
	public class _AdditionalData : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AdditionalData(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AdditionalData(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AdditionalData(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _AdditionalData()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC11","AC12","AC14")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC11 AC12 AC14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("AC11","AC12","AC14")]
		public NetOffice.AccessApi._AdditionalData get_Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.AccessApi._AdditionalData newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi._AdditionalData;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC11","AC12","AC14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary AC11 AC12 AC14 
		/// </summary>
		/// <param name="var">string var</param>
		[SupportByLibrary("AC11","AC12","AC14")]
		public NetOffice.AccessApi._AdditionalData Add(string var)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(var);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.AccessApi._AdditionalData newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.AccessApi._AdditionalData;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary AC11 AC12 AC14 
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[SupportByLibrary("AC11","AC12","AC14")]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return (bool)returnItem;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("AC11","AC12","AC14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}