# Модификаторы a - добавить к уже существующему, w - перезаписать, r - открыть для чтения

# 1й способ записи в файл
# colors = ['red', 'green', 'blue']
# data = open('file.txt', 'a')
# # dat   a.writelines(colors)
# data.write('\n LINE 2\n')
# data.write('LINE 3\n')
# data.close

# 2й способ записи в файл
# with open('file.txt', 'a') as data: # как некую переменую data, закрывать тут не надо, все автоматически
#     data.write('line 1\n')
#     data.write('line 2\n')


# Чтение данных из файла
path = 'file.txt'
data = open(path, 'r')
for line in data:
    print(line) # Делает переход на новую строку, поэтому есть задвоение
data.close()