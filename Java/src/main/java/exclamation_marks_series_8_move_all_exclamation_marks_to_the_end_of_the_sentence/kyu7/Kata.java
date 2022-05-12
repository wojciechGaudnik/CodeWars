package exclamation_marks_series_8_move_all_exclamation_marks_to_the_end_of_the_sentence.kyu7;

public class Kata {

	public static String remove(String s){
		var exclamations = s.chars().filter(c -> c == '!').count();
		s = s.replace("!", "");
		return s + "!".repeat(Math.toIntExact(exclamations));
	}
}