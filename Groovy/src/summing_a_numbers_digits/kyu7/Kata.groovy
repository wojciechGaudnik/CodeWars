package summing_a_numbers_digits.kyu7

class Kata {

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
