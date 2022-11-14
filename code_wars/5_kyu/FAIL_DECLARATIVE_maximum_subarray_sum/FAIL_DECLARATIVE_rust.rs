// kata fail with only immutable
fn sum(arr: &[i32]) -> i32 {
    let mut tmp = 0;
    arr.iter().fold(0, |acc, x| {
        if acc > tmp {
            tmp = acc + x
        }
        acc + x
    });
    return tmp;
}

fn max_cross(arr: &[i32]) -> i32 {
    let len = arr.len() / 2;
    let (left, right) = arr.split_at(len);
    let left_sum: i32 = sum(left);
    let right_sum: i32 = sum(right);
    left_sum.max(right_sum).max(left_sum + right_sum - arr[len])
}

fn max_sequence(seq: &[i32]) -> i32 {
    let len = seq.len() / 2;
    if len == 1 {
        let tmp = *seq.first().unwrap();
        if tmp > 0 {
            return tmp;
        }
        return 0;
    }
    let (left, right) = seq.split_at(len);
    return max_cross(seq)
        .max(max_sequence(left))
        .max(max_sequence(right));
}

fn main() {
    dbg!(max_sequence(&[-2, 1]));
}

#[cfg(test)]
mod tests {
    use super::max_sequence;

    #[test]
    fn sample_tests() {
        // assert_eq!(max_sequence(&[11]), 11);
        // assert_eq!(max_sequence(&[-32]), 0);
        assert_eq!(max_sequence(&[-2, 1, -3, 4, -1, 2, 1, -5, 4]), 6);
    }
}
