package simple_fun_198_cake_slice.kyu7

import org.junit.Test


class KataTest  {
    @Test
    void "Exampl Tests"() {
        assert Kata.cakeSlice(0) == 1
        assert Kata.cakeSlice(1) == 2
        assert Kata.cakeSlice(2) == 4
        assert Kata.cakeSlice(3) == 7
        assert Kata.cakeSlice(10) == 56
    }
}
