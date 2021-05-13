package the_office_IV_find_a_meeting_room.kyu7;

import java.util.stream.IntStream;

public class TheOffice {
	public static Object meeting(char[] x) {
		var answer = IntStream.range(0, x.length).filter(e -> x[e] == 'O').findFirst();
		System.out.println(answer);
		if (answer.isPresent()) {
			return answer.getAsInt();
		}
		return "None available!";
	}
}
