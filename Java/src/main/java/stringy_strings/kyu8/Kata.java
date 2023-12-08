package stringy_strings.kyu8;


import java.util.stream.Collectors;
import java.util.stream.IntStream;

class Kata {

    public static String stringy(int size) {
        return IntStream.range(0, size)
            .mapToObj(value -> value % 2 == 0 ? "1" : "0")
            .collect(Collectors.joining());
    }

}
