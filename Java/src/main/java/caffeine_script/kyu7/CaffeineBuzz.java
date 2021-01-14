package caffeine_script.kyu7;

public class CaffeineBuzz {

	public static String caffeineBuzz(int n){
		var answer = "mocha_missing!";
		if (n % 3 == 0) {
			answer = "Java";
		}
		if (n % 4 == 0 && answer.length() == 4) {
			answer = "Coffee";
		}
		if ((answer.length() == 4 || answer.length() == 6) && n % 2 == 0){
			answer += "Script";
		}
		return answer;
	}
}
   
