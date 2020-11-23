package find_screen_size.kyu7;

public class Kata {

	public static void main(String[] args) {
		System.out.println(findScreenHeight(1024,"4:3"));
	}

	public static String findScreenHeight(int width, String ratio) {
		return width + "x" +
				(width * Integer.parseInt(ratio.split(":")[1])) / Integer.parseInt(ratio.split(":")[0]);
	}
}
