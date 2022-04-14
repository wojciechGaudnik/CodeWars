package hndshake_problem.kyu6;

public class Kata {

	public static int GetParticipants(int handshakes) {
		System.out.println(handshakes);
		var people = 1;
		var calculateHandshakes = 0;
		while (calculateHandshakes < handshakes) {
			people++;
			calculateHandshakes = (people * (people - 1)) / 2;
		}
		return people;
	}

}
