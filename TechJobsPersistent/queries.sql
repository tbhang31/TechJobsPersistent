--Part 1

Columns:
Id int AI PK 
Name longtext 
EmployerId int

--Part 2

SELECT * FROM techjobs.employers where location="st louis"

--Part 3

SELECT * 
FROM techjobs.skills
LEFT JOIN techjobs.jobskills ON techjobs.skills.Id = techjobs.jobskills.SkillId
RIGHT JOIN techjobs.jobs ON techjobs.jobskills.JobId = techjobs.jobs.Id
WHERE techjobs.jobs.Name IS NOT NULL
ORDER BY techjobs.jobs.Name ASC