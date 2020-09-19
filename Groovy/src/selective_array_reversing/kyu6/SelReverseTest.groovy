package selective_array_reversing.kyu6

import org.junit.Test

class SelReverseTest {
    @Test
    void "Basic tests"() {
        assert SelReverse.selReverse([2,4,6,8,10,12,14,16],3) == [6,4,2,12,10,8,16,14]
        assert SelReverse.selReverse([2,4,6,8,10,12,14,16],2) == [4,2,8,6,12,10,16,14]
        assert SelReverse.selReverse([1,2,3,4,5,6],2) == [2,1,4,3,6,5]
        assert SelReverse.selReverse([1,2,3,4,5,6],0) == [1,2,3,4,5,6]
        assert SelReverse.selReverse([1,2,3,4,5,6],10) == [6,5,4,3,2,1]
    }
}
