package JurassicWord;

import static org.junit.Assert.*;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class ExampleTest {
	static String scene1 = "_CVvvvVC}>";
	static String scene2 = "iiiuuVuuiii";
	static String scene5 = "|||uuVuu|||";

	@Test
	public void test1() {
		assertEquals("A T-Rex is eating a dead dino.", JurassicWord.lunchTime(scene1));
	}

	@Test
	public void test2() {
		assertEquals("A triceratops is eating flowers.", JurassicWord.lunchTime(scene2));
	}

	@Test
	public void test3() {
		assertEquals("Something is eating leaves.", JurassicWord.lunchTime(scene5));
	}
}