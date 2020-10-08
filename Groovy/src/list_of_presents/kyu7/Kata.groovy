package list_of_presents.kyu7

class Kata {
    static int howManyGifts(maxBudget, gifts){
        gifts = gifts.sort()
        def answer = 0
        def sum = 0
        for (def i = 0; i < gifts.size(); i++) {
            sum += gifts[i]
            if (sum <= maxBudget) {
                answer++
                continue
            }
            break
        }
        return answer ;
    }
}
