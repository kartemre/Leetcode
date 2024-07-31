/* Write your T-SQL query statement below */

Select Distinct viewer_id AS id From Views 
Where author_id = viewer_id
Order BY viewer_id ASC