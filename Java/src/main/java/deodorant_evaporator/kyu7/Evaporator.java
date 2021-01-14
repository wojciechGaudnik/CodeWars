package deodorant_evaporator.kyu7;

public class Evaporator {

	public static int evaporator(double content, double evapPerDay, double threshold) {
		var answer = 0;
		var min = content * (threshold * 0.01);
		while (content > min) {
			content = content - content * (evapPerDay * 0.01);
			answer++;
		}
		return answer;
	}
}
