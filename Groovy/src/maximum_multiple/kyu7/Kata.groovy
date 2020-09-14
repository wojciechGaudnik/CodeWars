package maximum_multiple.kyu7

class Kata {
    static maxMultiple(d, b) {
        Integer answer = b;
        while (answer % d != 0) {
            answer--;
        }
        return answer
    }
}
