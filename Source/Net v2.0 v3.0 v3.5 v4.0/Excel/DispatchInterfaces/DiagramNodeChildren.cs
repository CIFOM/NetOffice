//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface DiagramNodeChildren SupportByLibraryAttribute Excel, 10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DiagramNodeChildren : NetOffice.OfficeApi._IMsoDispObj ,IEnumerable
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
                    _type = typeof(DiagramNodeChildren);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNodeChildren(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNodeChildren(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNodeChildren(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNodeChildren() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNodeChildren(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
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
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.DiagramNode FirstChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstChild", paramsArray);
				NetOffice.ExcelApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.ExcelApi.DiagramNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.DiagramNode LastChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastChild", paramsArray);
				NetOffice.ExcelApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.ExcelApi.DiagramNode;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.DiagramNode this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.ExcelApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.ExcelApi.DiagramNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">object Index</param>
		/// <param name="nodeType">NetOffice.OfficeApi.Enums.MsoDiagramNodeType nodeType</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public NetOffice.ExcelApi.DiagramNode AddNode(object index, NetOffice.OfficeApi.Enums.MsoDiagramNodeType nodeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, nodeType);
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.ExcelApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.DiagramNode.LateBindingApiWrapperType) as NetOffice.ExcelApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public void SelectAll()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SelectAll", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Excel, 10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
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