package did_she_say_hallo.kyu8;

import java.util.Arrays;

class Kata {


    public static boolean validateHello(String greetings){
        var hello = new String[]{"hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc"};
        return Arrays.stream(hello)
            .anyMatch(h -> greetings.toLowerCase().contains(h));
    }

}
