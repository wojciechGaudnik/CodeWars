package fizz_buzz_cuckoo_clock.kyu7

class Kata {
    static def fizzBuzzCuckooClock(time) {
        if (time == "00:00" || time == "12:00") return "Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo Cuckoo"
        def answer = ""
        def hours = time.split(":")[0] as int
        def minutes = time.split(":")[1] as int
        if (minutes % 3 == 0) answer += "Fizz "
        if (minutes % 5 == 0) answer += "Buzz "
        if (minutes == 30) answer = "Cuckoo"
        if (minutes == 0) answer = "Cuckoo " * (hours % 12)
        if (answer == "") {
            return "tick"
        }
        return answer.trim()
    }
}
