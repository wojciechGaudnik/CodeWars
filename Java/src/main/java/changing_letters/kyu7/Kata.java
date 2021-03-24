package changing_letters.kyu7;

import java.util.stream.Collectors;

public class Kata {
	public static void main(String[] args) {
		System.out.println(swap("HelloWorld!"));
	}
	public static String swap(String st){
		return st.chars()
				.mapToObj(e -> (char) e)
				.map(e -> ("aeiouAEIOU".indexOf(e) >= 0 ? Character.toUpperCase(e) : e))
				.map(String::valueOf)
				.collect(Collectors.joining());
	}
}
