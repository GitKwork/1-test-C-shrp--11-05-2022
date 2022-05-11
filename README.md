# 1-test-work-11-05-2022
## Итоговая проверочная работа.

Задача:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

### **Решение задания:**
Для решения создаем методы:
FillArray для заполнения массива;
PrintArray для печати массива;
CountSymTo3 для подсчета количества элементов в массиве, длина которых меньше либо равна 3 символа;
CreateNewArray для создания нового массива, состоящего из строк, длина которых меньше либо равна 3 символа.
**Алгоритм решения:**
создаем массив -> заполняем массив строками (ввод пользователем в консоли) -> производим подсчета количества элементов в массиве, длина которых меньше либо равна 3 символа -> создаем новый массив размером, равным количеству подсчитанных элементов -> наполняем новый массив элементами, длина которых меньше либо равна 3 символа -> выводим на печать исходный массив, символ "->" и новый массив.