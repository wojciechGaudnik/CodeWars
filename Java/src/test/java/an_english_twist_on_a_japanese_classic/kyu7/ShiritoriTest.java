package an_english_twist_on_a_japanese_classic.kyu7;

import org.junit.*;
import java.util.*;
import static org.junit.Assert.assertEquals;;

public class ShiritoriTest {
	private Shiritori S;
	@Before
	public void Init()
	{
		S = new Shiritori();

	}

	@Test
	public void test1()
	{
		ArrayList<String> words = new ArrayList<String>(Arrays.asList("dog","goose","elephant","tiger","rhino","orc","cat"));
		List<String> expected = new ArrayList<String>(Arrays.asList("dog","goose"
				,"elephant","tiger","rhino","orc", "cat"));
		assertEquals(expected, S.theGame(words));

	}
	@Test
	public void test2()
	{

		ArrayList<String> words = new ArrayList<String>(Arrays.asList("dog","goose","tiger","cat", "elephant","rhino","orc"));
		List<String> expected = new ArrayList<String>(Arrays.asList("dog","goose"));
		assertEquals(expected, S.theGame(words));

	}
	@Test
	public void test3()
	{

		ArrayList<String> words = new ArrayList<String>(Arrays.asList("dog","goose","elephant","tiger","cat" ,"rhino","rhino","orc"));
		List<String> expected = new ArrayList<String>(Arrays.asList("dog","goose"
				,"elephant","tiger"));
		assertEquals(expected, S.theGame(words));

	}
	@Test
	public void TestEmpty()
	{
		ArrayList<String> words = new ArrayList<String>();
		assertEquals(new ArrayList<String>(), S.theGame(words));

	}
	@Test
	public void TestEStrings()
	{
		ArrayList<String> words = new ArrayList<String>(Arrays.asList("","","","","","",""));
		assertEquals(new ArrayList<String>(), S.theGame(words));
	}
	@Test
	public void TestMidEStrings()
	{
		ArrayList<String> words = new ArrayList<String>(Arrays.asList("ab","bc","","de","","",""));
		ArrayList<String> expected = new ArrayList<String>(Arrays.asList("ab","bc"));
		assertEquals(expected, S.theGame(words));
	}
}