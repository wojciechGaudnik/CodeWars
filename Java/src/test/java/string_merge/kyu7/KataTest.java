package string_merge.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.Assert.assertEquals;

public class KataTest {
	@Test
	public void test1(){
		assertEquals("pere", Kata.stringMerge("person","here", 'e'));
	}
	@Test
	public void test2(){
		assertEquals("apowiejouh", Kata.stringMerge("apowiejfoiajsf","iwahfeijouh", 'j'));
	}
	@Test
	public void test3(){
		assertEquals("abcdefxxxyyyxyzz", Kata.stringMerge("abcdefxxxyzz","abcxxxyyyxyzz", 'x'));
	}
}