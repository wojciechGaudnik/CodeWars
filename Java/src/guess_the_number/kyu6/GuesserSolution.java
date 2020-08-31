package guess_the_number.kyu6;

public class GuesserSolution extends Guesser {

	public int getNumber() {
		var min = 0;
		var max = 1000;
		var number = 500;
		while (true) {
			var answer = guess(number);
			if (answer.equals("Correct!")) {
				return number;
			} else if (answer.equals("Too low!")) {
				min = number;
				number += (max - min) / 2;
			} else {
				max = number;
				number -= (max - min) / 2;
			}
		}
	}
}



