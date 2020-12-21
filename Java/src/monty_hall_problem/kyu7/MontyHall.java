package monty_hall_problem.kyu7;

import java.util.Arrays;

public class MontyHall {

	public int montyHallCase(int correctDoorNumber, int[] participantGuesses) {
		return (int)Math.round((Arrays.stream(participantGuesses).filter(n -> n != correctDoorNumber).count() * 100.0) / participantGuesses.length);
	}
}
