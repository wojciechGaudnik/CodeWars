package binary_calculator.kyu7;

public class BinaryCalculator {
	public static void main(String[] args) {
		System.out.println(calculate("1", "1", "add"));
	}

	public static String calculate(final String n1, final String n2, final String o) {
		var z1 = Integer.parseInt(n1, 2);
		var z2 = Integer.parseInt(n2, 2);
		switch (o) {
			case "add":
				return Integer.toBinaryString(z1 + z2);
			case "subtract":
				return Integer.toBinaryString(z1 - z2);
			case "multiply":
				return Integer.toBinaryString(z1 * z2);
			default:
				return "";
		}
	}
}
