package thinking_testing_true_or_false.kyu7;

public class ThinkingAndTesting {
	public static int testTrueFalse(int n) {
		return (int) Integer.toBinaryString(n).chars().mapToObj(i -> (char) i).filter(c -> c.equals('1')).count();
	}
}
