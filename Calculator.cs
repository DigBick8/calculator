    static double? Calculate(int num1, int num2, char operation)
    {
                while (operation != '=')
            {
                Console.WriteLine("Choose Operation ( + , - , * , / , % , = )");
                operation = Convert.ToChar(Console.ReadLine());
            
            switch (operation)
                {
                case '+':
                    return num1 + num2;
                    
                case '-':
                    return num1 - num2;
                    
                case '/':
                    if(num2 == 0){
                        Console.WriteLine("Cannot divide by zero");
                        return null;
                    }
                    else{
                        return (double) num1 / num2;
                    }
                    
                case '*':
                    return num1 * num2;
                    
                case '%':
                    if(num2 == 0){
                        Console.WriteLine("Cannot modulo by zero");
                        return null;
                    }
                    else{
                        return num1 % num2;
                    }
                    
                case '=':
                    Console.WriteLine("Program Terminated");
                    return null;
                    
                default:
                    Console.WriteLine("Incorrect Operation Used, Please try again");
                    return null;
                
                }
            }
        return null;
    }
