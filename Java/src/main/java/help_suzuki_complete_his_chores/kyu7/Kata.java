package help_suzuki_complete_his_chores.kyu7;

import java.util.Arrays;

public class Kata {

	public static int[] choreAssignments(int[] chores) {
		Arrays.sort(chores);
		var answer = new int[chores.length / 2];
		for (int i = 0, j = chores.length - 1; i < j; i++, j--) {
			answer[i] = chores[i] + chores[j];
		}
		Arrays.sort(answer);
		return answer;
	}
}
