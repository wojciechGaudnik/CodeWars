package zebulan_s_nightmare.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class ZebulansNightmareTest {
	@Test
	public void basicTest() {
		assertEquals("camelCase", ZebulansNightmare.zebulansNightmare("camel_case"));
		assertEquals("zebulansNightmare", ZebulansNightmare.zebulansNightmare("zebulans_nightmare"));
		assertEquals("markAsIssue", ZebulansNightmare.zebulansNightmare("mark_as_issue"));
		assertEquals("copyPastePep8", ZebulansNightmare.zebulansNightmare("copy_paste_pep8"));
		assertEquals("gotoNextKata", ZebulansNightmare.zebulansNightmare("goto_next_kata"));
		assertEquals("repeat", ZebulansNightmare.zebulansNightmare("repeat"));
		assertEquals("trollingIsFun", ZebulansNightmare.zebulansNightmare("trolling_is_fun"));
		assertEquals("why", ZebulansNightmare.zebulansNightmare("why"));
		assertEquals("123AbcDef", ZebulansNightmare.zebulansNightmare("123_abc_def"));
		assertEquals("", ZebulansNightmare.zebulansNightmare(""));
	}
}