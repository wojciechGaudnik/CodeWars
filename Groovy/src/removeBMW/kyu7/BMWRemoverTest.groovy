package removeBMW.kyu7

import org.junit.Test

class BMWRemoverTest  {
    @Test
    void "Basic tests"() {
        assert BMWRemover.removeBMW("bmwvolvoBMW") == "volvo"
    }
}
