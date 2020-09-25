package method_for_counting_total_occurence_of_specific_digits.kyu7

class Kata {
    static def countSpecDigits(integers, digits) {
        def answer = []
        def integersAsString = ""
        integers.each({
            integersAsString += (it as String)
        })

        def digitsAsString = ""
        digits.each({
            digitsAsString += it
        })

        digitsAsString.each({
            answer.add([(it as Integer), integersAsString.chars().filter({ d -> d == it }).count()])
        })

        return answer
    }
}
