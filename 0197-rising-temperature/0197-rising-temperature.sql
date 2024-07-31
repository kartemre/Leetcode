/* Write your T-SQL query statement below */

SELECT 
    V2.id
FROM
    Weather AS V1
    JOIN Weather AS V2 ON V2.recordDate = DATEADD(day, 1, V1.recordDate)
WHERE V1.temperature < V2.temperature