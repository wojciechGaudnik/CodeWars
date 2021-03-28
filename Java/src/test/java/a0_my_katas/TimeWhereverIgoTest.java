package a0_my_katas;

import org.junit.Test;

import java.time.Instant;
import java.time.LocalDateTime;
import java.time.ZoneId;
import java.time.ZoneOffset;
import java.time.ZonedDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.concurrent.ThreadLocalRandom;

import static org.junit.Assert.assertEquals;


public class TimeWhereverIgoTest {

	private static void testing(String myTime, String myZone, String friendZone, String friendTime) {
		var expected = friendTime;
		var actual = TimeWhereverIgo.getFriendDateAndTime(myTime, myZone, friendZone);
		assertEquals("Actual date time is: " + actual + " should be: " + expected, expected, actual);
	}

	@Test
	public void test1() {
		testing("27-03-2021 19:41", "Europe/Warsaw", "Africa/Asmera", "27-03-2021 21:41");
		testing("27-03-2021 19:41", "Europe/Warsaw", "Australia/Sydney", "28-03-2021 05:41");
		testing("28-03-2021 19:41", "Australia/Sydney", "Europe/Warsaw", "28-03-2021 10:41");
		testing("19-03-2021 01:01", "America/Halifax", "Asia/Makassar", "19-03-2021 12:01");
		testing("01-12-2021 00:00", "Europe/Dublin", "Europe/Belfast", "01-12-2021 00:00");
		testing("07-12-2021 23:59", "Pacific/Fiji", "Europe/Berlin", "07-12-2021 11:59");

	}

	@Test
	public void test2() {
		for (var i = 0; i < 1000; i++) {
			var myTime = getRandomDateTime();
			var myZone = getRandomZone();
			var friendZone = getRandomZone();
			var actual = TimeWhereverIgo.getFriendDateAndTime(myTime, myZone, friendZone);
			var expected = getFriendDateAndTime(myTime, myZone, friendZone);
			assertEquals("Actual date time is: " + actual + " should be: " + expected, expected, actual);
		}
	}


	static private DateTimeFormatter FORMATTER_IN = DateTimeFormatter.ofPattern("dd-MM-yyyy HH:mm VV");
	static private DateTimeFormatter FORMATTER_OUT = DateTimeFormatter.ofPattern("dd-MM-yyyy HH:mm");

	static public String getFriendDateAndTime(String myTime, String myZone, String friendZone) {
		var myZoneId = ZoneId.of(myZone);
		var myFriendZoneId = ZoneId.of(friendZone);
		var myDateTime = ZonedDateTime.parse(myTime + " " + myZone, FORMATTER_IN).withZoneSameLocal(myZoneId);
		var friendDateTime = myDateTime.withZoneSameInstant(myFriendZoneId);
		return friendDateTime.format(FORMATTER_OUT);
	}

	static public String getRandomDateTime() {
		var startSeconds = Instant.ofEpochSecond(0);
		var endSeconds = Instant.ofEpochSecond(LocalDateTime.of(3000, 1, 1, 0, 0, 0).toEpochSecond(ZoneOffset.UTC));
		var random = ThreadLocalRandom.current().nextLong(startSeconds.getEpochSecond(), endSeconds.getEpochSecond());
		return Instant.ofEpochSecond(random).atZone(ZoneId.systemDefault()).format(FORMATTER_OUT);
	}

	static public String getRandomZone() {
		return new ArrayList<>(ZoneId.getAvailableZoneIds()).get((int) (Math.random() * (ZoneId.getAvailableZoneIds().size())));
	}

}
