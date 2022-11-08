a = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
b = {2, 244, 55, 11, 22, 31, 534, 634, 123, 654}
c = a.copy()
print('Copy: ')
print(c)
u = a.union(b) # Объединиение множеств (без повторений)
print('Union: ')
print(u)
i = a.intersection(b) # пересечение
print('Intersection: ')
print(i)
dl = a.difference(b) # что есть в a минус пересечение ab
print('a diff b: ') 
print(dl)
dr = b.difference(a) # что есть в b минус пересечение ab
print('b diff a: ')
print(dr)

q = a \
    .union(b) \
    .difference(a.intersection(b))
print('Q:')
print(q)

s = frozenset(a)
print('Замороженное множество s:')
print(s)