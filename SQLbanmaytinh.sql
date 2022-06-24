Create database banmaytinh
go

use banmaytinh
go




-- tao bang mo dau
--Account, mathangCategory,mathang,phieunhap,orther,bill,billInfo

create table Account(
	userName Nvarchar(100) primary key,
	disName Nvarchar(100) not null,
	passWord Varchar(1000) not null,
	type int not null default 0 -- 1: ke toan && 0: saff
)
go

Create table mathangCategory(
	id int identity primary key,
	name Nvarchar(100) not null,
)
go

create table mathang(
	id int identity primary key,
	name Nvarchar(100),
	idCategory int not null,
	price int not null default 0,
	
	foreign key (idCategory) References dbo.mathangCategory(id),
)
go

create table phieuNhap(
	dateCheckIn Date not null default Getdate(),
	idCategory int not null,
	idMatHang int not null,
	count int not null default 0,
	price int not null default 0,

	CONSTRAINT phID_pk PRIMARY KEY ( idCategory,idMatHang),

	foreign key (idMatHang) references dbo.mathang (id),
	foreign key (idCategory) References dbo.mathangCategory (id),
)
go


create table orther(
	idOrther int identity primary key,
	idCus Nvarchar(100) not null,
	foreign key (idCus) references dbo.Customs(idCus), 
)
go

create table bill(
	id int identity primary key,
	dateCheckIn Date not null default Getdate(),
	dateChenkOut Date,
	idOrther int not null,
	st int not null default 0, --1 da thanh toan && 0 chua thanh toan
	tinhTrang Nvarchar(50) not null default N' ',
	foreign key (idOrther) references dbo.orther(idOrther),
)
go



create table billInfo(
	id int identity primary key,
	idBill int not null,
	idMatHang int not null,
	count int not null default 0,
	foreign key (idBill) references dbo.Bill(id),
	foreign key (idMatHang) references dbo.mathang(id)
)
go

create table Customs(
	idCus Nvarchar(100) primary key,
	Name Nvarchar(100) not null,
	Std varchar(20) not null,
)
go

--tao bang ket thuc

--them du lieu

Create PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
as 
begin
	select * from dbo.Account where userName = @userName and passWord = @passWord
end
go

select * from dbo.Account 
insert into dbo.Account values (N'admin',N'AD','1',0);


--Reset identity
-- nhung table co identity billInfo, bill , orther ,   mathangCategory,mathang
DBCC CHECKIDENT ('orther', RESEED, 0);
GO
DBCC CHECKIDENT ('billInfo', RESEED, 0);
GO
DBCC CHECKIDENT ('bill', RESEED, 0);
GO

--them danh muc
insert into dbo.mathangCategory (name) values (N'Chip')
insert into dbo.mathangCategory (name) values (N'Main')
insert into dbo.mathangCategory (name) values (N'Ram')
insert into dbo.mathangCategory (name) values (N'VGA')
insert into dbo.mathangCategory (name) values (N'GPU')
insert into dbo.mathangCategory (name) values (N'Case')
go

--them mat hang
insert into dbo.mathang (name, idCategory, price) values (N'I3-3',1,2290000)
insert into dbo.mathang (name, idCategory, price) values (N'I3-4',1,3290000)
insert into dbo.mathang (name, idCategory, price) values (N'H61',2,800000)
insert into dbo.mathang (name, idCategory, price) values (N'H81',2,900000)
insert into dbo.mathang (name, idCategory, price) values (N'D3-4G',3,300000)
insert into dbo.mathang (name, idCategory, price) values (N'D3-8G',3,600000)
insert into dbo.mathang (name, idCategory, price) values (N'GT630',4,900000)
insert into dbo.mathang (name, idCategory, price) values (N'GT730',4,1200000)
insert into dbo.mathang (name, idCategory, price) values (N'500W',5,400000)
insert into dbo.mathang (name, idCategory, price) values (N'550W',5,450000)
insert into dbo.mathang (name, idCategory, price) values (N'VP',6,120000)
insert into dbo.mathang (name, idCategory, price) values (N'LED',6,600000)
go


select dbo.mathangCategory.name as 'Danh mục', dbo.mathang.name as 'mặt hàng',dbo.phieuNhap.count as 'số lượng',dbo.phieuNhap.price as 'giá nhập',dbo.phieuNhap.dateCheckIn as 'ngày nhập' from dbo.mathang,dbo.mathangCategory,dbo.phieuNhap where dbo.mathangCategory.id = dbo.phieuNhap.idCategory and dbo.mathang.id = dbo.phieuNhap.idMatHang
go

Create PROC USP_InsertPhieuNhap
@idCategory int, @idMatHang int, @count Int, @price int
as
begin
	declare @isExitsKho int
	declare @mathangCount int

	select @isExitskho = idCategory,@mathangCount = count from dbo.phieuNhap where idCategory = @idCategory and idMatHang = @idMatHang

	if (@isExitsKho >0)
	begin
		declare @newCount int = @mathangCount + @count
		if(@newCount > 0)
			update dbo.phieuNhap set price = @price, count = @mathangCount + @count where idMatHang = @idMatHang
		else
			delete dbo.phieuNhap where idCategory = @idCategory and idMatHang = @idMatHang
	end
	else
	begin 
		insert into dbo.phieuNhap(idCategory,idMatHang,count,price) values (@idCategory, @idMatHang , @count,@price)
	end
end
go

--lay danh sanh dat hang
create proc USP_GetOrtherList
as  
	select dbo.orther.idOrther, dbo.Customs.Name, dbo.Customs.Std
	from dbo.orther, dbo.Customs, dbo.bill
	where dbo.orther.idCus = dbo.Customs.idCus and dbo.bill.st = 0
go
--lay danh sach da ban hang
Create PROC USP_UpdatePhieuNhap @idOrther int
as
begin
	declare @mathangCount int

	declare @idmathang int 
	select @idmathang = COUNT(mathang.id) from dbo.mathang

	declare @billID int
	select @billID =COUNT(bill.id) FROM dbo.billInfo,dbo.bill,dbo.orther  where bill.id = billInfo.idBill and bill.idOrther = orther.idOrther and orther.idOrther = @idOrther
	declare @Bill int = 0

	declare @idbill int = 0
	while @Bill < @billID
	begin
		while @idbill < @idmathang
		begin
			select @mathangCount = bi.count from dbo.phieuNhap as ph,dbo.billInfo as bi,dbo.bill as b
			where ph.idMatHang = bi.idMatHang and b.idOrther = @idOrther and bi.idBill = b.id and bi.idMatHang = @idbill and bi.idBill = @Bill
			declare @doProc int
			select @doProc = bill.id from bill,orther where orther.idOrther = @idOrther
			if (@doProc = @idOrther )
				update dbo.phieuNhap set count= dbo.phieuNhap.count - @mathangCount where @idbill = idMatHang 
			set @idbill = @idbill +1	
		end
		set @Bill = @Bill +1
	end
end
go


select * from Customs

select * from bill
select * from billInfo
select * from orther
select * from phieuNhap
select * from mathang

delete from Customs
delete from orther
delete from bill

go


insert into dbo.Customs (idCus,Name,Std) values ('KH01','Nguyen Anh Tai','036xxxxxx')
insert into dbo.orther (idCus) values ('KH01')
insert into bill(idOrther) values(1)
insert into billInfo(idBill,idMatHang,count) values (1,1,5)
insert into billInfo(idBill,idMatHang,count) values (1,2,5)
insert into billInfo(idBill,idMatHang,count) values (1,3,5)
go


select dateCheckIn, h.name		
from dbo.phieuNhap as ph,dbo.mathang as h
where dateCheckIn >= '20220114' and ph.idMatHang = h.id

Create proc USP_GetListNhap 
@dateCheckIn date 
as
begin 
	 select dateCheckIn, h.name	,ph.price as N'giá nhập'	
	from dbo.phieuNhap as ph,dbo.mathang as h
	where dateCheckIn >= @dateCheckIn and ph.idMatHang = h.id
end
go

Create proc USP_GetListXuat
@dateCheckIn date, @dateCheckOut date
as
begin 
	 select b.dateCheckIn, b.dateChenkOut,C.Name,b.tinhTrang
	from dbo.bill as b,dbo.orther as o,dbo.Customs AS c
	where dateCheckIn >= @dateCheckIn and dateChenkOut<= @dateCheckOut and o.idCus = c.idCus and b.idOrther = o.idOrther
end
go

