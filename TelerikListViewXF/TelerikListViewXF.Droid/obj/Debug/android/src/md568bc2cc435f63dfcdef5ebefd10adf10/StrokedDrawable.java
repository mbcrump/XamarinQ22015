package md568bc2cc435f63dfcdef5ebefd10adf10;


public class StrokedDrawable
	extends android.graphics.drawable.ColorDrawable
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_draw:(Landroid/graphics/Canvas;)V:GetDraw_Landroid_graphics_Canvas_Handler\n" +
			"";
		mono.android.Runtime.register ("Telerik.XamarinForms.DataControlsRenderer.Android.StrokedDrawable, Telerik.XamarinForms.DataControlsRenderer.Android, Version=2015.2.612.142, Culture=neutral, PublicKeyToken=null", StrokedDrawable.class, __md_methods);
	}


	public StrokedDrawable () throws java.lang.Throwable
	{
		super ();
		if (getClass () == StrokedDrawable.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.DataControlsRenderer.Android.StrokedDrawable, Telerik.XamarinForms.DataControlsRenderer.Android, Version=2015.2.612.142, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public StrokedDrawable (int p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == StrokedDrawable.class)
			mono.android.TypeManager.Activate ("Telerik.XamarinForms.DataControlsRenderer.Android.StrokedDrawable, Telerik.XamarinForms.DataControlsRenderer.Android, Version=2015.2.612.142, Culture=neutral, PublicKeyToken=null", "Android.Graphics.Color, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public void draw (android.graphics.Canvas p0)
	{
		n_draw (p0);
	}

	private native void n_draw (android.graphics.Canvas p0);

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
