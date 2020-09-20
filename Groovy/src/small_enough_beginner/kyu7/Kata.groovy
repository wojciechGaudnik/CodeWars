package small_enough_beginner.kyu7

class Kata {

    static def smallEnough(arr, limit) {
        return arr.every {e -> e <= limit}
    }
}
