local kata = {}

function kata.scramble(str, idxs)
  local answer = str
  for i = 1, #str do
    local c = str:sub(i,i)
    answer = answer:sub(1, idxs[i] - 1) .. c .. answer:sub(idxs[i] + 1)
  end

  return answer
end

return kata
