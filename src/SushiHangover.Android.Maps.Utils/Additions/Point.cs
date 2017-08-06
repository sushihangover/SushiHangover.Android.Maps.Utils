
namespace Android.Gms.Data
{
	public partial class Point
	{
		public unsafe Maps.Model.LatLng GeometryObject => GeometryJavaObject() as Maps.Model.LatLng;
	}
}
