package md5cadfe4b630089253d09a13d6e8b33029;


public class FoodRecyclerViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("SIT313Project1.Adapters.FoodRecyclerViewHolder, SIT313Project1", FoodRecyclerViewHolder.class, __md_methods);
	}


	public FoodRecyclerViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == FoodRecyclerViewHolder.class)
			mono.android.TypeManager.Activate ("SIT313Project1.Adapters.FoodRecyclerViewHolder, SIT313Project1", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

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
