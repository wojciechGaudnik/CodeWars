package ReturnRandomly;


public class Main {

	public static int oneTwoThree() {
		while (true) {
			int a = ontTwo();
			int b = ontTwo();
			if (a == 0 && b == 0) {
				return 0;
			} else if (a == 0 && b == 1) {
				return 1;
			} else if (a == 1 && b == 1) {
				return 2;
			}
		}
	}

	public static int ontTwo() {
		return (int) (Math.random() * 2);
	}
}
