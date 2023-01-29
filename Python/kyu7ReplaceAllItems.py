def replace_all(obj, find, replace):
    if isinstance(obj, list):
        return [replace if one == find else one for one in obj]
    if isinstance(obj, str):
        return obj.replace(find, replace)
