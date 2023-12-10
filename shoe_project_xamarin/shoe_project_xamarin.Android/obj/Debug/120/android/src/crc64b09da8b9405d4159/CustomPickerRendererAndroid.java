package crc64b09da8b9405d4159;


public class CustomPickerRendererAndroid
	extends crc643f46942d9dd1fff9.PickerRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("shoe_project_xamarin.Droid.CustomPickerRendererAndroid, shoe_project_xamarin.Android", CustomPickerRendererAndroid.class, __md_methods);
	}


	public CustomPickerRendererAndroid (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomPickerRendererAndroid.class) {
			mono.android.TypeManager.Activate ("shoe_project_xamarin.Droid.CustomPickerRendererAndroid, shoe_project_xamarin.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public CustomPickerRendererAndroid (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomPickerRendererAndroid.class) {
			mono.android.TypeManager.Activate ("shoe_project_xamarin.Droid.CustomPickerRendererAndroid, shoe_project_xamarin.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public CustomPickerRendererAndroid (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomPickerRendererAndroid.class) {
			mono.android.TypeManager.Activate ("shoe_project_xamarin.Droid.CustomPickerRendererAndroid, shoe_project_xamarin.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
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
