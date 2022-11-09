function getTotalX(a, b) {
  let count = 0;

  for (let i = a[a.length - 1]; i <= b[0]; i++) {
    let doCount = true;

    for (let j = 0; j < a.length; j++) {
      if (i % a[j] != 0) {
        doCount = false;
        break;
      }
    }

    for (let k = 0; k < b.length; k++) {
      if (b[k] % i != 0) {
        doCount = false;
        break;
      }
    }

    if (doCount) count++;
  }

  return count;
}
