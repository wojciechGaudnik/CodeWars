package simple_fun37_house_numbers_sum.kyu7


class Kata {

    static def houseNumbersSum(inputArray) {
        def answer = 0;
        for (def n : inputArray) {
            if (n != 0) {
                answer += n
            } else if (n == 0) {
                break
            }
        }
        return answer
//        xs.takeWhile{it}.sum(0)

    }
}
