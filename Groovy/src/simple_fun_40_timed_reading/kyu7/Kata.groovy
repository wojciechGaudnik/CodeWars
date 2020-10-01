package simple_fun_40_timed_reading.kyu7

class Kata {

    static def timedReading(maxLength, text) {
        return (text as String).split(' ').collect() {
            it.replaceAll("[^A-Za-z]", "").length() <= maxLength &&
            it.replaceAll("[^A-Za-z]", "").length() > 0
        }.count(true)
    }
}
