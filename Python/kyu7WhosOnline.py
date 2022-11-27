def who_is_online(friends):
    answer = {}
    for friend in friends:
        if friend["status"] == "offline":
            last = answer.get("offline", [])
            last.append(friend["username"])
            answer["offline"] = last
        elif friend["status"] == "online" and friend["last_activity"] > 10:
            last = answer.get("away", [])
            last.append(friend["username"])
            answer["away"] = last
        else:
            last = answer.get("online", [])
            last.append(friend["username"])
            answer["online"] = last
    return answer
