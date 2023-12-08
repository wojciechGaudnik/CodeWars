package stringy_strings.kyu8;

import java.util.Random;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;

class KataTest {

    @Test
    void startTest() {
        Assertions.assertEquals('1', Kata.stringy(3).charAt(0), "Your string should start with a 1");
    }

    @Test
    void lengthTests() {
        Random randGen = new Random();
        for (int i = 0; i < 10; i++) {
            int size = randGen.nextInt(50);
            Assertions.assertEquals(size, Kata.stringy(size).length(), "Wrong length using size " + size);
        }
    }


}
