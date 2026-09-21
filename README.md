# Практика: Одномерные массивы в C#

**ФИО:** Малоголовкина  
**Номер в журнале:** 14  
**Вариант итогового задания:** 2 (Палиндром)

**Исходный репозиторий преподавателя:** https://github.com/zayarniy/arrays-practice.git  
**Мой репозиторий:** https://github.com/sofamalogolovkina41-ship-it/arrays-practice

## Выполненные задания

- **Task1.Statistics** — статистика случайного массива (сумма, произведение, чётные, выше среднего)
- **Task2.InputSort** — ввод, реверс, сортировка массива
- **Task3.Unique** — уникальные элементы без LINQ и HashSet
- **Task4.Exceptions** — обработка FormatException, OverflowException, IndexOutOfRangeException
- **Final.Task** — проверка массива на палиндром (вариант 2)

## Использованные методы и приёмы

- `Array.Sort`, `Array.IndexOf` — сортировка и поиск
- `string.Join` — вывод массива в одну строку
- `int.Parse` + `try/catch` — обработка FormatException и OverflowException
- Вложенные циклы и вспомогательный массив для поиска уникальных (Task3)
- `input.Split(' ', StringSplitOptions.RemoveEmptyEntries)` — разбор чисел из одной строки (Final.Task)