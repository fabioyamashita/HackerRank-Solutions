function plusMinus(arr) {
  const res = [0, 0, 0];

  arr.forEach((value) => {
    if (value > 0) res[0]++;
    else if (value < 0) res[1]++;
    else res[2]++;
  });

  res.forEach((value) => console.log(value / arr.length));
}

plusMinus([-4, 3, -9, 0, 4, 1]);
