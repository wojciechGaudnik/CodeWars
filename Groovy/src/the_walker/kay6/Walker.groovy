package the_walker.kay6

class Walker {

    static int[] solve(int a, int b, int c, int alpha, int beta, int gamma) {
        println(a + "<--->" + b + "<--->" + c + "<--->" + alpha + "<--->" + beta + "<--->" + gamma)
        def cord = [0, 0]
        def answer = new int[4]
        cord = calculateCordinates(cord, a, alpha)
        cord = calculateCordinates(cord, b, (beta + 90) as int)
        cord = calculateCordinates(cord, c, (gamma + 180) as int)
        answer[0] = Math.round(Math.sqrt(cord[0]**2 + cord[1]**2)) as int
        def angle = Math.toDegrees(Math.atan2(Math.abs(cord[0] as double), Math.abs(cord[1] as double))) + 90
        answer[1] = angle as int
        answer[2] = ((angle - (angle as int)) * 60) as int
        answer[3] = (((angle - (angle as int)) * 60) - answer[2]) * 60 as int
        return answer
    }

    static def calculateCordinates(cords, length, angle) {
        angle = angle * Math.PI / 180
        cords = [length * Math.cos(angle) + cords[0], length * Math.sin(angle) + cords[1]]
    }
}
