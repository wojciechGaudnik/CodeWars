package dev.gaudnik.singleton;

public class Singleton {

	private volatile static Singleton INSTANCE;

	private Singleton() {
	}

	public static Singleton getInstance() {
		if (INSTANCE == null) {
			synchronized (Singleton.class) {
				INSTANCE = new Singleton();
			}
		}
		return INSTANCE;
	}
}
