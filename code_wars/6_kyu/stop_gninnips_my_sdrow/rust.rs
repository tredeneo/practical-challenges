fn spin_words(words: &str) -> String {
    words
        .split(" ")
        .enumerate()
        .map(|(_, str)| {
            if str.len() >= 5 {
                return str.chars().rev().collect::<String>();
            }
            str.to_string()
        })
        .collect::<Vec<String>>()
        .join(" ")
}
fn main() {
    examples();
}
fn examples() {
    println!("{:?},{:?}", spin_words("Welcome"), "emocleW");
    println!(
        "{:?},{}",
        spin_words("Hey fellow warriors"),
        "Hey wollef sroirraw"
    );
    println!("{:?},{}", spin_words("This is a test"), "This is a test");
    println!(
        "{:?},{}",
        spin_words("This is another test"),
        "This is rehtona test"
    );
    println!(
        "{:?},{}",
        spin_words("You are almost to the last test"),
        "You are tsomla to the last test"
    );
    println!(
        "{:?},{}",
        spin_words("Just kidding there is still one more"),
        "Just gniddik ereht is llits one more"
    );
    println!(
        "{:?},{}",
        spin_words("Seriously this is the last one"),
        "ylsuoireS this is the last one"
    );
}
