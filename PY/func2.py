import func as fc
print(fc.f(1))

# Конкатинация входных параметров
def concat(*params):
    res: str = ""
    for item in params:
        res += item
    return res

print(concat('Конкатинация: ', 'a', 'n', 'ы', ' ', 'иии'))