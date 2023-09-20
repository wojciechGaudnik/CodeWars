package quadrants.kata8;

import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;
import static org.junit.jupiter.api.Assertions.assertEquals;

class KataTest {

    @ParameterizedTest(name = "Quadrant {0}: ({1}, {2})")
    @CsvSource(textBlock = """
        1,       1,   2
        1,       3,   5
        2,     -10, 100
        3,      -1,  -9
        4,      19, -56
    """)
    @DisplayName("Sample tests") void sampleTests(int expected, int x, int y) {
        assertEquals(expected, Kata.quadrant(x, y));
    }
}
