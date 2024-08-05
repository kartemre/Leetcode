/* Write your T-SQL query statement below */
SELECT E.name , B.bonus
FROM 
    Employee AS E
    LEFT JOIN Bonus AS B ON B.empId = E.empId
WHERE B.bonus < 1000 OR B.bonus IS NULL;