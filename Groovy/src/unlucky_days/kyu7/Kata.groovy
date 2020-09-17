package unlucky_days.kyu7

class Kata {
    static int unluckyDays(int year) {
        def calendar = Calendar.getInstance()
        def answer = 0;
        for (def month = 0; month < 12; month++) {
            calendar.set(year, month, 13)
            if (calendar.get(Calendar.DAY_OF_WEEK) == 6) {
                answer++
            }
        }
        return answer
    }
}
