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
	/// DispatchInterface DispSVGTextPositioningElement SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DispSVGTextPositioningElement : COMObject
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
                    _type = typeof(DispSVGTextPositioningElement);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGTextPositioningElement(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGTextPositioningElement(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGTextPositioningElement(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGTextPositioningElement() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispSVGTextPositioningElement(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList x
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "x", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "x", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList y
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "y", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "y", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList dx
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "dx", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "dx", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList dy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "dy", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLengthList;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "dy", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedNumberList rotate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "rotate", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedNumberList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedNumberList;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "rotate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedLength textLength
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "textLength", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedLength newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedLength;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "textLength", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration lengthAdjust
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "lengthAdjust", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedEnumeration;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "lengthAdjust", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
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
		[SupportByLibrary("MSHTML", 4)]
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
		[SupportByLibrary("MSHTML", 4)]
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
		[SupportByLibrary("MSHTML", 4)]
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
		[SupportByLibrary("MSHTML", 4)]
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
		[SupportByLibrary("MSHTML", 4)]
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
		[SupportByLibrary("MSHTML", 4)]
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

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string xmllang
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "xmllang", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "xmllang", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public string xmlspace
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "xmlspace", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "xmlspace", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedBoolean externalResourcesRequired
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "externalResourcesRequired", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedBoolean newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedBoolean;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGAnimatedString className
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "className", paramsArray);
				LateBindingApi.MSHTMLApi.ISVGAnimatedString newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGAnimatedString;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 getNumberOfChars()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "getNumberOfChars", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public Single getComputedTextLength()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "getComputedTextLength", paramsArray);
			return (Single)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="charnum">Int32 charnum</param>
		/// <param name="nchars">Int32 nchars</param>
		[SupportByLibrary("MSHTML", 4)]
		public Single getSubStringLength(Int32 charnum, Int32 nchars)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(charnum, nchars);
			object returnItem = Invoker.MethodReturn(this, "getSubStringLength", paramsArray);
			return (Single)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="charnum">Int32 charnum</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGPoint getStartPositionOfChar(Int32 charnum)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(charnum);
			object returnItem = Invoker.MethodReturn(this, "getStartPositionOfChar", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGPoint newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGPoint;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="charnum">Int32 charnum</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGPoint getEndPositionOfChar(Int32 charnum)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(charnum);
			object returnItem = Invoker.MethodReturn(this, "getEndPositionOfChar", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGPoint newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGPoint;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="charnum">Int32 charnum</param>
		[SupportByLibrary("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ISVGRect getExtentOfChar(Int32 charnum)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(charnum);
			object returnItem = Invoker.MethodReturn(this, "getExtentOfChar", paramsArray);
			LateBindingApi.MSHTMLApi.ISVGRect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ISVGRect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="charnum">Int32 charnum</param>
		[SupportByLibrary("MSHTML", 4)]
		public Single getRotationOfChar(Int32 charnum)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(charnum);
			object returnItem = Invoker.MethodReturn(this, "getRotationOfChar", paramsArray);
			return (Single)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="point">LateBindingApi.MSHTMLApi.ISVGPoint point</param>
		[SupportByLibrary("MSHTML", 4)]
		public Int32 getCharNumAtPosition(LateBindingApi.MSHTMLApi.ISVGPoint point)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(point);
			object returnItem = Invoker.MethodReturn(this, "getCharNumAtPosition", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="charnum">Int32 charnum</param>
		/// <param name="nchars">Int32 nchars</param>
		[SupportByLibrary("MSHTML", 4)]
		public void selectSubString(Int32 charnum, Int32 nchars)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(charnum, nchars);
			Invoker.Method(this, "selectSubString", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="extension">string extension</param>
		[SupportByLibrary("MSHTML", 4)]
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