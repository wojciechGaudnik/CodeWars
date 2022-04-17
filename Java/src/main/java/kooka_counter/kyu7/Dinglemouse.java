package kooka_counter.kyu7;

public class Dinglemouse {

	public static int kookaCounter(final String laughing) {
		var laughingCopy = laughing;
		int oldLength;
		do {
			oldLength = laughingCopy.length();
			laughingCopy = laughingCopy.replace("haha", "ha");
			laughingCopy = laughingCopy.replace("HaHa", "Ha");

		} while (oldLength != laughingCopy.length());
		return laughingCopy.length() / 2;
	}

}