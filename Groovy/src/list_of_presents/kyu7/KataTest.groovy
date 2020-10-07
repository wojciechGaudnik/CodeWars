package list_of_presents.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Basic Tests"() {
        assert Kata.howManyGifts(20, [13, 2, 4, 6, 1]) == 4
        assert Kata.howManyGifts(90, [87, 3, 5, 25, 1, 3, 4, 6, 20]) == 8
        assert Kata.howManyGifts(100, [6, 94, 10, 45, 2, 4, 5, 6, 8, 1]) == 9
        assert Kata.howManyGifts(0, [1]) == 0
    }
}
