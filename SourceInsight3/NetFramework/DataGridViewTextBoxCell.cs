public class DataGridViewTextBoxCell : DataGridViewCell, System.ICloneable, System.IDisposable
{

	// Constructors
	public DataGridViewTextBoxCell() {}

	// Methods
	public virtual object Clone() {}
	public virtual void DetachEditingControl() {}
	public virtual void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle) {}
	public virtual bool KeyEntersEditMode(KeyEventArgs e) {}
	public virtual void PositionEditingControl(bool setLocation, bool setSize, System.Drawing.Rectangle cellBounds, System.Drawing.Rectangle cellClip, DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow) {}
	public virtual string ToString() {}
	public virtual DataGridViewAdvancedBorderStyle AdjustCellBorderStyle(DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStyleInput, DataGridViewAdvancedBorderStyle dataGridViewAdvancedBorderStylePlaceholder, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow) {}
	public virtual void Dispose() {}
	public System.Drawing.Rectangle GetContentBounds(int rowIndex) {}
	public object GetEditedFormattedValue(int rowIndex, DataGridViewDataErrorContexts context) {}
	public virtual ContextMenuStrip GetInheritedContextMenuStrip(int rowIndex) {}
	public virtual DataGridViewElementStates GetInheritedState(int rowIndex) {}
	public virtual DataGridViewCellStyle GetInheritedStyle(DataGridViewCellStyle inheritedCellStyle, int rowIndex, bool includeColors) {}
	public virtual object ParseFormattedValue(object formattedValue, DataGridViewCellStyle cellStyle, System.ComponentModel.TypeConverter formattedValueTypeConverter, System.ComponentModel.TypeConverter valueTypeConverter) {}
	public virtual System.Drawing.Rectangle PositionEditingPanel(System.Drawing.Rectangle cellBounds, System.Drawing.Rectangle cellClip, DataGridViewCellStyle cellStyle, bool singleVerticalBorderAdded, bool singleHorizontalBorderAdded, bool isFirstDisplayedColumn, bool isFirstDisplayedRow) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Type FormattedValueType { get{} }
	public int MaxInputLength { get{} set{} }
	public Type ValueType { get{} }
	public AccessibleObject AccessibilityObject { get{} }
	public int ColumnIndex { get{} }
	public System.Drawing.Rectangle ContentBounds { get{} }
	public ContextMenuStrip ContextMenuStrip { get{} set{} }
	public object DefaultNewRowValue { get{} }
	public bool Displayed { get{} }
	public object EditedFormattedValue { get{} }
	public Type EditType { get{} }
	public System.Drawing.Rectangle ErrorIconBounds { get{} }
	public string ErrorText { get{} set{} }
	public object FormattedValue { get{} }
	public bool Frozen { get{} }
	public bool HasStyle { get{} }
	public DataGridViewElementStates InheritedState { get{} }
	public DataGridViewCellStyle InheritedStyle { get{} }
	public bool IsInEditMode { get{} }
	public DataGridViewColumn OwningColumn { get{} }
	public DataGridViewRow OwningRow { get{} }
	public System.Drawing.Size PreferredSize { get{} }
	public bool ReadOnly { get{} set{} }
	public bool Resizable { get{} }
	public int RowIndex { get{} }
	public bool Selected { get{} set{} }
	public System.Drawing.Size Size { get{} }
	public DataGridViewCellStyle Style { get{} set{} }
	public object Tag { get{} set{} }
	public string ToolTipText { get{} set{} }
	public object Value { get{} set{} }
	public bool Visible { get{} }
	public DataGridViewElementStates State { get{} }
	public DataGridView DataGridView { get{} }
}

