public class Error : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public Error() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Text { get{} set{} }
	public string Code { get{} set{} }
	public string HelpKeyword { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}

