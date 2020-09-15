package thinkful_string_drills_repeater.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Sample Tests" () {
        assert Kata.repeater('a', 5) == 'aaaaa'
        assert Kata.repeater('Na', 16) == 'NaNaNaNaNaNaNaNaNaNaNaNaNaNaNaNa'
        assert Kata.repeater('Wub ', 6) == 'Wub Wub Wub Wub Wub Wub '
    }
}
