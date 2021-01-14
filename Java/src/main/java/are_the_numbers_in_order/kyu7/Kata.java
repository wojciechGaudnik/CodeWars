package are_the_numbers_in_order.kyu7;

class Solution {

	public static boolean isAscOrder(int[] arr) {
		for (var i = 0; i < arr.length - 1; i++) {
			if (arr[i] > arr[i + 1]) {
				return false;
			}
		}
		return true;
	}
}
   
