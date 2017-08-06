using System.Collections.Generic;

namespace Android.Gms.Data
{
	public partial class MultiGeometry
	{
		public unsafe IList<Android.Gms.Data.IGeometry> GeometryObject => GeometryJavaObject() as IList<Android.Gms.Data.IGeometry>;
	}
}
