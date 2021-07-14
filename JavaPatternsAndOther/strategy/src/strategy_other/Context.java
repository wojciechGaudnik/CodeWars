package strategy_other;

import java.util.List;

public class Context {
	private SortStrategy sortStrategy;
	private SearchStrategy searchStrategy;

	public Context(SortStrategy sortStrategy, SearchStrategy searchStrategy) {
		this.sortStrategy = sortStrategy;
		this.searchStrategy = searchStrategy;
	}

	public void setSortStrategy(SortStrategy sortStrategy) {
		this.sortStrategy = sortStrategy;
	}

	public void setSearchStrategy(SearchStrategy searchStrategy) {
		this.searchStrategy = searchStrategy;
	}

	public void sort(List<String> list) {
		sortStrategy.sort(list);
	}

	public void search(String s) {
		searchStrategy.search(s);
	}
}
