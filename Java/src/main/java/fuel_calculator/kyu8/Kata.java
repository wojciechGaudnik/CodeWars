package fuel_calculator.kyu8;

public class Kata {
	public static double fuelPrice(int litres, double pricePerLitre) {
		double answer = 0;
		if (litres >= 10) {
			return litres * (pricePerLitre - 0.25);
		}
		if (litres >= 8) {
			return litres * (pricePerLitre - 0.20);
		}
		if (litres >= 6) {
			return litres * (pricePerLitre - 0.15);
		}
		if (litres >= 4) {
			return litres * (pricePerLitre - 0.10);
		}
		if (litres >= 2) {
			return litres * (pricePerLitre - 0.05);
		}
		return answer + litres * pricePerLitre;
	}
}
