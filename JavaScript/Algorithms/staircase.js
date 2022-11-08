function staircase(n) {
  for (let i = 1; i <= n; i++) {
    // First solution
    // console.log(
    //   Array(n - i)
    //     .fill(" ")
    //     .concat(Array(i).fill("#"))
    //     .join("")
    // );

    // Second solution
    console.log(" ".repeat(n - i) + "#".repeat(i));
  }
}

staircase(6);
