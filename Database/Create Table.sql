 
CREATE TABLE [dbo].[UserDetails](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[MobileNo] [varchar](50) NULL,
	[EmailId] [varchar](50) NULL,
	[RoleId] [int] NULL,
	[GenderId] [int] NULL,
	[DOB] [varchar](50) NULL,
	[CreateDate] [datetime] NULL DEFAULT (getdate()),
	[IsDelete] [int] NULL DEFAULT ((0)),
	[IsActive] [int] NULL DEFAULT ((1)),
	[IsSuperUser] [int] NULL DEFAULT ((0)),
 CONSTRAINT [PK_UserDetails] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
 
CREATE TABLE [dbo].[Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
	[IsActive] [bit] NULL DEFAULT ((0)),
	[IsDelete] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
 
SET IDENTITY_INSERT [dbo].[UserDetails] ON 

GO
INSERT [dbo].[UserDetails] ([UserId], [UserName], [Password], [FirstName], [LastName], [MobileNo], [EmailId], [RoleId], [GenderId], [DOB], [CreateDate], [IsDelete], [IsActive], [IsSuperUser]) VALUES (1, N'jus', N'jus', N'Justine', N'Clement', N'9578329553', N'jus@jus.com', 1, 1, N'04/06/1988', CAST(N'2022-08-25 23:41:11.440' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UserDetails] ([UserId], [UserName], [Password], [FirstName], [LastName], [MobileNo], [EmailId], [RoleId], [GenderId], [DOB], [CreateDate], [IsDelete], [IsActive], [IsSuperUser]) VALUES (2, N'admin', N'jus', N'Admin', N'', N'9578329553', N'admin@admin.com', 1, 1, N'04/06/1988', CAST(N'2022-08-25 23:41:59.023' AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[UserDetails] ([UserId], [UserName], [Password], [FirstName], [LastName], [MobileNo], [EmailId], [RoleId], [GenderId], [DOB], [CreateDate], [IsDelete], [IsActive], [IsSuperUser]) VALUES (3, N'tony', N'tony', N'Leon', N'Leon', N'111111', N'jus@jus.com', 1, 1, N'Aug 25 2022 11:57PM', CAST(N'2022-08-25 23:57:26.767' AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[UserDetails] ([UserId], [UserName], [Password], [FirstName], [LastName], [MobileNo], [EmailId], [RoleId], [GenderId], [DOB], [CreateDate], [IsDelete], [IsActive], [IsSuperUser]) VALUES (4, N'tony1', N'tony', N'Leon1', N'Leon1', N'1111111', N'jus@jus.com', 1, 1, N'Apr  6 1988 12:00AM', CAST(N'2022-08-26 00:06:27.977' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UserDetails] ([UserId], [UserName], [Password], [FirstName], [LastName], [MobileNo], [EmailId], [RoleId], [GenderId], [DOB], [CreateDate], [IsDelete], [IsActive], [IsSuperUser]) VALUES (5, N'tony333asdfasd', N'tony', N'Leon', N'Leon', N'111111', N'jus@jus.com', 1, 1, N'Apr  6 1988 12:00AM', CAST(N'2022-08-27 11:18:17.403' AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[UserDetails] ([UserId], [UserName], [Password], [FirstName], [LastName], [MobileNo], [EmailId], [RoleId], [GenderId], [DOB], [CreateDate], [IsDelete], [IsActive], [IsSuperUser]) VALUES (6, N'tony222333', N'tony222333', N'Leon333', N'Leon333', N'111111', N'jus@jus.com', 1, 1, N'Apr  6 1988 12:00AM', CAST(N'2022-08-29 19:27:33.167' AS DateTime), 1, 1, 0)
GO
INSERT [dbo].[UserDetails] ([UserId], [UserName], [Password], [FirstName], [LastName], [MobileNo], [EmailId], [RoleId], [GenderId], [DOB], [CreateDate], [IsDelete], [IsActive], [IsSuperUser]) VALUES (7, N'justine', N'jus', N'JustineTest', N'JustineTest', N'9578329553', N'jus@jus.com', 1, 1, N'Apr  6 1988 12:00AM', CAST(N'2022-09-06 16:41:25.690' AS DateTime), 0, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[UserDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

GO
INSERT [dbo].[Roles] ([RoleId], [RoleName], [IsActive], [IsDelete]) VALUES (1, N'Admin', 0, 0)
GO
INSERT [dbo].[Roles] ([RoleId], [RoleName], [IsActive], [IsDelete]) VALUES (2, N'HR', 0, 0)
GO 

CREATE PROCEDURE [dbo].[usp_UserDelete] 
	@UserId INT=0
AS 
	Update UserDetails SET IsDelete=1 WHERE UserId =@UserId

GO 
CREATE PROCEDURE [dbo].[usp_UserGetDetils]  
AS 
	SELECT * FROM UserDetails  WHERE IsDelete =0  
	
	SELECT * FROM [dbo].[Roles]  WHERE IsDelete =0  
GO
 
CREATE PROCEDURE [dbo].[usp_UserGetDetilsById] 
	@UserId INT=0
AS 
	SELECT * FROM UserDetails  WHERE IsDelete =0 and UserId =@UserId

GO
 
CREATE PROCEDURE [dbo].[usp_UserSave] 
	@UserId INT=0,
	@UserName  VARCHAR(50)=NULL,
	@Password  VARCHAR(50)=NULL,
	@FirstName VARCHAR(50)=NULL,
    @LastName VARCHAR(50)=NULL,  
	@MobileNo VARCHAR(50)=NULL,
	@EmailId VARCHAR(50)=NULL, 
	@RoleId int=0, 
	@GenderId int,
	@DOB VARCHAR(50)=NULL,
	@returnVal int =@UserId output  
AS  
	IF(@UserId=0)
	BEGIN
		INSERT INTO UserDetails (UserName
           ,Password
           ,FirstName
           ,LastName 
           ,MobileNo
           ,EmailId 
           ,RoleId 
           ,GenderId
           ,DOB ) 
		VALUES  (
		    @UserName
           ,@Password
           ,@FirstName
           ,@LastName 
           ,@MobileNo
           ,@EmailId 
           ,@RoleId
		   ,@GenderId
           ,@DOB );
		    set @returnVal = SCOPE_IDENTITY()  
  
	END
	ELSE  
	BEGIN
		 
		Update UserDetails 
		SET 
			UserName=@UserName
           ,Password	=@Password	
           ,FirstName =@FirstName
           ,LastName = @LastName 
           ,MobileNo =@MobileNo
           ,EmailId=@EmailId 
           ,RoleId=@RoleId 
		   ,GenderId=@GenderId
           ,DOB =@DOB 
		WHERE UserId =@UserId;
		 set @returnVal =@UserId;
	END 

	 return @returnVal  
 