package hop_across.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Basic tests"() {
        assert Kata.hopAcross([1] as int[]) == 2
        assert Kata.hopAcross([2] as int[]) == 2
        assert Kata.hopAcross([1,1] as int[]) == 4
        assert Kata.hopAcross([2,1] as int[]) == 3
        assert Kata.hopAcross([2,1,1] as int[]) == 5
        assert Kata.hopAcross([1,2,1,2] as int[]) == 5
        assert Kata.hopAcross([1,2,5,1] as int[]) == 5
        assert Kata.hopAcross([2,2,3,1,1,2,1] as int[]) == 7
    }
}
