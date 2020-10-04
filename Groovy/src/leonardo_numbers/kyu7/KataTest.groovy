package leonardo_numbers.kyu7

import org.junit.Test

class KataTest {


    @Test
    void sampleTests() {
        assert Kata.leonardoNumbers(5, 1, 1, 1) == [1, 1, 3, 5, 9]
        assert Kata.leonardoNumbers(5, 0, 0, 2) == [0, 0, 2, 4, 8]
        assert Kata.leonardoNumbers(5, 0, 0, 0) == [0, 0, 0, 0, 0]
    }
}
