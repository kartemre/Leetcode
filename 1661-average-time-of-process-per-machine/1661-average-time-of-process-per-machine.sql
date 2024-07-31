/* Write your T-SQL query statement below */

SELECT 
    V1.machine_id,
    ROUND(AVG(V2.timestamp - V1.timestamp), 3) AS processing_time
FROM
    Activity AS V1
    JOIN Activity AS V2 ON V2.process_id = V1.process_id AND V1.machine_id = V2.machine_id 
    AND V1.timestamp < V2.timestamp
GROUP BY V1.machine_id