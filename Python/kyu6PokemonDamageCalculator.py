def calculate_damage(your_type, opponent_type, attack, defense):
	if your_type == opponent_type:
		return 50 * (attack / defense) * .5
	setUp2 = [["fire", "grass"], ["grass", "water"], ["water", "fire"], ["electric", "water"] ]
	setUp1 = [["fire", "electric"], ["grass", "electric"]]
	if [your_type, opponent_type] in setUp2:
		return 50 * (attack / defense) * 2
	if [opponent_type, your_type] in setUp2:
		return 50 * (attack / defense) * .5
	if [your_type, opponent_type] in setUp1:
		return 50 * (attack / defense)
	return 50 * (attack / defense)
