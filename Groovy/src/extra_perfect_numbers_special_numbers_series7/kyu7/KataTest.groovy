package extra_perfect_numbers_special_numbers_series7.kyu7

import org.junit.Test

class KataTest {
    @Test
    void basicTests() {
        assert Kata.extraPerfect(3) == [1, 3]
        assert Kata.extraPerfect(5) == [1, 3, 5]
        assert Kata.extraPerfect(7) == [1, 3, 5, 7]
        assert Kata.extraPerfect(28) == [1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27]
        assert Kata.extraPerfect(39) == [1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39]
    }
}
