package easy_wallpaper.kyu7

import org.junit.After
import org.junit.Before
import org.junit.Test

import static groovy.util.GroovyTestCase.assertEquals

class EasyWallpaperTest{
    private static final String[] numbers = [
            "zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine", "ten",
            "eleven", "twelve", "thirteen", "fourteen", "fifteen",
            "sixteen", "seventeen", "eighteen", "nineteen", "twenty"
    ];

    private EasyWallpaper easyWallpaper;

    @Before
    public void setUp() {
        easyWallpaper = new EasyWallpaper();
    }

    @After
    public void tearDown() {
        easyWallpaper = null;
    }

    @Test
    public void basicTests() {
        assertEquals("ten", easyWallpaper.wallpaper(4, 3.5, 3));
        assertEquals("sixteen", easyWallpaper.wallpaper(6.3, 4.5, 3.29));
        assertEquals("sixteen", easyWallpaper.wallpaper(7.8, 2.9, 3.29));
    }
}
