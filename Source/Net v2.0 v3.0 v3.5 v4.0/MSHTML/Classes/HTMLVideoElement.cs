//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{

	#region Delegates

	#pragma warning disable
	public delegate void HTMLVideoElement_onhelpEventHandler();
	public delegate void HTMLVideoElement_onclickEventHandler();
	public delegate void HTMLVideoElement_ondblclickEventHandler();
	public delegate void HTMLVideoElement_onkeypressEventHandler();
	public delegate void HTMLVideoElement_onkeydownEventHandler();
	public delegate void HTMLVideoElement_onkeyupEventHandler();
	public delegate void HTMLVideoElement_onmouseoutEventHandler();
	public delegate void HTMLVideoElement_onmouseoverEventHandler();
	public delegate void HTMLVideoElement_onmousemoveEventHandler();
	public delegate void HTMLVideoElement_onmousedownEventHandler();
	public delegate void HTMLVideoElement_onmouseupEventHandler();
	public delegate void HTMLVideoElement_onselectstartEventHandler();
	public delegate void HTMLVideoElement_onfilterchangeEventHandler();
	public delegate void HTMLVideoElement_ondragstartEventHandler();
	public delegate void HTMLVideoElement_onbeforeupdateEventHandler();
	public delegate void HTMLVideoElement_onafterupdateEventHandler();
	public delegate void HTMLVideoElement_onerrorupdateEventHandler();
	public delegate void HTMLVideoElement_onrowexitEventHandler();
	public delegate void HTMLVideoElement_onrowenterEventHandler();
	public delegate void HTMLVideoElement_ondatasetchangedEventHandler();
	public delegate void HTMLVideoElement_ondataavailableEventHandler();
	public delegate void HTMLVideoElement_ondatasetcompleteEventHandler();
	public delegate void HTMLVideoElement_onlosecaptureEventHandler();
	public delegate void HTMLVideoElement_onpropertychangeEventHandler();
	public delegate void HTMLVideoElement_onscrollEventHandler();
	public delegate void HTMLVideoElement_onfocusEventHandler();
	public delegate void HTMLVideoElement_onblurEventHandler();
	public delegate void HTMLVideoElement_onresizeEventHandler();
	public delegate void HTMLVideoElement_ondragEventHandler();
	public delegate void HTMLVideoElement_ondragendEventHandler();
	public delegate void HTMLVideoElement_ondragenterEventHandler();
	public delegate void HTMLVideoElement_ondragoverEventHandler();
	public delegate void HTMLVideoElement_ondragleaveEventHandler();
	public delegate void HTMLVideoElement_ondropEventHandler();
	public delegate void HTMLVideoElement_onbeforecutEventHandler();
	public delegate void HTMLVideoElement_oncutEventHandler();
	public delegate void HTMLVideoElement_onbeforecopyEventHandler();
	public delegate void HTMLVideoElement_oncopyEventHandler();
	public delegate void HTMLVideoElement_onbeforepasteEventHandler();
	public delegate void HTMLVideoElement_onpasteEventHandler();
	public delegate void HTMLVideoElement_oncontextmenuEventHandler();
	public delegate void HTMLVideoElement_onrowsdeleteEventHandler();
	public delegate void HTMLVideoElement_onrowsinsertedEventHandler();
	public delegate void HTMLVideoElement_oncellchangeEventHandler();
	public delegate void HTMLVideoElement_onreadystatechangeEventHandler();
	public delegate void HTMLVideoElement_onbeforeeditfocusEventHandler();
	public delegate void HTMLVideoElement_onlayoutcompleteEventHandler();
	public delegate void HTMLVideoElement_onpageEventHandler();
	public delegate void HTMLVideoElement_onbeforedeactivateEventHandler();
	public delegate void HTMLVideoElement_onbeforeactivateEventHandler();
	public delegate void HTMLVideoElement_onmoveEventHandler();
	public delegate void HTMLVideoElement_oncontrolselectEventHandler();
	public delegate void HTMLVideoElement_onmovestartEventHandler();
	public delegate void HTMLVideoElement_onmoveendEventHandler();
	public delegate void HTMLVideoElement_onresizestartEventHandler();
	public delegate void HTMLVideoElement_onresizeendEventHandler();
	public delegate void HTMLVideoElement_onmouseenterEventHandler();
	public delegate void HTMLVideoElement_onmouseleaveEventHandler();
	public delegate void HTMLVideoElement_onmousewheelEventHandler();
	public delegate void HTMLVideoElement_onactivateEventHandler();
	public delegate void HTMLVideoElement_ondeactivateEventHandler();
	public delegate void HTMLVideoElement_onfocusinEventHandler();
	public delegate void HTMLVideoElement_onfocusoutEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass HTMLVideoElement SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class HTMLVideoElement : DispHTMLVideoElement, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		HTMLElementEvents_SinkHelper _hTMLElementEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(HTMLVideoElement);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public HTMLVideoElement(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLVideoElement(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLVideoElement(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of HTMLVideoElement 
        /// </summary>		
		public HTMLVideoElement():base("MSHTML.HTMLVideoElement")
		{
		}
		
		/// <summary>
        /// creates a new instance of HTMLVideoElement
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public HTMLVideoElement(string progId):base(progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, HTMLElementEvents_SinkHelper.Id);


			if(HTMLElementEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_hTMLElementEvents_SinkHelper = new HTMLElementEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onhelpEventHandler _onhelpEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onhelpEventHandler onhelpEvent
		{
			add
			{
				CreateEventBridge();
				_onhelpEvent += value;
			}
			remove
			{
				_onhelpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onclickEventHandler _onclickEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onclickEventHandler onclickEvent
		{
			add
			{
				CreateEventBridge();
				_onclickEvent += value;
			}
			remove
			{
				_onclickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondblclickEventHandler _ondblclickEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondblclickEventHandler ondblclickEvent
		{
			add
			{
				CreateEventBridge();
				_ondblclickEvent += value;
			}
			remove
			{
				_ondblclickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onkeypressEventHandler _onkeypressEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onkeypressEventHandler onkeypressEvent
		{
			add
			{
				CreateEventBridge();
				_onkeypressEvent += value;
			}
			remove
			{
				_onkeypressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onkeydownEventHandler _onkeydownEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onkeydownEventHandler onkeydownEvent
		{
			add
			{
				CreateEventBridge();
				_onkeydownEvent += value;
			}
			remove
			{
				_onkeydownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onkeyupEventHandler _onkeyupEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onkeyupEventHandler onkeyupEvent
		{
			add
			{
				CreateEventBridge();
				_onkeyupEvent += value;
			}
			remove
			{
				_onkeyupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onmouseoutEventHandler _onmouseoutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onmouseoutEventHandler onmouseoutEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseoutEvent += value;
			}
			remove
			{
				_onmouseoutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onmouseoverEventHandler _onmouseoverEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onmouseoverEventHandler onmouseoverEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseoverEvent += value;
			}
			remove
			{
				_onmouseoverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onmousemoveEventHandler _onmousemoveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onmousemoveEventHandler onmousemoveEvent
		{
			add
			{
				CreateEventBridge();
				_onmousemoveEvent += value;
			}
			remove
			{
				_onmousemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onmousedownEventHandler _onmousedownEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onmousedownEventHandler onmousedownEvent
		{
			add
			{
				CreateEventBridge();
				_onmousedownEvent += value;
			}
			remove
			{
				_onmousedownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onmouseupEventHandler _onmouseupEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onmouseupEventHandler onmouseupEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseupEvent += value;
			}
			remove
			{
				_onmouseupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onselectstartEventHandler _onselectstartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onselectstartEventHandler onselectstartEvent
		{
			add
			{
				CreateEventBridge();
				_onselectstartEvent += value;
			}
			remove
			{
				_onselectstartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onfilterchangeEventHandler _onfilterchangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onfilterchangeEventHandler onfilterchangeEvent
		{
			add
			{
				CreateEventBridge();
				_onfilterchangeEvent += value;
			}
			remove
			{
				_onfilterchangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondragstartEventHandler _ondragstartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondragstartEventHandler ondragstartEvent
		{
			add
			{
				CreateEventBridge();
				_ondragstartEvent += value;
			}
			remove
			{
				_ondragstartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onbeforeupdateEventHandler _onbeforeupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onbeforeupdateEventHandler onbeforeupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeupdateEvent += value;
			}
			remove
			{
				_onbeforeupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onafterupdateEventHandler _onafterupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onafterupdateEventHandler onafterupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onafterupdateEvent += value;
			}
			remove
			{
				_onafterupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onerrorupdateEventHandler _onerrorupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onerrorupdateEventHandler onerrorupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onerrorupdateEvent += value;
			}
			remove
			{
				_onerrorupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onrowexitEventHandler _onrowexitEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onrowexitEventHandler onrowexitEvent
		{
			add
			{
				CreateEventBridge();
				_onrowexitEvent += value;
			}
			remove
			{
				_onrowexitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onrowenterEventHandler _onrowenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onrowenterEventHandler onrowenterEvent
		{
			add
			{
				CreateEventBridge();
				_onrowenterEvent += value;
			}
			remove
			{
				_onrowenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondatasetchangedEventHandler _ondatasetchangedEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondatasetchangedEventHandler ondatasetchangedEvent
		{
			add
			{
				CreateEventBridge();
				_ondatasetchangedEvent += value;
			}
			remove
			{
				_ondatasetchangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondataavailableEventHandler _ondataavailableEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondataavailableEventHandler ondataavailableEvent
		{
			add
			{
				CreateEventBridge();
				_ondataavailableEvent += value;
			}
			remove
			{
				_ondataavailableEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondatasetcompleteEventHandler _ondatasetcompleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondatasetcompleteEventHandler ondatasetcompleteEvent
		{
			add
			{
				CreateEventBridge();
				_ondatasetcompleteEvent += value;
			}
			remove
			{
				_ondatasetcompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onlosecaptureEventHandler _onlosecaptureEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onlosecaptureEventHandler onlosecaptureEvent
		{
			add
			{
				CreateEventBridge();
				_onlosecaptureEvent += value;
			}
			remove
			{
				_onlosecaptureEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onpropertychangeEventHandler _onpropertychangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onpropertychangeEventHandler onpropertychangeEvent
		{
			add
			{
				CreateEventBridge();
				_onpropertychangeEvent += value;
			}
			remove
			{
				_onpropertychangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onscrollEventHandler _onscrollEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onscrollEventHandler onscrollEvent
		{
			add
			{
				CreateEventBridge();
				_onscrollEvent += value;
			}
			remove
			{
				_onscrollEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onfocusEventHandler _onfocusEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onfocusEventHandler onfocusEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusEvent += value;
			}
			remove
			{
				_onfocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onblurEventHandler _onblurEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onblurEventHandler onblurEvent
		{
			add
			{
				CreateEventBridge();
				_onblurEvent += value;
			}
			remove
			{
				_onblurEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onresizeEventHandler _onresizeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onresizeEventHandler onresizeEvent
		{
			add
			{
				CreateEventBridge();
				_onresizeEvent += value;
			}
			remove
			{
				_onresizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondragEventHandler _ondragEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondragEventHandler ondragEvent
		{
			add
			{
				CreateEventBridge();
				_ondragEvent += value;
			}
			remove
			{
				_ondragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondragendEventHandler _ondragendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondragendEventHandler ondragendEvent
		{
			add
			{
				CreateEventBridge();
				_ondragendEvent += value;
			}
			remove
			{
				_ondragendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondragenterEventHandler _ondragenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondragenterEventHandler ondragenterEvent
		{
			add
			{
				CreateEventBridge();
				_ondragenterEvent += value;
			}
			remove
			{
				_ondragenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondragoverEventHandler _ondragoverEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondragoverEventHandler ondragoverEvent
		{
			add
			{
				CreateEventBridge();
				_ondragoverEvent += value;
			}
			remove
			{
				_ondragoverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondragleaveEventHandler _ondragleaveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondragleaveEventHandler ondragleaveEvent
		{
			add
			{
				CreateEventBridge();
				_ondragleaveEvent += value;
			}
			remove
			{
				_ondragleaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondropEventHandler _ondropEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondropEventHandler ondropEvent
		{
			add
			{
				CreateEventBridge();
				_ondropEvent += value;
			}
			remove
			{
				_ondropEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onbeforecutEventHandler _onbeforecutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onbeforecutEventHandler onbeforecutEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforecutEvent += value;
			}
			remove
			{
				_onbeforecutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_oncutEventHandler _oncutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_oncutEventHandler oncutEvent
		{
			add
			{
				CreateEventBridge();
				_oncutEvent += value;
			}
			remove
			{
				_oncutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onbeforecopyEventHandler _onbeforecopyEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onbeforecopyEventHandler onbeforecopyEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforecopyEvent += value;
			}
			remove
			{
				_onbeforecopyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_oncopyEventHandler _oncopyEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_oncopyEventHandler oncopyEvent
		{
			add
			{
				CreateEventBridge();
				_oncopyEvent += value;
			}
			remove
			{
				_oncopyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onbeforepasteEventHandler _onbeforepasteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onbeforepasteEventHandler onbeforepasteEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforepasteEvent += value;
			}
			remove
			{
				_onbeforepasteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onpasteEventHandler _onpasteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onpasteEventHandler onpasteEvent
		{
			add
			{
				CreateEventBridge();
				_onpasteEvent += value;
			}
			remove
			{
				_onpasteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_oncontextmenuEventHandler _oncontextmenuEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_oncontextmenuEventHandler oncontextmenuEvent
		{
			add
			{
				CreateEventBridge();
				_oncontextmenuEvent += value;
			}
			remove
			{
				_oncontextmenuEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onrowsdeleteEventHandler _onrowsdeleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onrowsdeleteEventHandler onrowsdeleteEvent
		{
			add
			{
				CreateEventBridge();
				_onrowsdeleteEvent += value;
			}
			remove
			{
				_onrowsdeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onrowsinsertedEventHandler _onrowsinsertedEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onrowsinsertedEventHandler onrowsinsertedEvent
		{
			add
			{
				CreateEventBridge();
				_onrowsinsertedEvent += value;
			}
			remove
			{
				_onrowsinsertedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_oncellchangeEventHandler _oncellchangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_oncellchangeEventHandler oncellchangeEvent
		{
			add
			{
				CreateEventBridge();
				_oncellchangeEvent += value;
			}
			remove
			{
				_oncellchangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onreadystatechangeEventHandler _onreadystatechangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onreadystatechangeEventHandler onreadystatechangeEvent
		{
			add
			{
				CreateEventBridge();
				_onreadystatechangeEvent += value;
			}
			remove
			{
				_onreadystatechangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onbeforeeditfocusEventHandler _onbeforeeditfocusEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onbeforeeditfocusEventHandler onbeforeeditfocusEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeeditfocusEvent += value;
			}
			remove
			{
				_onbeforeeditfocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onlayoutcompleteEventHandler _onlayoutcompleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onlayoutcompleteEventHandler onlayoutcompleteEvent
		{
			add
			{
				CreateEventBridge();
				_onlayoutcompleteEvent += value;
			}
			remove
			{
				_onlayoutcompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onpageEventHandler _onpageEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onpageEventHandler onpageEvent
		{
			add
			{
				CreateEventBridge();
				_onpageEvent += value;
			}
			remove
			{
				_onpageEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onbeforedeactivateEventHandler _onbeforedeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onbeforedeactivateEventHandler onbeforedeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforedeactivateEvent += value;
			}
			remove
			{
				_onbeforedeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onbeforeactivateEventHandler _onbeforeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onbeforeactivateEventHandler onbeforeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeactivateEvent += value;
			}
			remove
			{
				_onbeforeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onmoveEventHandler _onmoveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onmoveEventHandler onmoveEvent
		{
			add
			{
				CreateEventBridge();
				_onmoveEvent += value;
			}
			remove
			{
				_onmoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_oncontrolselectEventHandler _oncontrolselectEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_oncontrolselectEventHandler oncontrolselectEvent
		{
			add
			{
				CreateEventBridge();
				_oncontrolselectEvent += value;
			}
			remove
			{
				_oncontrolselectEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onmovestartEventHandler _onmovestartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onmovestartEventHandler onmovestartEvent
		{
			add
			{
				CreateEventBridge();
				_onmovestartEvent += value;
			}
			remove
			{
				_onmovestartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onmoveendEventHandler _onmoveendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onmoveendEventHandler onmoveendEvent
		{
			add
			{
				CreateEventBridge();
				_onmoveendEvent += value;
			}
			remove
			{
				_onmoveendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onresizestartEventHandler _onresizestartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onresizestartEventHandler onresizestartEvent
		{
			add
			{
				CreateEventBridge();
				_onresizestartEvent += value;
			}
			remove
			{
				_onresizestartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onresizeendEventHandler _onresizeendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onresizeendEventHandler onresizeendEvent
		{
			add
			{
				CreateEventBridge();
				_onresizeendEvent += value;
			}
			remove
			{
				_onresizeendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onmouseenterEventHandler _onmouseenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onmouseenterEventHandler onmouseenterEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseenterEvent += value;
			}
			remove
			{
				_onmouseenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onmouseleaveEventHandler _onmouseleaveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onmouseleaveEventHandler onmouseleaveEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseleaveEvent += value;
			}
			remove
			{
				_onmouseleaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onmousewheelEventHandler _onmousewheelEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onmousewheelEventHandler onmousewheelEvent
		{
			add
			{
				CreateEventBridge();
				_onmousewheelEvent += value;
			}
			remove
			{
				_onmousewheelEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onactivateEventHandler _onactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onactivateEventHandler onactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onactivateEvent += value;
			}
			remove
			{
				_onactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_ondeactivateEventHandler _ondeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_ondeactivateEventHandler ondeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_ondeactivateEvent += value;
			}
			remove
			{
				_ondeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onfocusinEventHandler _onfocusinEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onfocusinEventHandler onfocusinEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusinEvent += value;
			}
			remove
			{
				_onfocusinEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLVideoElement_onfocusoutEventHandler _onfocusoutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLVideoElement_onfocusoutEventHandler onfocusoutEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusoutEvent += value;
			}
			remove
			{
				_onfocusoutEvent -= value;
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
			if( null != _hTMLElementEvents_SinkHelper)
			{
				_hTMLElementEvents_SinkHelper.Dispose();
				_hTMLElementEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}