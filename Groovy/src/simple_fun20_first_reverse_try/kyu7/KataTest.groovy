package simple_fun20_first_reverse_try.kyu7

import org.junit.Test

class KataTest{
    @Test
    void "Example Tests"() {
        assert Kata.solution([1, 2, 3, 4, 5]) == [5, 2, 3, 4, 1]
        assert Kata.solution([3, 5, 6, 2]) == [2, 5, 6, 3]
        assert Kata.solution([]) == []
        assert Kata.solution([111]) == [111]
    }
}
