def persistence(n):
    n = str(n)
    if len(n) == 1:
        return 0
    from functools import reduce
    string = list(n)
    valor = reduce(lambda a, b: a*b, [int(i) for i in string])
    return 1+persistence(valor)


if __name__ == "__main__":
    assert persistence(39) == 3
    assert persistence(4) == 0
    assert persistence(25) == 2
    assert persistence(999) == 4
