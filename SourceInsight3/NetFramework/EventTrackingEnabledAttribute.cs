public class EventTrackingEnabledAttribute : System.Attribute, System.Runtime.InteropServices._Attribute, IConfigurationAttribute
{

	// Constructors
	public EventTrackingEnabledAttribute() {}
	public EventTrackingEnabledAttribute(bool val) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Value { get{} }
	public object TypeId { get{} }
}

