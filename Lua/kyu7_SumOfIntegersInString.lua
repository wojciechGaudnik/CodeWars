kata = {}
function kata.sumOfIntegersInString(s)
  local answer = 0
  for d in s:gmatch "%d+" do
    answer = answer + d
  end
  return answer;
end

return kata
