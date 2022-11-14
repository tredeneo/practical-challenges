fn convert_check(number: &str) -> Option<u8> {
    match number.parse::<u8>() {
        Ok(s) => Some(s),
        Err(_) => None,
    }
}
fn is_valid_ip(ip: &str) -> bool {
    let mut iter = ip.split(".").map(|f| match f {
        s if s.starts_with("0") && !s.ends_with("0") => match convert_check(s) {
            Some(s) => {
                if s == 0 {
                    true
                } else {
                    false
                }
            }
            None => false,
        },
        s if s.starts_with("0") && s.len() > 1 => false,
        s => match convert_check(s) {
            Some(_) => true,
            None => false,
        },
    });
    let count = iter.clone().count();
    let check = iter.all(|f| f == true);
    if count == 4 {
        return check;
    }
    false
}

#[cfg(test)]
mod tests {
    use super::is_valid_ip;

    #[test]
    fn sample_test() {
        assert!(is_valid_ip("0.0.0.0"));
        assert!(is_valid_ip("12.255.56.1"));
        assert!(is_valid_ip("137.255.156.100"));
        assert!(!is_valid_ip(""));
        assert!(!is_valid_ip("abc.def.ghi.jkl"));
        assert!(!is_valid_ip("123.456.789.0"));
        assert!(!is_valid_ip("12.34.56"));
        assert!(!is_valid_ip("01.02.03.04"));
        assert!(!is_valid_ip("256.1.2.3"));
        assert!(!is_valid_ip("1.2.3.4.5"));
        assert!(!is_valid_ip("123,45,67,89"));
        assert!(!is_valid_ip("1e0.1e1.1e2.2e2"));
        assert!(!is_valid_ip(" 1.2.3.4"));
        assert!(!is_valid_ip("1.2.3.4 "));
        assert!(!is_valid_ip("12.34.56.-7"));
        assert!(!is_valid_ip("1.2.3.4\n"));
        assert!(!is_valid_ip("\n1.2.3.4"));
    }
}
