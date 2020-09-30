package stacked_balls_2D.kyu7

import org.junit.Test

import static org.junit.Assert.assertEquals

class DinglemouseTest{
    private final def epsilon = 0.001
    @Test
    void "Example Tests"() {
        assertEquals(1.0, Dinglemouse.stackHeight2d(1), epsilon)
        assertEquals(1.866, Dinglemouse.stackHeight2d(2), epsilon)
    }
}
