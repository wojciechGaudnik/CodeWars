package round_up_to_the_next_multiple_of_5.kyu7;

public class RoundToTheNextMultipleOf5 {

	public static void main(String[] args) {
		System.out.println(roundToNext5(-1997378));
	}
	public static int roundToNext5(int number) {
		if (number % 5 == 0) return number;
		if (number <= 0) return -((Math.abs(number) / 5) * 5);
		return ((Math.abs(number) / 5) * 5) + 5;
	}
}
   
