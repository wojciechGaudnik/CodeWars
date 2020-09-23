package simple_fun63_shape_area.kyu7

class Kata {
    public static void main(String[] args) {
        println(shapeArea(5))
    }
    static def shapeArea(n) {
        return --n * n + (n + 1) * (n + 1)
    }
}
