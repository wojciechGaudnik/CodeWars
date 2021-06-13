package observer;

import java.util.Random;

public class Main {
	public static void main(String[] args) throws InterruptedException {
		WeatherStation weatherStation = new WeatherStation();
		CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherStation);
		ForecastDisplay forecastDisplay = new ForecastDisplay(weatherStation);

		for (int i = 0; i < 5; i++) {
			System.out.println("\n--- Update " + i + " ---");

			int randomTemp = getRandomInt(-50, 40);
			int randomHumidity = getRandomInt(0, 100);
			weatherStation.measurementsChanged(randomTemp, randomHumidity);
			Thread.sleep(1000);
		}
	}

	private static int getRandomInt(int min, int max) {
		Random rand = new Random();
		return rand.nextInt(max + 1 - min) + min;
	}
}
