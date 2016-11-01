package md518fa5af4af528744189e627de1e0a429;


public class DramaFragment
	extends android.app.Fragment
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ViewPagerTabs.mTabs.DramaFragment, ViewPagerTabs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DramaFragment.class, __md_methods);
	}


	public DramaFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DramaFragment.class)
			mono.android.TypeManager.Activate ("ViewPagerTabs.mTabs.DramaFragment, ViewPagerTabs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
