public class GroupBoxArray : BaseControlArray, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.ISupportInitialize, System.ComponentModel.IExtenderProvider
{

	// Constructors
	public GroupBoxArray() {}
	public GroupBoxArray(System.ComponentModel.IContainer Container) {}

	// Methods
	public virtual bool CanExtend(object target) {}
	public short GetIndex(System.Windows.Forms.GroupBox o) {}
	public void SetIndex(System.Windows.Forms.GroupBox o, short Index) {}
	public bool ShouldSerializeIndex(System.Windows.Forms.GroupBox o) {}
	public void ResetIndex(System.Windows.Forms.GroupBox o) {}
	public void Load(short Index) {}
	public void Unload(short Index) {}
	public short LBound() {}
	public short UBound() {}
	public short Count() {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Windows.Forms.GroupBox Item { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler AutoSizeChanged;
	public event System.EventHandler BackColorChanged;
	public event System.EventHandler BackgroundImageChanged;
	public event System.EventHandler BackgroundImageLayoutChanged;
	public event System.EventHandler BindingContextChanged;
	public event System.EventHandler CausesValidationChanged;
	public event System.Windows.Forms.UICuesEventHandler ChangeUICues;
	public event System.EventHandler ClientSizeChanged;
	public event System.EventHandler ContextMenuChanged;
	public event System.EventHandler ContextMenuStripChanged;
	public event System.Windows.Forms.ControlEventHandler ControlAdded;
	public event System.Windows.Forms.ControlEventHandler ControlRemoved;
	public event System.EventHandler CursorChanged;
	public event System.EventHandler DockChanged;
	public event System.Windows.Forms.DragEventHandler DragDrop;
	public event System.Windows.Forms.DragEventHandler DragEnter;
	public event System.EventHandler DragLeave;
	public event System.Windows.Forms.DragEventHandler DragOver;
	public event System.EventHandler EnabledChanged;
	public event System.EventHandler Enter;
	public event System.EventHandler FontChanged;
	public event System.EventHandler ForeColorChanged;
	public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;
	public event System.Windows.Forms.HelpEventHandler HelpRequested;
	public event System.EventHandler ImeModeChanged;
	public event System.Windows.Forms.LayoutEventHandler Layout;
	public event System.EventHandler Leave;
	public event System.EventHandler LocationChanged;
	public event System.EventHandler MarginChanged;
	public event System.EventHandler MouseCaptureChanged;
	public event System.EventHandler MouseHover;
	public event System.EventHandler Move;
	public event System.EventHandler PaddingChanged;
	public event System.Windows.Forms.PaintEventHandler Paint;
	public event System.EventHandler ParentChanged;
	public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
	public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag;
	public event System.EventHandler RegionChanged;
	public event System.EventHandler Resize;
	public event System.EventHandler RightToLeftChanged;
	public event System.EventHandler SizeChanged;
	public event System.EventHandler StyleChanged;
	public event System.EventHandler SystemColorsChanged;
	public event System.EventHandler TabIndexChanged;
	public event System.EventHandler TextChanged;
	public event System.EventHandler Validated;
	public event System.ComponentModel.CancelEventHandler Validating;
	public event System.EventHandler VisibleChanged;
	public event System.EventHandler Disposed;
}

