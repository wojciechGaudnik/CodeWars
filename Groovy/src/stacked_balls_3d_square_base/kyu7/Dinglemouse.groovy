package stacked_balls_3d_square_base.kyu7

class Dinglemouse {
    static def stackHeight3d(layers) {
        if (layers == 0) {
            return 0
        }
        return 1 + (layers - 1) * Math.sqrt(1 / 2)
    }
}
