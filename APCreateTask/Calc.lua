--[[
The purpose of this program is to help the user with simple math equations

The function of this program is the user inputs a number followed by an operator and finally the other number, the user then gets the equation back to conform if it is the
desired equation to be solved, if it is then the user receives the answer, if it is not, then the user starts the process over again
--]]

-- The global variables used
inp = {}
ans = ""

-- Does the math part
function mathCalc(num1, op, num2)
  -- Does the correct operation dependent on the operator given
  if op == "+" then
    ans = num1 + num2
    check(false, ans)
  elseif op == "-" then
    ans = num1 - num2
    check(false, ans)
  elseif op == "*" then
    ans = num1 * num2
    check(false, ans)
  elseif op == "/" then
    ans = num1 / num2
    check(false, ans)
  else
    -- If there is no valid operator then the user is told
    print("No valid operator")
  end
end

-- Used to check if the division is possible, or weather or not the answer is positive or negative
function check(t, num, op)
  -- Checking if there is no division by 0
  if t == true then
    if num == 0 and op == "/" then
      print("Can not divide by 0")
      os.exit()
    end
  else
    -- Checking if the answer is either positive or negative
    if num < 0 then
      print("This answer (" .. num .. ") is negative")
    else
      print("The answer (" .. num .. ") is positive")
    end
  end
end

-- Main function which ties program together
function main()
  -- Collects user input
  print("Number 1")
  table.insert(inp, 1, tonumber(io.read()))
  print("Operator (+ - * /)")
  table.insert(inp, 2, io.read())
  print("Number 2")
  table.insert(inp, 3, tonumber(io.read()))
  
  -- Displays the equation
  for k,v in ipairs(inp) do print(v)  end
  print("Is the above the problem? Y/N")
  
  -- Asks user if this is the equation needing solving
  local a = io.read()
  if a ~= "Y" and a ~= "y" then
    inp = {}
    return
    main()
  end

  -- Checks if it is division and if it is being divided by 0 or not followed by doing the math part of the calculation
  check(true, inp[3], inp[2])
  mathCalc(inp[1], inp[2], inp[3])
end

-- Calls the main function
main()