package md566e88859871c57c7b4d1725617bcc7b9;


public class ListViewSortDescriptor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.telerik.android.common.Function2
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_apply:(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;:GetApply_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Telerik.Android.Common.IFunction2Invoker, Telerik.Xamarin.Android.Common\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.DataControlsRenderer.Android.ListView.ListViewSortDescriptor, Telerik.XamarinForms.DataControlsRenderer.Android, Version=2015.2.612.142, Culture=neutral, PublicKeyToken=null", ListViewSortDescriptor.class, __md_methods);
	}


	public ListViewSortDescriptor () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ListViewSortDescriptor.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.DataControlsRenderer.Android.ListView.ListViewSortDescriptor, Telerik.XamarinForms.DataControlsRenderer.Android, Version=2015.2.612.142, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public java.lang.Object apply (java.lang.Object p0, java.lang.Object p1)
	{
		return n_apply (p0, p1);
	}

	private native java.lang.Object n_apply (java.lang.Object p0, java.lang.Object p1);

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
