package drying_potatoes.kyu7

import org.junit.Test

import static groovy.util.GroovyTestCase.assertEquals

class PotatoesTest {
    private static void dotest(int p0, int w0, int p1, int expected) {
        assertEquals(expected, Potatoes.potatoes(p0, w0, p1));
    }

    @Test
    void test() {
        dotest(82, 127, 80, 114);
        dotest(93, 129, 91, 100);
    }
}
