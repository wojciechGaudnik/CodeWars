package guess_the_number.kyu6;

public class Guesser {
	int number = 0;
	public void setAnswer(int i) {
		this.number = i;
	}

	public String guess(int i) {
		if (i == number) {
			return "Correct!";
		}
		return (i > number)?"Too high!":"Too low!";
	}
}
   
