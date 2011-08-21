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
	/// DispatchInterface View SupportByLibrary Word, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class View : COMObject
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
                    _type = typeof(View);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public View(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public View(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public View(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public View() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public View(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdViewType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.WordApi.Enums.WdViewType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool FullScreen
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FullScreen", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FullScreen", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool Draft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Draft", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Draft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowAll
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowAll", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowAll", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowFieldCodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowFieldCodes", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowFieldCodes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool MailMergeDataView
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MailMergeDataView", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MailMergeDataView", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool Magnifier
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Magnifier", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Magnifier", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowFirstLineOnly
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowFirstLineOnly", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowFirstLineOnly", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowFormat", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Zoom Zoom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Zoom", paramsArray);
				NetOffice.WordApi.Zoom newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Zoom.LateBindingApiWrapperType) as NetOffice.WordApi.Zoom;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowObjectAnchors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowObjectAnchors", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowObjectAnchors", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowTextBoundaries
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTextBoundaries", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTextBoundaries", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowHighlight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowHighlight", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowHighlight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowDrawings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowDrawings", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowDrawings", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowTabs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTabs", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTabs", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowSpaces
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowSpaces", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowSpaces", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowParagraphs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowParagraphs", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowParagraphs", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowHyphens
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowHyphens", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowHyphens", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowHiddenText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowHiddenText", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowHiddenText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool WrapToWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WrapToWindow", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WrapToWindow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowPicturePlaceHolders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowPicturePlaceHolders", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowPicturePlaceHolders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowBookmarks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowBookmarks", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowBookmarks", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdFieldShading FieldShading
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FieldShading", paramsArray);
				return (NetOffice.WordApi.Enums.WdFieldShading)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FieldShading", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowAnimation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowAnimation", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowAnimation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool TableGridlines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TableGridlines", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TableGridlines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 EnlargeFontsLessThan
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnlargeFontsLessThan", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnlargeFontsLessThan", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowMainTextLayer
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowMainTextLayer", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowMainTextLayer", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdSeekView SeekView
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SeekView", paramsArray);
				return (NetOffice.WordApi.Enums.WdSeekView)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SeekView", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdSpecialPane SplitSpecial
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SplitSpecial", paramsArray);
				return (NetOffice.WordApi.Enums.WdSpecialPane)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SplitSpecial", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 BrowseToWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BrowseToWindow", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BrowseToWindow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public bool ShowOptionalBreaks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowOptionalBreaks", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowOptionalBreaks", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool DisplayPageBoundaries
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayPageBoundaries", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayPageBoundaries", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool DisplaySmartTags
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplaySmartTags", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplaySmartTags", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool ShowRevisionsAndComments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowRevisionsAndComments", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowRevisionsAndComments", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool ShowComments
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowComments", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowComments", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool ShowInsertionsAndDeletions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowInsertionsAndDeletions", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowInsertionsAndDeletions", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool ShowFormatChanges
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowFormatChanges", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowFormatChanges", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public NetOffice.WordApi.Enums.WdRevisionsView RevisionsView
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RevisionsView", paramsArray);
				return (NetOffice.WordApi.Enums.WdRevisionsView)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RevisionsView", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public NetOffice.WordApi.Enums.WdRevisionsMode RevisionsMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RevisionsMode", paramsArray);
				return (NetOffice.WordApi.Enums.WdRevisionsMode)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RevisionsMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public Single RevisionsBalloonWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RevisionsBalloonWidth", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RevisionsBalloonWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public NetOffice.WordApi.Enums.WdRevisionsBalloonWidthType RevisionsBalloonWidthType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RevisionsBalloonWidthType", paramsArray);
				return (NetOffice.WordApi.Enums.WdRevisionsBalloonWidthType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RevisionsBalloonWidthType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public NetOffice.WordApi.Enums.WdRevisionsBalloonMargin RevisionsBalloonSide
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RevisionsBalloonSide", paramsArray);
				return (NetOffice.WordApi.Enums.WdRevisionsBalloonMargin)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RevisionsBalloonSide", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public NetOffice.WordApi.Reviewers Reviewers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Reviewers", paramsArray);
				NetOffice.WordApi.Reviewers newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Reviewers.LateBindingApiWrapperType) as NetOffice.WordApi.Reviewers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 10,11,12,14)]
		public bool RevisionsBalloonShowConnectingLines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RevisionsBalloonShowConnectingLines", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RevisionsBalloonShowConnectingLines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public bool ReadingLayout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReadingLayout", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReadingLayout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public Int32 ShowXMLMarkup
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowXMLMarkup", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowXMLMarkup", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public Int32 ShadeEditableRanges
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShadeEditableRanges", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShadeEditableRanges", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public bool ShowInkAnnotations
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowInkAnnotations", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowInkAnnotations", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public bool DisplayBackgrounds
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayBackgrounds", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayBackgrounds", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public bool ReadingLayoutActualView
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReadingLayoutActualView", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReadingLayoutActualView", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 11,12,14)]
		public bool ReadingLayoutAllowMultiplePages
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReadingLayoutAllowMultiplePages", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReadingLayoutAllowMultiplePages", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool ReadingLayoutAllowEditing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReadingLayoutAllowEditing", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReadingLayoutAllowEditing", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Enums.WdReadingLayoutMargin ReadingLayoutTruncateMargins
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReadingLayoutTruncateMargins", paramsArray);
				return (NetOffice.WordApi.Enums.WdReadingLayoutMargin)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ReadingLayoutTruncateMargins", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool ShowMarkupAreaHighlight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowMarkupAreaHighlight", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowMarkupAreaHighlight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool Panning
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Panning", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Panning", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public bool ShowCropMarks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowCropMarks", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowCropMarks", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 12,14)]
		public NetOffice.WordApi.Enums.WdRevisionsMode MarkupMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkupMode", paramsArray);
				return (NetOffice.WordApi.Enums.WdRevisionsMode)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkupMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool ConflictMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ConflictMode", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ConflictMode", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("Word", 14)]
		public bool ShowOtherAuthors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowOtherAuthors", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowOtherAuthors", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">optional object Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void CollapseOutline(object range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			Invoker.Method(this, "CollapseOutline", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void CollapseOutline()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CollapseOutline", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">optional object Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void ExpandOutline(object range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			Invoker.Method(this, "ExpandOutline", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void ExpandOutline()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ExpandOutline", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void ShowAllHeadings()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ShowAllHeadings", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Level">Int32 Level</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void ShowHeading(Int32 level)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(level);
			Invoker.Method(this, "ShowHeading", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void PreviousHeaderFooter()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PreviousHeaderFooter", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void NextHeaderFooter()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "NextHeaderFooter", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}