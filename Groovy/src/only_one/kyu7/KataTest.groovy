package only_one.kyu7

import org.junit.Test

class KataTest  {

    @Test
    void "Example Tests"() {
        assert Kata.onlyOne() == false
        assert Kata.onlyOne(true, false, false) == true
        assert Kata.onlyOne(true, false, false, true) == false
        assert Kata.onlyOne(false, false, false, false) == false
    }
}
