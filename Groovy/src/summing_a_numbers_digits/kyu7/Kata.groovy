package summing_a_numbers_digits.kyu7

class Kata {
    static void main(String[] args) {
        println(sumDigits(123))
    }
    static int sumDigits(number) {
        Integer answer = 0;
        (number as String).each { c ->
            if ((c as char).isDigit()) {
                answer += c as Integer
            }
        }
        return answer
    }
}
