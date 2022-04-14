package Pyramid;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

import org.junit.runners.JUnit4;

public class SolutionTest {
	@Test
	public void basicTest2() {
		String characters = "*#";
		String expectedWatchFromSide =
				" # \n" +
						"***";
		String expectedWatchFromAbove =
				"***\n" +
						"*#*\n" +
						"***";
		String actualWatchFromSide = Pyramid.watchPyramidFromTheSide(characters);
		String actualWatchFromAbove = Pyramid.watchPyramidFromAbove(characters);
		visualisation(expectedWatchFromSide, expectedWatchFromAbove, actualWatchFromSide, actualWatchFromAbove);
		assertEquals(9, Pyramid.countVisibleCharactersOfThePyramid(characters));
		assertEquals(10, Pyramid.countAllCharactersOfThePyramid(characters));
	}

	@Test
	public void basicTest3() {
		String characters = "abc";
		String expectedWatchFromSide =
				"  c  \n" +
						" bbb \n" +
						"aaaaa";
		String expectedWatchFromAbove =
				"aaaaa\n" +
						"abbba\n" +
						"abcba\n" +
						"abbba\n" +
						"aaaaa";
		String actualWatchFromSide = Pyramid.watchPyramidFromTheSide(characters);
		String actualWatchFromAbove = Pyramid.watchPyramidFromAbove(characters);
		visualisation(expectedWatchFromSide, expectedWatchFromAbove, actualWatchFromSide, actualWatchFromAbove);
		assertEquals(25, Pyramid.countVisibleCharactersOfThePyramid(characters));
		assertEquals(35, Pyramid.countAllCharactersOfThePyramid(characters));
	}

	private void visualisation(String expectedWatchFromSide, String expectedWatchFromAbove, String actualWatchFromSide, String actualWatchFromAbove) {
		System.out.println("From side correct:\n" + expectedWatchFromSide);
		System.out.println("From above correct:\n" + expectedWatchFromAbove);
		System.out.println("From side yours:\n" + actualWatchFromSide);
		System.out.println("From above yours:\n" + actualWatchFromAbove);
		assertEquals(expectedWatchFromSide, actualWatchFromSide);
		assertEquals(expectedWatchFromAbove, actualWatchFromAbove);
	}
}