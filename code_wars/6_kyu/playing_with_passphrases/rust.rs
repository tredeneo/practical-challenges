use std::char;

trait Password {
    fn shift(self, valor: u32) -> Self;
    fn invert_case(self, index: u32) -> Self;
    fn complement(self) -> Self;
    fn to_int(self) -> u32;
}
impl Password for char {
    fn to_int(self) -> u32 {
        self as u32
    }
    fn shift(self, valor: u32) -> Self {
        let a = 'a'.to_int();
        let ptr = ((self.to_int() - a + valor) % 26) + a;
        char::from_u32(ptr).unwrap()
    }
    fn complement(self) -> Self {
        ((('0' as u8) + ('9' as u8)) - (self as u8)) as char
    }
    fn invert_case(self, index: u32) -> char {
        if index % 2 == 0 {
            return self.to_ascii_uppercase();
        }
        self.to_ascii_lowercase()
    }
}

fn play_pass(s: &str, n: u32) -> String {
    s.to_string()
        .to_lowercase()
        .chars()
        .enumerate()
        .map(|(index, rune)| match rune {
            c if c.is_numeric() => c.complement(),
            c if c.is_alphabetic() => c.shift(n).invert_case(index as u32),
            c => c,
        })
        .collect::<String>()
        .chars()
        .rev()
        .collect::<String>()
}
fn main() {
    basic_tests();
}
fn dotest(s: &str, n: u32, exp: &str) -> () {
    let ans = play_pass(s, n);
    if ans == exp {
        println!("{:?}, deu certo", true);
        return ();
    }
    println!("original: {:?};", s);
    println!("expect:{:?};", exp);
    println!("actual:{:?};", ans);
    // assert_eq!(ans, exp);
    println!("{};", "-");
}

fn basic_tests() {
    dotest("I LOVE YOU!!!", 1, "!!!vPz fWpM J");
    dotest("I LOVE YOU!!!", 0, "!!!uOy eVoL I");
    dotest(
        "MY GRANMA CAME FROM NY ON THE 23RD OF APRIL 2015",
        2,
        "4897 NkTrC Hq fT67 GjV Pq aP OqTh gOcE CoPcTi aO",
    );
    dotest("AAABBCCY", 1, "zDdCcBbB");
}
