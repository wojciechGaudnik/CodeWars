package maximum_multiple.kyu7

import org.junit.Test

class KataTest{
    @Test
    void basicTests() {
        assert Kata.maxMultiple(2, 7) == 6
        assert Kata.maxMultiple(3, 10) == 9
        assert Kata.maxMultiple(7, 17) == 14
        assert Kata.maxMultiple(10, 50) == 50
        assert Kata.maxMultiple(37, 200) == 185
        assert Kata.maxMultiple(7, 100) == 98
    }
}
