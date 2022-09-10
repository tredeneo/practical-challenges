fn persistence(num: u64) -> u64 {
    if num < 10 {
        return 0;
    }
    let valor = num
        .to_string()
        .chars()
        .map(|f| f.to_string().parse::<u64>().unwrap())
        .product::<u64>();
    return 1 + persistence(valor);
}
fn main() {
    assert_eq!(persistence(39), 3);
    assert_eq!(persistence(4), 0);
    assert_eq!(persistence(25), 2);
    assert_eq!(persistence(999), 4);
}
