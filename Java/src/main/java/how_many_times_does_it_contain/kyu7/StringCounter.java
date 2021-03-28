package how_many_times_does_it_contain.kyu7;

public class StringCounter {

	public static int stringCounter(String inputS, char charS){
		return Math.toIntExact(inputS.chars().mapToObj(c -> (char) c).filter(c -> c.equals(charS)).count());
	}
}
