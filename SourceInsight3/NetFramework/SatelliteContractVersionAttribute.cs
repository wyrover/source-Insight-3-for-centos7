public class SatelliteContractVersionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SatelliteContractVersionAttribute(string version) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Version { get{} }
	public object TypeId { get{} }
}

