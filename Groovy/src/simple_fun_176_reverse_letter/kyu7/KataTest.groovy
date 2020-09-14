package simple_fun_176_reverse_letter.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Example Tests"() {
        assert Kata.reverseLetter("krishan") == "nahsirk"
        assert Kata.reverseLetter("ultr53o?n") == "nortlu"
        assert Kata.reverseLetter("ab23c") == "cba"
        assert Kata.reverseLetter("krish21an") == "nahsirk"
    }
}
