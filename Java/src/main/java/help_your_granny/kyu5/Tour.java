package help_your_granny.kyu5;

import java.util.Arrays;
import java.util.Map;
import java.util.stream.Collectors;

public class Tour {

	public static int tour(String[] arrFriends, String[][] ftwns, Map<String, Double> h) {
		double answer = 0;
		var friendsArr = Arrays.stream(arrFriends)
				.filter(f -> Arrays.stream(ftwns)
						.anyMatch(t -> t[0].equals(f)))
				.collect(Collectors.toList());

		var secondTown = 0.0;
		var firstTown = 0.0;

		for (var i = 0; i < friendsArr.size() - 1; i++) {
			int finalI = i;
			firstTown = Arrays.stream(ftwns)
					.filter(e -> e[0].equals(friendsArr.get(finalI)))
					.map(e -> e[1]).map(h::get)
					.findFirst()
					.get();
			secondTown = Arrays.stream(ftwns)
					.filter(e -> e[0].equals(friendsArr.get(finalI + 1)))
					.map(e -> e[1]).map(h::get)
					.findFirst()
					.get();
			answer += Math.sqrt(Math.pow(Math.max(firstTown, secondTown), 2) - Math.pow(Math.min(firstTown, secondTown), 2));
			if (i == 0) answer += firstTown;
		}
		answer += secondTown;
		return (int) answer;
	}
}
   
