package compound_array.kyu7;

public class CompoundArray {
	public static int[] compoundArray(int[] a, int[] b){
		var answer = new int[a.length + b.length];
		var i = 0;
		var abi = 0;
		for (; i < a.length && i < b.length; i++) {
			answer[abi++] = a[i];
			answer[abi++] = b[i];
		}
		if (a.length > i) {
			for (; i < a.length; i++) {
				answer[abi++] = a[i];
			}
			return answer;
		} else {
			for (; i < b.length; i++) {
				answer[abi++] = b[i];
			}
			return answer;
		}
	}
}
