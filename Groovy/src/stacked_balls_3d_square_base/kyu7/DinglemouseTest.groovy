package stacked_balls_3d_square_base.kyu7

import org.junit.Test

import static groovy.util.GroovyTestCase.assertEquals

class DinglemouseTest  {
    private final def epsilon = 0.001
    @Test
    void "Example Tests"() {
        assertEquals(1.0, Dinglemouse.stackHeight3d(1), epsilon)
        assertEquals(1.7071, Dinglemouse.stackHeight3d(2), epsilon)
    }
}
