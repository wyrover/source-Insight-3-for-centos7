public class DataGridViewTextBoxColumn : DataGridViewColumn, System.ICloneable, System.IDisposable, System.ComponentModel.IComponent
{

	// Constructors
	public DataGridViewTextBoxColumn() {}

	// Methods
	public virtual string ToString() {}
	public virtual object Clone() {}
	public virtual int GetPreferredWidth(DataGridViewAutoSizeColumnMode autoSizeColumnMode, bool fixedHeight) {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewCell CellTemplate { get{} set{} }
	public int MaxInputLength { get{} set{} }
	public DataGridViewColumnSortMode SortMode { get{} set{} }
	public DataGridViewAutoSizeColumnMode AutoSizeMode { get{} set{} }
	public Type CellType { get{} }
	public ContextMenuStrip ContextMenuStrip { get{} set{} }
	public string DataPropertyName { get{} set{} }
	public DataGridViewCellStyle DefaultCellStyle { get{} set{} }
	public int DisplayIndex { get{} set{} }
	public int DividerWidth { get{} set{} }
	public float FillWeight { get{} set{} }
	public bool Frozen { get{} set{} }
	public DataGridViewColumnHeaderCell HeaderCell { get{} set{} }
	public string HeaderText { get{} set{} }
	public DataGridViewAutoSizeColumnMode InheritedAutoSizeMode { get{} }
	public DataGridViewCellStyle InheritedStyle { get{} }
	public bool IsDataBound { get{} }
	public int MinimumWidth { get{} set{} }
	public string Name { get{} set{} }
	public bool ReadOnly { get{} set{} }
	public DataGridViewTriState Resizable { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public string ToolTipText { get{} set{} }
	public Type ValueType { get{} set{} }
	public bool Visible { get{} set{} }
	public int Width { get{} set{} }
	public Type DefaultHeaderCellType { get{} set{} }
	public bool Displayed { get{} }
	public bool HasDefaultCellStyle { get{} }
	public int Index { get{} }
	public bool Selected { get{} set{} }
	public object Tag { get{} set{} }
	public DataGridViewElementStates State { get{} }
	public DataGridView DataGridView { get{} }

	// Events
	public event System.EventHandler Disposed;
}

