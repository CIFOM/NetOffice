//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{

	#region Delegates

	#pragma warning disable
	public delegate void HTMLTableSection_onhelpEventHandler();
	public delegate void HTMLTableSection_onclickEventHandler();
	public delegate void HTMLTableSection_ondblclickEventHandler();
	public delegate void HTMLTableSection_onkeypressEventHandler();
	public delegate void HTMLTableSection_onkeydownEventHandler();
	public delegate void HTMLTableSection_onkeyupEventHandler();
	public delegate void HTMLTableSection_onmouseoutEventHandler();
	public delegate void HTMLTableSection_onmouseoverEventHandler();
	public delegate void HTMLTableSection_onmousemoveEventHandler();
	public delegate void HTMLTableSection_onmousedownEventHandler();
	public delegate void HTMLTableSection_onmouseupEventHandler();
	public delegate void HTMLTableSection_onselectstartEventHandler();
	public delegate void HTMLTableSection_onfilterchangeEventHandler();
	public delegate void HTMLTableSection_ondragstartEventHandler();
	public delegate void HTMLTableSection_onbeforeupdateEventHandler();
	public delegate void HTMLTableSection_onafterupdateEventHandler();
	public delegate void HTMLTableSection_onerrorupdateEventHandler();
	public delegate void HTMLTableSection_onrowexitEventHandler();
	public delegate void HTMLTableSection_onrowenterEventHandler();
	public delegate void HTMLTableSection_ondatasetchangedEventHandler();
	public delegate void HTMLTableSection_ondataavailableEventHandler();
	public delegate void HTMLTableSection_ondatasetcompleteEventHandler();
	public delegate void HTMLTableSection_onlosecaptureEventHandler();
	public delegate void HTMLTableSection_onpropertychangeEventHandler();
	public delegate void HTMLTableSection_onscrollEventHandler();
	public delegate void HTMLTableSection_onfocusEventHandler();
	public delegate void HTMLTableSection_onblurEventHandler();
	public delegate void HTMLTableSection_onresizeEventHandler();
	public delegate void HTMLTableSection_ondragEventHandler();
	public delegate void HTMLTableSection_ondragendEventHandler();
	public delegate void HTMLTableSection_ondragenterEventHandler();
	public delegate void HTMLTableSection_ondragoverEventHandler();
	public delegate void HTMLTableSection_ondragleaveEventHandler();
	public delegate void HTMLTableSection_ondropEventHandler();
	public delegate void HTMLTableSection_onbeforecutEventHandler();
	public delegate void HTMLTableSection_oncutEventHandler();
	public delegate void HTMLTableSection_onbeforecopyEventHandler();
	public delegate void HTMLTableSection_oncopyEventHandler();
	public delegate void HTMLTableSection_onbeforepasteEventHandler();
	public delegate void HTMLTableSection_onpasteEventHandler();
	public delegate void HTMLTableSection_oncontextmenuEventHandler();
	public delegate void HTMLTableSection_onrowsdeleteEventHandler();
	public delegate void HTMLTableSection_onrowsinsertedEventHandler();
	public delegate void HTMLTableSection_oncellchangeEventHandler();
	public delegate void HTMLTableSection_onreadystatechangeEventHandler();
	public delegate void HTMLTableSection_onbeforeeditfocusEventHandler();
	public delegate void HTMLTableSection_onlayoutcompleteEventHandler();
	public delegate void HTMLTableSection_onpageEventHandler();
	public delegate void HTMLTableSection_onbeforedeactivateEventHandler();
	public delegate void HTMLTableSection_onbeforeactivateEventHandler();
	public delegate void HTMLTableSection_onmoveEventHandler();
	public delegate void HTMLTableSection_oncontrolselectEventHandler();
	public delegate void HTMLTableSection_onmovestartEventHandler();
	public delegate void HTMLTableSection_onmoveendEventHandler();
	public delegate void HTMLTableSection_onresizestartEventHandler();
	public delegate void HTMLTableSection_onresizeendEventHandler();
	public delegate void HTMLTableSection_onmouseenterEventHandler();
	public delegate void HTMLTableSection_onmouseleaveEventHandler();
	public delegate void HTMLTableSection_onmousewheelEventHandler();
	public delegate void HTMLTableSection_onactivateEventHandler();
	public delegate void HTMLTableSection_ondeactivateEventHandler();
	public delegate void HTMLTableSection_onfocusinEventHandler();
	public delegate void HTMLTableSection_onfocusoutEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass HTMLTableSection SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibrary("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class HTMLTableSection : DispHTMLTableSection, IEventBinding 
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
                    _type = typeof(HTMLTableSection);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public HTMLTableSection(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLTableSection(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLTableSection(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of HTMLTableSection 
        /// </summary>		
		public HTMLTableSection():base("MSHTML.HTMLTableSection")
		{
		}
		
		/// <summary>
        /// creates a new instance of HTMLTableSection
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public HTMLTableSection(string progId):base(progId)
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
		private event HTMLTableSection_onhelpEventHandler _onhelpEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onhelpEventHandler onhelpEvent
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
		private event HTMLTableSection_onclickEventHandler _onclickEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onclickEventHandler onclickEvent
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
		private event HTMLTableSection_ondblclickEventHandler _ondblclickEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondblclickEventHandler ondblclickEvent
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
		private event HTMLTableSection_onkeypressEventHandler _onkeypressEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onkeypressEventHandler onkeypressEvent
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
		private event HTMLTableSection_onkeydownEventHandler _onkeydownEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onkeydownEventHandler onkeydownEvent
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
		private event HTMLTableSection_onkeyupEventHandler _onkeyupEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onkeyupEventHandler onkeyupEvent
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
		private event HTMLTableSection_onmouseoutEventHandler _onmouseoutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onmouseoutEventHandler onmouseoutEvent
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
		private event HTMLTableSection_onmouseoverEventHandler _onmouseoverEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onmouseoverEventHandler onmouseoverEvent
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
		private event HTMLTableSection_onmousemoveEventHandler _onmousemoveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onmousemoveEventHandler onmousemoveEvent
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
		private event HTMLTableSection_onmousedownEventHandler _onmousedownEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onmousedownEventHandler onmousedownEvent
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
		private event HTMLTableSection_onmouseupEventHandler _onmouseupEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onmouseupEventHandler onmouseupEvent
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
		private event HTMLTableSection_onselectstartEventHandler _onselectstartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onselectstartEventHandler onselectstartEvent
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
		private event HTMLTableSection_onfilterchangeEventHandler _onfilterchangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onfilterchangeEventHandler onfilterchangeEvent
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
		private event HTMLTableSection_ondragstartEventHandler _ondragstartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondragstartEventHandler ondragstartEvent
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
		private event HTMLTableSection_onbeforeupdateEventHandler _onbeforeupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onbeforeupdateEventHandler onbeforeupdateEvent
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
		private event HTMLTableSection_onafterupdateEventHandler _onafterupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onafterupdateEventHandler onafterupdateEvent
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
		private event HTMLTableSection_onerrorupdateEventHandler _onerrorupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onerrorupdateEventHandler onerrorupdateEvent
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
		private event HTMLTableSection_onrowexitEventHandler _onrowexitEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onrowexitEventHandler onrowexitEvent
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
		private event HTMLTableSection_onrowenterEventHandler _onrowenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onrowenterEventHandler onrowenterEvent
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
		private event HTMLTableSection_ondatasetchangedEventHandler _ondatasetchangedEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondatasetchangedEventHandler ondatasetchangedEvent
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
		private event HTMLTableSection_ondataavailableEventHandler _ondataavailableEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondataavailableEventHandler ondataavailableEvent
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
		private event HTMLTableSection_ondatasetcompleteEventHandler _ondatasetcompleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondatasetcompleteEventHandler ondatasetcompleteEvent
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
		private event HTMLTableSection_onlosecaptureEventHandler _onlosecaptureEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onlosecaptureEventHandler onlosecaptureEvent
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
		private event HTMLTableSection_onpropertychangeEventHandler _onpropertychangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onpropertychangeEventHandler onpropertychangeEvent
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
		private event HTMLTableSection_onscrollEventHandler _onscrollEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onscrollEventHandler onscrollEvent
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
		private event HTMLTableSection_onfocusEventHandler _onfocusEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onfocusEventHandler onfocusEvent
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
		private event HTMLTableSection_onblurEventHandler _onblurEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onblurEventHandler onblurEvent
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
		private event HTMLTableSection_onresizeEventHandler _onresizeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onresizeEventHandler onresizeEvent
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
		private event HTMLTableSection_ondragEventHandler _ondragEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondragEventHandler ondragEvent
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
		private event HTMLTableSection_ondragendEventHandler _ondragendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondragendEventHandler ondragendEvent
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
		private event HTMLTableSection_ondragenterEventHandler _ondragenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondragenterEventHandler ondragenterEvent
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
		private event HTMLTableSection_ondragoverEventHandler _ondragoverEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondragoverEventHandler ondragoverEvent
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
		private event HTMLTableSection_ondragleaveEventHandler _ondragleaveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondragleaveEventHandler ondragleaveEvent
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
		private event HTMLTableSection_ondropEventHandler _ondropEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondropEventHandler ondropEvent
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
		private event HTMLTableSection_onbeforecutEventHandler _onbeforecutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onbeforecutEventHandler onbeforecutEvent
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
		private event HTMLTableSection_oncutEventHandler _oncutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_oncutEventHandler oncutEvent
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
		private event HTMLTableSection_onbeforecopyEventHandler _onbeforecopyEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onbeforecopyEventHandler onbeforecopyEvent
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
		private event HTMLTableSection_oncopyEventHandler _oncopyEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_oncopyEventHandler oncopyEvent
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
		private event HTMLTableSection_onbeforepasteEventHandler _onbeforepasteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onbeforepasteEventHandler onbeforepasteEvent
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
		private event HTMLTableSection_onpasteEventHandler _onpasteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onpasteEventHandler onpasteEvent
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
		private event HTMLTableSection_oncontextmenuEventHandler _oncontextmenuEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_oncontextmenuEventHandler oncontextmenuEvent
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
		private event HTMLTableSection_onrowsdeleteEventHandler _onrowsdeleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onrowsdeleteEventHandler onrowsdeleteEvent
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
		private event HTMLTableSection_onrowsinsertedEventHandler _onrowsinsertedEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onrowsinsertedEventHandler onrowsinsertedEvent
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
		private event HTMLTableSection_oncellchangeEventHandler _oncellchangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_oncellchangeEventHandler oncellchangeEvent
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
		private event HTMLTableSection_onreadystatechangeEventHandler _onreadystatechangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onreadystatechangeEventHandler onreadystatechangeEvent
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
		private event HTMLTableSection_onbeforeeditfocusEventHandler _onbeforeeditfocusEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onbeforeeditfocusEventHandler onbeforeeditfocusEvent
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
		private event HTMLTableSection_onlayoutcompleteEventHandler _onlayoutcompleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onlayoutcompleteEventHandler onlayoutcompleteEvent
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
		private event HTMLTableSection_onpageEventHandler _onpageEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onpageEventHandler onpageEvent
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
		private event HTMLTableSection_onbeforedeactivateEventHandler _onbeforedeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onbeforedeactivateEventHandler onbeforedeactivateEvent
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
		private event HTMLTableSection_onbeforeactivateEventHandler _onbeforeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onbeforeactivateEventHandler onbeforeactivateEvent
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
		private event HTMLTableSection_onmoveEventHandler _onmoveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onmoveEventHandler onmoveEvent
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
		private event HTMLTableSection_oncontrolselectEventHandler _oncontrolselectEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_oncontrolselectEventHandler oncontrolselectEvent
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
		private event HTMLTableSection_onmovestartEventHandler _onmovestartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onmovestartEventHandler onmovestartEvent
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
		private event HTMLTableSection_onmoveendEventHandler _onmoveendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onmoveendEventHandler onmoveendEvent
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
		private event HTMLTableSection_onresizestartEventHandler _onresizestartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onresizestartEventHandler onresizestartEvent
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
		private event HTMLTableSection_onresizeendEventHandler _onresizeendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onresizeendEventHandler onresizeendEvent
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
		private event HTMLTableSection_onmouseenterEventHandler _onmouseenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onmouseenterEventHandler onmouseenterEvent
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
		private event HTMLTableSection_onmouseleaveEventHandler _onmouseleaveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onmouseleaveEventHandler onmouseleaveEvent
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
		private event HTMLTableSection_onmousewheelEventHandler _onmousewheelEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onmousewheelEventHandler onmousewheelEvent
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
		private event HTMLTableSection_onactivateEventHandler _onactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onactivateEventHandler onactivateEvent
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
		private event HTMLTableSection_ondeactivateEventHandler _ondeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_ondeactivateEventHandler ondeactivateEvent
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
		private event HTMLTableSection_onfocusinEventHandler _onfocusinEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onfocusinEventHandler onfocusinEvent
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
		private event HTMLTableSection_onfocusoutEventHandler _onfocusoutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLTableSection_onfocusoutEventHandler onfocusoutEvent
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