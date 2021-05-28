package string_task.kyu7;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class StringTaskTest {
	@Test
	public void perform() throws Exception {
		assertEquals( ".t.r", StringTask.perform( "tour" ) );
		assertEquals( ".c.d.w.r.s", StringTask.perform( "Codewars" ) );
		assertEquals( ".b.c.b", StringTask.perform( "aBAcAba" ) );
	}
}