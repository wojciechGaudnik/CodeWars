package predict_your_age.kyu7

class Solution {

    static predictAge(age1, age2, age3, age4, age5, age6, age7, age8) {
        def list = [age1, age2, age3, age4, age5, age6, age7, age8]
        return Math.sqrt(list.collect { e -> (e * e) }.sum() as double).div(2) as Integer
    }
}
