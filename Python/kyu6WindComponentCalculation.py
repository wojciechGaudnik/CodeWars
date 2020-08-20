import math


def wind_info(runway, wind_direction, wind_speed):
	RH = int("".join([c for c in runway if c.isdigit()]) + "0")
	WA = RH - wind_direction
	dir_wind = "left"
	i = 180
	while i >= 0:
		if RH == wind_direction:
			dir_wind = 'right'
			break
		RH += 1
		RH = 0 if RH == 360 else RH
		i -= 1
	if WA <= 0:
		WA += 360
	HW = int(round(wind_speed * math.cos(math.radians(WA))))
	TW = int(round(wind_speed * math.sin(math.radians(WA))))
	wind = "Headwind" if HW >= 0 else "Tailwind"
	if HW == 0:
		dir_wind = "right"
	return f"{wind} {abs(HW)} knots. Crosswind {abs(TW)} knots from your {dir_wind}."
