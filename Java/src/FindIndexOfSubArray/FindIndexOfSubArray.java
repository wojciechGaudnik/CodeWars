package FindIndexOfSubArray;

import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class FindIndexOfSubArray {
	private int[] arr;
	public FindIndexOfSubArray(int[] arr) {
		this.arr = arr;
	}

	public static void main(String[] args) {
		FindIndexOfSubArray test = new FindIndexOfSubArray(new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 81, 39, 4, 20, 24, 49, 97, 74, 80, 45, 18, 17, 37, 26, 61, 46, 27, 65, 77, 43, 24, 8, 46, 80, 95, 49, 99, 2, 23, 85, 72, 1, 92, 66, 56, 90, 95, 33, 12, 42});
		System.out.println("should return [1,49]");
		System.out.println(Arrays.toString(test.findIndexOfSubArray()));
	}



	public int[] findIndexOfSubArray(){
		List<Integer> list1 = Arrays.stream(arr).boxed().collect(Collectors.toList());
		List<Integer> list2 = Arrays.stream(arr).boxed().collect(Collectors.toList());
		int m1 = -1;
		int n1 = 0;
		for (int i = 0; i < list1.size() - 1; i++) {
			for (int j = 0; j < list1.size() - i - 1; j++) {
				if (list1.get(j) > list1.get(j + 1)) {
					if(m1 == -1) m1 = j;
					if(m1 > j) m1 = j;
					if(n1 < j + 1) n1 = j + 1;
					int temp = list1.get(j);
					list1.set(j, list1.get(j + 1));
					list1.set(j + 1, temp);
				}
			}
		}
		int m2 = -1;
		int n2 = 0;
		for (int i = 0; i < list2.size() - 1; i++) {
			for (int j = 0; j < list2.size() - i - 1; j++) {
				if (list2.get(j) < list2.get(j + 1)) {
					if(m2 == -1) m2 = j;
					if(m2 > j) m2 = j;
					if(n2 < j + 1) n2 = j + 1;
					int temp = list2.get(j);
					list2.set(j, list2.get(j + 1));
					list2.set(j + 1, temp);
				}
			}
		}
		if(m1 == -1) m1 = 0;
		if(m2 == -1) m2 = 0;
		if(((m1 == 0) && (n1 == 0)) || ((m2 == 0) && (n2 == 0))) return new int[]{0, 0};
		return ((n1 - m1) < (n2 - m2))? new int[]{m1, n1}: new int []{m2, n2};
	}
}
