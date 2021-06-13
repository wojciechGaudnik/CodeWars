package observer;

import java.util.ArrayList;
import java.util.List;

public class WeatherStation implements Subject{
	private List<Observer> observers;
	private int temp;
	private int humidity;

	public WeatherStation() {
		this.observers = new ArrayList<>();
	}

	@Override
	public void registerObserver(Observer o) {
		observers.add(o);
	}

	@Override
	public void removeObserver(Observer o) {
		observers.remove(o);
	}

	@Override
	public void notifyObservers() {
		observers.forEach(o -> o.update(temp, humidity));
	}

	public void measurementsChanged(int temp, int humidity) {
		this.temp = temp;
		this.humidity = humidity;
		notifyObservers();
	}
}
