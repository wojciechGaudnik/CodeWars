package make_a_window.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void fixedTest() {
		//n =1
		assertEquals("-----\n|.|.|\n|-+-|\n|.|.|\n-----",Solution.makeAWindow(1));
		//n =3
		assertEquals("---------\n|...|...|\n|...|...|\n|...|...|\n|---+---|\n|...|...|\n|...|...|\n|...|...|\n---------",Solution.makeAWindow(3));
	}
}