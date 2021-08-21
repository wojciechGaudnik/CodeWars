package describe_a_list.kyu7;

import java.util.List;

class Kata {
	public static String describeList(final List list) {
		if (list.isEmpty()) {
			return "empty";
		}
		if (list.size() == 1) {
			return "singleton";
		}
		return "longer";
	}
}
