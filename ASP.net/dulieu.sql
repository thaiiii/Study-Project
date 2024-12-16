use master
go
if DB_ID('HocSinhDB') is not null
	drop database HocSinhDB;
go
create database HocSinhDB;
go
use HocSinhDB;

go
create table LopHoc(
malop int primary key,
tenlop nvarchar(25));

go
insert into LopHoc (malop,tenlop) values(1,'12 A');
insert into LopHoc (malop,tenlop) values(2,'12 B');
insert into LopHoc (malop,tenlop) values(3,'12 C');

go
create table HocSinh(
sbd nvarchar(10) primary key,
hoten nvarchar(50),
anhduthi nvarchar(50),
malop int foreign key references LopHoc(malop),
diemthi float);

go
insert into HocSinh values('HaUI01',N'Nguyen Lan Anh','a01.jpg',1,7);
insert into HocSinh values('HaUI02',N'Tran Thi Huong','a02.jpg',2,6);
insert into HocSinh values('HaUI03',N'Le Van Ha','a03.jpg',3,5);
insert into HocSinh values('HaUI04',N'Pham Hong Linh','a04.jpg',1,8);
insert into HocSinh values('HaUI05',N'Vu Van Hung','a05.jpg',2,9);
insert into HocSinh values('HaUI06',N'Nguyen Hai Yen','a06.jpg',3,10);
insert into HocSinh values('HaUI07',N'Phan My Ha','a07.jpg',1,3);
insert into HocSinh values('HaUI08',N'Le Phuong Thuy','a08.jpg',2,2);
insert into HocSinh values('HaUI09',N'Pham Phi Hung','a09.jpg',3,4);
insert into HocSinh values('HaUI10',N'Nguyen Cong Tuan','a10.jpg',1,8);

go
select * from HocSinh where malop=1;