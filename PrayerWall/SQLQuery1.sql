CREATE table Blog
(Bid int not null primary key identity(1,1),
Btitle nvarchar(150),
BCategory nvarchar(150),
BDesc nvarchar(300),
BUrl nvarchar(250)
);