package fizz_buzz_cuckoo_clock.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Example Tests"() {
        assert Kata.fizzBuzzCuckooClock("13:34") == "tick"
        assert Kata.fizzBuzzCuckooClock("21:00") == "Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo"
        assert Kata.fizzBuzzCuckooClock("11:15") == "Fizz Buzz"
        assert Kata.fizzBuzzCuckooClock("03:03") == "Fizz"
        assert Kata.fizzBuzzCuckooClock("14:30") == "Cuckoo"
        assert Kata.fizzBuzzCuckooClock("08:55") == "Buzz"
        assert Kata.fizzBuzzCuckooClock("00:00") == "Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo"
        assert Kata.fizzBuzzCuckooClock("12:00") == "Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo"
    }
}
