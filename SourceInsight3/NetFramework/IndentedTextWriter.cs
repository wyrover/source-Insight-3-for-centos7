public class IndentedTextWriter : System.IO.TextWriter, System.IDisposable
{

	// Constructors
	public IndentedTextWriter(System.IO.TextWriter writer, string tabString) {}
	public IndentedTextWriter(System.IO.TextWriter writer) {}

	// Methods
	public virtual void Close() {}
	public virtual void Flush() {}
	public virtual void Write(string s) {}
	public virtual void Write(bool value) {}
	public virtual void Write(char value) {}
	public virtual void Write(char[] buffer) {}
	public virtual void Write(char[] buffer, int index, int count) {}
	public virtual void Write(double value) {}
	public virtual void Write(float value) {}
	public virtual void Write(int value) {}
	public virtual void Write(long value) {}
	public virtual void Write(object value) {}
	public virtual void Write(string format, object arg0) {}
	public virtual void Write(string format, object arg0, object arg1) {}
	public virtual void Write(string format, object[] arg) {}
	public void WriteLineNoTabs(string s) {}
	public virtual void WriteLine(string s) {}
	public virtual void WriteLine() {}
	public virtual void WriteLine(bool value) {}
	public virtual void WriteLine(char value) {}
	public virtual void WriteLine(char[] buffer) {}
	public virtual void WriteLine(char[] buffer, int index, int count) {}
	public virtual void WriteLine(double value) {}
	public virtual void WriteLine(float value) {}
	public virtual void WriteLine(int value) {}
	public virtual void WriteLine(long value) {}
	public virtual void WriteLine(object value) {}
	public virtual void WriteLine(string format, object arg0) {}
	public virtual void WriteLine(string format, object arg0, object arg1) {}
	public virtual void WriteLine(string format, object[] arg) {}
	public virtual void WriteLine(uint value) {}
	public virtual void Dispose() {}
	public virtual void Write(uint value) {}
	public virtual void Write(ulong value) {}
	public virtual void Write(decimal value) {}
	public virtual void Write(string format, object arg0, object arg1, object arg2) {}
	public virtual void WriteLine(ulong value) {}
	public virtual void WriteLine(decimal value) {}
	public virtual void WriteLine(string format, object arg0, object arg1, object arg2) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string DefaultTabString;

	// Properties
	public System.Text.Encoding Encoding { get{} }
	public string NewLine { get{} set{} }
	public int Indent { get{} set{} }
	public System.IO.TextWriter InnerWriter { get{} }
	public System.IFormatProvider FormatProvider { get{} }
}

