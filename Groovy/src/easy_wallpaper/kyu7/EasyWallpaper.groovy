package easy_wallpaper.kyu7

class EasyWallpaper {
    static String wallpaper(double l, double w, double h) {
        String[] numbers = [
                "zero", "one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine", "ten",
                "eleven", "twelve", "thirteen", "fourteen", "fifteen",
                "sixteen", "seventeen", "eighteen", "nineteen", "twenty"
        ];
        if (l == 0 || w == 0 || h == 0) {
            return numbers[0]
        }
        return numbers[Math.ceil(((l * h * 2 + w * h * 2) * 1.15) / (0.52 * 10)) as int]
    }
}
