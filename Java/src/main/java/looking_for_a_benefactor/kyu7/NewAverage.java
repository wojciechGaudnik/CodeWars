package looking_for_a_benefactor.kyu7;

import java.util.Arrays;

public class NewAverage {

	public static long newAvg(double[] arr, double navg){
		System.out.println(Arrays.toString(arr) + "<--->" + navg);
		var answer = (long)Math.ceil(navg * arr.length + navg - Arrays.stream(arr).sum());
		if (answer < 0) {
			throw new IllegalArgumentException();
		}
		return answer;
	}
}
