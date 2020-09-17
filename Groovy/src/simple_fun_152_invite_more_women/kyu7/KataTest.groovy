package simple_fun_152_invite_more_women.kyu7

import org.junit.Test

class KataTest {
    @Test
    void "Example Tests" () {
        assert Kata.inviteMoreWomen([1, -1, 1]) == true
        assert Kata.inviteMoreWomen([-1, -1, -1]) == false
        assert Kata.inviteMoreWomen([1, -1]) == false
        assert Kata.inviteMoreWomen([1, 1, 1]) == true
    }
}
