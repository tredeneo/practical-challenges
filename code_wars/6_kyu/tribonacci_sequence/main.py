def tribonacci(signature:list[int], n:int):
    if n == 0:
        return list()
    if n == 1:
        return signature[:1]
    if n == 2:
        return signature[:2]
    if n == 3:
        return signature
    for i in range(3,n):
        signature.append(sum(signature[i-3:i]))
    return signature

if __name__ == "__main__":
    print(tribonacci([0,0,1],10))

