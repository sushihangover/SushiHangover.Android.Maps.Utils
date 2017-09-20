
namespace Android.Gms.Data
{
	public partial class Point
	{
		//LatLng getGeometryObject()
		public unsafe Maps.Model.LatLng GeometryObject => GeometryJavaObject() as Maps.Model.LatLng;
	}
}
