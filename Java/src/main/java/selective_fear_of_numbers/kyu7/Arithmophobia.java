package selective_fear_of_numbers.kyu7;

public class Arithmophobia {

	static public boolean AmIAfraid(final String day, final int num) {
		switch (day) {
			case "Monday":
				return num == 12;
			case "Tuesday":
				return num > 95;
			case "Wednesday":
				return num == 34;
			case "Thursday":
				return num == 0;
			case "Friday":
				return num % 2 == 0;
			case "Saturday":
				return num == 56;
			case "Sunday":
				return (num == -666) || (num == 666);
		}
		return false;
	}
}
