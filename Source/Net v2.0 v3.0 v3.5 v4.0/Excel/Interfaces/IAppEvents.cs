//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IAppEvents SupportByLibraryAttribute Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IAppEvents : COMObject
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
                    _type = typeof(IAppEvents);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAppEvents(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAppEvents(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAppEvents(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAppEvents() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAppEvents(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 NewWorkbook(NetOffice.ExcelApi.Workbook wb)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb);
			object returnItem = Invoker.MethodReturn(this, "NewWorkbook", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 SheetSelectionChange(object sh, NetOffice.ExcelApi.Range target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target);
			object returnItem = Invoker.MethodReturn(this, "SheetSelectionChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 SheetBeforeDoubleClick(object sh, NetOffice.ExcelApi.Range target, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target, cancel);
			object returnItem = Invoker.MethodReturn(this, "SheetBeforeDoubleClick", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 SheetBeforeRightClick(object sh, NetOffice.ExcelApi.Range target, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target, cancel);
			object returnItem = Invoker.MethodReturn(this, "SheetBeforeRightClick", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 SheetActivate(object sh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh);
			object returnItem = Invoker.MethodReturn(this, "SheetActivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 SheetDeactivate(object sh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh);
			object returnItem = Invoker.MethodReturn(this, "SheetDeactivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 SheetCalculate(object sh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh);
			object returnItem = Invoker.MethodReturn(this, "SheetCalculate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.Range Target</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 SheetChange(object sh, NetOffice.ExcelApi.Range target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target);
			object returnItem = Invoker.MethodReturn(this, "SheetChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WorkbookOpen(NetOffice.ExcelApi.Workbook wb)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb);
			object returnItem = Invoker.MethodReturn(this, "WorkbookOpen", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WorkbookActivate(NetOffice.ExcelApi.Workbook wb)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb);
			object returnItem = Invoker.MethodReturn(this, "WorkbookActivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WorkbookDeactivate(NetOffice.ExcelApi.Workbook wb)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb);
			object returnItem = Invoker.MethodReturn(this, "WorkbookDeactivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WorkbookBeforeClose(NetOffice.ExcelApi.Workbook wb, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, cancel);
			object returnItem = Invoker.MethodReturn(this, "WorkbookBeforeClose", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="SaveAsUI">bool SaveAsUI</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WorkbookBeforeSave(NetOffice.ExcelApi.Workbook wb, bool saveAsUI, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, saveAsUI, cancel);
			object returnItem = Invoker.MethodReturn(this, "WorkbookBeforeSave", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WorkbookBeforePrint(NetOffice.ExcelApi.Workbook wb, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, cancel);
			object returnItem = Invoker.MethodReturn(this, "WorkbookBeforePrint", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Sh">object Sh</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WorkbookNewSheet(NetOffice.ExcelApi.Workbook wb, object sh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, sh);
			object returnItem = Invoker.MethodReturn(this, "WorkbookNewSheet", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WorkbookAddinInstall(NetOffice.ExcelApi.Workbook wb)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb);
			object returnItem = Invoker.MethodReturn(this, "WorkbookAddinInstall", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WorkbookAddinUninstall(NetOffice.ExcelApi.Workbook wb)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb);
			object returnItem = Invoker.MethodReturn(this, "WorkbookAddinUninstall", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Wn">NetOffice.ExcelApi.Window Wn</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WindowResize(NetOffice.ExcelApi.Workbook wb, NetOffice.ExcelApi.Window wn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, wn);
			object returnItem = Invoker.MethodReturn(this, "WindowResize", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Wn">NetOffice.ExcelApi.Window Wn</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WindowActivate(NetOffice.ExcelApi.Workbook wb, NetOffice.ExcelApi.Window wn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, wn);
			object returnItem = Invoker.MethodReturn(this, "WindowActivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Wn">NetOffice.ExcelApi.Window Wn</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 WindowDeactivate(NetOffice.ExcelApi.Workbook wb, NetOffice.ExcelApi.Window wn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, wn);
			object returnItem = Invoker.MethodReturn(this, "WindowDeactivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.Hyperlink Target</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public Int32 SheetFollowHyperlink(object sh, NetOffice.ExcelApi.Hyperlink target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target);
			object returnItem = Invoker.MethodReturn(this, "SheetFollowHyperlink", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="Target">NetOffice.ExcelApi.PivotTable Target</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public Int32 SheetPivotTableUpdate(object sh, NetOffice.ExcelApi.PivotTable target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, target);
			object returnItem = Invoker.MethodReturn(this, "SheetPivotTableUpdate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Target">NetOffice.ExcelApi.PivotTable Target</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public Int32 WorkbookPivotTableCloseConnection(NetOffice.ExcelApi.Workbook wb, NetOffice.ExcelApi.PivotTable target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, target);
			object returnItem = Invoker.MethodReturn(this, "WorkbookPivotTableCloseConnection", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 10, 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Target">NetOffice.ExcelApi.PivotTable Target</param>
		[SupportByLibraryAttribute("Excel", 10,11,12,14)]
		public Int32 WorkbookPivotTableOpenConnection(NetOffice.ExcelApi.Workbook wb, NetOffice.ExcelApi.PivotTable target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, target);
			object returnItem = Invoker.MethodReturn(this, "WorkbookPivotTableOpenConnection", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="SyncEventType">NetOffice.OfficeApi.Enums.MsoSyncEventType SyncEventType</param>
		[SupportByLibraryAttribute("Excel", 11,12,14)]
		public Int32 WorkbookSync(NetOffice.ExcelApi.Workbook wb, NetOffice.OfficeApi.Enums.MsoSyncEventType syncEventType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, syncEventType);
			object returnItem = Invoker.MethodReturn(this, "WorkbookSync", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="Url">string Url</param>
		/// <param name="IsRefresh">bool IsRefresh</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 11,12,14)]
		public Int32 WorkbookBeforeXmlImport(NetOffice.ExcelApi.Workbook wb, NetOffice.ExcelApi.XmlMap map, string url, bool isRefresh, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, map, url, isRefresh, cancel);
			object returnItem = Invoker.MethodReturn(this, "WorkbookBeforeXmlImport", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="IsRefresh">bool IsRefresh</param>
		/// <param name="Result">NetOffice.ExcelApi.Enums.XlXmlImportResult Result</param>
		[SupportByLibraryAttribute("Excel", 11,12,14)]
		public Int32 WorkbookAfterXmlImport(NetOffice.ExcelApi.Workbook wb, NetOffice.ExcelApi.XmlMap map, bool isRefresh, NetOffice.ExcelApi.Enums.XlXmlImportResult result)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, map, isRefresh, result);
			object returnItem = Invoker.MethodReturn(this, "WorkbookAfterXmlImport", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="Url">string Url</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 11,12,14)]
		public Int32 WorkbookBeforeXmlExport(NetOffice.ExcelApi.Workbook wb, NetOffice.ExcelApi.XmlMap map, string url, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, map, url, cancel);
			object returnItem = Invoker.MethodReturn(this, "WorkbookBeforeXmlExport", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 11, 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Map">NetOffice.ExcelApi.XmlMap Map</param>
		/// <param name="Url">string Url</param>
		/// <param name="Result">NetOffice.ExcelApi.Enums.XlXmlExportResult Result</param>
		[SupportByLibraryAttribute("Excel", 11,12,14)]
		public Int32 WorkbookAfterXmlExport(NetOffice.ExcelApi.Workbook wb, NetOffice.ExcelApi.XmlMap map, string url, NetOffice.ExcelApi.Enums.XlXmlExportResult result)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, map, url, result);
			object returnItem = Invoker.MethodReturn(this, "WorkbookAfterXmlExport", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Description">string Description</param>
		/// <param name="Sheet">string Sheet</param>
		/// <param name="Success">bool Success</param>
		[SupportByLibraryAttribute("Excel", 12,14)]
		public Int32 WorkbookRowsetComplete(NetOffice.ExcelApi.Workbook wb, string description, string sheet, bool success)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, description, sheet, success);
			object returnItem = Invoker.MethodReturn(this, "WorkbookRowsetComplete", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 12,14)]
		public Int32 AfterCalculate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AfterCalculate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="TargetRange">NetOffice.ExcelApi.Range TargetRange</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 SheetPivotTableAfterValueChange(object sh, NetOffice.ExcelApi.PivotTable targetPivotTable, NetOffice.ExcelApi.Range targetRange)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, targetPivotTable, targetRange);
			object returnItem = Invoker.MethodReturn(this, "SheetPivotTableAfterValueChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 SheetPivotTableBeforeAllocateChanges(object sh, NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, targetPivotTable, valueChangeStart, valueChangeEnd, cancel);
			object returnItem = Invoker.MethodReturn(this, "SheetPivotTableBeforeAllocateChanges", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 SheetPivotTableBeforeCommitChanges(object sh, NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, targetPivotTable, valueChangeStart, valueChangeEnd, cancel);
			object returnItem = Invoker.MethodReturn(this, "SheetPivotTableBeforeCommitChanges", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Sh">object Sh</param>
		/// <param name="TargetPivotTable">NetOffice.ExcelApi.PivotTable TargetPivotTable</param>
		/// <param name="ValueChangeStart">Int32 ValueChangeStart</param>
		/// <param name="ValueChangeEnd">Int32 ValueChangeEnd</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 SheetPivotTableBeforeDiscardChanges(object sh, NetOffice.ExcelApi.PivotTable targetPivotTable, Int32 valueChangeStart, Int32 valueChangeEnd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sh, targetPivotTable, valueChangeStart, valueChangeEnd);
			object returnItem = Invoker.MethodReturn(this, "SheetPivotTableBeforeDiscardChanges", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Pvw">NetOffice.ExcelApi.ProtectedViewWindow Pvw</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 ProtectedViewWindowOpen(NetOffice.ExcelApi.ProtectedViewWindow pvw)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvw);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowOpen", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Pvw">NetOffice.ExcelApi.ProtectedViewWindow Pvw</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 ProtectedViewWindowBeforeEdit(NetOffice.ExcelApi.ProtectedViewWindow pvw, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvw, cancel);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowBeforeEdit", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Pvw">NetOffice.ExcelApi.ProtectedViewWindow Pvw</param>
		/// <param name="Reason">NetOffice.ExcelApi.Enums.XlProtectedViewCloseReason Reason</param>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 ProtectedViewWindowBeforeClose(NetOffice.ExcelApi.ProtectedViewWindow pvw, NetOffice.ExcelApi.Enums.XlProtectedViewCloseReason reason, bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvw, reason, cancel);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowBeforeClose", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Pvw">NetOffice.ExcelApi.ProtectedViewWindow Pvw</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 ProtectedViewWindowResize(NetOffice.ExcelApi.ProtectedViewWindow pvw)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvw);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowResize", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Pvw">NetOffice.ExcelApi.ProtectedViewWindow Pvw</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 ProtectedViewWindowActivate(NetOffice.ExcelApi.ProtectedViewWindow pvw)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvw);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowActivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Pvw">NetOffice.ExcelApi.ProtectedViewWindow Pvw</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 ProtectedViewWindowDeactivate(NetOffice.ExcelApi.ProtectedViewWindow pvw)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvw);
			object returnItem = Invoker.MethodReturn(this, "ProtectedViewWindowDeactivate", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Success">bool Success</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 WorkbookAfterSave(NetOffice.ExcelApi.Workbook wb, bool success)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, success);
			object returnItem = Invoker.MethodReturn(this, "WorkbookAfterSave", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="Wb">NetOffice.ExcelApi.Workbook Wb</param>
		/// <param name="Ch">NetOffice.ExcelApi.Chart Ch</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 WorkbookNewChart(NetOffice.ExcelApi.Workbook wb, NetOffice.ExcelApi.Chart ch)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wb, ch);
			object returnItem = Invoker.MethodReturn(this, "WorkbookNewChart", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}