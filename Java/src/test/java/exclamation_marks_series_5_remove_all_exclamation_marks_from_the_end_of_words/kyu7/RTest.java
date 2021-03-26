package exclamation_marks_series_5_remove_all_exclamation_marks_from_the_end_of_words.kyu7;
import org.junit.Test;


import static org.junit.Assert.assertEquals;

class RTest {
	@Test
	public void testBasic() {
		assertEquals("nothing to do", R.removeBang("nothing to do"));
		assertEquals("should remove bangs from the end of words", "No seriously Seriously Wow", R.removeBang("No seriously! Seriously!! Wow"));
		assertEquals("should remove bangs from the end of words only", "!!No seriously !Seriously !!Wow", R.removeBang("!!No! seriously! !Seriously!! !!Wow!"));
	}
}