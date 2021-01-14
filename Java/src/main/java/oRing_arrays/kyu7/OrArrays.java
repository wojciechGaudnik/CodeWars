package oRing_arrays.kyu7;

public class OrArrays {

	public static int[] orArrays(int[] arr1, int[] arr2, int... c) {
		var maxLength = Math.max(arr1.length, arr2.length);
		var answer = new int[maxLength];
		for (var i = 0; i < maxLength; i++) {
			var a = c.length > 0 ? c[0] : 0;
			var b = c.length > 0 ? c[0] : 0;
			if (arr1.length > i) a = arr1[i];
			if (arr2.length > i) b = arr2[i];
			answer[i] = a | b;
		}
		return answer;
	}
}
   
