package BullsAndCows;

import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.Stream;

public class BullsAndCows {
	private int secretNumber;
	private boolean gameState = false;
	private int turns = 0;
	private int bulls = 0;
	private int cows = 0;

	public BullsAndCows(int n) {
		if (String.valueOf(n).chars().distinct().toArray().length != 4 || n < 1000 || n > 9999) {
			throw new IllegalArgumentException("The number sent to the constructor is invalid. You should throw IllegalArgumentException");
		}
		this.secretNumber = n;
	}

	public String compareWith(int n) {
		if (gameState) return "You already won!";
		if (turns > 7) return "Sorry, you're out of turns!";
		if (String.valueOf(n).chars().distinct().toArray().length != 4 || n < 1000 || n > 9999)
			throw new IllegalArgumentException();
		List<Integer> secretNumberList = String.valueOf(secretNumber).chars().boxed().collect(Collectors.toList());
		List<Integer> nNumberList = String.valueOf(n).chars().boxed().collect(Collectors.toList());
		for (int i = 0; i < 4; i++) {
			if (secretNumberList.get(i).equals(nNumberList.get(i))) {
				bulls++;
			}
		}
		if (bulls == 4) {
			gameState = true;
			return "You win!";
		}
		;
		cows = (int) Stream.concat(secretNumberList.stream(), nNumberList.stream()).count() - (int) Stream.concat(secretNumberList.stream(), nNumberList.stream()).distinct().count() - bulls;
		String answer = bulls +
				" bull" +
				((bulls != 1) ? "s and " : " and ") +
				cows +
				" cow" +
				((cows != 1) ? "s" : "");
		bulls = 0;
		cows = 0;
		turns++;
		return answer;
	}
}
