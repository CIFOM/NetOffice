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
	/// DispatchInterface HTMLImgEvents2 SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class HTMLImgEvents2 : COMObject
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
                    _type = typeof(HTMLImgEvents2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLImgEvents2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLImgEvents2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLImgEvents2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLImgEvents2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLImgEvents2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onhelp(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onhelp", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onclick(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onclick", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool ondblclick(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "ondblclick", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onkeypress(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onkeypress", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onkeydown(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onkeydown", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onkeyup(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onkeyup", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onmouseout(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onmouseout", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onmouseover(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onmouseover", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onmousemove(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onmousemove", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onmousedown(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onmousedown", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onmouseup(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onmouseup", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onselectstart(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onselectstart", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onfilterchange(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onfilterchange", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool ondragstart(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "ondragstart", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onbeforeupdate(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onbeforeupdate", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onafterupdate(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onafterupdate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onerrorupdate(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onerrorupdate", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onrowexit(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onrowexit", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onrowenter(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onrowenter", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void ondatasetchanged(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "ondatasetchanged", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void ondataavailable(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "ondataavailable", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void ondatasetcomplete(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "ondatasetcomplete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onlosecapture(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onlosecapture", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onpropertychange(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onpropertychange", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onscroll(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onscroll", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onfocus(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onfocus", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onblur(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onblur", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onresize(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onresize", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool ondrag(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "ondrag", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void ondragend(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "ondragend", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool ondragenter(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "ondragenter", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool ondragover(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "ondragover", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void ondragleave(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "ondragleave", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool ondrop(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "ondrop", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onbeforecut(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onbeforecut", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool oncut(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "oncut", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onbeforecopy(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onbeforecopy", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool oncopy(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "oncopy", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onbeforepaste(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onbeforepaste", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onpaste(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onpaste", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool oncontextmenu(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "oncontextmenu", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onrowsdelete(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onrowsdelete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onrowsinserted(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onrowsinserted", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void oncellchange(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "oncellchange", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onreadystatechange(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onreadystatechange", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onlayoutcomplete(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onlayoutcomplete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onpage(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onpage", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onmouseenter(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onmouseenter", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onmouseleave(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onmouseleave", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onactivate(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onactivate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void ondeactivate(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "ondeactivate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onbeforedeactivate(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onbeforedeactivate", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onbeforeactivate(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onbeforeactivate", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onfocusin(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onfocusin", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onfocusout(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onfocusout", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onmove(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onmove", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool oncontrolselect(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "oncontrolselect", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onmovestart(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onmovestart", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onmoveend(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onmoveend", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onresizestart(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onresizestart", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onresizeend(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onresizeend", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool onmousewheel(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			object returnItem = Invoker.MethodReturn(this, "onmousewheel", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onload(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onload", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onerror(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onerror", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pEvtObj">LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void onabort(LateBindingApi.MSHTMLApi.IHTMLEventObj pEvtObj)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pEvtObj);
			Invoker.Method(this, "onabort", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}