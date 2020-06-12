# Algorithms
Basic algorithms and their codes

1 BINARY SEARCH
- Requires sorted list/array.
- It searches for the required item in the list/array of items by repeatedly dividing the list/array in halves untill it finds the correct item.
- Number of guessings = log2n. n = length of an array

2 SELECTION SORT
- Does not require sorted list/array.
- Finds min value (IndexOfMinimum method) of an array and swaps (Swap method) it with the first item in an array. Iterates in the same fashion through subarrays. 
- Asymptotic notation: Swap: big theta(n), IndexOfMinimum: big theta(n^2), Selectionsort: big theta(n) -> running time of selection sort is big theta(n^2)
- Sidenote: sum of arithmetic series (i.e. how many times we run the for loop in IndexOfMinimum) = n^2/2 + n/2.

3 INSERTION SORT
