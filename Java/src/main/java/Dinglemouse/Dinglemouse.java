package Dinglemouse;

import java.util.*;
import java.util.stream.Collectors;

public class Dinglemouse {

	public static List<String> oldLadySwallows(final List<String> animals) {
		Map<String, Integer> mapAnimals = new HashMap<>() {{
			put("fly", 0);
			put("spider", 1);
			put("bird", 2);
			put("cat", 3);
			put("dog", 4);
			put("goat", 5);
			put("cow", 6);
			put("horse", 7);
		}};
		Map<Integer, String> revAnimals = new HashMap<>() {{
			put(0, "fly");
			put(1, "spider");
			put(2, "bird");
			put(3, "cat");
			put(4, "dog");
			put(5, "goat");
			put(6, "cow");
			put(7, "horse");
		}};

		List<Integer> intAnimals = new ArrayList<>();
		for (String animal : animals) {
			if (animal.equals("horse")) {
				intAnimals.add(7);
				break;
			}
			intAnimals.add(mapAnimals.get(animal));
		}
		List<Integer> stomachInt = new ArrayList<>();
		for (int intAnimal : intAnimals) {
			if (stomachInt.contains(intAnimal - 1)) {
				stomachInt.removeAll(Collections.singleton((intAnimal - 1)));
			}
			if (!stomachInt.contains(intAnimal + 1)) {
				stomachInt.add(intAnimal);
			}
		}
		return stomachInt.stream().map(revAnimals::get).collect(Collectors.toList());
	}
}
