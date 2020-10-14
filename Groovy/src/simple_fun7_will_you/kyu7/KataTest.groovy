package simple_fun7_will_you.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Example Tests"() {
        assert Kata.willYou(true,true,true) == false
        assert Kata.willYou(true,false,true) == true
        assert Kata.willYou(false,false,false) == false
        assert Kata.willYou(false,false,true) == true
    }
}
