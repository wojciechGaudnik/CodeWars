package a0_my_katas;

import java.time.ZoneId;
import java.time.ZonedDateTime;
import java.time.format.DateTimeFormatter;

public class TimeWhereverIgo {

	static private DateTimeFormatter FORMATTER_IN = DateTimeFormatter.ofPattern("dd-MM-yyyy HH:mm VV");
	static private DateTimeFormatter FORMATTER_OUT = DateTimeFormatter.ofPattern("dd-MM-yyyy HH:mm");

	static public String getFriendDateAndTime(String myTime, String myZone, String friendZone) {
		var myZoneId = ZoneId.of(myZone);
		var myFriendZoneId = ZoneId.of(friendZone);
		var myDateTime = ZonedDateTime.parse(myTime + " " + myZone, FORMATTER_IN).withZoneSameLocal(myZoneId);
		var friendDateTime = myDateTime.withZoneSameInstant(myFriendZoneId);
		return friendDateTime.format(FORMATTER_OUT);
	}

	static public String description() {
		return "<h1>Background</h2>\n" +
				"Your task is very simple, I need to know if I can ring up my friend or not, I travel a lot and my friends too. So I will give you my local date and time also where I'm and where is my friend. Your task is to give mi date and time where he is. \n" +
				"<br><br>\n" +
				"<h1>Kata task</h2>\n" +
				"What is the date and time where my friend is?\n" +
				"<br><br>\n" +
				"<h1>Notes</h2>\n" +
				"<li>the input format of date and time is \"dd-MM-yyyy HH:mm\", 23h clock</li>\n" +
				"<li>input zones from <a href=\"https://en.wikipedia.org/wiki/List_of_tz_database_time_zones\">Zones </a></li>\n" +
				"<li>the output format of date and time is \"dd-MM-yyyy HH:mm\"</li>\n" +
				"<li> min date 1969-01-01 </li>\n" +
				"<li> max date 2999-01-01 </li>\n" +
				"<br><br>\n" +
				"<h1>Example</h2>\n" +
				"my date and time is 26-03-2021 19:41 and a live-in Europe/Warsaw, my friend right now is in Africa/Asmera so his current data and time is: 27-03-2021 21:41\n" +
				"Good Luck !";
	}
}
