using System.Collections.Generic;
using Android.Gms.Maps.Model;
using System.Linq;

namespace Android.Gms.Data.GeoJson
{
	public partial class GeoJsonPolygon
	{
		// A GeoJsonPolygon geometry contains an array of arrays of com.google.android.gms.maps.model.LatLngs.
		// The first array is the polygon exterior boundary. 
		// Subsequent arrays are holes.
		//java.util.List<? extends java.util.List<LatLng>> getGeometryObject()

		/// <summary>
		/// A GeoJsonPolygon geometry contains an array of arrays of com.google.android.gms.maps.model.LatLngs.
		/// The first array is the polygon exterior boundary. 
		/// Subsequent arrays are holes.
		/// </summary>
		/// <value>The geometry object.</value>
		public IList<IList<LatLng>> GeometryObject
		{
			get
			{
				var geometry = new List<List<LatLng>>();
				geometry.Add(OuterBoundaryCoordinates.ToList());
				foreach (var latlngList in InnerBoundaryCoordinates)
				{
					geometry.Add(latlngList.ToList());
				}

				//var iter = (GeometryJavaObject() as Java.Util.IList).Iterator();
				//while (iter.HasNext)
				//{
				//	var q = new Runtime.JavaList<LatLng>(iter.Next().Handle, Runtime.JniHandleOwnership.DoNotTransfer);
				//	geometry.Add(q);
				//}
				return (System.Collections.Generic.IList<System.Collections.Generic.IList<Android.Gms.Maps.Model.LatLng>>)geometry;
			}
		}
	}
}
