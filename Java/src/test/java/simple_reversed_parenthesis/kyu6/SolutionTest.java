package simple_reversed_parenthesis.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void basicTests(){
		assertEquals(2,Solution.solve(")()("));
		assertEquals(1,Solution.solve("((()"));
		assertEquals(-1,Solution.solve("((("));
		assertEquals(3,Solution.solve("())((("));
		assertEquals(4,Solution.solve("())()))))()()("));
		assertEquals(21,Solution.solve("(()))(((())))()(())()()()))())))(()()()(()()())))((()(()()(((()()))())())(())()())(()(()()(()())(())))(()(()())()))()(()(()(()((()()(()()))))))(()))())()())))((()(()()))(())((((((()((())()(()()))()))))()((())()))))()())))())))(()())())((()()))()((())()(((()))()((((((()()(((()))((())(())(((())()))()()))()())(())(())(()((()))()))))((((()((()((()))())(((())())()))()))))())(()((((())()))))()()(()))()((()((()(()(()((((((())())()()()))))()))))))()(()))()((((())()()()(())(()))))()))((())((())(()(())))(()(()(())))(()()()((()((()())(()((())()(()()())(((())((((())())(()))((()((())((()()(()()(()()))))(())())()())((())()))((((((()()((()(()(()()()))())())()((())())()())())()()()())(())))(((((()()()(((()((()))())((((()()(()()())(()(()()))())())()((()"));
	}

}