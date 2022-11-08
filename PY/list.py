# list1 = [1,2,3,4,5,6,7]
# list2 = [0,0]

# list1[0] = 300

# list2 = list1.copy()
# print(list1,'\n', list2)

# list1[0] = 100
# list2[0] = 200

# print(list1,'\n', list2)

list1 = [1,2,3,4,5,6,7]
for i in range(1,7):
    print(f'Итерация №{i}')
    list1.pop()
    print(list1)
    i = i + 1

list2 = list(range(1,10))
print(f'Исходный список: {list2}')
list2.pop(4) # Удаление элемента с 4ым индексом
print(f'Список после POP(4): {list2}')
list2.insert(0, 99) # Позиция , значение вставки
print(f'Список после Insert: {list2}')
list2.append(100) # Добавление в конец
print(f'Список после Append: {list2}')