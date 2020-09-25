package method_for_counting_total_occurence_of_specific_digits.kyu7

import org.junit.Test

class KataTest{
    @Test
    void "Example Test"() {
        assert Kata.countSpecDigits([1, 1, 2 ,3 ,1 ,2 ,3 ,4], [1, 3]) == [[1, 3], [3, 2]]
        assert Kata.countSpecDigits([-18, -31, 81, -19, 111, -888], [1, 8, 4]) == [[1, 7], [8, 5], [4, 0]]
        assert Kata.countSpecDigits([-77, -65, 56, -79, 6666, 222], [1, 8, 4]) == [[1, 0], [8, 0], [4, 0]]
        assert Kata.countSpecDigits([], [1, 8, 4]) == [[1, 0], [8, 0], [4, 0]]
    }
}
