package alphabetical_sequence.kyu7

class Kata {

    static def alphaSeq(string) {
        return (string as String).toUpperCase().chars().sorted().collect() {
            return [it as char, ((it + 32) as char).toString().multiply(it - 65)].join()
        }.join(',')
    }
}
