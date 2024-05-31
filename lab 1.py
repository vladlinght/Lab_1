# Завдання 1: Створіть чотири змінні
var1 = float(input("Введіть перше число: "))
var2 = float(input("Введіть друге число: "))
var3 = float(input("Введіть третє число: "))
var4 = float(input("Введіть четверте число: "))
result_list = [
    var1 + var2,
    var1 - var3,
    var2 * var4,
    var3 / var4,
    var4 ** 2,
    var1 // var2,
    var3 % var4
]
num_elements = len(result_list)
even_elements = [num for num in result_list if num % 2 == 0]
print(f"Кількість елементів у списку: {num_elements}")
print("Парні елементи у списку:", even_elements)
if len(result_list) >= 5:
    result_list[1], result_list[4] = result_list[4], result_list[1]
    print("Список після обміну елементів:", result_list)
name = input("Введіть ваше прізвище та ім'я: ")
print("Виконавець лабораторної роботи:", name)
print("Результати та висновки:", "Завдання виконані успішно!")