# Итоговая проверочная работа
**Задача:** написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. Первоначальный массива можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:** 

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [] 

**Решение:**

1. Выводим изначальный массива на экран при помощи метода: WriteArray.
2. При помощи цикла опрделеняем длину нового массива. Размер складывается из количества элементов в изначальном массиве, длина которых меньше или равна 3 символам.
3. Задаем новый массив размером, который получили в пункте 2.
4. При помощи цикла проверяем все элементы массива, длина которых меньше или равна 3 символам. Если таковые есть - записываем их поочередно в новый массив.
5. Выводим получившийся массив на экран при помощи метода: WtiteArray.
