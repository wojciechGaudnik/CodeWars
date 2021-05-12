package all_star_code_challenge_22.kyu7;

public class TimeConverter{
	public static String toTime(int seconds){
		return (seconds / 3600) + " hour(s) and " + ((seconds % 3600) / 60) + " minute(s)";
	}
}
