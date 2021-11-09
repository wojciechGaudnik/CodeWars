function toFreud(string) {
    if (string == null || string.length === 0) {
        return "";
    }
    return string.split(" ").map((s) => "sex").join(" ");
}