def convert_hash_to_array(hash):
    return sorted([[one, hash[one]] for one in hash])
