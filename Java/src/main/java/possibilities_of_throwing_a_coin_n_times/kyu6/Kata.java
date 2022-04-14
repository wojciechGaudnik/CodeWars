package possibilities_of_throwing_a_coin_n_times.kyu6;

import java.util.LinkedList;
import java.util.List;
import java.util.stream.Collectors;

public class Kata {

	public String[] coin(int n) {
		List<String> answer = new LinkedList<>();
		var start = (int) Math.pow(2, n + 1);
		var stop = (int) Math.pow(2, n);
		while (--start >= stop) {
			answer.add(Integer.toBinaryString(start).substring(1));
		}
		return answer.stream().map(s -> s.replace("1", "H").replace("0", "T")).collect(Collectors.toList()).toArray(new String[answer.size()]);
	}

}
