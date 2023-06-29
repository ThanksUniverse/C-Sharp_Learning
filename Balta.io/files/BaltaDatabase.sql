create database [balta]
drop database [balta]

use [balta]
go

drop table [Student]
create table [Student](
    [Id] UNIQUEIDENTIFIER not null,
    [Name] nvarchar(50) not null,
    [Email] nvarchar(100) not null,
    [Document] nvarchar(25) null,
    [Phone] nvarchar(20) null,
    [Birthdate] datetime null,
    [CreateDate] datetime not null default(GetDate())
    constraint [PK_Student] primary key([Id])
)

create table [Author](
    [Id] UNIQUEIDENTIFIER not null,
    [Name] nvarchar(80) not null,
    [Title] nvarchar(80) not null,
    [Image] nvarchar(1024) not null,
    [Bio] nvarchar(2000) not null,
    [Url] nvarchar(450) not null,
    [Email] nvarchar(160) not null,
    [Type] tinyint not null, -- 0 a 255

    constraint [PK_Author] Primary Key ([Id])
)

create table [Career](
    [Id] UNIQUEIDENTIFIER not null,
    [Title] nvarchar(160) not null,
    [Summary] nvarchar(2000) not null,
    [Url] nvarchar(1024) not null,
    [DurationInMinutes] int not null,
    [Active] bit not null,
    [Featured] bit not null,
    [Tags] nvarchar(160) not null,

    constraint [PK_Career] Primary Key ([Id])
)

create table [Category](
    [Id] uniqueidentifier not null,
    [Title] nvarchar(160) not null,
    [Url] nvarchar(1024) not null,
    [Summary] nvarchar(2000) not null,
    [Order] int not null,
    [Description] text not null,
    [Featured] bit not null,

    constraint [PK_Category] Primary Key ([Id])
)

create table [Course](
    [Id] uniqueidentifier not null,
    [Tag] nvarchar(20) not null,
    [Title] nvarchar(160) not null,
    [Summary] nvarchar(2000) not null,
    [Url] nvarchar(1024) not null,
    [Level] tinyint not null,
    [DurationInMinutes] int not null,
    [CreateDate] datetime not null,
    [LastUpdateDate] datetime not null,
    [Active] bit not null,
    [Free] bit not null,
    [Featured] bit not null,
    [AuthorId] uniqueidentifier null,
    [CategoryId] uniqueidentifier null,
    [Tags] nvarchar(160) not null,

    constraint [PK_Couse] Primary Key([Id]),
    constraint [FK_Course_Author_AuthorId] Foreign Key([AuthorId]) references [Author] ([Id]) on delete no action,
    constraint [FK_Course_Category_CategoryId] Foreign Key([CategoryId]) references [Category] ([Id]) on delete no action
)

create table [CareerItem](
    [CareerId] uniqueidentifier not null,
    [CourseId] uniqueidentifier not null,
    [Title] nvarchar(160) not null,
    [Description] text not null,
    [Order] tinyint not null,
    
    constraint [PK_CareerItem] primary key ([CourseId], [CareerId]),
    constraint [FK_CareerItem_Career_CareerId] foreign key ([CareerId]) references [Career] ([Id]) on delete no action,
    constraint [FK_CareerItem_Course_CourseId] foreign key ([CourseId]) references [Course] ([Id]) on delete no action
)

create table [StudentCourse](
    [CourseId] uniqueidentifier not null,
    [StudentId] uniqueidentifier not null,
    [Progress] tinyint not null,
    [Favorite] bit not null,
    [StartDate] datetime not null,
    [LastUpdateDate] datetime null default (GetDate()),

    constraint [PK_StudentCourse] primary key ([CourseId], [StudentId]),
    constraint [FK_StudentCourse_Course_CourseId] foreign key ([CourseId]) references [Course] ([Id]) on delete no action,
    constraint [FK_StudentCourse_Student_StudentId] foreign key ([StudentId]) references [Student] ([Id]) on delete no action

)