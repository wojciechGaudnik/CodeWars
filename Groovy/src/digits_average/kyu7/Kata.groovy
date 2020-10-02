package digits_average.kyu7

class Kata {

    static int digitsAverage(n) {
        if (n > 9) {
            def number = String.valueOf(n)
            def average = ""
            for (def i = 1; i < n.toString().length(); i++) {
                average += (Math.ceil(((number.charAt(i - 1).toString() as Integer) + (number.charAt(i).toString() as Integer)) / 2) as Integer) as String
            }
            return digitsAverage(average as Integer)
        }
        return n
    }
}
