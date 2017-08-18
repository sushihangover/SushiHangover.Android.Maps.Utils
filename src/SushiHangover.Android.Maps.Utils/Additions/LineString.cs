using System.Collections.Generic;

namespace Android.Gms.Data
{
	public partial class LineString
	{
		public unsafe IList<Maps.Model.LatLng> GeometryObject => GeometryJavaObject() as IList<Maps.Model.LatLng>;
	}
}
