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
	/// DispatchInterface DispHTMLDOMAttribute SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DispHTMLDOMAttribute : COMObject
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
                    _type = typeof(DispHTMLDOMAttribute);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMAttribute(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMAttribute(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMAttribute(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMAttribute() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispHTMLDOMAttribute(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string nodeName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "nodeName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public object nodeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "nodeValue", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "nodeValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public bool specified
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "specified", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "value", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public bool expando
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "expando", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 nodeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "nodeType", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode parentNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "parentNode", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public COMObject childNodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "childNodes", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode firstChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "firstChild", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode lastChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "lastChild", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode previousSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "previousSibling", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode nextSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "nextSibling", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public COMObject attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "attributes", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public COMObject ownerDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ownerDocument", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public object ie8_nodeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie8_nodeValue", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ie8_nodeValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string ie8_value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie8_value", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ie8_value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public bool ie8_specified
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie8_specified", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLElement2 ownerElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ownerElement", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLElement2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLElement2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public COMObject constructor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "constructor", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public object ie9_nodeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie9_nodeValue", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ie9_nodeValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string ie9_nodeName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie9_nodeName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string ie9_name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie9_name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string ie9_value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie9_value", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ie9_value", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode ie9_firstChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie9_firstChild", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode ie9_lastChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie9_lastChild", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public COMObject ie9_childNodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie9_childNodes", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public bool ie9_specified
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ie9_specified", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public object prefix
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "prefix", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "prefix", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public object localName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "localName", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public object namespaceURI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "namespaceURI", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public object textContent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "textContent", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "textContent", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild</param>
		/// <param name="refChild">optional object refChild</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode insertBefore(LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild, object refChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild, refChild);
			object returnItem = Invoker.MethodReturn(this, "insertBefore", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode insertBefore(LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild);
			object returnItem = Invoker.MethodReturn(this, "insertBefore", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild</param>
		/// <param name="oldChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode oldChild</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode replaceChild(LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild, LateBindingApi.MSHTMLApi.IHTMLDOMNode oldChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild, oldChild);
			object returnItem = Invoker.MethodReturn(this, "replaceChild", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="oldChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode oldChild</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode removeChild(LateBindingApi.MSHTMLApi.IHTMLDOMNode oldChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oldChild);
			object returnItem = Invoker.MethodReturn(this, "removeChild", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode appendChild(LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild);
			object returnItem = Invoker.MethodReturn(this, "appendChild", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public bool hasChildNodes()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "hasChildNodes", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="fDeep">bool fDeep</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMAttribute cloneNode(bool fDeep)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fDeep);
			object returnItem = Invoker.MethodReturn(this, "cloneNode", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMAttribute newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMAttribute;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public bool hasAttributes()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "hasAttributes", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public bool ie9_hasChildNodes()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ie9_hasChildNodes", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public void normalize()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "normalize", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="otherNode">LateBindingApi.MSHTMLApi.IHTMLDOMNode3 otherNode</param>
		[SupportByLibrary("MSHTML", 4)]
		public bool isEqualNode(LateBindingApi.MSHTMLApi.IHTMLDOMNode3 otherNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(otherNode);
			object returnItem = Invoker.MethodReturn(this, "isEqualNode", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pvarPrefix">object pvarPrefix</param>
		[SupportByLibrary("MSHTML", 4)]
		public object lookupNamespaceURI(object pvarPrefix)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvarPrefix);
			object returnItem = Invoker.MethodReturn(this, "lookupNamespaceURI", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pvarNamespaceURI">object pvarNamespaceURI</param>
		[SupportByLibrary("MSHTML", 4)]
		public object lookupPrefix(object pvarNamespaceURI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvarNamespaceURI);
			object returnItem = Invoker.MethodReturn(this, "lookupPrefix", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pvarNamespace">object pvarNamespace</param>
		[SupportByLibrary("MSHTML", 4)]
		public bool isDefaultNamespace(object pvarNamespace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvarNamespace);
			object returnItem = Invoker.MethodReturn(this, "isDefaultNamespace", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode ie9_appendChild(LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild);
			object returnItem = Invoker.MethodReturn(this, "ie9_appendChild", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild</param>
		/// <param name="refChild">optional object refChild</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode ie9_insertBefore(LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild, object refChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild, refChild);
			object returnItem = Invoker.MethodReturn(this, "ie9_insertBefore", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode ie9_insertBefore(LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild);
			object returnItem = Invoker.MethodReturn(this, "ie9_insertBefore", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="oldChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode oldChild</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode ie9_removeChild(LateBindingApi.MSHTMLApi.IHTMLDOMNode oldChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oldChild);
			object returnItem = Invoker.MethodReturn(this, "ie9_removeChild", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="newChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild</param>
		/// <param name="oldChild">LateBindingApi.MSHTMLApi.IHTMLDOMNode oldChild</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDOMNode ie9_replaceChild(LateBindingApi.MSHTMLApi.IHTMLDOMNode newChild, LateBindingApi.MSHTMLApi.IHTMLDOMNode oldChild)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newChild, oldChild);
			object returnItem = Invoker.MethodReturn(this, "ie9_replaceChild", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLDOMNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDOMNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="otherNode">LateBindingApi.MSHTMLApi.IHTMLDOMNode3 otherNode</param>
		[SupportByLibrary("MSHTML", 4)]
		public bool isSameNode(LateBindingApi.MSHTMLApi.IHTMLDOMNode3 otherNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(otherNode);
			object returnItem = Invoker.MethodReturn(this, "isSameNode", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="otherNode">LateBindingApi.MSHTMLApi.IHTMLDOMNode otherNode</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int16 compareDocumentPosition(LateBindingApi.MSHTMLApi.IHTMLDOMNode otherNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(otherNode);
			object returnItem = Invoker.MethodReturn(this, "compareDocumentPosition", paramsArray);
			return (Int16)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="feature">string feature</param>
		/// <param name="version">object version</param>
		[SupportByLibrary("MSHTML", 4)]
		public bool isSupported(string feature, object version)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(feature, version);
			object returnItem = Invoker.MethodReturn(this, "isSupported", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}