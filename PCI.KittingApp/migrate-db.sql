-- CREATE Table Users
CREATE TABLE "Users" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"EmployeeId"	TEXT UNIQUE,
	"FullName"	TEXT,
	"Email"	TEXT,
	"Password"	TEXT,
	"Role"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
);

-- CREATE Table Transaction Failed
CREATE TABLE "TransactionFailed" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"TypeTransaction"	TEXT,
	"DataTransaction"	TEXT,
	"DateTransaction"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
);

-- CREATE Table Printing Label
CREATE TABLE "PrintingLabel" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"IdTxn"	INTEGER,
	"FinishGood"	TEXT,
	"TypeTxn"	TEXT,
	"DataTxn"	TEXT,
	"PathPrinter"	TEXT,
	"DateTxn"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
);

-- CREATE ADMIN Users
INSERT INTO Users (EmployeeId, FullName, Email, Role, Password) VALUES ('9999', 'Administrator', 'admin@pciltd.com.sg', '0', 'EMmz7PsDP/Q=');