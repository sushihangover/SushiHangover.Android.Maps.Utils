using System.Collections.Generic;

namespace Android.Gms.Data.GeoJson
{
	public partial class GeoJsonPolygon
	{
		public unsafe IList<IList<Maps.Model.LatLng>> GeometryObject => GeometryJavaObject() as IList<IList<Maps.Model.LatLng>>;
	}
}
