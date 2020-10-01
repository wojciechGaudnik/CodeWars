package simple_fun_40_timed_reading.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Example Tests"() {
        assert Kata.timedReading(4, "The Fox asked the stork, 'How is the soup?'") == 7
        assert Kata.timedReading(1, "...") == 0
        assert Kata.timedReading(3, "This play was good for us.") == 3
        assert Kata.timedReading(3, "Suddenly he stopped, and glanced up at the houses") == 5
        assert Kata.timedReading(6, "Zebras evolved among the Old World horses within the last four million years.") == 11
        assert Kata.timedReading(5, "Although zebra species may have overlapping ranges, they do not interbreed.") == 6
        assert Kata.timedReading(1, "Oh!") == 0
        assert Kata.timedReading(5, "Now and then, however, he is horribly thoughtless, and seems to take a real delight in giving me pain.") == 14
    }
}
