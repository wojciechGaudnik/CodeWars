package _80_s_kids_5_you_can_t_do_that_on_television.kyu7;

import java.util.regex.Pattern;

class EightiesKids5 {
	public static String bucketOf(String said) {
		var water = Pattern.compile("water|wet|wash").matcher(said.toLowerCase()).find();
		var slime = Pattern.compile("slime|i don't know").matcher(said.toLowerCase()).find();
		if (water && slime) {
			return "sludge";
		}
		if (water) {
			return "water";
		}
		if (slime) {
			return "slime";
		}
		return "air";
	}
}
