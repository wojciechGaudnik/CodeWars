def sum_of_a_beach(beach):
    words = ["sand", "water", "fish", "sun"]
    beach = beach.lower()
    beaches = 0
    for word in words:
        before = len(beach)
        beach = beach.replace(word, "")
        beaches += (before - len(beach)) // len(word)
    return beaches
