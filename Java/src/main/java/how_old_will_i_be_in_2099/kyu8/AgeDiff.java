package how_old_will_i_be_in_2099.kyu8;

public class AgeDiff {
	public static String CalculateAge(int birth, int yearTo) {
		if (birth == yearTo) {
			return "You were born this very year!";
		}
		var s = (Math.abs(birth - yearTo) > 1) ? "s" : "";
		return (birth > yearTo) ?
				"You will be born in " + (birth - yearTo) + " year" + s +"." :
				"You are " + (yearTo - birth) + " year" + s + " old.";

	}
}

