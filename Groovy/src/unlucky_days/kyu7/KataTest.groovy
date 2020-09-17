package unlucky_days.kyu7

import org.junit.Test

class KataTest {
    @Test
    void exampleTests() {
        assert Kata.unluckyDays(2015) == 3
        assert Kata.unluckyDays(1986) == 1
    }
}
