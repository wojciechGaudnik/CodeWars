package last_survivors_ep_3.kyu6;

import org.junit.jupiter.api.Test;

import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class KataTest {
	@Test
	void sample() {
		assertEquals("", sort(Kata.lastSurvivors(new String[]{" ", "z"}, new int[]{1})));
		assertEquals("a", sort(Kata.lastSurvivors(new String[]{"abc", "   ", " a "}, new int[]{0, 4, 1})));
		assertEquals("jj", sort(Kata.lastSurvivors(new String[]{"zj", "zj"}, new int[]{9,0})));
		assertEquals("", sort(Kata.lastSurvivors(new String[]{"d", " ", " ", " ", " "}, new int[]{1})));
		assertEquals("eeeiu", sort(Kata.lastSurvivors(new String[]{"help us we are dying"},
				                                                   new int[]{2,0,2,1,2,0,2,1,2,0,2,1,2,0,2,1,2,0,2,1})));
		assertEquals("ail", sort(Kata.lastSurvivors(new String[]{"to   ", "  tal", "it   ", "  ari", "an   ", "  ism"}, new int[]{7,6,4,2,1})));
		assertEquals("", sort(Kata.lastSurvivors(new String[]{" ", " "}, new int[]{0})));
	}

	@Test
	void emptyCases() {
		assertEquals("", sort(Kata.lastSurvivors(new String[]{}, new int[]{1,2,3,4})));
		assertEquals("", sort(Kata.lastSurvivors(new String[]{"", "", "", ""}, new int[]{})));
		assertEquals("", sort(Kata.lastSurvivors(new String[]{}, new int[]{1,2,3})));
	}

	@Test
	void newEdge() {
		assertEquals("bbdefhilnoqrrsuvvvwy", sort(Kata.lastSurvivors(
				new String[]{
						"w bby   n d  r   s v",
						" ff  i vd     s     ",
						" e   glv          s ",
						"ug k  ob  am   t   a",
						" pmalfiih hw     ku ",
						"oj   w    w  rbe n  ",
						"d   q   iq  i k    y",
						"jn     g xn  b      ",
						"     navd   w      q"
				},
				new int[]{2, 4, 4, 2, 1, 4, 7, 4, 2, 1, 7, 6, 7, 0, 2, 5, 0, 5, 6, 3})));
	}

	static private String sort(String s) {
		char[] chars = s.toCharArray();
		Arrays.sort(chars);
		return new String(chars);
	}
}