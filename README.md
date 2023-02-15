# Итоговая проверочная работа.
**Задача:** Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Решение:** Массив строк *arrayString* был задан в коде программы. Была объявлена целочисленная переменная *size*, которая в последующем будет хранить размер массива из строк, длина которых меньше или равна 3 символам. 
Был описан **void** метод *PrintArray* для вывода массива на печать. С помощью этого метода вывели массив *arrayString* на экран.
После этого, циклом **for** "прошлись" по массиву *arrayString* и присвоили переменной *size* значение длины нового массива. Сама длина была подсчитана с помощью условия "если количество символов в элементе массива меньше или равен 3, то увеличить значение счётчика на 1.

После того как было найдено значение длины нового массива, он был объявлен в переменную *array3*. Также была объявлена переменная *k* для перехода к 0-му элементу этого массива. 

Далее проверили все элементы массива *arrayString* на количество символов, и если, условие выполнялось, то этот элемент записывался в новый массив *array3*. После этого, массив *array3* был выведен на печать.