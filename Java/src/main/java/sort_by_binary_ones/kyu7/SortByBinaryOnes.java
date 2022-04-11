package sort_by_binary_ones.kyu7;

import java.util.Comparator;
import java.util.TreeMap;

class SortByBinaryOnes {
	public static Integer[] sort(Integer list[]) {
		var treeMap = new TreeMap<String, Integer>(new BinarySort());
		for (var one : list) {
			treeMap.put(Integer.toBinaryString(one), one);
		}
		return treeMap.values().toArray(new Integer[0]);
	}

	static class BinarySort implements Comparator<String> {

		@Override
		public int compare(String o1, String o2) {
			var o1Count = o1.chars().filter(ch -> ch == '1').count();
			var o2Count = o2.chars().filter(ch -> ch == '1').count();
			if (o1Count > o2Count) {
				return -1;
			}
			if (o1Count < o2Count) {
				return 1;
			}
			if (o1.length() > o2.length()) {
				return 1;
			}
			if (o1.length() < o2.length()) {
				return -1;
			}
			return Integer.compare(Integer.parseInt(o1, 2), Integer.parseInt(o2, 2));
		}
	}


	public static void main(String[] args) {
		System.out.println(sort(new Integer[]{1, 2, 3, 4}));
	}
}
