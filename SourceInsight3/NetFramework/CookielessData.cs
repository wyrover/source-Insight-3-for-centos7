public class CookielessData : System.Collections.Specialized.HybridDictionary, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CookielessData() {}

	// Methods
	public virtual void Add(object key, object value) {}
	public virtual bool Contains(object key) {}
	public virtual void Remove(object key) {}
	public virtual void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} set{} }
	public int Count { get{} }
	public System.Collections.ICollection Keys { get{} }
	public bool IsReadOnly { get{} }
	public bool IsFixedSize { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public System.Collections.ICollection Values { get{} }
}

