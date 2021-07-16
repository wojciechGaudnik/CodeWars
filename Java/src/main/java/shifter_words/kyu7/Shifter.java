package shifter_words.kyu7;

import java.util.Arrays;

public class Shifter {
	public static int count(String st){
		return (int) Arrays.stream(st.split(" "))
				.distinct()
				.filter(w -> !w.equals("") && w.replaceAll("[HINOSXZWM]", "").equals(""))
				.count();
	}

}
