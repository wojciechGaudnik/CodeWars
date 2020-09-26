package floating_point_approximation_ii.kyu6

import org.junit.Test

import static groovy.util.GroovyTestCase.assertEquals

class ApproxInterTest {
    private static void testing(String actual, String expected) {
        assertEquals(expected, actual);
    }

    @Test
    public void test1() {
        testing(ApproxInter.interp({x -> x}, 0, 9.0, 4).toString(),
                "[0.0, 2.25, 4.5, 6.75]");
        testing(ApproxInter.interp({x -> x}, 0, 15.0, 9).toString(),
                "[0.0, 1.66, 3.33, 5.0, 6.66, 8.33, 10.0, 11.66, 13.33]");
    }
    @Test
    public void test2() {
        testing(ApproxInter.interp({x -> Math.sin(x)}, 0, 18.0, 12).toString(),
                "[0.0, 0.99, 0.14, -0.98, -0.28, 0.93, 0.41, -0.88, -0.54, 0.8, 0.65, -0.72]");
        testing(ApproxInter.interp({x -> Math.sin(x)}, 0, 21.0, 10).toString(),
                "[0.0, 0.86, -0.88, 0.01, 0.85, -0.88, 0.03, 0.84, -0.89, 0.05]");
    }
    @Test
    public void test3() {
        testing(ApproxInter.interp({x -> Math.cos(x)}, 0, 21.0, 7).toString(),
                "[1.0, -0.99, 0.96, -0.92, 0.84, -0.76, 0.66]");
        testing(ApproxInter.interp({x -> Math.cos(x)}, 0, 15.0, 12).toString(),
                "[1.0, 0.31, -0.81, -0.83, 0.28, 0.99, 0.34, -0.79, -0.84, 0.25, 0.99, 0.37]");
    }
}
