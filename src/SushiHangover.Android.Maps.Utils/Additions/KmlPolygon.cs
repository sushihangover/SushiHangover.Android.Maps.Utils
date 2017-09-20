using System.Collections.Generic;
using Android.Gms.Maps.Model;
using System.Linq;

namespace Android.Gms.Data.Klm
{
	public partial class KmlPolygon
	{
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

				//global::Android.Runtime.JavaList<global::Android.Gms.Maps.Model.LatLng>.FromJniHandle
					                  //(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, 
					                                           //id_getOuterBoundaryCoordinates), JniHandleOwnership.TransferLocalRef);

				//var geometry = new Runtime.JavaList<Runtime.JavaList<LatLng>>();
				//var iter = (GeometryJavaObject() as Java.Util.IList).Iterator();
				//while (iter.HasNext)
				//{
				//	var q = new Runtime.JavaList<LatLng>(iter.Next().Handle, Runtime.JniHandleOwnership.DoNotTransfer);
				//	geometry.Add(q);
				//}
				return (IList<IList<LatLng>>)geometry;
			}
		}
	}
}
