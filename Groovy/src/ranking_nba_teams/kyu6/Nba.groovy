package ranking_nba_teams.kyu6

class Nba {

    static String nbaCup(String resultSheet, String toFind) {
        if (toFind.equals("")) return ""
        if (!resultSheet.contains(toFind)) return toFind + ":This team didn't play!"
        def W = 0, D = 0, L = 0, Scored = 0, Conceded = 0, Points = 0
        def floatExists
        resultSheet.split(",").findAll { it.contains(toFind) }.each {
            if ((it =~ '\\s\\d+\\.\\d+').find()) {
                floatExists = "Error(float number):" + it
                return
            }
            if (!(it =~ toFind + '\\s').find()) return
            def match = it =~ '^(.+?)\\s(\\d+)\\s(.+?)\\s(\\d+)$'
            def firstTeamScore, secondTeamScore
            if ((match[0][1] as String).equals(toFind)) {
                firstTeamScore = match[0][2] as Integer
                secondTeamScore = match[0][4] as Integer
            } else {
                firstTeamScore = match[0][4] as Integer
                secondTeamScore = match[0][2] as Integer
            }
            if (firstTeamScore > secondTeamScore) {
                W++
                Points += 3
            }
            if (firstTeamScore == secondTeamScore) {
                D++
                Points += 1
            }
            if (firstTeamScore < secondTeamScore) L++
            Scored += firstTeamScore
            Conceded += secondTeamScore
        }
        if (floatExists) return floatExists
        if (W == 0 && D == 0 && L == 0) return "${toFind}:This team didn't play!"
        return "${toFind}:W=${W};D=${D};L=${L};Scored=${Scored};Conceded=${Conceded};Points=${Points}"
    }
}
