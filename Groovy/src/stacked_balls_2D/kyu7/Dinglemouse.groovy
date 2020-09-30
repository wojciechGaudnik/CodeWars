package stacked_balls_2D.kyu7

class Dinglemouse {
    static def stackHeight2d(layers) {
        if (layers == 0) return 0
        return Math.sqrt(Math.pow(layers - 1, 2) - Math.pow(0.5 * (layers - 1) as double, 2)) + 1
    }
}
