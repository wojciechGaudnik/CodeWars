package phone_directory.kyu5;

import java.util.HashMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class PhoneDir {

	public static void main(String[] args) {
		var s = "/+1-541-754-3010 156 Alphand_St. <J Steeve>\n 133, Green, Rd. <E Kustur> NY-56423 ;+1-541-914-3010!";
		var ss = "/+1-541-754-3010 156 Alphand_St. <J Steeve>\n 133, Green, Rd. <E Kustur> NY-56423 ;+1-541-914-3010!\n /+1-541-754-3010 156 Alphand_St. <J Steeve>\n/+1-541-754-3010 156 Alphand_St. <J Steeve>\n 133, Green, Rd. <E Kustur> NY-56423 ;+1-541-914-3010!\n /+1-541-754-3010 156 Alphand_St. <J Steeve>\n";
		var b = " ";
		var n = "1-541-754-3010";
		String dr = "/+1-541-754-3010 156 Alphand_St. <J Steeve>\n 133, Green, Rd. <E Kustur> NY-56423 ;+1-541-914-3010\n"
				+ "+1-541-984-3012 <P Reed> /PO Box 530; Pollocksville, NC-28573\n :+1-321-512-2222 <Paul Dive> Sequoia Alley PQ-67209\n"
				+ "+1-741-984-3090 <Peter Reedgrave> _Chicago\n :+1-921-333-2222 <Anna Stevens> Haramburu_Street AA-67209\n"
				+ "+1-111-544-8973 <Peter Pan> LA\n +1-921-512-2222 <Wilfrid Stevens> Wild Street AA-67209\n"
				+ "<Peter Gone> LA ?+1-121-544-8974 \n <R Steell> Quora Street AB-47209 +1-481-512-2222\n"
				+ "<Arthur Clarke> San Antonio $+1-121-504-8974 TT-45120\n <Ray Chandler> Teliman Pk. !+1-681-512-2222! AB-47209,\n"
				+ "<Sophia Loren> +1-421-674-8974 Bern TP-46017\n <Peter O'Brien> High Street +1-908-512-2222; CC-47209\n"
				+ "<Anastasia> +48-421-674-8974 Via Quirinal Roma\n <P Salinger> Main Street, +1-098-512-2222, Denver\n"
				+ "<C Powel> *+19-421-674-8974 Chateau des Fosses Strasbourg F-68000\n <Bernard Deltheil> +1-498-512-2222; Mount Av.  Eldorado\n"
				+ "+1-099-500-8000 <Peter Crush> Labrador Bd.\n +1-931-512-4855 <William Saurin> Bison Street CQ-23071\n"
				+ "<P Salinge> Main Street, +1-098-512-2222, Denve\n"+ "<P Salinge> Main Street, +1-098-512-2222, Denve\n";

		var dd = "/+1-541-754-3010 156 Alphand_St. <J Steeve>\n" +
				" 133, Green, Rd. <E Kustur> NY-56423 ;+1-541-914-3010\n" +
				"+1-541-984-3012 <P Reed> /PO Box 530; Pollocksville, NC-28573\n" +
				" :+1-321-512-2222 <Paul Dive> Sequoia Alley PQ-67209\n" +
				"+1-741-984-3090 <Peter Reedgrave> _Chicago\n" +
				" :+1-921-333-2222 <Anna Stevens> Haramburu_Street AA-67209\n" +
				"+1-111-544-8973 <Peter Pan> LA\n" +
				" +1-921-512-2222 <Wilfrid Stevens> Wild Street AA-67209\n" +
				"<Peter Gone> LA ?+1-121-544-8974 \n" +
				" <R Steell> Quora Street AB-47209 +1-481-512-2222\n" +
				"<Arthur Clarke> San Antonio $+1-121-504-8974 TT-45120\n" +
				" <Ray Chandler> Teliman Pk. !+1-681-512-2222! AB-47209,\n" +
				"<Sophia Loren> +1-421-674-8974 Bern TP-46017\n" +
				" <Peter O'Brien> High Street +1-908-512-2222; CC-47209\n" +
				"<Anastasia> +48-421-674-8974 Via Quirinal Roma\n" +
				" <P Salinger> Main Street, +1-098-512-2222, Denver\n" +
				"<C Powel> *+19-421-674-8974 Chateau des Fosses Strasbourg F-68000\n" +
				" <Bernard Deltheil> +1-498-512-2222; Mount Av.  Eldorado\n" +
				"+1-099-500-8000 <Peter Crush> Labrador Bd.\n" +
				" +1-931-512-4855 <William Saurin> Bison Street CQ-23071\n" +
				"<P Salinge> Main Street, +1-098-512-2222, Denve\n" +
				"<P Salinge> Main Street, +1-098-512-2222, Denve\n" +
				"/+5-541-754-3010 156 Alphandria_Street. <Jr Part>\n" +
				" 1333, Green, Road <F Fulgur> NW-46423 ;+6-541-914-3010!\n" +
				"+5-541-984-3012 <Peter Reeves> /PO Box 5300; Albertville, SC-28573\n" +
				" :+5-321-512-2222 <Paulo Divino> Boulder Alley ZQ-87209\n" +
				"+3-741-984-3090 <F Flanaghan> _Chicago Av.\n" +
				" :+3-921-333-2222 <Roland Scorsini> Bellevue_Street DA-67209\n" +
				"+8-111-544-8973 <Laurence Pantow> SA\n" +
				" +8-921-512-2222 <Raymond Stevenson> Joly Street EE-67209\n" +
				"<John Freeland> Mantow ?+2-121-544-8974 \n" +
				" <Robert Mitch> Eleonore Street QB-87209 +2-481-512-2222?\n" +
				"<Arthur Paternos> San Antonio $+7-121-504-8974 TT-45121\n" +
				" <Ray Charles> Stevenson Pk. !+7-681-512-2222! CB-47209,\n" +
				"<JP Gorce> +9-421-674-8974 New-Bern TP-16017\n" +
				" <P McDon> Revolution Street +2-908-512-2222; PP-47209\n" +
				"<Elizabeth Corber> +8-421-674-8974 Via Papa Roma\n" +
				" <C Saborn> Main Street, +15-098-512-2222, Boulder\n" +
				"<Colin Marshall> *+9-421-674-8974 Edinburgh UK\n" +
				" <Bernard Povit> +3-498-512-2222; Hill Av.  Cameron\n" +
				"+12-099-500-8000 <Pete Highman> Ontario Bd.\n" +
				" +8-931-512-4855 <W Mount> Oxford Street CQ-23071\n" +
				"<Donald Drinkaw> Moon Street, +3-098-512-2222, Peterville";
		System.out.println(phone(dd, "5-321-512-2222"));

	}


	public static  String phone(String strng, String num) {
		var allNumbers = new HashMap<String, String>();
		String pattern = "\\d{1,2}-\\d{3}-\\d{3}-\\d{4}";
		Pattern numberPattern = Pattern.compile(pattern);

		for (var line : strng.split("\n")) {
			Matcher numberMatch = numberPattern.matcher(line);
			if (numberMatch.find()) {
				var number = numberMatch.group(0);
				if (allNumbers.containsKey(number) && number.equals(num)) return "Error => Too many people: " + num;
				else allNumbers.put(number, line);
			}
		}
		if (!allNumbers.containsKey(num)) return "Error => Not found: " + num;
		else return new JohnFriend(allNumbers.get(num)).toString();
	}
}

class JohnFriend {
	private String phone;
	private String name;
	private String address;

	public JohnFriend(String line) {
		String pattern = "\\d{1,2}-\\d{3}-\\d{3}-\\d{4}";
		Pattern numberPattern = Pattern.compile(pattern);
		Matcher numberMatch = numberPattern.matcher(line);
		if (numberMatch.find()) phone = numberMatch.group(0);
		line = line.replaceAll(pattern, "");

		pattern = "<.*>";
		Pattern namePattern = Pattern.compile(pattern);
		Matcher nameMatch = namePattern.matcher(line);
		if (nameMatch.find()) name = nameMatch.group(0).replaceAll("[<>]" ,"");
		line = line.replaceAll(pattern, "");

		line = line.trim().replaceAll("[\\+;:!/$,\\*\\?]", "").trim();
		address = line.trim().replaceAll("[\\s_]+", " ").trim();
	}

	@Override
	public String toString() {
		return "Phone => " + phone + ", " +
				"Name => " + name + ", " +
				"Address => " + address;
	}
}
   
