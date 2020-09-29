package odds_index.kyu7

import org.junit.Test

class KataTest{
    @Test
    void "Sample Tests" () {
        assert Kata.oddBall(["even",4,"even",7,"even",55,"even",6,"even",10,"odd",3,"even"]) == true
        assert Kata.oddBall(["even",4,"even",7,"even",55,"even",6,"even",9,"odd",3,"even"]) == false
        assert Kata.oddBall(["even",10,"odd",2,"even"]) == true
    }
}
