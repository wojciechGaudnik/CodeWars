package simple_fun9_array_packing.kyu7

class Kata {

    static def arrayPacking(arr) {
        return Long.valueOf(arr.reverse().collect{
            return Integer.toBinaryString(it as int).padLeft(8, '0')
        }.join(), 2)
    }
}
