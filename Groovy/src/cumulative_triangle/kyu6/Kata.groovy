package cumulative_triangle.kyu6

class Kata {

    static def cumulativeTriangle(BigInteger n) {
        return (((0..n - 1).sum() as BigInteger)+ 1..(0..n - 1).sum() + n).sum()
    }
}
