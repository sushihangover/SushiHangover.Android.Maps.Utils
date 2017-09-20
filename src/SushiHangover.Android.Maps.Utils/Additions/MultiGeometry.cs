using System.Collections.Generic;

namespace Android.Gms.Data
{
	public partial class MultiGeometry
	{
		//java.util.List<Geometry> getGeometryObject()
		public unsafe IList<Data.IGeometry> GeometryObject => new Runtime.JavaList<Data.IGeometry>(GeometryJavaObject().Handle, Runtime.JniHandleOwnership.DoNotTransfer);
	}
}
