package simple_string_reversal_II.kyu7;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals("cawedors", Solution.solve("codewars",1,5));
		assertEquals("conuFsIgnid", Solution.solve("codingIsFun",2,100));
		assertEquals("FuargorPlanoitcnmming", Solution.solve("FunctionalProgramming", 2,15));
		assertEquals("vutsrqponmlkjihgfecbawxyz", Solution.solve("abcefghijklmnopqrstuvwxyz",0,20));
		assertEquals("abcefvutsrqponmlkjihgwxyz", Solution.solve("abcefghijklmnopqrstuvwxyz",5,20));
	}
}