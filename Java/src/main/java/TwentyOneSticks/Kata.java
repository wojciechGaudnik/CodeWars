package TwentyOneSticks;

public class Kata {
	public static int makeMove(int sticks) {
		return (sticks <= 3) ? sticks : sticks % 4;
	}
}
