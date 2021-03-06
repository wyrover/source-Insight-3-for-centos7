public class XmlSiteMapProvider : StaticSiteMapProvider, System.IDisposable
{

	// Constructors
	public XmlSiteMapProvider() {}

	// Methods
	public virtual SiteMapNode BuildSiteMap() {}
	public virtual void Dispose() {}
	public virtual SiteMapNode FindSiteMapNode(string rawUrl) {}
	public virtual SiteMapNode FindSiteMapNodeFromKey(string key) {}
	public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection attributes) {}
	public virtual SiteMapNodeCollection GetChildNodes(SiteMapNode node) {}
	public virtual SiteMapNode GetParentNode(SiteMapNode node) {}
	public virtual SiteMapNode FindSiteMapNode(HttpContext context) {}
	public virtual SiteMapNode GetCurrentNodeAndHintAncestorNodes(int upLevel) {}
	public virtual SiteMapNode GetCurrentNodeAndHintNeighborhoodNodes(int upLevel, int downLevel) {}
	public virtual SiteMapNode GetParentNodeRelativeToCurrentNodeAndHintDownFromParent(int walkupLevels, int relativeDepthFromWalkup) {}
	public virtual SiteMapNode GetParentNodeRelativeToNodeAndHintDownFromParent(SiteMapNode node, int walkupLevels, int relativeDepthFromWalkup) {}
	public virtual void HintAncestorNodes(SiteMapNode node, int upLevel) {}
	public virtual void HintNeighborhoodNodes(SiteMapNode node, int upLevel, int downLevel) {}
	public virtual bool IsAccessibleToUser(HttpContext context, SiteMapNode node) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SiteMapNode RootNode { get{} }
	public SiteMapNode CurrentNode { get{} }
	public bool EnableLocalization { get{} set{} }
	public SiteMapProvider ParentProvider { get{} set{} }
	public string ResourceKey { get{} set{} }
	public SiteMapProvider RootProvider { get{} }
	public bool SecurityTrimmingEnabled { get{} }
	public string Name { get{} }
	public string Description { get{} }

	// Events
	public event System.Web.SiteMapResolveEventHandler SiteMapResolve;
}

