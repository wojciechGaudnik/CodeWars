package switcheroo.kyu7

import org.junit.Test

class KataTest{
    @Test
    void "Exampl Tests"() {
        assert Kata.switcheroo("abc") == "bac"
        assert Kata.switcheroo('aaabcccbaaa') == 'bbbacccabbb'
        assert Kata.switcheroo('ccccc') == 'ccccc'
        assert Kata.switcheroo('abababababababab') == 'babababababababa'
        assert Kata.switcheroo('aaaaa') == 'bbbbb'
    }
}
