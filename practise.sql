create Database Laibary;
create table CSE_Department_Book (semIII varchar(200),semIV varchar(200),semV varchar(200), semVI varchar(200), semVII varchar(200), semVIII varchar(200));
select * from CSE_Department_Book
create table EC_Department_Book (semIII varchar(200),semIV varchar(200),semV varchar(200), semVI varchar(200), semVII varchar(200), semVIII varchar(200));
create table ME_Department_Book (semIII varchar(200),semIV varchar(200),semV varchar(200), semVI varchar(200), semVII varchar(200), semVIII varchar(200));
create table Ex_Department_Book (semIII varchar(200),semIV varchar(200),semV varchar(200), semVI varchar(200), semVII varchar(200), semVIII varchar(200));
select * from EC_Department_Book
select * from ME_Department_Book
select * from Ex_Department_Book
insert into CSE_Department_Book (semIII, semIV, semV, semVI, semVII, semVIII)
values ('50','70','70','70','70','70');
insert into EC_Department_Book (semIII, semIV, semV, semVI, semVII, semVIII)
values ('50','50','50','50','50','50');
insert into ME_Department_Book (semIII, semIV, semV, semVI, semVII, semVIII)
values ('50','70','70','70','70','70');
insert into Ex_Department_Book (semIII, semIV, semV, semVI, semVII, semVIII)
values ('40','40','40','40','40','40');
select * from Ex_Department_Book

SELECT CSE_Department_Book.semIII, EC_Department_Book.semIV, EC_Department_Book.semIII
FROM CSE_Department_Book RIGHT JOIN EC_Department_Book ON CSE_Department_Book.semV = EC_Department_Book.semVII
ORDER BY CSE_Department_Book.semIII;

SELECT ME_Department_Book.semIII, EC_Department_Book.semIV
FROM ME_Department_Book
FULL OUTER JOIN EC_Department_Book ON ME_Department_Book.semIII=EC_Department_Book.semIV
ORDER BY ME_Department_Book.semIII;
GO
CREATE PROCEDURE SelectAllSem
AS
SELECT * FROM CSE_Department_Book
GO;
EXEC SelectAllSem;

