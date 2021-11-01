kata = {}
function kata.save(sizes, hd)
  local answer = 0;
  for i = 1, #sizes do
    hd = hd - sizes[i]
    if (hd < 0) then
      return answer
    end
    answer = answer + 1
  end
  return answer;
end
return kata
