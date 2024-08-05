/* Write your T-SQL query statement below */
SELECT 
    St.student_id, 
    St.student_name, 
    Su.subject_name, 
    COALESCE(COUNT(E.student_id), 0) AS attended_exams
FROM 
    Students AS St
CROSS JOIN 
    Subjects AS Su
LEFT JOIN 
    Examinations AS E 
ON 
    St.student_id = E.student_id 
    AND Su.subject_name = E.subject_name
GROUP BY 
    St.student_id, 
    St.student_name, 
    Su.subject_name