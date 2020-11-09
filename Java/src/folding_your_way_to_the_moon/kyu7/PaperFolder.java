package folding_your_way_to_the_moon.kyu7;

public class PaperFolder {

	public static Long fold(Double distance) {
		Double paper = 0.0001;
		Long step = 0L;
		if (distance < 0) return null;
		while (paper < distance) {
			paper = paper * 2;
			step += 1;
		}
		return step;
	}
}
   
