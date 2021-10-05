class DoubleCheckedLockingSingleton {
	private static DoubleCheckedLockingSingleton instance;

	public static synchronized DoubleCheckedLockingSingleton getInstance() {
		if (instance == null) {
			instance = new DoubleCheckedLockingSingleton();
		}
		return instance;
	}

}
