package BMI;

public class Calculate {
	public static String bmi(double weight, double height) {
		double bmi = weight / Math.pow(height, 2);
		if (bmi <= 18.5) {
			return "Underweight";
		} else if (bmi <= 25.0) {
			return "Normal";
		} else if (bmi <= 30) {
			return "Overweight";
		}
		return "Obese";
	}
}