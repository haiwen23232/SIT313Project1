package md5cadfe4b630089253d09a13d6e8b33029;


public class OrderRecyclerViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("SIT313Project1.Adapters.OrderRecyclerViewHolder, SIT313Project1", OrderRecyclerViewHolder.class, __md_methods);
	}


	public OrderRecyclerViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == OrderRecyclerViewHolder.class)
			mono.android.TypeManager.Activate ("SIT313Project1.Adapters.OrderRecyclerViewHolder, SIT313Project1", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
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
