package simple_fun9_array_packing.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Example Tests" () {
        assert Kata.arrayPacking([24, 85, 0]) == 21784
        assert Kata.arrayPacking([23, 45, 39]) == 2567447
        assert Kata.arrayPacking([1, 1]) == 257
        assert Kata.arrayPacking([0]) == 0
        assert Kata.arrayPacking([255, 255, 255, 255]) == 4294967295
    }
}
