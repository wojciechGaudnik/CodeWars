print(25 % 2 ~= 0)
local kata = {}

function kata.animals(heads, legs)
  if heads == 0 and legs == 0 then return {0, 0} end
  if heads <= 0 or legs <= 0 or legs % 2 ~= 0 then return "No solutions" end
  cows = (legs / 2) - heads
  if (heads - cows < 0 or cows < 0) then return "No solutions" end
  return {heads - cows, cows}
end

return kata
