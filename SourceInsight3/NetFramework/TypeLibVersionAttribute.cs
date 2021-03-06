public class TypeLibVersionAttribute : System.Attribute, _Attribute
{

	// Constructors
	public TypeLibVersionAttribute(int major, int minor) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int MajorVersion { get{} }
	public int MinorVersion { get{} }
	public object TypeId { get{} }
}

