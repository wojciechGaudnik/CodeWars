package help_suzuki_rake_his_garden.kyu7;

public class Kata {
	public static String rakeGarden(String garden){
		var answer = new StringBuilder();
		for (var one : garden.split(" ")) {
			if (one.equals("rock")) {
				answer.append("rock ");
			} else {
				answer.append("gravel ");
			}
		}
		return answer.toString().trim();
	}
}