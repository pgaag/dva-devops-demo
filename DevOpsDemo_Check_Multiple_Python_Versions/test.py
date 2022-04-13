#some_test_code

### ADDED WITH 3.8 ###
#There is new syntax := that assigns values to variables as part of a larger expression. It is affectionately known 
#as “the walrus operator” due to its resemblance to the eyes and tusks of a walrus.
#In this example, the assignment expression helps avoid calling len() twice:
def python_3_8():
    a = [i for i in range(20)]
    if (n := len(a)) > 10:
        return 1
    else: 
        return 0

python_3_8()
 
    
### ADDED WITH 3.9 ###
#In type annotations you can now use built-in collection types such as list and dict as generic types 
#instead of importing the corresponding capitalized types (e.g. List or Dict) from typing. Some other 
#types in the standard library are also now generic, for example queue.Queue.

'''
def greet_all(names: list[str]) -> None:
    for name in names:
        print("Hello", name)

greet_all([str('adam'), str('peter'), str('bonny')])
'''


### ADDED WITH 3.10 ###
#A new type union operator was introduced which enables the syntax X | Y. This provides a cleaner 
#way of expressing ‘either type X or type Y’ instead of using typing.Union, especially in type hints.
#In previous versions of Python, to apply a type hint for functions accepting arguments of multiple 
#types, typing.Union was used

'''
def square(number: int | float) -> int | float:
    return number ** 2

def test_square():
    assert square(2, 2.5) == 25
'''


### ADDED WITH 3.11 ###
#Add math.exp2(): return 2 raised to the power of x. (Contributed by Gideon Mitchell in bpo-45917.)

'''
#result = math.exp2(4)
'''
#
