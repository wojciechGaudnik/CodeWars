package string_array_duplicates.kyu6;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;

class SolutionTest {
	@Test
	public void basicTests(){
		assertArrayEquals(new String[]{"codewars","picaniny","hubububo"},Solution.dup(new String[]{"ccooddddddewwwaaaaarrrrsssss","piccaninny","hubbubbubboo"}));
		assertArrayEquals(new String[]{"abracadabra","alote","asese"},Solution.dup(new String[]{"abracadabra","allottee","assessee"}));
		assertArrayEquals(new String[]{"keles","kenes"},Solution.dup(new String[]{"kelless","keenness"}));
	}
}