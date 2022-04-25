package remove_consecutive_duplicate_words.kyu7;

public class Kata {

	public static String removeConsecutiveDuplicates(String s){
		var answer = new StringBuilder();
		var actualWorld = "";
		for (var one: s.split(" ")){
			if (!actualWorld.equals(one)) {
				answer.append(one).append(" ");
				actualWorld = one;
			}
		}
		return answer.toString().trim();
	}
}