-- Vraag 1 (Categorie: Sport)
INSERT INTO Questions (CategoryId, Text, TimeLimitSeconds)
VALUES (2, 'Welke sport wordt gespeeld op Wimbledon?', 15);

DECLARE @q1 INT = SCOPE_IDENTITY();
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q1, 'Tennis', 1);
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q1, 'Voetbal', 0);
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q1, 'Basketbal', 0);
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q1, 'Honkbal', 0);

-- Vraag 2 (Categorie: Auto’s)
INSERT INTO Questions (CategoryId, Text, TimeLimitSeconds)
VALUES (1, 'Welk automerk maakt de Golf?', 15);

DECLARE @q2 INT = SCOPE_IDENTITY();
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q2, 'Volkswagen', 1);
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q2, 'BMW', 0);
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q2, 'Audi', 0);
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q2, 'Mercedes', 0);

-- Vraag 3 (Categorie: Geschiedenis)
INSERT INTO Questions (CategoryId, Text, TimeLimitSeconds)
VALUES (3, 'Wie was de eerste president van de Verenigde Staten?', 15);

DECLARE @q3 INT = SCOPE_IDENTITY();
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q3, 'George Washington', 1);
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q3, 'Abraham Lincoln', 0);
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q3, 'John Adams', 0);
INSERT INTO Answers (QuestionId, Text, IsCorrect) VALUES (@q3, 'Thomas Jefferson', 0);
