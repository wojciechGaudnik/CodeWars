kata = {}
function kata.solve(n)
	return 2 * fibonacci(n + 1) - 1
end

function fibonacci(n)
	if ( n <= 1) then
		return n	
	end
	return fibonacci(n - 1) + fibonacci(n - 2)
end

return kata
