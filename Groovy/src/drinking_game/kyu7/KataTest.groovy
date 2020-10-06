package drinking_game.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Basic tests"() {
        assert Kata.game(3,2) == "Joe"
        assert Kata.game(4,2) == "Mike"
        assert Kata.game(9,1000) == "Joe"
        assert Kata.game(0,1) == "Non-drinkers can't play"
    }
}
