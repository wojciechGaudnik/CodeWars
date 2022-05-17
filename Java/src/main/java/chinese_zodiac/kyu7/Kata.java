package chinese_zodiac.kyu7;

public class Kata {

	public static String chineseZodiac(int year) {
		var animal = new String[]{"Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig"}[(year - 1924) % 12];
		var element = new String[]{"Wood", "Fire", "Earth", "Metal", "Water"}[((year - 1924) >> 1) % 5];
		return element + " " + animal;
	}

}