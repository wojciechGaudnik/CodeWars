package Rotator;

import java.util.Arrays;
import java.util.Collections;

public class Rotator {

	public static void main(String[] args) {
		Rotator rotator = new Rotator();
		System.out.println(Arrays.toString(rotator.rotate(new Object[]{1, 2, 3, 4, 5}, 1)));
	}

	public Object[] rotate(Object[] data, int n) {
		Collections.rotate(Arrays.asList(data), n % data.length);
		return data;
	}

	public String[] getTopics(){
		String[] students = new String[]{"Sade", "Alexus", "Sam", "Koma"};

		return students;
	}

}
