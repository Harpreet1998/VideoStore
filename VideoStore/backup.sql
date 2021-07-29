CREATE DATABASE [videostore]
GO
USE [videostore]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[cust_id] [int] IDENTITY(100,1) NOT NULL,
	[first_name] [varchar](100) NULL,
	[last_name] [varchar](100) NULL,
	[address] [varchar](500) NULL,
	[phone_no] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[viewAllCustomer]
as
SELECT cust_id, first_name + ' ' + last_name AS name
FROM     dbo.customer;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movies](
	[movie_id] [int] IDENTITY(1000,1) NOT NULL,
	[title] [varchar](100) NULL,
	[rating] [float] NULL,
	[rental_cost] [float] NULL,
	[release_year] [int] NULL,
	[copies] [int] NULL,
	[plot] [text] NULL,
	[genre_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[movie_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[viewAllMovie]
as
SELECT movie_id, title + ' $' + CAST(rental_cost AS varchar(10)) AS title
FROM     movies;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[genres](
	[genre_id] [int] IDENTITY(1,1) NOT NULL,
	[genre_name] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[genre_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rented_movies](
	[rent_id] [int] IDENTITY(1,1) NOT NULL,
	[movie_id] [int] NULL,
	[cust_id] [int] NULL,
	[date_rented] [datetime] NULL,
	[date_returned] [datetime] NULL,
	[rented_cost] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[rent_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[customer] ON 
GO
INSERT [dbo].[customer] ([cust_id], [first_name], [last_name], [address], [phone_no]) VALUES (100, N'Deborah', N'N Litz', N'147  Chettle Court, Blockhouse Bay, Auckland', N'0222106584')
GO
INSERT [dbo].[customer] ([cust_id], [first_name], [last_name], [address], [phone_no]) VALUES (101, N'Rose', N'V Wiseman', N'127  Ostler Road, Mount Cook', N'0203096468')
GO
INSERT [dbo].[customer] ([cust_id], [first_name], [last_name], [address], [phone_no]) VALUES (102, N'Kandi', N'R Raglin', N'50  Guinness Street, Scarborough', N'0221288894')
GO
INSERT [dbo].[customer] ([cust_id], [first_name], [last_name], [address], [phone_no]) VALUES (103, N'Earl', N'K Forde', N'96  English Avenue, Mount Grand', N'0212405583')
GO
SET IDENTITY_INSERT [dbo].[customer] OFF
GO
SET IDENTITY_INSERT [dbo].[genres] ON 
GO
INSERT [dbo].[genres] ([genre_id], [genre_name]) VALUES (1, N'Action')
GO
INSERT [dbo].[genres] ([genre_id], [genre_name]) VALUES (3, N'Adventure')
GO
INSERT [dbo].[genres] ([genre_id], [genre_name]) VALUES (2, N'Animated')
GO
INSERT [dbo].[genres] ([genre_id], [genre_name]) VALUES (4, N'Comedy')
GO
INSERT [dbo].[genres] ([genre_id], [genre_name]) VALUES (5, N'Drama')
GO
INSERT [dbo].[genres] ([genre_id], [genre_name]) VALUES (6, N'Fantasy')
GO
INSERT [dbo].[genres] ([genre_id], [genre_name]) VALUES (7, N'Historical')
GO
SET IDENTITY_INSERT [dbo].[genres] OFF
GO
SET IDENTITY_INSERT [dbo].[movies] ON 
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [copies], [plot], [genre_id]) VALUES (1000, N'Tenet', 5, 5, 2020, NULL, NULL, 1)
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [copies], [plot], [genre_id]) VALUES (1001, N'AVA', 5, 5, 2019, NULL, NULL, 2)
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [copies], [plot], [genre_id]) VALUES (1002, N'Monster Hunter', 3, 2, 2015, NULL, NULL, 6)
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [copies], [plot], [genre_id]) VALUES (1003, N'Mortel Engine', 4, 5, 2018, NULL, NULL, 6)
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [copies], [plot], [genre_id]) VALUES (1004, N'Tom & Jerry', 5, 5, 2020, NULL, NULL, 4)
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [copies], [plot], [genre_id]) VALUES (1005, N'Work It', 4, 5, 2016, NULL, NULL, 4)
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [copies], [plot], [genre_id]) VALUES (1006, N'Treasure', 4, 2, 2015, NULL, NULL, 5)
GO
INSERT [dbo].[movies] ([movie_id], [title], [rating], [rental_cost], [release_year], [copies], [plot], [genre_id]) VALUES (1007, N'New Order', 4, 2, 2015, NULL, NULL, 5)
GO
SET IDENTITY_INSERT [dbo].[movies] OFF
GO
SET IDENTITY_INSERT [dbo].[rented_movies] ON 
GO
INSERT [dbo].[rented_movies] ([rent_id], [movie_id], [cust_id], [date_rented], [date_returned], [rented_cost]) VALUES (1, 1000, 100, CAST(N'2021-07-06T00:06:24.877' AS DateTime), NULL, 5)
GO
INSERT [dbo].[rented_movies] ([rent_id], [movie_id], [cust_id], [date_rented], [date_returned], [rented_cost]) VALUES (2, 1003, 100, CAST(N'2021-07-06T00:06:24.877' AS DateTime), CAST(N'2021-07-06T00:06:51.303' AS DateTime), 5)
GO
INSERT [dbo].[rented_movies] ([rent_id], [movie_id], [cust_id], [date_rented], [date_returned], [rented_cost]) VALUES (3, 1006, 101, CAST(N'2021-07-06T00:06:24.877' AS DateTime), NULL, 2)
GO
SET IDENTITY_INSERT [dbo].[rented_movies] OFF
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [dbo].[genres] ADD UNIQUE NONCLUSTERED 
(
	[genre_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[movies]  WITH CHECK ADD FOREIGN KEY([genre_id])
REFERENCES [dbo].[genres] ([genre_id])
GO
ALTER TABLE [dbo].[rented_movies]  WITH CHECK ADD FOREIGN KEY([cust_id])
REFERENCES [dbo].[customer] ([cust_id])
GO
ALTER TABLE [dbo].[rented_movies]  WITH CHECK ADD FOREIGN KEY([movie_id])
REFERENCES [dbo].[movies] ([movie_id])
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[procDisplayRentedMovies]
as
select rent_id, first_name + ' ' + last_name as name,address,phone_no, title , rm.rented_cost , date_rented, date_returned
from rented_movies rm join customer c on rm.cust_id = c.cust_id
join movies m on rm.movie_id = m.movie_id;

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[procDisplayRentedOutMovies]
as
select rent_id, first_name + ' ' + last_name as name,address,phone_no, title , rm.rented_cost , date_rented, date_returned
from rented_movies rm join customer c on rm.cust_id = c.cust_id
join movies m on rm.movie_id = m.movie_id where date_returned is null;
GO
