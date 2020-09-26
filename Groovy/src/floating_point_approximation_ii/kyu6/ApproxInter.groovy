package floating_point_approximation_ii.kyu6

import java.math.RoundingMode
import java.text.DecimalFormat
import java.util.function.DoubleUnaryOperator

class ApproxInter {
    public static List<Double> interp(DoubleUnaryOperator f, double l, double u, int n) {
        List<Double> answerBefore = []
        List<Double> answer = []
        answerBefore.add(l)
        def d = (u - l) / (n as double)
        for (def i = 1; answerBefore.size() < n; i++) {
            l += d
            answerBefore.add(l)
        }
        def df = new DecimalFormat("#.###")
        df.setRoundingMode(RoundingMode.HALF_EVEN)
        for (def i = 0; i < answerBefore.size(); i++) {
            def t = f.applyAsDouble(answerBefore[i]) as double
            def m = df.format(t) as Double
            answer.add(Math.floor(m * 100.0) / 100.0)
        }
        return answer
    }
}
