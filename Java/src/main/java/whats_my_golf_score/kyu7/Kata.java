package whats_my_golf_score.kyu7;

public class Kata {
	public static int golfScoreCalculator(String parList, String scoreList) {
		var answer = 0;
		for (var i = 0; i < scoreList.length(); i++) {
			answer += Integer.parseInt(String.valueOf(scoreList.charAt(i))) - Integer.parseInt(String.valueOf(parList.charAt(i)));
		}
		return answer;
	}
}
