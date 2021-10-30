local t = {}
function t.twoOldestAges(ages)
  last = 0
  prev = 0
  table.sort(ages)
  for k, v in pairs(ages) do
    print(k, " ", ages[k])
    prev = last
    last = ages[k]
  end
  return {prev, last}
end
return t

-- local test = {1,3,5,7,5,3,1}
-- test2 = t.twoOldestAges(test)
-- print(test2)
-- print("---------")
-- for k, v in pairs(test2) do
  -- print(v)
-- end
