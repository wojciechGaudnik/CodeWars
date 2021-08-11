package geometry_basics_dot_product_in_3D.kyu7;

public class GeometryBasics {
	public static double dotProduct(final Vector3D a, final Vector3D b) {
		return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
	}

}


class Vector3D {
	public double x, y, z;

	public Vector3D(double x, double y, double z) {
		this.x = x;
		this.y = y;
		this.z = z;
	}
}
