package odds_index.kyu7

class Kata {
    public static void main(String[] args) {
        println(oddBall(["even",4,"even",7,"even",55,"even",6,"even",10,"odd",3,"even"]))
    }
    static def oddBall(arr) {
        def indexOdd = arr.indexOf("odd")
        return arr.any {it == indexOdd}
    }
}
