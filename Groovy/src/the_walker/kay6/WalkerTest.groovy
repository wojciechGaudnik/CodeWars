package the_walker.kay6

import org.junit.Test

import static groovy.util.GroovyTestCase.assertEquals

class WalkerTest {
    private static void dotest(int a, int b, int c, int alpha, int beta, int gamma, String expect) {
        String actual = Arrays.toString(Walker.solve(a, b, c, alpha, beta, gamma));
        assertEquals(expect, actual);
    }
    @Test
    public void test() {
        dotest(12, 20, 18, 45, 30, 60, "[15, 135, 49, 18]");
        dotest(15,15,19,50,29,55, "[12, 133, 18, 44]");
        dotest(14,25,17,41,35,59, "[20, 129, 41, 57]");

    }
}
