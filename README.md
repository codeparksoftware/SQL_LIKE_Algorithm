# SQL_LIKE_Algorithm
Select * from Students where Name LIKE  'a%o' query has an algorithm to filter the strings by LIKE statement. As you know this LIKE statement search if the word starts with 'a' ends with 'o' . In this point, there becomes performance concerns.Because one million row filtering will take very huge time. My solution aims performs this requirement by O(n) linear complexity.
