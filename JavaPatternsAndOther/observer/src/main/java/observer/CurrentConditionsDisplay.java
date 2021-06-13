package observer;

public class CurrentConditionsDisplay implements Observer{

	private int temp;
	private int humidity;

	public CurrentConditionsDisplay(Subject weatherStation) {
		weatherStation.registerObserver(this);
	}

	@Override
	public void update(int temp, int humidity) {
		this.temp = temp;
		this.humidity = humidity;
		displayCurrentConditions();
	}

	private void displayCurrentConditions() {
		System.out.println("Current Temperature: " + temp);
		System.out.println("Current Humidity: " + humidity);
	}
}
