package Rotator;

import java.util.Arrays;
import java.util.Collections;

public class Rotator {

	public Object[] rotate(Object[] data, int n) {
		Collections.rotate(Arrays.asList(data), n % data.length);
		return data;
	}

	public String[] getTopics() {
		String[] students = new String[]{"Sade", "Alexus", "Sam", "Koma"};

		return students;
	}

}
