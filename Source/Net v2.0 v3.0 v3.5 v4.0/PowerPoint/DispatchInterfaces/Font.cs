//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface Font SupportByLibrary PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Font : COMObject
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
                    _type = typeof(Font);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Font(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Font(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Font(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Font() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Font(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
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
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.ColorFormat Color
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Color", paramsArray);
				NetOffice.PowerPointApi.ColorFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ColorFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Bold
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Bold", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Bold", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Italic
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Italic", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Italic", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Shadow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shadow", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Shadow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Emboss
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Emboss", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Emboss", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Underline
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Underline", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Underline", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Subscript
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Subscript", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Subscript", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Superscript
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Superscript", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Superscript", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single BaselineOffset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaselineOffset", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BaselineOffset", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Embedded
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Embedded", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Embeddable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Embeddable", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single Size
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Size", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Size", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
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
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string NameFarEast
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameFarEast", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameFarEast", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string NameAscii
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameAscii", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameAscii", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState AutoRotateNumbers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoRotateNumbers", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoRotateNumbers", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string NameOther
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameOther", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameOther", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public string NameComplexScript
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameComplexScript", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameComplexScript", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}