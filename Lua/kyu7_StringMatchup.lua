matchup = {}
function matchup.solve(a,b)
  answer = {}
  for i = 1, #b do
    buff = 0;
    for j = 1, #a do
      if b[i] == a[j] then
        buff = buff + 1
      end
    end
    answer[i] = buff
  end
  return answer
end
return matchup
