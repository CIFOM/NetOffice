//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi
{
	///<summary>
	/// Interface ConnectionEventsVt SupportByLibrary ADO2.1 ADO2.5 
	///</summary>
	[SupportByLibrary("ADO2.1","ADO2.5")]
	public class ConnectionEventsVt : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ConnectionEventsVt(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ConnectionEventsVt(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ConnectionEventsVt(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ConnectionEventsVt()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="pError">NetOffice.ADODBApi.Error pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pConnection">NetOffice.ADODBApi._Connection pConnection</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 InfoMessage(NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pError, adStatus, pConnection);
			object returnItem = Invoker.MethodReturn(this, "InfoMessage", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="TransactionLevel">Int32 TransactionLevel</param>
		/// <param name="pError">NetOffice.ADODBApi.Error pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pConnection">NetOffice.ADODBApi._Connection pConnection</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 BeginTransComplete(Int32 transactionLevel, NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(transactionLevel, pError, adStatus, pConnection);
			object returnItem = Invoker.MethodReturn(this, "BeginTransComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="pError">NetOffice.ADODBApi.Error pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pConnection">NetOffice.ADODBApi._Connection pConnection</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 CommitTransComplete(NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pError, adStatus, pConnection);
			object returnItem = Invoker.MethodReturn(this, "CommitTransComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="pError">NetOffice.ADODBApi.Error pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pConnection">NetOffice.ADODBApi._Connection pConnection</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 RollbackTransComplete(NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pError, adStatus, pConnection);
			object returnItem = Invoker.MethodReturn(this, "RollbackTransComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Source">ref string Source</param>
		/// <param name="CursorType">NetOffice.ADODBApi.Enums.CursorTypeEnum CursorType</param>
		/// <param name="LockType">NetOffice.ADODBApi.Enums.LockTypeEnum LockType</param>
		/// <param name="Options">ref Int32 Options</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pCommand">NetOffice.ADODBApi._Command pCommand</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		/// <param name="pConnection">NetOffice.ADODBApi._Connection pConnection</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 WillExecute(ref string source, NetOffice.ADODBApi.Enums.CursorTypeEnum cursorType, NetOffice.ADODBApi.Enums.LockTypeEnum lockType, ref Int32 options, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Command pCommand, NetOffice.ADODBApi._Recordset pRecordset, NetOffice.ADODBApi._Connection pConnection)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,false,false,true,false,false,false,false);
			object[] paramsArray = Invoker.ValidateParamsArray(source, cursorType, lockType, options, adStatus, pCommand, pRecordset, pConnection);
			object returnItem = Invoker.MethodReturn(this, "WillExecute", paramsArray);
			source = (string)paramsArray[0];
			options = (Int32)paramsArray[3];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="RecordsAffected">Int32 RecordsAffected</param>
		/// <param name="pError">NetOffice.ADODBApi.Error pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pCommand">NetOffice.ADODBApi._Command pCommand</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		/// <param name="pConnection">NetOffice.ADODBApi._Connection pConnection</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 ExecuteComplete(Int32 recordsAffected, NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Command pCommand, NetOffice.ADODBApi._Recordset pRecordset, NetOffice.ADODBApi._Connection pConnection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(recordsAffected, pError, adStatus, pCommand, pRecordset, pConnection);
			object returnItem = Invoker.MethodReturn(this, "ExecuteComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="ConnectionString">ref string ConnectionString</param>
		/// <param name="UserID">ref string UserID</param>
		/// <param name="Password">ref string Password</param>
		/// <param name="Options">ref Int32 Options</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pConnection">NetOffice.ADODBApi._Connection pConnection</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 WillConnect(ref string connectionString, ref string userID, ref string password, ref Int32 options, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,false,false);
			object[] paramsArray = Invoker.ValidateParamsArray(connectionString, userID, password, options, adStatus, pConnection);
			object returnItem = Invoker.MethodReturn(this, "WillConnect", paramsArray);
			connectionString = (string)paramsArray[0];
			userID = (string)paramsArray[1];
			password = (string)paramsArray[2];
			options = (Int32)paramsArray[3];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="pError">NetOffice.ADODBApi.Error pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pConnection">NetOffice.ADODBApi._Connection pConnection</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 ConnectComplete(NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pError, adStatus, pConnection);
			object returnItem = Invoker.MethodReturn(this, "ConnectComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pConnection">NetOffice.ADODBApi._Connection pConnection</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 Disconnect(NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Connection pConnection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adStatus, pConnection);
			object returnItem = Invoker.MethodReturn(this, "Disconnect", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}