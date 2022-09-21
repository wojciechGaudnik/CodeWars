def process_array(arr, callback):
    return [callback(e) for e in arr]
