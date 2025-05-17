CREATE TABLE Requests (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT,
    National TEXT,
    Phone TEXT,
    RequestText TEXT
);

CREATE TABLE Complaints (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT,
    National TEXT,
    Phone TEXT,
    ComplaintText TEXT
);

CREATE TABLE Replies (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    RequestId INTEGER,
    ReplyText TEXT,
    FOREIGN KEY(RequestId) REFERENCES Requests(Id)
); 