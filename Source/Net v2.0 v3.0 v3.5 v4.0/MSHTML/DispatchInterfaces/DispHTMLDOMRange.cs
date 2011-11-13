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
	/// DispatchInterface DispHTMLDOMRange SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DispHTMLDOMRange : COMObject
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
                    _type = typeof(DispHTMLDOMRange);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMRange(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMRange(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMRange(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMRange() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMRange(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode startContainer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "startContainer", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 startOffset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "startOffset", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode endContainer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "endContainer", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 endOffset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "endOffset", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool collapsed
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "collapsed", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode commonAncestorContainer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "commonAncestorContainer", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="refNode">object refNode</param>
		/// <param name="offset">Int32 offset</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void setStart(object refNode, Int32 offset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(refNode, offset);
			Invoker.Method(this, "setStart", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="refNode">object refNode</param>
		/// <param name="offset">Int32 offset</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void setEnd(object refNode, Int32 offset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(refNode, offset);
			Invoker.Method(this, "setEnd", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="refNode">object refNode</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void setStartBefore(object refNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(refNode);
			Invoker.Method(this, "setStartBefore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="refNode">object refNode</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void setStartAfter(object refNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(refNode);
			Invoker.Method(this, "setStartAfter", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="refNode">object refNode</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void setEndBefore(object refNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(refNode);
			Invoker.Method(this, "setEndBefore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="refNode">object refNode</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void setEndAfter(object refNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(refNode);
			Invoker.Method(this, "setEndAfter", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="toStart">bool toStart</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void collapse(bool toStart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(toStart);
			Invoker.Method(this, "collapse", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="refNode">object refNode</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void selectNode(object refNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(refNode);
			Invoker.Method(this, "selectNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="refNode">object refNode</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void selectNodeContents(object refNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(refNode);
			Invoker.Method(this, "selectNodeContents", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="how">Int16 how</param>
		/// <param name="sourceRange">object sourceRange</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 compareBoundaryPoints(Int16 how, object sourceRange)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(how, sourceRange);
			object returnItem = Invoker.MethodReturn(this, "compareBoundaryPoints", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void deleteContents()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "deleteContents", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public COMObject extractContents()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "extractContents", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public COMObject cloneContents()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "cloneContents", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newNode">object newNode</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void insertNode(object newNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newNode);
			Invoker.Method(this, "insertNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newParent">object newParent</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void surroundContents(object newParent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newParent);
			Invoker.Method(this, "surroundContents", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMRange cloneRange()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "cloneRange", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string toString()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "toString", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void Detach()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Detach", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLRectCollection getClientRects()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "getClientRects", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLRectCollection newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,LateBindingApi.MSHTMLApi.IHTMLRectCollection.LateBindingApiWrapperType) as LateBindingApi.MSHTMLApi.IHTMLRectCollection;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLRect getBoundingClientRect()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "getBoundingClientRect", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLRect newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,LateBindingApi.MSHTMLApi.IHTMLRect.LateBindingApiWrapperType) as LateBindingApi.MSHTMLApi.IHTMLRect;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}