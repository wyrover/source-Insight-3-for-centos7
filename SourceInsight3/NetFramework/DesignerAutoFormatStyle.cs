public class DesignerAutoFormatStyle : System.Web.UI.WebControls.Style, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IStateManager
{

	// Constructors
	public DesignerAutoFormatStyle() {}

	// Methods
	public void AddAttributesToRender(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void AddAttributesToRender(System.Web.UI.HtmlTextWriter writer, System.Web.UI.WebControls.WebControl owner) {}
	public virtual void CopyFrom(System.Web.UI.WebControls.Style s) {}
	public System.Web.UI.CssStyleCollection GetStyleAttributes(System.Web.UI.IUrlResolutionService urlResolver) {}
	public virtual void MergeWith(System.Web.UI.WebControls.Style s) {}
	public virtual void Reset() {}
	public void SetDirty() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.UI.WebControls.VerticalAlign VerticalAlign { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Color BorderColor { get{} set{} }
	public System.Web.UI.WebControls.Unit BorderWidth { get{} set{} }
	public System.Web.UI.WebControls.BorderStyle BorderStyle { get{} set{} }
	public string CssClass { get{} set{} }
	public System.Web.UI.WebControls.FontInfo Font { get{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public System.Web.UI.WebControls.Unit Height { get{} set{} }
	public bool IsEmpty { get{} }
	public string RegisteredCssClass { get{} }
	public System.Web.UI.WebControls.Unit Width { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler Disposed;
}

