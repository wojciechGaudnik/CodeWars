return {
  getStrings = function(city)
    local map = {}
    city = string.lower(city)
    for i = 1, #city do
      c = string.sub(city, i, i)
      if (map[c] == nil) then
        map[c] = c .. ":*"
      else
        map[c] = map[c] .. "*"
      end
    end
    answer = ""
    for i = 1, #city do
      c = string.sub(city, i, i)
      if (c ~= " " and map[c] ~= nil) then
        answer = answer .. map[c] .. ","
        map[c] = nil
      end
    end
    return answer:sub(1, #answer - 1)
  end
}
