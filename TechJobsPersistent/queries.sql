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

SELECT name, description
FROM techjobs.skills
FULL JOIN techjobs.jobskills ON techjobs.skills.Id = techjobs.jobskills.skillid
WHERE techjobs.skills.Id = techjobs.jobskills.skillid;
