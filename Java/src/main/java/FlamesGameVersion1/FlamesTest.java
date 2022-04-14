package FlamesGameVersion1;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class FlamesTest {
	@Test
	public void testSimpleFlames() throws Exception {
		assertEquals("NEIL and MAE are enemies",
				"Enemies", Flames.showRelationship("NEIL", "MAE"));
	}

	@Test
	public void testSimpleFlames1() throws Exception {
		assertEquals("JOE and ANN are enemies",
				"Siblings", Flames.showRelationship("JOE", "ANN"));
	}
}
