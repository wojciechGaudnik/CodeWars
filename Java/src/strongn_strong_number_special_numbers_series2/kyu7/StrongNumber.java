package strongn_strong_number_special_numbers_series2.kyu7;

public class StrongNumber {

	public static void main(String[] args) {
		var strongNumber = new StrongNumber();
		System.out.println(isStrongNumber(1));
		System.out.println(isStrongNumber(2));
		System.out.println(isStrongNumber(145));
		System.out.println(isStrongNumber(7));
		System.out.println(isStrongNumber(93));
		System.out.println(isStrongNumber(185));
	}



	static int[] factorials = new int[10];

	{
		factorials[0] = 1;
		for (var i = 1; i <= 9; i++) {
			factorials[i] = factorials[i - 1] * i;
		}
		factorials[0] = 0;
	}

	public static String isStrongNumber(int num) {
		if (factorials[1] == 0)	new StrongNumber();
		var answer = String.valueOf(num).chars().map(Character::getNumericValue).map(i -> factorials[i]).sum();
		return (answer == num) ? "STRONG!!!!": "Not Strong !!";
	}
}
