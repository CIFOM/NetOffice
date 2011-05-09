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
	/// Interface RecordsetEventsVt SupportByLibrary ADO2.1 ADO2.5 
	///</summary>
	[SupportByLibrary("ADO2.1","ADO2.5")]
	public class RecordsetEventsVt : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RecordsetEventsVt(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RecordsetEventsVt(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RecordsetEventsVt(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public RecordsetEventsVt()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="cFields">Int32 cFields</param>
		/// <param name="Fields">object Fields</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 WillChangeField(Int32 cFields, object fields, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Recordset pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cFields, fields, adStatus, pRecordset);
			object returnItem = Invoker.MethodReturn(this, "WillChangeField", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="cFields">Int32 cFields</param>
		/// <param name="Fields">object Fields</param>
		/// <param name="pError">NetOffice.ADODBApi.Error pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 FieldChangeComplete(Int32 cFields, object fields, NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Recordset pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cFields, fields, pError, adStatus, pRecordset);
			object returnItem = Invoker.MethodReturn(this, "FieldChangeComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="cRecords">Int32 cRecords</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 WillChangeRecord(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, Int32 cRecords, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Recordset pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, cRecords, adStatus, pRecordset);
			object returnItem = Invoker.MethodReturn(this, "WillChangeRecord", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="cRecords">Int32 cRecords</param>
		/// <param name="pError">NetOffice.ADODBApi.Error pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 RecordChangeComplete(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, Int32 cRecords, NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Recordset pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, cRecords, pError, adStatus, pRecordset);
			object returnItem = Invoker.MethodReturn(this, "RecordChangeComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 WillChangeRecordset(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Recordset pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, adStatus, pRecordset);
			object returnItem = Invoker.MethodReturn(this, "WillChangeRecordset", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="pError">NetOffice.ADODBApi.Error pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 RecordsetChangeComplete(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Recordset pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, pError, adStatus, pRecordset);
			object returnItem = Invoker.MethodReturn(this, "RecordsetChangeComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 WillMove(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Recordset pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, adStatus, pRecordset);
			object returnItem = Invoker.MethodReturn(this, "WillMove", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="adReason">NetOffice.ADODBApi.Enums.EventReasonEnum adReason</param>
		/// <param name="pError">NetOffice.ADODBApi.Error pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 MoveComplete(NetOffice.ADODBApi.Enums.EventReasonEnum adReason, NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Recordset pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(adReason, pError, adStatus, pRecordset);
			object returnItem = Invoker.MethodReturn(this, "MoveComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="fMoreData">ref bool fMoreData</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 EndOfRecordset(ref bool fMoreData, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Recordset pRecordset)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,false,false);
			object[] paramsArray = Invoker.ValidateParamsArray(fMoreData, adStatus, pRecordset);
			object returnItem = Invoker.MethodReturn(this, "EndOfRecordset", paramsArray);
			fMoreData = (bool)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Progress">Int32 Progress</param>
		/// <param name="MaxProgress">Int32 MaxProgress</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 FetchProgress(Int32 progress, Int32 maxProgress, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Recordset pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(progress, maxProgress, adStatus, pRecordset);
			object returnItem = Invoker.MethodReturn(this, "FetchProgress", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="pError">NetOffice.ADODBApi.Error pError</param>
		/// <param name="adStatus">NetOffice.ADODBApi.Enums.EventStatusEnum adStatus</param>
		/// <param name="pRecordset">NetOffice.ADODBApi._Recordset pRecordset</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public Int32 FetchComplete(NetOffice.ADODBApi.Error pError, NetOffice.ADODBApi.Enums.EventStatusEnum adStatus, NetOffice.ADODBApi._Recordset pRecordset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pError, adStatus, pRecordset);
			object returnItem = Invoker.MethodReturn(this, "FetchComplete", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}