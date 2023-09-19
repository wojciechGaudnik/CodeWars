package pillars.kyu8;

public class Kata{

    public static int pillars(int numPill, int dist, int width){
        if (numPill < 2) return 0;
        return (numPill - 1) * (dist * 100) + numPill * width - 2 * width;
    }

}
