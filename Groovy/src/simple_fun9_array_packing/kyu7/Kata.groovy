package simple_fun9_array_packing.kyu7

class Kata {

    public static void main(String[] args) {
        println(Integer.toBinaryString(12))
        println(arrayPacking([24, 85, 0]))
        println(arrayPacking([255, 255, 255, 255]))
    }

    static def arrayPacking(arr) {
        return Long.valueOf(arr.reverse().collect{
            return Integer.toBinaryString(it as int).padLeft(8, '0')
        }.join(), 2)
    }
}
