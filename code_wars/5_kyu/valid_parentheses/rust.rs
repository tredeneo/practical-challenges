fn valid_parentheses(s: &str) -> bool {
    let mut stack: Vec<char> = Vec::new();
    for ch in s.chars() {
        if ch == '(' {
            stack.push(ch);
        } else if ch == ')' {
            match stack.pop() {
                None => return false,
                Some(s) => {
                    if s == '(' {
                        continue;
                    } else {
                        return false;
                    }
                }
            }
        }
    }
    stack.is_empty()
}

fn main() {
    println!("Hello, world!");
}

#[cfg(test)]
mod tests {
    use super::valid_parentheses;

    #[test]
    fn sample_tests() {
        do_test("()", true);
        do_test("())", false);
        do_test("", true);
        do_test("(}{)", true);
    }

    fn do_test(s: &str, exp: bool) {
        let actual = valid_parentheses(s);
        assert_eq!(
            actual, exp,
            "\nFor the input \"{}\", your result ({}) did not match the expected output ({})",
            s, actual, exp
        );
    }
}
