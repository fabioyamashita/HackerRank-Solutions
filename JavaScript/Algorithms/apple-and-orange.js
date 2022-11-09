function countApplesAndOranges(s, t, a, b, apples, oranges) {
  let sumApple = apples.reduce(
    (acc, curr) => acc + (curr + a >= s && curr + a <= t ? 1 : 0),
    0
  );

  let sumOrange = oranges.reduce(
    (acc, curr) => acc + (curr + b >= s && curr + b <= t ? 1 : 0),
    0
  );

  console.log(sumApple);
  console.log(sumOrange);
}

countApplesAndOranges(7, 11, 5, 15, [-2, 2, 1], [5, -6]);
