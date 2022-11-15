function pageCount(n, p) {
  const fromPage1 = Math.ceil((p - 1) / 2);
  let fromLastPage = 0;

  if (n % 2 === 0) {
    fromLastPage = Math.ceil((n - p) / 2);
  } else {
    fromLastPage = Math.floor((n - p) / 2);
  }

  return Math.min(fromPage1, fromLastPage);
}

console.log(pageCount(6, 5));
