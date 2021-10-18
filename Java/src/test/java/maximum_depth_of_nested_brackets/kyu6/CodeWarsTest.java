package maximum_depth_of_nested_brackets.kyu6;

import org.junit.Test;

import java.util.ArrayList;
import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class CodeWarsTest {
	@Test
	public void staticTestCases() {
		assertEquals(new ArrayList<String>(Arrays.asList("YY")), CodeWars.stringsInMaxDepth("AA(XX((YY))(U))"));
		assertEquals(new ArrayList<String>(Arrays.asList("AB", "UP", "Z")), CodeWars.stringsInMaxDepth("((AAX(AB)(UP)F(Z))(HH))"));
		assertEquals(new ArrayList<String>(Arrays.asList("VCPXSHXQ", "CBC")), CodeWars.stringsInMaxDepth("FB(TAIHJK(NZZCGDZXKF(SYMBLACQ)SBJMRFM)PRTRX(JCLYCOXIMOKGGIE)MWIOIJDCLXDSQFHK)WLVYSMNNHIGKR(MOIZLOT(RWMAVXSJQROHJ(GZURPPOQJVMYCE(VCPXSHXQ)LETIEWE(CBC)AAHEEO)NZHIGXBSJATXV)BSBYCMKFFAFZIK(KECNRQ)PIIQZGIDMLNQRQS)VGXXBYD"));
		assertEquals(new ArrayList<String>(Arrays.asList("AAA")), CodeWars.stringsInMaxDepth("AAA"));
		assertEquals(new ArrayList<String>(Arrays.asList("")), CodeWars.stringsInMaxDepth(""));
		assertEquals(new ArrayList<String>(Arrays.asList("F")), CodeWars.stringsInMaxDepth("UPC()N((NOG(MI(YBE()((QR(DX(RF((BR()PHPL(H(F)Q)XJO)))))J)W)AV)V)H)"));
	}
}