using System.Collections.Generic;

namespace Android.Gms.Data.Klm
{
	public partial class KmlPolygon
	{
		public unsafe IList<IList<Maps.Model.LatLng>> GeometryObject => GeometryJavaObject() as IList<IList<Maps.Model.LatLng>>;
	}
}
