package simple_fun37_house_numbers_sum.kyu7

import org.junit.Test

class KataTest{
    @Test
    void "Example Tests"() {
        assert Kata.houseNumbersSum([5, 1, 2, 3, 0, 1, 5, 0, 2]) == 11
        assert Kata.houseNumbersSum([4, 2, 1, 6, 0]) == 13
        assert Kata.houseNumbersSum([4, 1, 2, 3, 0, 10, 2]) == 10
        assert Kata.houseNumbersSum([0, 1, 2, 3, 4, 5]) == 0
    }
}
