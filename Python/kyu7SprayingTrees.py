def task(w, n, c):
    workers = {
        "Wednesday": "Robert",
        "Monday": "James",
        "Friday": "William",
        "Tuesday": "John",
        "Thursday": "Michael",
    }
    return "It is {} today, {}, you have to work, you must spray {} trees and you need {} dollars to buy liquid".format(w, workers[w], n, n * c)
