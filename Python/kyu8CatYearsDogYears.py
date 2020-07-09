def human_years_cat_years_dog_years(human_years):
	years = [human_years, 15, 15]
	if human_years >= 2:
		years[1] += 9
		years[2] += 9
	if human_years > 2:
		years[1] = years[1] + (human_years - 2) * 4
		years[2] = years[2] + (human_years - 2) * 5
	return years
