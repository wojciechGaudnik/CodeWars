package snail_crawls_up.kyu7;

public class Kata {

	public static int snail(int column, int day, int night) {
		int answer = 1;
		int high = day;
		while (high < column) {
			high += day - night;
			answer++;
		}
		return answer;
	}
}
