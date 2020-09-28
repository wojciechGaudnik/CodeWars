package elevator_distance.kyu7

import org.junit.Test

class KataTest  {

    @Test
    void "STATIC TESTS"() {
        assert Kata.elevatorDistance([5,2,8]) == 9
        assert Kata.elevatorDistance([1,2,3]) == 2
        assert Kata.elevatorDistance([7,1,7,1]) == 18
    }
}
