USE [master]
GO
/****** Object:  Database [Student Affairs]    Script Date: 02/06/2022 13:48:09 ******/
CREATE DATABASE [Student Affairs]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Student Affairs', FILENAME = N'D:\devtools\MicrosoftSQL2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\Student Affairs.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Student Affairs_log', FILENAME = N'D:\devtools\MicrosoftSQL2019\MSSQL15.SQLEXPRESS\MSSQL\DATA\Student Affairs_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Student Affairs] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Student Affairs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Student Affairs] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Student Affairs] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Student Affairs] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Student Affairs] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Student Affairs] SET ARITHABORT OFF 
GO
ALTER DATABASE [Student Affairs] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Student Affairs] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Student Affairs] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Student Affairs] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Student Affairs] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Student Affairs] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Student Affairs] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Student Affairs] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Student Affairs] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Student Affairs] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Student Affairs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Student Affairs] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Student Affairs] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Student Affairs] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Student Affairs] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Student Affairs] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Student Affairs] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Student Affairs] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Student Affairs] SET  MULTI_USER 
GO
ALTER DATABASE [Student Affairs] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Student Affairs] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Student Affairs] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Student Affairs] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Student Affairs] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Student Affairs] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Student Affairs] SET QUERY_STORE = OFF
GO
USE [Student Affairs]
GO
/****** Object:  Table [dbo].[branches]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branches](
	[branch_id] [int] IDENTITY(1,1) NOT NULL,
	[branch_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_branches] PRIMARY KEY CLUSTERED 
(
	[branch_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cities]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cities](
	[city_id] [int] IDENTITY(1,1) NOT NULL,
	[city_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_cities] PRIMARY KEY CLUSTERED 
(
	[city_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[classes]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[classes](
	[class_id] [int] IDENTITY(1,1) NOT NULL,
	[class_name] [varchar](10) NOT NULL,
	[class_grade] [int] NULL,
 CONSTRAINT [PK_classes_1] PRIMARY KEY CLUSTERED 
(
	[class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[govenante]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[govenante](
	[gov_id] [int] IDENTITY(1,1) NOT NULL,
	[gov_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_govenante] PRIMARY KEY CLUSTERED 
(
	[gov_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grades]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grades](
	[grade_id] [int] IDENTITY(1,1) NOT NULL,
	[grade_name] [varchar](10) NOT NULL,
 CONSTRAINT [PK_classes] PRIMARY KEY CLUSTERED 
(
	[grade_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[guardian]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[guardian](
	[guardian_id] [int] IDENTITY(1,1) NOT NULL,
	[guardian_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_guardian] PRIMARY KEY CLUSTERED 
(
	[guardian_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[joinYear]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[joinYear](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](10) NULL,
 CONSTRAINT [PK_joinYear] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[languages]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[languages](
	[language_id] [int] IDENTITY(1,1) NOT NULL,
	[language_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_languages] PRIMARY KEY CLUSTERED 
(
	[language_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nationality]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nationality](
	[nat_id] [int] IDENTITY(1,1) NOT NULL,
	[nat_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_nationality] PRIMARY KEY CLUSTERED 
(
	[nat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[parents]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[parents](
	[parent_id] [int] IDENTITY(1,1) NOT NULL,
	[parent_type] [int] NOT NULL,
	[parent_english_name] [varchar](50) NULL,
	[parent_arabic_name] [nvarchar](50) NULL,
	[parent_nid] [char](14) NULL,
	[parent_mobilephone] [varchar](30) NOT NULL,
	[parent_email] [varchar](200) NOT NULL,
	[parent_job] [nvarchar](50) NOT NULL,
	[parent_qualification] [int] NULL,
	[parent_language] [int] NULL,
	[parent_nationality] [int] NULL,
	[parent_passport] [varchar](50) NULL,
	[parent_job_location] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_parents] PRIMARY KEY CLUSTERED 
(
	[parent_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[qualifications]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[qualifications](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_qualifications] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[religions]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[religions](
	[religion_id] [int] IDENTITY(1,1) NOT NULL,
	[religion_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_religions] PRIMARY KEY CLUSTERED 
(
	[religion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[status]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[status](
	[status_id] [int] IDENTITY(1,1) NOT NULL,
	[status_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_status] PRIMARY KEY CLUSTERED 
(
	[status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[students]    Script Date: 02/06/2022 13:48:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[students](
	[student_id] [int] IDENTITY(1,1) NOT NULL,
	[student_branch] [int] NULL,
	[student_grade] [int] NULL,
	[student_class] [int] NULL,
	[student_code] [varchar](50) NULL,
	[student_nid] [char](14) NULL,
	[student_nat] [int] NULL,
	[student_status] [int] NULL,
	[join_year] [int] NOT NULL,
	[staff_son] [bit] NULL,
	[guardian] [int] NULL,
	[parents_separated] [tinyint] NULL,
	[school_abrev] [varchar](50) NULL,
	[student_update] [bit] NULL,
	[student_arabic_fName] [nvarchar](50) NOT NULL,
	[student_arabic_mName] [nvarchar](50) NOT NULL,
	[student_arabic_lName] [nvarchar](50) NOT NULL,
	[student_arabic_fmName] [nvarchar](50) NOT NULL,
	[student_english_fName] [varchar](50) NOT NULL,
	[student_english_mName] [varchar](50) NOT NULL,
	[student_english_lName] [varchar](50) NOT NULL,
	[student_english_fmName] [varchar](50) NOT NULL,
	[dob] [date] NOT NULL,
	[birth_place] [varchar](50) NOT NULL,
	[gender] [tinyint] NOT NULL,
	[religon] [int] NULL,
	[city] [int] NULL,
	[student_address] [nvarchar](50) NOT NULL,
	[student_email] [varchar](100) NULL,
	[student_password] [char](256) NULL,
	[student_affairs1] [nvarchar](50) NULL,
	[student_affairs2] [nvarchar](50) NULL,
	[birth_code] [varchar](50) NULL,
	[student_gov] [int] NULL,
	[emergency_contact] [nvarchar](50) NOT NULL,
	[emergency_phone] [varchar](30) NOT NULL,
	[student_father] [int] NULL,
	[student_mother] [int] NULL,
	[student_passport] [varchar](50) NULL,
	[old_school] [nvarchar](50) NULL,
	[applyingForGrade] [int] NOT NULL,
	[old_school_number] [varchar](50) NULL,
	[leaving_reason] [nvarchar](50) NULL,
	[applied_before] [tinyint] NULL,
	[have_sibling] [tinyint] NULL,
	[subscribe_bus] [tinyint] NULL,
	[reference_name1] [nvarchar](50) NOT NULL,
	[reference_phone1] [varchar](50) NOT NULL,
	[reference_name2] [nvarchar](50) NOT NULL,
	[reference_phone2] [varchar](50) NOT NULL,
 CONSTRAINT [PK_students] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[branches] ON 

INSERT [dbo].[branches] ([branch_id], [branch_name]) VALUES (1, N'Obour')
INSERT [dbo].[branches] ([branch_id], [branch_name]) VALUES (2, N'Jasmine')
SET IDENTITY_INSERT [dbo].[branches] OFF
GO
SET IDENTITY_INSERT [dbo].[cities] ON 

INSERT [dbo].[cities] ([city_id], [city_name]) VALUES (1, N'Obour')
INSERT [dbo].[cities] ([city_id], [city_name]) VALUES (2, N'Mokattam')
SET IDENTITY_INSERT [dbo].[cities] OFF
GO
SET IDENTITY_INSERT [dbo].[classes] ON 

INSERT [dbo].[classes] ([class_id], [class_name], [class_grade]) VALUES (1, N'1A', 1)
INSERT [dbo].[classes] ([class_id], [class_name], [class_grade]) VALUES (2, N'2A', 2)
SET IDENTITY_INSERT [dbo].[classes] OFF
GO
SET IDENTITY_INSERT [dbo].[govenante] ON 

INSERT [dbo].[govenante] ([gov_id], [gov_name]) VALUES (1, N'Cairo')
INSERT [dbo].[govenante] ([gov_id], [gov_name]) VALUES (2, N'Giza')
SET IDENTITY_INSERT [dbo].[govenante] OFF
GO
SET IDENTITY_INSERT [dbo].[grades] ON 

INSERT [dbo].[grades] ([grade_id], [grade_name]) VALUES (1, N'Gr1')
INSERT [dbo].[grades] ([grade_id], [grade_name]) VALUES (2, N'Gr2')
SET IDENTITY_INSERT [dbo].[grades] OFF
GO
SET IDENTITY_INSERT [dbo].[guardian] ON 

INSERT [dbo].[guardian] ([guardian_id], [guardian_name]) VALUES (1, N'Father')
INSERT [dbo].[guardian] ([guardian_id], [guardian_name]) VALUES (2, N'Mother')
INSERT [dbo].[guardian] ([guardian_id], [guardian_name]) VALUES (3, N'Grandparent')
SET IDENTITY_INSERT [dbo].[guardian] OFF
GO
SET IDENTITY_INSERT [dbo].[joinYear] ON 

INSERT [dbo].[joinYear] ([id], [name]) VALUES (1, N'2010-2011 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (2, N'2011-2012 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (3, N'2012-2013 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (4, N'2013-2014 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (5, N'2014-2015 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (6, N'2015-2016 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (7, N'2016-2017 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (8, N'2017-2018 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (9, N'2018-2019 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (10, N'2019-2020 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (11, N'2020-2021 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (12, N'2021-2022 ')
INSERT [dbo].[joinYear] ([id], [name]) VALUES (13, N'2022-2023 ')
SET IDENTITY_INSERT [dbo].[joinYear] OFF
GO
SET IDENTITY_INSERT [dbo].[languages] ON 

INSERT [dbo].[languages] ([language_id], [language_name]) VALUES (1, N'Arabic')
INSERT [dbo].[languages] ([language_id], [language_name]) VALUES (2, N'English')
INSERT [dbo].[languages] ([language_id], [language_name]) VALUES (3, N'French')
INSERT [dbo].[languages] ([language_id], [language_name]) VALUES (4, N'Dutch')
SET IDENTITY_INSERT [dbo].[languages] OFF
GO
SET IDENTITY_INSERT [dbo].[nationality] ON 

INSERT [dbo].[nationality] ([nat_id], [nat_name]) VALUES (1, N'Egyptian')
INSERT [dbo].[nationality] ([nat_id], [nat_name]) VALUES (2, N'English')
SET IDENTITY_INSERT [dbo].[nationality] OFF
GO
SET IDENTITY_INSERT [dbo].[parents] ON 

INSERT [dbo].[parents] ([parent_id], [parent_type], [parent_english_name], [parent_arabic_name], [parent_nid], [parent_mobilephone], [parent_email], [parent_job], [parent_qualification], [parent_language], [parent_nationality], [parent_passport], [parent_job_location]) VALUES (5, 0, NULL, NULL, N'47525855852585', N'12345678901', N'a@a.com', N'a', 1, 1, 1, NULL, N'a')
INSERT [dbo].[parents] ([parent_id], [parent_type], [parent_english_name], [parent_arabic_name], [parent_nid], [parent_mobilephone], [parent_email], [parent_job], [parent_qualification], [parent_language], [parent_nationality], [parent_passport], [parent_job_location]) VALUES (6, 1, N'a', N'سمر', N'15201520215205', N'12345678901', N'a@a.com', N'a', 1, 1, 1, NULL, N'a')
SET IDENTITY_INSERT [dbo].[parents] OFF
GO
SET IDENTITY_INSERT [dbo].[qualifications] ON 

INSERT [dbo].[qualifications] ([id], [name]) VALUES (1, N'Secondary')
INSERT [dbo].[qualifications] ([id], [name]) VALUES (2, N'Bachelor')
INSERT [dbo].[qualifications] ([id], [name]) VALUES (3, N'Master')
INSERT [dbo].[qualifications] ([id], [name]) VALUES (4, N'Doctoral')
SET IDENTITY_INSERT [dbo].[qualifications] OFF
GO
SET IDENTITY_INSERT [dbo].[religions] ON 

INSERT [dbo].[religions] ([religion_id], [religion_name]) VALUES (1, N'Islam')
INSERT [dbo].[religions] ([religion_id], [religion_name]) VALUES (2, N'Christian')
SET IDENTITY_INSERT [dbo].[religions] OFF
GO
SET IDENTITY_INSERT [dbo].[status] ON 

INSERT [dbo].[status] ([status_id], [status_name]) VALUES (1, N'Active')
INSERT [dbo].[status] ([status_id], [status_name]) VALUES (2, N'In-active')
INSERT [dbo].[status] ([status_id], [status_name]) VALUES (3, N'pending')
INSERT [dbo].[status] ([status_id], [status_name]) VALUES (4, N'Accepted')
INSERT [dbo].[status] ([status_id], [status_name]) VALUES (5, N'Rejected')
SET IDENTITY_INSERT [dbo].[status] OFF
GO
SET IDENTITY_INSERT [dbo].[students] ON 

INSERT [dbo].[students] ([student_id], [student_branch], [student_grade], [student_class], [student_code], [student_nid], [student_nat], [student_status], [join_year], [staff_son], [guardian], [parents_separated], [school_abrev], [student_update], [student_arabic_fName], [student_arabic_mName], [student_arabic_lName], [student_arabic_fmName], [student_english_fName], [student_english_mName], [student_english_lName], [student_english_fmName], [dob], [birth_place], [gender], [religon], [city], [student_address], [student_email], [student_password], [student_affairs1], [student_affairs2], [birth_code], [student_gov], [emergency_contact], [emergency_phone], [student_father], [student_mother], [student_passport], [old_school], [applyingForGrade], [old_school_number], [leaving_reason], [applied_before], [have_sibling], [subscribe_bus], [reference_name1], [reference_phone1], [reference_name2], [reference_phone2]) VALUES (3, 1, 1, NULL, NULL, N'54548154145544', 1, NULL, 13, NULL, 1, 0, NULL, 0, N'ش', N'ش', N'ش', N'ش', N'a', N'a', N'a', N'a', CAST(N'2022-06-21' AS Date), N'a', 0, 1, 1, N'a', NULL, NULL, NULL, NULL, NULL, 1, N'a', N'12345678901', 5, 6, NULL, N'a', 1, N'12345678901', N'a', 1, 0, 0, N'a', N'12345678901', N'a', N'12345678901')
SET IDENTITY_INSERT [dbo].[students] OFF
GO
ALTER TABLE [dbo].[classes]  WITH CHECK ADD  CONSTRAINT [FK_classes_grades] FOREIGN KEY([class_grade])
REFERENCES [dbo].[grades] ([grade_id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[classes] CHECK CONSTRAINT [FK_classes_grades]
GO
ALTER TABLE [dbo].[parents]  WITH CHECK ADD  CONSTRAINT [FK_parents_languages] FOREIGN KEY([parent_language])
REFERENCES [dbo].[languages] ([language_id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[parents] CHECK CONSTRAINT [FK_parents_languages]
GO
ALTER TABLE [dbo].[parents]  WITH CHECK ADD  CONSTRAINT [FK_parents_nationality] FOREIGN KEY([parent_nationality])
REFERENCES [dbo].[nationality] ([nat_id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[parents] CHECK CONSTRAINT [FK_parents_nationality]
GO
ALTER TABLE [dbo].[parents]  WITH CHECK ADD  CONSTRAINT [FK_parents_qualifications] FOREIGN KEY([parent_qualification])
REFERENCES [dbo].[qualifications] ([id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[parents] CHECK CONSTRAINT [FK_parents_qualifications]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_branches] FOREIGN KEY([student_branch])
REFERENCES [dbo].[branches] ([branch_id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_branches]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_cities] FOREIGN KEY([city])
REFERENCES [dbo].[cities] ([city_id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_cities]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_classes] FOREIGN KEY([student_class])
REFERENCES [dbo].[classes] ([class_id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_classes]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_Father] FOREIGN KEY([student_father])
REFERENCES [dbo].[parents] ([parent_id])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_Father]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_govenante] FOREIGN KEY([student_gov])
REFERENCES [dbo].[govenante] ([gov_id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_govenante]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_grades] FOREIGN KEY([student_grade])
REFERENCES [dbo].[grades] ([grade_id])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_grades]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_grades_applyingfor] FOREIGN KEY([applyingForGrade])
REFERENCES [dbo].[grades] ([grade_id])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_grades_applyingfor]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_guardian] FOREIGN KEY([guardian])
REFERENCES [dbo].[guardian] ([guardian_id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_guardian]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_joinYear] FOREIGN KEY([join_year])
REFERENCES [dbo].[joinYear] ([id])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_joinYear]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_Mother] FOREIGN KEY([student_mother])
REFERENCES [dbo].[parents] ([parent_id])
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_Mother]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_nationality] FOREIGN KEY([student_nat])
REFERENCES [dbo].[nationality] ([nat_id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_nationality]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_religions] FOREIGN KEY([religon])
REFERENCES [dbo].[religions] ([religion_id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_religions]
GO
ALTER TABLE [dbo].[students]  WITH CHECK ADD  CONSTRAINT [FK_students_status] FOREIGN KEY([student_status])
REFERENCES [dbo].[status] ([status_id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[students] CHECK CONSTRAINT [FK_students_status]
GO
USE [master]
GO
ALTER DATABASE [Student Affairs] SET  READ_WRITE 
GO
