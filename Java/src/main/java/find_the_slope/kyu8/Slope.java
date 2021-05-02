package find_the_slope.kyu8;

public class Slope {

	public String slope(int[] points) {
		var delY = points[3] - points[1];
		var delX = points[2] - points[0];
		return (delX == 0) ? "undefined" : "" + delY / delX;
	}
}
