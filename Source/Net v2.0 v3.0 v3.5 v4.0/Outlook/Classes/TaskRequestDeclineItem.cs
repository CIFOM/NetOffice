//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void TaskRequestDeclineItem_OpenEventHandler(ref bool Cancel);
	public delegate void TaskRequestDeclineItem_CustomActionEventHandler(COMObject Action, COMObject Response, ref bool Cancel);
	public delegate void TaskRequestDeclineItem_CustomPropertyChangeEventHandler(string Name);
	public delegate void TaskRequestDeclineItem_ForwardEventHandler(COMObject Forward, ref bool Cancel);
	public delegate void TaskRequestDeclineItem_CloseEventHandler(ref bool Cancel);
	public delegate void TaskRequestDeclineItem_PropertyChangeEventHandler(string Name);
	public delegate void TaskRequestDeclineItem_ReadEventHandler();
	public delegate void TaskRequestDeclineItem_ReplyEventHandler(COMObject Response, ref bool Cancel);
	public delegate void TaskRequestDeclineItem_ReplyAllEventHandler(COMObject Response, ref bool Cancel);
	public delegate void TaskRequestDeclineItem_SendEventHandler(ref bool Cancel);
	public delegate void TaskRequestDeclineItem_WriteEventHandler(ref bool Cancel);
	public delegate void TaskRequestDeclineItem_BeforeCheckNamesEventHandler(ref bool Cancel);
	public delegate void TaskRequestDeclineItem_AttachmentAddEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void TaskRequestDeclineItem_AttachmentReadEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void TaskRequestDeclineItem_BeforeAttachmentSaveEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void TaskRequestDeclineItem_BeforeDeleteEventHandler(COMObject Item, ref bool Cancel);
	public delegate void TaskRequestDeclineItem_AttachmentRemoveEventHandler(NetOffice.OutlookApi.Attachment Attachment);
	public delegate void TaskRequestDeclineItem_BeforeAttachmentAddEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void TaskRequestDeclineItem_BeforeAttachmentPreviewEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void TaskRequestDeclineItem_BeforeAttachmentReadEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void TaskRequestDeclineItem_BeforeAttachmentWriteToTempFileEventHandler(NetOffice.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void TaskRequestDeclineItem_UnloadEventHandler();
	public delegate void TaskRequestDeclineItem_BeforeAutoSaveEventHandler(ref bool Cancel);
	public delegate void TaskRequestDeclineItem_BeforeReadEventHandler();
	public delegate void TaskRequestDeclineItem_AfterWriteEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass TaskRequestDeclineItem SupportByLibraryAttribute Outlook, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class TaskRequestDeclineItem : _TaskRequestDeclineItem, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ItemEvents_SinkHelper _itemEvents_SinkHelper;
		ItemEvents_10_SinkHelper _itemEvents_10_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(TaskRequestDeclineItem);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public TaskRequestDeclineItem(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TaskRequestDeclineItem(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TaskRequestDeclineItem(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of TaskRequestDeclineItem 
        /// </summary>		
		public TaskRequestDeclineItem():base("Outlook.TaskRequestDeclineItem")
		{
		}
		
		/// <summary>
        /// creates a new instance of TaskRequestDeclineItem
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public TaskRequestDeclineItem(string progId):base(progId)
		{
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ItemEvents_SinkHelper.Id,ItemEvents_10_SinkHelper.Id);


			if(ItemEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_itemEvents_SinkHelper = new ItemEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(ItemEvents_10_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_itemEvents_10_SinkHelper = new ItemEvents_10_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_OpenEventHandler _OpenEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_OpenEventHandler OpenEvent
		{
			add
			{
				CreateEventBridge();
				_OpenEvent += value;
			}
			remove
			{
				_OpenEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_CustomActionEventHandler _CustomActionEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_CustomActionEventHandler CustomActionEvent
		{
			add
			{
				CreateEventBridge();
				_CustomActionEvent += value;
			}
			remove
			{
				_CustomActionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_CustomPropertyChangeEventHandler _CustomPropertyChangeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_CustomPropertyChangeEventHandler CustomPropertyChangeEvent
		{
			add
			{
				CreateEventBridge();
				_CustomPropertyChangeEvent += value;
			}
			remove
			{
				_CustomPropertyChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_ForwardEventHandler _ForwardEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_ForwardEventHandler ForwardEvent
		{
			add
			{
				CreateEventBridge();
				_ForwardEvent += value;
			}
			remove
			{
				_ForwardEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_CloseEventHandler _CloseEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_CloseEventHandler CloseEvent
		{
			add
			{
				CreateEventBridge();
				_CloseEvent += value;
			}
			remove
			{
				_CloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_PropertyChangeEventHandler _PropertyChangeEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_PropertyChangeEventHandler PropertyChangeEvent
		{
			add
			{
				CreateEventBridge();
				_PropertyChangeEvent += value;
			}
			remove
			{
				_PropertyChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_ReadEventHandler _ReadEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_ReadEventHandler ReadEvent
		{
			add
			{
				CreateEventBridge();
				_ReadEvent += value;
			}
			remove
			{
				_ReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_ReplyEventHandler _ReplyEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_ReplyEventHandler ReplyEvent
		{
			add
			{
				CreateEventBridge();
				_ReplyEvent += value;
			}
			remove
			{
				_ReplyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_ReplyAllEventHandler _ReplyAllEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_ReplyAllEventHandler ReplyAllEvent
		{
			add
			{
				CreateEventBridge();
				_ReplyAllEvent += value;
			}
			remove
			{
				_ReplyAllEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_SendEventHandler _SendEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_SendEventHandler SendEvent
		{
			add
			{
				CreateEventBridge();
				_SendEvent += value;
			}
			remove
			{
				_SendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_WriteEventHandler _WriteEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_WriteEventHandler WriteEvent
		{
			add
			{
				CreateEventBridge();
				_WriteEvent += value;
			}
			remove
			{
				_WriteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_BeforeCheckNamesEventHandler _BeforeCheckNamesEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_BeforeCheckNamesEventHandler BeforeCheckNamesEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeCheckNamesEvent += value;
			}
			remove
			{
				_BeforeCheckNamesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_AttachmentAddEventHandler _AttachmentAddEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_AttachmentAddEventHandler AttachmentAddEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentAddEvent += value;
			}
			remove
			{
				_AttachmentAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_AttachmentReadEventHandler _AttachmentReadEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_AttachmentReadEventHandler AttachmentReadEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentReadEvent += value;
			}
			remove
			{
				_AttachmentReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_BeforeAttachmentSaveEventHandler _BeforeAttachmentSaveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event TaskRequestDeclineItem_BeforeAttachmentSaveEventHandler BeforeAttachmentSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentSaveEvent += value;
			}
			remove
			{
				_BeforeAttachmentSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 10,11,12,14
		/// </summary>
		private event TaskRequestDeclineItem_BeforeDeleteEventHandler _BeforeDeleteEvent;

		/// <summary>
		/// SupportByLibrary Outlook 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public event TaskRequestDeclineItem_BeforeDeleteEventHandler BeforeDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDeleteEvent += value;
			}
			remove
			{
				_BeforeDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event TaskRequestDeclineItem_AttachmentRemoveEventHandler _AttachmentRemoveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event TaskRequestDeclineItem_AttachmentRemoveEventHandler AttachmentRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentRemoveEvent += value;
			}
			remove
			{
				_AttachmentRemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event TaskRequestDeclineItem_BeforeAttachmentAddEventHandler _BeforeAttachmentAddEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event TaskRequestDeclineItem_BeforeAttachmentAddEventHandler BeforeAttachmentAddEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentAddEvent += value;
			}
			remove
			{
				_BeforeAttachmentAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event TaskRequestDeclineItem_BeforeAttachmentPreviewEventHandler _BeforeAttachmentPreviewEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event TaskRequestDeclineItem_BeforeAttachmentPreviewEventHandler BeforeAttachmentPreviewEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentPreviewEvent += value;
			}
			remove
			{
				_BeforeAttachmentPreviewEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event TaskRequestDeclineItem_BeforeAttachmentReadEventHandler _BeforeAttachmentReadEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event TaskRequestDeclineItem_BeforeAttachmentReadEventHandler BeforeAttachmentReadEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentReadEvent += value;
			}
			remove
			{
				_BeforeAttachmentReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event TaskRequestDeclineItem_BeforeAttachmentWriteToTempFileEventHandler _BeforeAttachmentWriteToTempFileEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event TaskRequestDeclineItem_BeforeAttachmentWriteToTempFileEventHandler BeforeAttachmentWriteToTempFileEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentWriteToTempFileEvent += value;
			}
			remove
			{
				_BeforeAttachmentWriteToTempFileEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event TaskRequestDeclineItem_UnloadEventHandler _UnloadEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event TaskRequestDeclineItem_UnloadEventHandler UnloadEvent
		{
			add
			{
				CreateEventBridge();
				_UnloadEvent += value;
			}
			remove
			{
				_UnloadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 12,14
		/// </summary>
		private event TaskRequestDeclineItem_BeforeAutoSaveEventHandler _BeforeAutoSaveEvent;

		/// <summary>
		/// SupportByLibrary Outlook 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public event TaskRequestDeclineItem_BeforeAutoSaveEventHandler BeforeAutoSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAutoSaveEvent += value;
			}
			remove
			{
				_BeforeAutoSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 14
		/// </summary>
		private event TaskRequestDeclineItem_BeforeReadEventHandler _BeforeReadEvent;

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public event TaskRequestDeclineItem_BeforeReadEventHandler BeforeReadEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeReadEvent += value;
			}
			remove
			{
				_BeforeReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 14
		/// </summary>
		private event TaskRequestDeclineItem_AfterWriteEventHandler _AfterWriteEvent;

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public event TaskRequestDeclineItem_AfterWriteEventHandler AfterWriteEvent
		{
			add
			{
				CreateEventBridge();
				_AfterWriteEvent += value;
			}
			remove
			{
				_AfterWriteEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _itemEvents_SinkHelper)
			{
				_itemEvents_SinkHelper.Dispose();
				_itemEvents_SinkHelper = null;
			}
			if( null != _itemEvents_10_SinkHelper)
			{
				_itemEvents_10_SinkHelper.Dispose();
				_itemEvents_10_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}