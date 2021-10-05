package last_survivors_ep_2.kyu6;

class Kata {
	public static String lastSurvivors(String str) {
		var alphabet = "abcdefghijklmnopqrstuvwxyz";
		var i = 0;
		for (i = 0; i < str.length(); i++) {
			var actualChar = str.charAt(i);
			if (str.chars().filter(c -> c == actualChar).count() >= 2) {
				var nextChar = (char) (actualChar + 1);
				if (actualChar == 'z') {
					nextChar = 'a';
				}
				str = str.replaceFirst(String.valueOf(actualChar), String.valueOf(nextChar));
				str = str.replaceFirst(String.valueOf(actualChar), "");
				i = -1;
			}
		}
		var answer = new StringBuilder();
		for (var j = 0; j < alphabet.length(); j++) {
			if (str.contains(String.valueOf(alphabet.charAt(j)))) {
				answer.append(alphabet.charAt(j));
			}
		}
		return answer.toString();
	}

}
