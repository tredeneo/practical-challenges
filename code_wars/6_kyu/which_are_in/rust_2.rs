use itertools::Itertools;

fn in_array(arr_a: &[&str], arr_b: &[&str]) -> Vec<String> {
    arr_a
        .iter()
        .map(|x| x.to_string())
        .filter(|x| arr_b.into_iter().any(|y| y.contains(x.as_str())))
        .unique()
        .sorted()
        .collect()
}
