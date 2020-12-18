--Part 1

--int Id;
--longtext Name;
--int EmployerId;

SELECT * FROM techjobs.jobs;


--Part 2

SELECT Location
FROM techjobs.employers
WHERE Location = "St Louis City";

--Part 3

SELECT *
FROM skills
LEFT JOIN jobskills ON skills.Id = jobskills.SkillId
WHERE jobskills.JobId IS NOT NULL
ORDER BY Name ASC; 