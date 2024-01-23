# GA_InsertionSort_Ronda

Pseudocode for Insertion Array:

Get the length of the array.

Iterate through the array, beginning at the second element.
Save the value of the current element. Compare it to the element before it. 
If the current element belongs before the previous element, shift the previous element forward. 
When the previous element does not need to be shifted, save the element to the current index.
(Because all of the previous elements have been sorted, 
we know the current element is in the correct spot when the previous element belongs before it.)
Continue this process until the last element in the array is reached.

