package cumulative_triangle.kyu6

import org.junit.Test

class KataTest{
    @Test
    void "Example Tests"() {
        assert Kata.cumulativeTriangle(1) == 1
        assert Kata.cumulativeTriangle(3) == 15
        assert Kata.cumulativeTriangle(4) == 34
    }
}
