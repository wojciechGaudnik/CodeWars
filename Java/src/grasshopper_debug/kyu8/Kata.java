package grasshopper_debug.kyu8;

public class Kata {
	public static String tripleTrouble(String one, String two, String three) {
		StringBuilder answer = new StringBuilder();
		for (int i = 0; i < one.length(); i++) {
			answer.append(one.charAt(i)).append(two.charAt(i)).append(three.charAt(i));
		}
		return answer.toString();
	}
}
   
