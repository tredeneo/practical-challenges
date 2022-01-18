# \d

The expression \d matches any digit [*0*-*9*].
![](./01.jpg)

# \D

The expression \D matches any character that is not a digit.
![](./02.png)

# Task

You have a test string `S`. Your task is to match the pattern 
`xxXxxXxxxx` Here `x` denotes a digit character, and `X` denotes a non-digit character

# Code

```python
Regex_Pattern = r"\d\d\D\d\d\D\d\d\d\d"
```

```python
Regex_Pattern = r"(\d{2}\D){2}\d{4}"
```

# Test

```python
06-11-2015
```



```python
true
```
