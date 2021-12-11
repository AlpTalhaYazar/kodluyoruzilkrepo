# ***Insertion Sort***

```
[ 22, 27, 16, 2, 18, 6 ] -> Insertion Sort
```

---
### 1. Write the stages of the above sequence according to the sort type.
> - [ 22, 27, 16,  2, 18,  6 ] - Stage 1 (n)
> - [  2, 27, 16, 22, 18,  6 ] - Stage 2 (n-1)
> - [  2,  6, 16, 22, 18, 27 ] - Stage 3 (n-2)
> - [  2,  6, 16, 18, 22, 27 ] - Stage 4 (1)
---
---
### 2. Write the Big-O notation.
> ![](https://cdn.upload.systems/uploads/4PGINCcg.png)
> 
> ![](https://cdn.upload.systems/uploads/1bcmyjZs.png)
---
---
### 3. Time Complexity: 
* Average case: The number we are looking for is in the middle,
* Worst case: The number we are looking for is at the end,
* Best case: The number we're looking for is at the very beginning of the array.
> Average Case : [ 22, 27, 16, 2, 18, 6 ] => 16, 2
> 
> Worst Case : [ 22, 27, 16, 2, 18, 6 ] => 6
> 
> Best Case : [ 22, 27, 16, 2, 18, 6 ] => 22
---
---
### 4. What case does the number 18 fall into after the array is sorted? Write.
> Since it is in the middle of the array, it is in the scope of the ***Average Case***.
---