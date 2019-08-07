package md5dab51fe6f80f211cead7351ee8c35c87;


public class MainActivity_CredentialAsyncTask
	extends android.os.AsyncTask
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_doInBackground:([Ljava/lang/Object;)Ljava/lang/Object;:GetDoInBackground_arrayLjava_lang_Object_Handler\n" +
			"";
		mono.android.Runtime.register ("SIT313Project1.MainActivity+CredentialAsyncTask, SIT313Project1", MainActivity_CredentialAsyncTask.class, __md_methods);
	}


	public MainActivity_CredentialAsyncTask ()
	{
		super ();
		if (getClass () == MainActivity_CredentialAsyncTask.class)
			mono.android.TypeManager.Activate ("SIT313Project1.MainActivity+CredentialAsyncTask, SIT313Project1", "", this, new java.lang.Object[] {  });
	}


	public java.lang.Object doInBackground (java.lang.Object[] p0)
	{
		return n_doInBackground (p0);
	}

	private native java.lang.Object n_doInBackground (java.lang.Object[] p0);

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
