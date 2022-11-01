#![allow(unused_variables)]

use itertools::Itertools;
fn in_array(arr_a: &[&str], arr_b: &[&str]) -> Vec<String> {
    let mut tmp = arr_a
        .iter()
        .map(|x| {
            let count = arr_b
                .iter()
                .filter(|y| y.contains(&(x.to_string())))
                .count();
            if count >= 1 {
                x.to_string()
            } else {
                "".to_string()
            }
        })
        .filter(|x| x.len() > 0)
        .unique()
        .collect::<Vec<String>>();

    tmp.sort();
    tmp
}
fn main() {
    let tmp = (
        in_array(
            &["xyz", "live", "strong"],
            &["lively", "alive", "harp", "sharp", "armstrong"],
        ),
        ["live", "strong"],
    );
    println!("{:?}", tmp);
}

#[cfg(test)]
mod tests {
    use super::*;

    #[test]
    fn examples() {
        assert_eq!(
            in_array(
                &["xyz", "live", "strong"],
                &["lively", "alive", "harp", "sharp", "armstrong"],
            ),
            ["live", "strong"]
        );

        assert_eq!(
            in_array(
                &["live", "strong", "arp"],
                &["lively", "alive", "harp", "sharp", "armstrong"],
            ),
            ["arp", "live", "strong"]
        );

        assert_eq!(
            in_array(
                &["tarp", "mice", "bull"],
                &["lively", "alive", "harp", "sharp", "armstrong"],
            ),
            [] as [&str; 0]
        );

        assert_eq!(
            in_array(
                &["live", "strong", "arp", "arp"],
                &["lively", "alive", "harp", "sharp", "armstrong"],
            ),
            ["arp", "live", "strong"]
        );
    }
}
