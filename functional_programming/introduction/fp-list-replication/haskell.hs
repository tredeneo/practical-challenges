ver_1 n arr= concatMap(\num -> replicate n num) arr

ver_2 n arr = concatMap(replicate n) arr

ver_3 n = concatMap (replicate n)

ver_4 = concatMap . replicate



f :: Int -> [Int] -> [Int]
f n arr = -- Complete this function

-- This part handles the Input and Output and can be used as it is. Do not modify this part.
main :: IO ()
main = getContents >>=
       mapM_ print. (\(n:arr) -> f n arr). map read. words
