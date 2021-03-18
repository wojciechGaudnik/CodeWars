package santa_s_naughty_list.kyu7;

import java.util.Comparator;
import java.util.List;
import java.util.stream.Collectors;

public class FindList {

	public static List<String> findChildren(List<String> santasList, List<String> children) {
		return santasList.stream().filter(children::contains).distinct().sorted(Comparator.comparing(s -> s)).collect(Collectors.toList());
	}
}

