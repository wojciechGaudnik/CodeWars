package duplicates_duplicates_everywhere.kyu6;

import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class SolutionTest {
	@Test
	public void test() {
		assertEquals(Utils.createObject(new Object[]{1, new String[]{"C"}},
						new Object[]{2, new String[]{"A", "B", "D"}}),
				Solution.removeDuplicateIds(Utils.createObject(new Object[]{1, new String[]{"A", "B", "C"}},
						new Object[]{2, new String[]{"A", "B", "D", "A"}})));
		assertEquals(Utils.createObject(new Object[]{1, new String[]{"F", "G"}},
						new Object[]{2, new String[]{"C"}},
						new Object[]{3, new String[]{"A", "B", "D"}}),
				Solution.removeDuplicateIds(Utils.createObject(new Object[]{1, new String[]{"C", "F", "G"}},
						new Object[]{2, new String[]{"A", "B", "C"}},
						new Object[]{3, new String[]{"A", "B", "D"}})));
		assertEquals(Utils.createObject(new Object[]{1, new String[0]},
						new Object[]{2, new String[0]},
						new Object[]{3, new String[]{"A"}}),
				Solution.removeDuplicateIds(Utils.createObject(new Object[]{1, new String[]{"A"}},
						new Object[]{2, new String[]{"A"}},
						new Object[]{3, new String[]{"A"}})));
		assertEquals(Utils.createObject(new Object[]{432, new String[]{"A", "B", "D"}},
						new Object[]{53, new String[]{"C"}},
						new Object[]{236, new String[]{"L", "X", "G", "H"}},
						new Object[]{11, new String[]{"P", "R", "S"}}),
				Solution.removeDuplicateIds(Utils.createObject(new Object[]{432, new String[]{"A", "A", "B", "D"}},
						new Object[]{53, new String[]{"L", "G", "B", "C"}},
						new Object[]{236, new String[]{"L", "A", "X", "G", "H", "X"}},
						new Object[]{11, new String[]{"P", "R", "S", "D"}})));
	}
}