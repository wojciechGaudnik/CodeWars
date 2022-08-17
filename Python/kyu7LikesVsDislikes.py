def like_or_dislike(lst):
    answer = "Nothing"
    state_map = {
        "Nothing Dislike": "Dislike",
        "Nothing Like": "Like",
        "Like Like": "Nothing",
        "Like Dislike": "Dislike",
        "Dislike Dislike": "Nothing",
        "Dislike Like": "Like",
    }
    for a in lst:
        answer = state_map[answer + " " + a]
    return answer
