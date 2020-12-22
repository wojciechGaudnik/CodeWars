package how_far_will_I_go.kyu7;

public class Kata {

	public static int travel(int totalTime, int runTime, int restTime, int speed) {
		var answer = 0;
		while (totalTime > runTime) {
			answer += runTime * speed;
			totalTime -= (runTime + restTime);
		}
		if (totalTime > 0) return answer + speed * totalTime;
		return answer ;
	}
}
