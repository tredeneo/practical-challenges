# return masked string
def maskify(cc):
    return cc[-4:].rjust(len(cc),"#")
