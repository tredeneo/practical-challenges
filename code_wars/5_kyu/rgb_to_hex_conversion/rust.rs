#![allow(dead_code)]

fn letters(exp: i32) -> String {
    if exp < 10 {
        return exp.to_string();
    }
    let tmp = match exp {
        10 => "A",
        11 => "B",
        12 => "C",
        13 => "D",
        14 => "E",
        15 => "F",
        _ => "0",
    };
    tmp.to_string()
}

fn convert(exp: i32) -> String {
    if exp > 255 {
        return "FF".to_owned();
    } else if exp < 1 {
        return "00".to_owned();
    }
    let div = letters(exp / 16);
    let rest = letters(exp % 16);
    div + &rest
}
fn rgb(r: i32, g: i32, b: i32) -> String {
    [convert(r), convert(g), convert(b)].join("")
}
fn main() {
    dbg!(convert(255));
}

macro_rules! compare {
    ( $got : expr, $expected : expr ) => {
        if $got != $expected {
            panic!("Got: {}\nExpected: {}\n", $got, $expected);
        }
    };
}

#[cfg(test)]
mod sample_tests {
    use self::super::*;

    #[test]
    fn tests() {
        compare!(rgb(0, 0, 0), "000000");
        compare!(rgb(1, 2, 3), "010203");
        compare!(rgb(255, 255, 255), "FFFFFF");
        compare!(rgb(254, 253, 252), "FEFDFC");
        compare!(rgb(-20, 275, 125), "00FF7D");
    }
}
