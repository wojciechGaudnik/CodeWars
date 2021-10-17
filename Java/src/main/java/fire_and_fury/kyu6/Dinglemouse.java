package fire_and_fury.kyu6;

import java.util.regex.Pattern;

class Dinglemouse {

	public static String fireAndFury(final String tweet) {
		var cleanTweet = getCleanTweet(tweet);
		if (cleanTweet.contains("X")) {
			return "Fake tweet.";
		}
		var clearTweet = clearTweet(cleanTweet);
		if (clearTweet.length() == 0) {
			return "Fake tweet.";
		}
		return clearTweet.substring(0, clearTweet.length() - 1);
	}

	private static StringBuilder clearTweet(String cleanTweet) {
		var clearTweet = new StringBuilder();
		var matcher = Pattern.compile("(FIRE|FURY)").matcher(cleanTweet);
		while (matcher.find()) {
			clearTweet.append(matcher.group());
		}
		var matcherMulti = Pattern.compile("((FIRE)+|(FURY)+)").matcher(clearTweet);
		var answer = new StringBuilder();
		while (matcherMulti.find()) {
			if (matcherMulti.group().contains("FIRE")) {
				answer.append(fire(matcherMulti.group().length() / 4));
			} else if (matcherMulti.group().contains("FURY")) {
				answer.append(fury(matcherMulti.group().length() / 4));
			}
		}
		return answer;
	}

	private static String getCleanTweet(String tweet) {
		return tweet
				.replaceAll("RY+", "RY")
				.replaceAll("Y{2,}", "")
				.replaceAll("[^FIREUY]", "X");
	}

	private static String fire(int n) {
		var answer = new StringBuilder();
		answer.append("You ");
		if (n > 1) {
			answer.append("and you ".repeat(n - 1));
		}
		return answer.append("are fired! ").toString();
	}

	private static String fury(int n) {
		var answer = new StringBuilder();
		answer.append("I am ");
		if (n > 1) {
			answer.append("really ".repeat(n - 1));
		}
		return answer.append("furious. ").toString();
	}
}
