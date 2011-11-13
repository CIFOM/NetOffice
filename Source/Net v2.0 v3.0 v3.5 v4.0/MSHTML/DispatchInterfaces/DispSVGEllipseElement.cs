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
	/// DispatchInterface DispSVGEllipseElement SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DispSVGEllipseElement : COMObject
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
                    _type = typeof(DispSVGEllipseElement);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGEllipseElement(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGEllipseElement(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGEllipseElement(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGEllipseElement() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGEllipseElement(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLength cx
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "cx", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLength newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLength;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "cx", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLength cy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "cy", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLength newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLength;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "cy", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLength rx
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "rx", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLength newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLength;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "rx", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLength ry
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ry", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLength newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLength;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ry", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedTransformList transform
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "transform", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedTransformList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedTransformList;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGElement nearestViewportElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "nearestViewportElement", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGElement;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGElement farthestViewportElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "farthestViewportElement", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGElement;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string xmlbase
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "xmlbase", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "xmlbase", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGSVGElement ownerSVGElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ownerSVGElement", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGSVGElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGSVGElement;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ownerSVGElement", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGElement viewportElement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "viewportElement", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGElement;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "viewportElement", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration focusable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "focusable", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "focusable", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGStringList requiredFeatures
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "requiredFeatures", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGStringList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGStringList;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGStringList requiredExtensions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "requiredExtensions", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGStringList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGStringList;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGStringList systemLanguage
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "systemLanguage", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGStringList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGStringList;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGRect getBBox()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "getBBox", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGRect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGRect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGMatrix getCTM()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "getCTM", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGMatrix newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGMatrix;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGMatrix getScreenCTM()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "getScreenCTM", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGMatrix newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGMatrix;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pElement">LateBindingApi.MSHTMLApi.ISVGElement pElement</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGMatrix getTransformToElement(LateBindingApi.MSHTMLApi.ISVGElement pElement)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pElement);
			object returnItem = Invoker.MethodReturn(this, "getTransformToElement", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGMatrix newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGMatrix;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="extension">string extension</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool hasExtension(string extension)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(extension);
			object returnItem = Invoker.MethodReturn(this, "hasExtension", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}