package small_enough_beginner.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Example Tests"() {
        assert Kata.smallEnough([66, 101], 200) == true
        assert Kata.smallEnough([78, 117, 110, 99, 104, 117, 107, 115], 100) == false
        assert Kata.smallEnough([101, 45, 75, 105, 99, 107], 107) == true
        assert Kata.smallEnough([80, 117, 115, 104, 45, 85, 112, 115], 120) == true
        assert Kata.smallEnough([1, 1, 1, 1, 1, 2], 1) == false
        assert Kata.smallEnough([78, 33, 22, 44, 88, 9, 6], 87) == false
        assert Kata.smallEnough([1, 2, 3, 4, 5, 6, 7, 8, 9], 10) == true
        assert Kata.smallEnough([12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12], 12) == true
    }
}
