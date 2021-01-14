package where_is_vasya.kyu7;

public class WhereIsVasya {

	public static int whereIsHe(int p, int bef, int aft){
		return Math.min(p - bef, aft + 1);
	}
}
