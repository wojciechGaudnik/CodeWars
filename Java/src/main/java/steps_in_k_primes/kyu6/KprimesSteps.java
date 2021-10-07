package steps_in_k_primes.kyu6;

import java.util.ArrayList;
import java.util.List;

class KprimesSteps {

	public static List<long[]> kprimesStep(int k, int step, long start, long end) {
		var answer = new ArrayList<long[]>();
		var list = kprimes(k, start, end);
		var iBuff = 1;
		for (var i = 0; i < list.length - 1; ) {
			if (list[i] + step == list[iBuff]) {
				answer.add(new long[]{list[i], list[iBuff]});
				i++;
				iBuff = i + 1;
			} else if (list[i] + step > list[iBuff] && iBuff + 1 < list.length) {
				iBuff++;
			} else {
				i++;
				iBuff = i + 1;
			}
		}
		return answer;
	}

	private static long[] kprimes(int k, long start, long end) {
		List<Long> result = new ArrayList<>();
		for (var i = start == 0 ? 2 : start; i <= end; i++) {
			var num = 0;
			var act = i;
			for (var j = 2; j <= act / j; j++) {
				while (act % j == 0) {
					num++;
					act /= j;
				}
			}
			if (act > 1) num++;
			if (num == k) result.add(i);
		}
		return result.stream().mapToLong(l -> l).toArray();
	}
}
