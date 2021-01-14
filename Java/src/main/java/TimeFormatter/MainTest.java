package TimeFormatter;//import org.junit.jupiter.api.Test;

//import static org.junit.jupiter.api.Assertions.assertEquals;
//import static org.junit.jupiter.api.Assertions.assertEquals;
//import org.junit.Test;
//import static org.junit.Assert.assertEquals;
//import org.junit.runners.JUnit4;

import TimeFormatter.TimeFormatter;
import org.junit.Test;
import static org.junit.Assert.assertEquals;


public class MainTest {

	@Test
	public void basicTests() {
		assertEquals("twenty-eight minutes past five", TimeFormatter.toHumanTime("05:28 pm"));
		assertEquals("twelve o'clock", TimeFormatter.toHumanTime("12:00"));
		assertEquals("quarter to four", TimeFormatter.toHumanTime("03:45am"));
		assertEquals("quarter past seven", TimeFormatter.toHumanTime("07:15"));
		assertEquals("half past eleven", TimeFormatter.toHumanTime("23:30"));
		assertEquals("one minute past twelve", TimeFormatter.toHumanTime("00:01"));
		assertEquals("nine minutes to six", TimeFormatter.toHumanTime("17:51"));
	}

	@Test
	public  void myTests(){
		assertEquals("half past twelve", TimeFormatter.toHumanTime("00:30"));
		assertEquals("quarter to twelve", TimeFormatter.toHumanTime("11:45am"));
		assertEquals("quarter to one", TimeFormatter.toHumanTime("12:45am"));
		assertEquals("quarter to twelve", TimeFormatter.toHumanTime("23:45"));
		assertEquals("quarter past twelve", TimeFormatter.toHumanTime("00:15"));
		assertEquals("one minute to four", TimeFormatter.toHumanTime("03:59"));
		assertEquals("one minute to twelve", TimeFormatter.toHumanTime("23:59"));
		assertEquals("fourteen minutes past three", TimeFormatter.toHumanTime("03:14"));
		assertEquals("one minute to four", TimeFormatter.toHumanTime("03:59"));
		assertEquals("twenty minutes to four", TimeFormatter.toHumanTime("03:40"));
		assertEquals("twenty minutes to twelve", TimeFormatter.toHumanTime("23:40"));
		assertEquals("twenty-nine minutes to twelve", TimeFormatter.toHumanTime("23:31"));
	}
}