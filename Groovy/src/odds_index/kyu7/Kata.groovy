package odds_index.kyu7

class Kata {

    static def oddBall(arr) {
        def indexOdd = arr.indexOf("odd")
        return arr.any {it == indexOdd}
    }
}
