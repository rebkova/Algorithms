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
- Does not require sorted list/array.
- Compares values in an array/list left from the current element/value called *key*. To make space for the key element, values in array are slid to the right or left in an array, depending on their size. 
- Asymptotic notation: worst case: big theta(n^2), best case: big theta(n), avg case for a random array: big theta(n^2) and almost sorted case: big theta(n). 

4 RECURSION 

4.1 Iterative factorial
- Used to calculate in how many ways we can combine things.

4.2 Recursive factorial
- We calculate the first case first (base case) - typically we know answer to this immediately, and then the second (recursive) case.
