using System.Collections.Generic;
using Android.Gms.Maps.Model;

namespace Android.Gms.Data
{
	public partial class LineString
	{
		//public java.util.ArrayList<LatLng> getGeometryObject()
		public unsafe IList<LatLng> GeometryObject => new Runtime.JavaList<LatLng>(GeometryJavaObject().Handle, Runtime.JniHandleOwnership.DoNotTransfer);
	}
}
