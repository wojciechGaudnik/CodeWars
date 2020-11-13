package JurassicWord;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class JurassicWord {
	static String T_Rex = "VvvvV.{3}$";
	static String brachiosaurus = "uuuuu.{3}$";
	static String velociraptor = "vvvvv.{3}$";
	static String triceratops = "uuVuu.{3}$";

	static String dead_dino = "_C.....C}>";
	static String flowers = "iii.....iii";
	static String leaves = "\\|\\|\\|.....\\|\\|\\|";

	public static String lunchTime (String scene) {
		Map<String, String> dishMap = new HashMap<>() {{
			put("dead dino", dead_dino);
			put("flowers", flowers);
			put("leaves", leaves);
		}};
		Map<String, String> animalMap = new HashMap<>() {{
			put("T-Rex", T_Rex);
			put("brachiosaurus", brachiosaurus);
			put("velociraptor", velociraptor);
			put("triceratops", triceratops);
		}};
		String dish = "something";
		String animal = "Something";
		for (Map.Entry<String, String> entryDish : dishMap.entrySet()) {
			Pattern pattern = Pattern.compile(entryDish.getValue());
			Matcher matcher = pattern.matcher(scene);
			if(matcher.find()) dish = entryDish.getKey();

		}
		for (Map.Entry<String, String> entryAnimal : animalMap.entrySet()) {
			Pattern pattern = Pattern.compile(entryAnimal.getValue());
			Matcher matcher = pattern.matcher(scene);
			if(matcher.find() && !matcher.find()) animal = entryAnimal.getKey();
		}
		if (!animal.equals("Something")) animal = "A " + animal;
		if (dish.equals("dead dino")) dish = "a " + dish;
		if (animal.equals("A T-Rex") && dish.equals("flowers")) animal = "Something";
		if (animal.equals("A T-Rex") && dish.equals("leaves")) animal = "Something";
		if (animal.equals("A triceratops") && dish.equals("a dead dino")) animal = "Something";
		if (animal.equals("A triceratops") && dish.equals("leaves")) animal = "Something";
		if (animal.equals("A velociraptor") && dish.equals("leaves")) animal = "Something";
		if (animal.equals("A velociraptor") && dish.equals("flowers")) animal = "Something";
		if (animal.equals("A brachiosaurus") && dish.equals("a dead dino")) animal = "Something";
		return animal + " is eating " + dish + ".";
	}
}