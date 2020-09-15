package leap_years.kyu7

import org.apache.tools.ant.taskdefs.optional.extension.Specification
import org.junit.Test

class KataTest {
    @Test
    void "Should be true"() {
        assert Kata.isLeapYear(1984) == true : 'Year 1984 was a leap year!'
        assert Kata.isLeapYear(2000) == true : 'Year 2000 was a leap year!'
    }

    @Test
    void "Should be false"() {
        assert Kata.isLeapYear(1234) == false: 'Year 1234 was NOT a leap year!'
        assert Kata.isLeapYear(1100) == false: 'Year 1100 was NOT a leap year!'
    }
}
