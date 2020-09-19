package the_wheat_rice_and_chessboard_problem.kyu7

class Kata {
    static def squaresNeeded(BigInteger grains) {
        if (grains < 0 ) return 32
        def answer = 0
        while (2**answer <= grains) {
            answer++
        }
        return answer
    }
}
