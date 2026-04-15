DecToHex. C# Tutorials. Simple Input/Output. Strings. Algorithms. DotNet FrameWork Platform. Console Application.
A console application in the C# programming language. 
The program does the following:
  1. Prompts the user to enter an integer.
  2. Checks whether the number is positive. It should also be no more than 4,294,967,295.
  3. If not, the program displays a message about the invalid number and terminates.
  4. Requests the format of the letters in a hexadecimal number: uppercase (capital) and lowercase (small).
  5. Sets a string variable to the empty string.
  6. Creates a temporary variable with an initial value equal to the number entered from the keyboard.
  7. The loop with precondition is executed:
     a) The variable's value is compared to zero. If it is greater than zero, the loop continues executing; otherwise, it terminates (Go to step 8).
     b) The remainder of dividing the value of the temporary variable by 16 is calculated.
     c) It is translated as a symbol. The symbol code is calculated according to the following rules:
        Case 1. The remainder of a decimal fraction between 0 and 9 when divided by 16.
                The formula used is: symbol code "0" (number "48") + remainder of a decimal fraction between 16.
        Case 2. The remainder of a decimal fraction between 10 and 15 when divided by 16. Hexadecimal letter format: uppercase.
                The formula used is: symbol code "A" (number "65") + remainder of a decimal fraction between 16 and 10.
        Case 3. The remainder of a decimal fraction between 10 and 15 when divided by 16. Hexadecimal letter format: lowercase.
                The formula used is: symbol code "a" (number "97") + remainder of a decimal fraction between 16 and 10.
        This symbol is added to the end of the string that was declared in point 5.
     d) The temporary variable is divided by 16.
  8. If the string remains empty after the loop completes, it is replaced with the character "0".
  9. The entered number and its hexadecimal number (the string that was declared in point 5) are displayed on the screen.
Developed in the Microsoft Visual Studio integrated environment.

DecToHex. Занятия по С#. Простой ввод/вывод. Строки. Алгоритмы. Платформа DotNet FrameWork. Консольное приложение.
Консольное приложение написанное на языке программирования C#
Программа делает следующее:
  1. Запрашивает у пользователя ввод целого числа.
  2. Проверяет является ли оно положительным. Также оно должно быть не более 4 294 967 295.
  3. Если нет, программа выводит сообщение о неверно введенном числе и завершает работу.
  4. Запрашивает формат букв шестнадцатиричного числа : прописные (большие) или строчные (малые).
  5. Устанавливает строковую переменную в значение равное пустой строке.
  6. Создаёт временную переменную с первоначальным значением равным числу введённому с клавиатуры.
  7. Выполняется цикл с предусловием:
     a) Значение переменной сравнивается с нулём. Если оно больше нуля, цикл продолжает выполняться, в противном случае завершается (Переход к пункту 8).
     b) Вычисляется остаток от деления значения временной переменной на 16.
     c) Он переводится символ. Код символа вычисляется по правилам:
        1-й случай. Остаток от деления на число 16 от 0 до 9. Используется формула:код символа "0" (число "48") + остаток от деления на 16.
        2-й случай. Остаток от деления на число 16 от 10 до 15. Формат букв шестнадцатиричного числа : прописные (большие). 
                    Используется формула:код символа "A" (число "65") + остаток от деления на 16 - 10.
        3-й случай. Остаток от деления на число 16 от 10 до 15. Формат букв шестнадцатиричного числа : строчные (малые). 
                    Используется формула:код символа "a" (число "97") + остаток от деления на 16 - 10. 
        Этот символ прибавляется в конец строки, которая была объявлена в пункте 5.
     d) Времменая переменная делится на 16.
  8. Если после завершения цикла строка остаётся пустой, она заменяется на символ "0".
  9. На экран выводится введённое число и его шестнадцатиричное число (строка, которая была объявлена в пункте 5).
Разработано в итегрированной среде Microsoft Visual Studio.
