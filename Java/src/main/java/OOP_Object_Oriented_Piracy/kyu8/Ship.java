package OOP_Object_Oriented_Piracy.kyu8;


public class Ship {

    private final double draft;

    private final int crew;

    public Ship(double draft, int crew) {
        this.draft = draft;
        this.crew = crew;
    }

    public boolean isWorthIt() {
        return draft - (1.5 * crew) > 20;
    }

}
