package extra_perfect_numbers_special_numbers_series7.kyu7

class Kata {

    static extraPerfect(n) {
        return (0..n).findAll {i ->
            Integer.toBinaryString(i)[0] == '1' && Integer.toBinaryString(i)[-1] == '1'
        }.toArray()
    }
}
