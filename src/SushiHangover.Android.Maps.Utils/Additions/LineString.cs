using System.Collections.Generic;

namespace Android.Gms.Data
{
	public partial class LineString
	{
		//public java.util.ArrayList<LatLng> getGeometryObject()
		public unsafe IList<Maps.Model.LatLng> GeometryObject => new Runtime.JavaArray<Maps.Model.LatLng>(GeometryJavaObject().Handle, Android.Runtime.JniHandleOwnership.TransferLocalRef);

	}
}
