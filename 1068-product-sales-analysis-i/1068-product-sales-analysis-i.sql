/* Write your T-SQL query statement below */

SELECT 
    P.product_name,
    S.year,
    S.price
FROM 
    Sales AS S
    JOIN Product AS P ON P.product_id = S.product_id
