package formatting_decimal_places.kyu7;

public class Numbers {

	public static double twoDecimalPlaces(double number)	{
		return (int)(number * 100) / 100.0;
	}
}
