//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.DAOApi
{
	///<summary>
	/// DispatchInterface _DBEngine SupportByLibrary DAO3.6 DAO12 
	///</summary>
	[SupportByLibrary("DAO3.6","DAO12")]
	public class _DBEngine : _DAO
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _DBEngine(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _DBEngine(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _DBEngine(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _DBEngine()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string Version
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Version", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string IniPath
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IniPath", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IniPath", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string DefaultUser
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultUser", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultUser", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string DefaultPassword
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultPassword", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultPassword", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public Int16 LoginTimeout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LoginTimeout", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LoginTimeout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Workspaces Workspaces
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Workspaces", paramsArray);
				NetOffice.DAOApi.Workspaces newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Workspaces;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Errors Errors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Errors", paramsArray);
				NetOffice.DAOApi.Errors newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Errors;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string SystemDB
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SystemDB", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SystemDB", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public Int32 DefaultType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultType", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DefaultType", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Action">optional object Action</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void Idle(object action)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(action);
			Invoker.Method(this, "Idle", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void Idle()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Idle", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="SrcName">string SrcName</param>
		/// <param name="DstName">string DstName</param>
		/// <param name="DstLocale">optional object DstLocale</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="SrcLocale">optional object SrcLocale</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void CompactDatabase(string srcName, string dstName, object dstLocale, object options, object srcLocale)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(srcName, dstName, dstLocale, options, srcLocale);
			Invoker.Method(this, "CompactDatabase", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="SrcName">string SrcName</param>
		/// <param name="DstName">string DstName</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void CompactDatabase(string srcName, string dstName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(srcName, dstName);
			Invoker.Method(this, "CompactDatabase", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void RepairDatabase(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "RepairDatabase", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Dsn">string Dsn</param>
		/// <param name="Driver">string Driver</param>
		/// <param name="Silent">bool Silent</param>
		/// <param name="Attributes">string Attributes</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void RegisterDatabase(string dsn, string driver, bool silent, string attributes)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dsn, driver, silent, attributes);
			Invoker.Method(this, "RegisterDatabase", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="UserName">string UserName</param>
		/// <param name="Password">string Password</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Workspace _30_CreateWorkspace(string name, string userName, string password)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, userName, password);
			object returnItem = Invoker.MethodReturn(this, "_30_CreateWorkspace", paramsArray);
			NetOffice.DAOApi.Workspace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Workspace;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="Connect">optional object Connect</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Database OpenDatabase(string name, object options, object readOnly, object connect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, options, readOnly, connect);
			object returnItem = Invoker.MethodReturn(this, "OpenDatabase", paramsArray);
			NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Database;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Database OpenDatabase(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "OpenDatabase", paramsArray);
			NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Database;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Locale">string Locale</param>
		/// <param name="Option">optional object Option</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Database CreateDatabase(string name, string locale, object option)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, locale, option);
			object returnItem = Invoker.MethodReturn(this, "CreateDatabase", paramsArray);
			NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Database;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Locale">string Locale</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Database CreateDatabase(string name, string locale)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, locale);
			object returnItem = Invoker.MethodReturn(this, "CreateDatabase", paramsArray);
			NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Database;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void FreeLocks()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "FreeLocks", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void BeginTrans()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "BeginTrans", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Option">Int32 Option</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void CommitTrans(Int32 option)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(option);
			Invoker.Method(this, "CommitTrans", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void Rollback()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Rollback", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Password">string Password</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void SetDefaultWorkspace(string name, string password)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, password);
			Invoker.Method(this, "SetDefaultWorkspace", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Option">Int16 Option</param>
		/// <param name="Value">object Value</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void SetDataAccessOption(Int16 option, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(option, value);
			Invoker.Method(this, "SetDataAccessOption", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="StatNum">Int32 StatNum</param>
		/// <param name="Reset">optional object Reset</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public Int32 ISAMStats(Int32 statNum, object reset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(statNum, reset);
			object returnItem = Invoker.MethodReturn(this, "ISAMStats", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="StatNum">Int32 StatNum</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public Int32 ISAMStats(Int32 statNum)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(statNum);
			object returnItem = Invoker.MethodReturn(this, "ISAMStats", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="UserName">string UserName</param>
		/// <param name="Password">string Password</param>
		/// <param name="UseType">optional object UseType</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Workspace CreateWorkspace(string name, string userName, string password, object useType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, userName, password, useType);
			object returnItem = Invoker.MethodReturn(this, "CreateWorkspace", paramsArray);
			NetOffice.DAOApi.Workspace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Workspace;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="UserName">string UserName</param>
		/// <param name="Password">string Password</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Workspace CreateWorkspace(string name, string userName, string password)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, userName, password);
			object returnItem = Invoker.MethodReturn(this, "CreateWorkspace", paramsArray);
			NetOffice.DAOApi.Workspace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Workspace;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="ReadOnly">optional object ReadOnly</param>
		/// <param name="Connect">optional object Connect</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Connection OpenConnection(string name, object options, object readOnly, object connect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, options, readOnly, connect);
			object returnItem = Invoker.MethodReturn(this, "OpenConnection", paramsArray);
			NetOffice.DAOApi.Connection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Connection;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public NetOffice.DAOApi.Connection OpenConnection(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "OpenConnection", paramsArray);
			NetOffice.DAOApi.Connection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Connection;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Option">Int32 Option</param>
		/// <param name="Value">object Value</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public void SetOption(Int32 option, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(option, value);
			Invoker.Method(this, "SetOption", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}