import java.lang.String;

class Rename{

    private String stylus;
    private String deviceName;

    public void touchDevice(int x, int y, float strength, Device device){
        device.touchByStylus(x, y, strength);
    }

    public boolean checkIPad(){
        if(deviceName.equals("iPad")) return true;
        return false;
    }

    public String getStylus() {
        return stylus;
    }

    interface Device{
        void touchByStylus(int x, int y, float strength);
    }
}