package area_of_a_square.kyu8;

public class Geometry {

	public static void main(String[] args) {
		System.out.println(squareArea(2));
		System.out.println(squareArea(14.05));


	}

	public static double squareArea(double A) {
		var count = Math.pow((A * 4) / (2 * Math.PI), 2);
		return Math.round(count * 100.0) / 100.0;
	}
}
   
