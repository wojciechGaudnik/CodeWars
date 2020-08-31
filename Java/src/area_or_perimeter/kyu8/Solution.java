package area_or_perimeter.kyu8;

public class Solution {
	public static int areaOrPerimeter (int l, int w) {
		if (l != w) {
			return l * 2 + w * 2;
		} else {
			return (int) Math.pow(l, 2);
		}
	}
}
   
