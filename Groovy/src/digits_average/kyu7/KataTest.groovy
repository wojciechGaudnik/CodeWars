package digits_average.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Basic tests"() {
        assert Kata.digitsAverage(246) == 4
        assert Kata.digitsAverage(89) == 9
        assert Kata.digitsAverage(2) == 2
        assert Kata.digitsAverage(245) == 4
        assert Kata.digitsAverage(345) == 5
        assert Kata.digitsAverage(346) == 5
    }
}
