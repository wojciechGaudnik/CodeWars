package formatting_decimal_places.kyu7;

public class Numbers {

	public static void main(String[] args) {
		System.out.println(twoDecimalPlaces(10.128963465));
	}

	public static double twoDecimalPlaces(double number)	{
		return (int)(number * 100) / 100.0;
	}
}
