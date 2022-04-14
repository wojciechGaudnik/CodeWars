package FunWithListsLength;

import java.util.ArrayList;
import java.util.List;

class Solution {

	public static double find_average(int[] array) {
		int sum = 0;
		for (int i = 0; i < array.length; i++) {
			sum += array[i];
		}
		return (double) sum / array.length;

	}

	public static String weatherInfo(int temp) {
		System.out.println(temp);
		double c = convertToCelsius(temp);
		if (c < 0)
			return (c + " is freezing temperature");
		else
			return (c + " is above freezing temperature");
	}

	public static double convertToCelsius(int temperature) {
		return (temperature - 32) * 0.5555555555555556;
	}

	static int lastIndexOf(Node head, Object value) {
		List<Object> objectList = new ArrayList<>();
		Node temp = head;
		while (temp != null) {
			objectList.add(temp.data);
			temp = temp.next;
		}
		return objectList.lastIndexOf(value);
	}


	static int length(Node head) {
		return (head == null) ? 0 : length(head.next) + 1;
	}

	static int indexOf(Node head, Object value) {
		if (ifExist(head, value) == 0) {
			if (head == null) {
				return -1;
			} else if (head.data.equals(value)) {
				return 0;
			} else {
				return 1 + indexOf(head.next, value);
			}
		} else {
			return -1;
		}
	}

	private static int ifExist(Node head, Object value) {
		if (head == null) {
			return -1;
		} else if (!head.data.equals(value)) {
			return ifExist(head.next, value);
		}
		;
		return 0;
	}
}

