package the_wheat_rice_and_chessboard_problem.kyu7

import org.junit.Test

class KataTest{
    @Test
    void "Example Tests"() {
        assert Kata.squaresNeeded(0) == 0
        assert Kata.squaresNeeded(1) == 1
        assert Kata.squaresNeeded(2) == 2
        assert Kata.squaresNeeded(3) == 2
        assert Kata.squaresNeeded(4) == 3
    }
}
