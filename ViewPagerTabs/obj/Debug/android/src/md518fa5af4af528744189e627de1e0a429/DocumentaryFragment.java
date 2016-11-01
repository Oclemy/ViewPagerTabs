package md518fa5af4af528744189e627de1e0a429;


public class DocumentaryFragment
	extends android.app.Fragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ViewPagerTabs.mTabs.DocumentaryFragment, ViewPagerTabs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DocumentaryFragment.class, __md_methods);
	}


	public DocumentaryFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DocumentaryFragment.class)
			mono.android.TypeManager.Activate ("ViewPagerTabs.mTabs.DocumentaryFragment, ViewPagerTabs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
