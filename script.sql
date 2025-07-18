USE [CarBook]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Abouts]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abouts](
	[AboutID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[ImageUrl] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Abouts] PRIMARY KEY CLUSTERED 
(
	[AboutID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppRoles]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppRoles](
	[AppRoleID] [int] IDENTITY(1,1) NOT NULL,
	[AppRoleName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AppRoles] PRIMARY KEY CLUSTERED 
(
	[AppRoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUsers]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUsers](
	[AppuserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Password] [int] NOT NULL,
	[AppRoleID] [int] NOT NULL,
 CONSTRAINT [PK_AppUsers] PRIMARY KEY CLUSTERED 
(
	[AppuserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CoverImage] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Banners]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Banners](
	[BannerID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[VideoDescription] [nvarchar](max) NOT NULL,
	[VideoUrl] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Banners] PRIMARY KEY CLUSTERED 
(
	[BannerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Blogs]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Blogs](
	[BlogID] [int] IDENTITY(1,1) NOT NULL,
	[CoverImage] [nvarchar](max) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[ViewCount] [int] NOT NULL,
	[AuthorID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[CommentID] [int] NOT NULL,
 CONSTRAINT [PK_Blogs] PRIMARY KEY CLUSTERED 
(
	[BlogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BlogTags]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BlogTags](
	[BlogTagsID] [int] IDENTITY(1,1) NOT NULL,
	[TagID] [int] NOT NULL,
	[BlogID] [int] NOT NULL,
 CONSTRAINT [PK_BlogTags] PRIMARY KEY CLUSTERED 
(
	[BlogTagsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[BrandID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarDescriptions]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarDescriptions](
	[CarDescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[Details] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CarDescriptions] PRIMARY KEY CLUSTERED 
(
	[CarDescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarFeatures]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarFeatures](
	[CarFeatureID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[FeatureID] [int] NOT NULL,
	[Available] [bit] NOT NULL,
 CONSTRAINT [PK_CarFeatures] PRIMARY KEY CLUSTERED 
(
	[CarFeatureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarPricings]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarPricings](
	[CarPricingID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[PricingID] [int] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_CarPricings] PRIMARY KEY CLUSTERED 
(
	[CarPricingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[BrandID] [int] NOT NULL,
	[Model] [nvarchar](max) NOT NULL,
	[CoverImageUrl] [nvarchar](max) NOT NULL,
	[Km] [int] NOT NULL,
	[Transmission] [nvarchar](max) NOT NULL,
	[Seat] [tinyint] NOT NULL,
	[Luggage] [tinyint] NOT NULL,
	[Fuel] [nvarchar](max) NOT NULL,
	[BigImageUrl] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[BlogID] [int] NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[BlogComment] [nvarchar](max) NOT NULL,
	[CoverImage] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Subject] [nvarchar](max) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[SendDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Features]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Features](
	[FeatureID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Features] PRIMARY KEY CLUSTERED 
(
	[FeatureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FooterAddresses]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FooterAddresses](
	[FooterAddressID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_FooterAddresses] PRIMARY KEY CLUSTERED 
(
	[FooterAddressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pricings]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pricings](
	[PricingID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Pricings] PRIMARY KEY CLUSTERED 
(
	[PricingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentAcarProcesses]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentAcarProcesses](
	[RentAcarProcessID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[StartLocation] [int] NOT NULL,
	[EndLocation] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[PickUpDescription] [nvarchar](max) NOT NULL,
	[DropOffDescription] [nvarchar](max) NOT NULL,
	[TotalAmount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_RentAcarProcesses] PRIMARY KEY CLUSTERED 
(
	[RentAcarProcessID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentAcars]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentAcars](
	[RentAcarID] [int] IDENTITY(1,1) NOT NULL,
	[LocationID] [int] NOT NULL,
	[CarID] [int] NOT NULL,
	[Available] [bit] NOT NULL,
 CONSTRAINT [PK_RentAcars] PRIMARY KEY CLUSTERED 
(
	[RentAcarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[ReservationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[CarID] [int] NOT NULL,
	[StartLocationID] [int] NOT NULL,
	[EndLocationID] [int] NOT NULL,
	[Age] [int] NOT NULL,
	[DriverLicenceYear] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Reservations] PRIMARY KEY CLUSTERED 
(
	[ReservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ServicesID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[IconUrl] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[ServicesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SocialMedias]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocialMedias](
	[SocialMediaID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Url] [nvarchar](max) NOT NULL,
	[Icon] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_SocialMedias] PRIMARY KEY CLUSTERED 
(
	[SocialMediaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tags]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tags](
	[TagID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Tags] PRIMARY KEY CLUSTERED 
(
	[TagID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Testimonials]    Script Date: 16.07.2025 16:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Testimonials](
	[TestimonialID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Comment] [nvarchar](max) NOT NULL,
	[ImageUrl] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Testimonials] PRIMARY KEY CLUSTERED 
(
	[TestimonialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250615131119_migg_first', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250621132345_add_migg_changeServicesName', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250623093428_migg_add_Blog-Category-Author', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250623094021_migg_add_category_update', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250623103938_add_blog_author_route', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250624142806_add_tag_blogtags', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250624144145_update_tag', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250628122125_add_comment', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250628122432_add_comment_NAME', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250630080515_add_comment_name_add', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250703105233_add_rentAcar', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250703112214_add_customer', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250704075608_add_migration_reservation_With_RelationLocation', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250704085824_add_migration_reservation_in_status_CarRelations', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250704134410_add_mig_pricing_relation_with_carPricing', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250704134707_add_migration_Pricing_update', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250704140123_add_migration_Pricing_update2', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250704141835_add_migration_carID_PricingID_unique', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250707152615_add_carfeature_IsUnique', N'7.0.12')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250710091034_add_appuser_approle', N'7.0.12')
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([AboutID], [Title], [Description], [ImageUrl]) VALUES (1, N'Özgürlüğe Sürüyoruz.', N'Yılların birikimiyle, yolların ve keşiflerin coşkusunu her an yanınızda taşıyoruz. Hayatın ritmine ayak uyduran, her biri titizlikle bakımdan geçmiş geniş araç yelpazemizle, ister iş ister tatil amaçlı olsun, her yolculuğunuzu eşsiz bir deneyime dönüştürüyoruz. Şehrin dinamik sokaklarından sakin kasabalara, gizli kalmış cennet koylarından görkemli dağ geçitlerine uzanan her rotada, en güvenilir yol arkadaşınız olmaktan gurur duyuyoruz.', N'/carbook-UI/images/about.jpg')
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[AppRoles] ON 

INSERT [dbo].[AppRoles] ([AppRoleID], [AppRoleName]) VALUES (1, N'Admin')
INSERT [dbo].[AppRoles] ([AppRoleID], [AppRoleName]) VALUES (2, N'Misafir')
SET IDENTITY_INSERT [dbo].[AppRoles] OFF
GO
SET IDENTITY_INSERT [dbo].[AppUsers] ON 

INSERT [dbo].[AppUsers] ([AppuserID], [UserName], [Password], [AppRoleID]) VALUES (1, N'Emre', 1234, 1)
INSERT [dbo].[AppUsers] ([AppuserID], [UserName], [Password], [AppRoleID]) VALUES (2, N'Ali', 1234, 2)
INSERT [dbo].[AppUsers] ([AppuserID], [UserName], [Password], [AppRoleID]) VALUES (3, N'Zeliha', 1234, 1)
INSERT [dbo].[AppUsers] ([AppuserID], [UserName], [Password], [AppRoleID]) VALUES (5, N'Deneme', 1234, 1)
SET IDENTITY_INSERT [dbo].[AppUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorID], [Name], [CoverImage], [Description]) VALUES (1, N'Emre Binici', N'/carbook-UI/images/person_1.jpg', N'Doktor')
INSERT [dbo].[Authors] ([AuthorID], [Name], [CoverImage], [Description]) VALUES (2, N'Ali Yılmaz', N'/carbook-UI/images/person_2.jpg', N'Selamlar, çocukluğumdan beri arabalar ve teknoloji ile yakından ilgilenmekteyim; umarım yazılarımı beğenirsiniz.')
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([BannerID], [Title], [Description], [VideoDescription], [VideoUrl]) VALUES (2, N'
Araba Kiralamanın Hızlı ve Kolay Yolu', N'Yılların Tecrübesi İle Hizmetinizdeyiz.', N'Araçlarımıza Göz Atın', N'https://vimeo.com/396260528')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([BlogID], [CoverImage], [Date], [Title], [Description], [ViewCount], [AuthorID], [CategoryID], [CommentID]) VALUES (1, N'/carbook-UI/images/image_1.jpg', CAST(N'2025-06-23T00:00:00.0000000' AS DateTime2), N'Büyük Araç Konforu', N'Uzun yolculuklar veya kalabalık aile gezileri için büyük araçlar, sundukları konforla vazgeçilmez hale geliyor. Geniş iç hacimleri sayesinde hem yolcular hem de bagajlar için bolca alan sunar. Koltukların ferah yerleşimi, gelişmiş süspansiyon sistemleri ve sessiz kabin tasarımı, sürüş esnasında maksimum rahatlık sağlar. Ayrıca multimedya sistemleri, klima kontrolü ve ergonomik detaylar da bu konforu destekler. Uzun saatler boyunca araç içinde vakit geçirmeniz gerektiğinde, büyük araçlar yorgunluğu en aza indirir. Hem sürücü hem de yolcular için sunduğu lüks ve işlevsellik sayesinde büyük araçlar, yolculuk deneyimini bambaşka bir seviyeye taşır.', 2, 1, 2, 0)
INSERT [dbo].[Blogs] ([BlogID], [CoverImage], [Date], [Title], [Description], [ViewCount], [AuthorID], [CategoryID], [CommentID]) VALUES (2, N'/carbook-UI/images/image_2.jpg', CAST(N'2025-06-25T00:00:00.0000000' AS DateTime2), N'Konfor mu ?', N'Motosiklet sürmek, özgürlüğü ve doğayla bütünleşmeyi hissetmenin en keyifli yollarından biridir. Ancak bu deneyimin konforlu olması, doğru ekipman ve ergonomik tasarımla mümkündür. Gelişmiş süspansiyon sistemleri, titreşimi azaltan şasi yapıları ve yumuşak sele tasarımları, uzun sürüşlerde bile rahatlık sunar. Aynı zamanda modern motosikletlerde bulunan ısıtmalı elcikler, elektronik destek sistemleri ve rüzgar koruyucu camlar da sürüş konforunu artırır. Özellikle şehir içi ve uzun yol kullanımında konforlu bir motosiklet, hem güvenliği hem de keyfi üst düzeye çıkarır. Doğru ayarlanmış bir motor, yolda olmanın verdiği huzuru iki katına çıkarır.', 3, 2, 3, 0)
INSERT [dbo].[Blogs] ([BlogID], [CoverImage], [Date], [Title], [Description], [ViewCount], [AuthorID], [CategoryID], [CommentID]) VALUES (3, N'/carbook-UI/images/image_3.jpg', CAST(N'2025-06-18T00:00:00.0000000' AS DateTime2), N'Lüks mü?', N'Lüks araçlar, sadece bir ulaşım aracı değil; konfor, teknoloji ve prestijin birleşimidir. İç tasarımdaki deri döşemeler, masajlı ve ısıtmalı koltuklar ile sürüş keyfi adeta bir dinlenme anına dönüşür. Gelişmiş süspansiyon sistemleri, yolun en ufak pürüzlerini bile hissettirmezken; kabin içi sessizlik ve premium ses sistemleri, bambaşka bir atmosfer yaratır. Akıllı sürüş asistanları ve dijital kokpit teknolojileri de hem güvenliği artırır hem de konforu tamamlar. Lüks bir araçta seyahat etmek, sadece varılacak yere değil, yolculuğun kendisine de değer katmak demektir. Bu araçlar, konforu bir ayrıcalığa dönüştürür.', 12, 1, 2, 0)
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[BlogTags] ON 

INSERT [dbo].[BlogTags] ([BlogTagsID], [TagID], [BlogID]) VALUES (4, 6, 1)
INSERT [dbo].[BlogTags] ([BlogTagsID], [TagID], [BlogID]) VALUES (5, 7, 1)
INSERT [dbo].[BlogTags] ([BlogTagsID], [TagID], [BlogID]) VALUES (6, 8, 1)
INSERT [dbo].[BlogTags] ([BlogTagsID], [TagID], [BlogID]) VALUES (7, 9, 1)
INSERT [dbo].[BlogTags] ([BlogTagsID], [TagID], [BlogID]) VALUES (8, 10, 1)
SET IDENTITY_INSERT [dbo].[BlogTags] OFF
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([BrandID], [Name]) VALUES (2, N'BMW')
INSERT [dbo].[Brands] ([BrandID], [Name]) VALUES (3, N'FİAT')
INSERT [dbo].[Brands] ([BrandID], [Name]) VALUES (4, N'MERCEDES')
INSERT [dbo].[Brands] ([BrandID], [Name]) VALUES (5, N'RANGE ROVER')
INSERT [dbo].[Brands] ([BrandID], [Name]) VALUES (6, N'FERRARİ')
INSERT [dbo].[Brands] ([BrandID], [Name]) VALUES (7, N'FORD')
INSERT [dbo].[Brands] ([BrandID], [Name]) VALUES (8, N'SUBARU')
INSERT [dbo].[Brands] ([BrandID], [Name]) VALUES (9, N'TOGG')
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[CarDescriptions] ON 

INSERT [dbo].[CarDescriptions] ([CarDescriptionID], [CarID], [Details]) VALUES (1, 10, N'Gelişmiş mühendislik ve kusursuz işçilikle tasarlanmış, her yolculuğu bir keyfe dönüştüren prestijli bir şaheser.')
INSERT [dbo].[CarDescriptions] ([CarDescriptionID], [CarID], [Details]) VALUES (2, 17, N'Dinamik sürüş yeteneklerini, sofistike iç mekan tasarımı ve üstün konforla birleştiren eşsiz bir deneyim.')
INSERT [dbo].[CarDescriptions] ([CarDescriptionID], [CarID], [Details]) VALUES (3, 5, N'En son dijital asistanlar, otonom sürüş özellikleri ve bağlantı seçenekleriyle geleceği bugüne taşıyan akıllı bir lüks.')
INSERT [dbo].[CarDescriptions] ([CarDescriptionID], [CarID], [Details]) VALUES (4, 7, N' Geniş, el işçiliğiyle döşenmiş iç mekanı, masajlı koltukları ve özel ses yalıtımıyla beş yıldızlı bir konaklama hissi sunar.')
INSERT [dbo].[CarDescriptions] ([CarDescriptionID], [CarID], [Details]) VALUES (5, 8, N'Heybetli duruşu, güçlü motor performansı ve yol hakimiyetiyle fark yaratan, her detayı özenle düşünülmüş bir SUV.')
INSERT [dbo].[CarDescriptions] ([CarDescriptionID], [CarID], [Details]) VALUES (6, 9, N'Özel sipariş detayları, nadir ahşap ve deri seçenekleriyle kişiliğinizi yansıtan, size özel bir otomobil.')
INSERT [dbo].[CarDescriptions] ([CarDescriptionID], [CarID], [Details]) VALUES (7, 11, N'Elektrikli veya hibrit motor teknolojisi sayesinde çevreye saygılı ve adeta süzülürcesine sessiz bir sürüş sunan lüksün yeni tanımı.')
SET IDENTITY_INSERT [dbo].[CarDescriptions] OFF
GO
SET IDENTITY_INSERT [dbo].[CarFeatures] ON 

INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (1, 5, 2, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (4, 5, 3, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (5, 5, 4, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (6, 5, 5, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (7, 5, 6, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (10, 5, 7, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (20, 10, 8, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (21, 17, 8, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (23, 5, 8, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (24, 7, 8, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (25, 8, 8, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (26, 9, 8, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (27, 11, 8, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (29, 10, 2, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (30, 10, 3, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (31, 10, 4, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (32, 10, 5, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (33, 10, 6, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (34, 10, 7, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (36, 11, 2, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (37, 11, 3, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (38, 11, 4, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (39, 11, 5, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (40, 11, 6, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (41, 11, 7, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (42, 7, 2, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (43, 7, 3, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (44, 7, 4, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (45, 7, 5, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (46, 7, 6, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (47, 7, 7, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (48, 8, 2, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (49, 8, 3, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (50, 8, 4, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (51, 8, 5, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (52, 8, 6, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (53, 8, 7, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (54, 9, 2, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (55, 9, 3, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (57, 9, 4, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (58, 9, 5, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (59, 9, 6, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (60, 9, 7, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (61, 17, 2, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (62, 17, 3, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (63, 17, 4, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (64, 17, 5, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (65, 17, 6, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (66, 17, 7, 1)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (68, 10, 9, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (69, 17, 9, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (71, 5, 9, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (72, 7, 9, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (73, 8, 9, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (74, 9, 9, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (75, 11, 9, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (76, 10, 10, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (77, 17, 10, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (79, 5, 10, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (80, 7, 10, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (81, 8, 10, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (82, 9, 10, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (83, 11, 10, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (93, 10, 11, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (94, 17, 11, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (95, 5, 11, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (96, 7, 11, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (97, 8, 11, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (98, 9, 11, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (99, 11, 11, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (100, 10, 12, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (101, 17, 12, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (102, 5, 12, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (103, 7, 12, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (104, 8, 12, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (105, 9, 12, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (106, 11, 12, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (107, 10, 13, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (108, 17, 13, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (109, 5, 13, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (110, 7, 13, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (111, 8, 13, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (112, 9, 13, 0)
INSERT [dbo].[CarFeatures] ([CarFeatureID], [CarID], [FeatureID], [Available]) VALUES (113, 11, 13, 0)
SET IDENTITY_INSERT [dbo].[CarFeatures] OFF
GO
SET IDENTITY_INSERT [dbo].[CarPricings] ON 

INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (1, 5, 2, CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (3, 7, 2, CAST(400.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (4, 8, 2, CAST(700.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (5, 9, 2, CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (6, 10, 2, CAST(800.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (7, 11, 2, CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (19, 17, 2, CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (20, 17, 3, CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (21, 17, 4, CAST(2500.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (22, 5, 3, CAST(700.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (23, 5, 4, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (24, 7, 3, CAST(600.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (25, 7, 4, CAST(1400.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (26, 8, 3, CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (27, 8, 4, CAST(1500.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (28, 9, 3, CAST(1300.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (29, 9, 4, CAST(1800.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (30, 10, 3, CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (31, 10, 4, CAST(1900.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (32, 11, 3, CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[CarPricings] ([CarPricingID], [CarID], [PricingID], [Amount]) VALUES (33, 11, 4, CAST(1800.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[CarPricings] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([CarID], [BrandID], [Model], [CoverImageUrl], [Km], [Transmission], [Seat], [Luggage], [Fuel], [BigImageUrl]) VALUES (5, 4, N'Mercedes Grand Sedan', N'/carbook-UI/images/car-1.jpg', 150, N'Manuel', 4, 4, N'Benzin', N'/carbook-UI/images/car-1.jpg')
INSERT [dbo].[Cars] ([CarID], [BrandID], [Model], [CoverImageUrl], [Km], [Transmission], [Seat], [Luggage], [Fuel], [BigImageUrl]) VALUES (7, 5, N'Range Rover City', N'/carbook-UI/images/car-2.jpg', 50, N'Otomatik', 7, 6, N'Elektrik', N'/carbook-UI/images/car-2.jpg')
INSERT [dbo].[Cars] ([CarID], [BrandID], [Model], [CoverImageUrl], [Km], [Transmission], [Seat], [Luggage], [Fuel], [BigImageUrl]) VALUES (8, 6, N'Ferrari xs', N'/carbook-UI/images/car-3.jpg', 80, N'Otomatik', 2, 4, N'Benzin', N'/carbook-UI/images/car-2.jpg')
INSERT [dbo].[Cars] ([CarID], [BrandID], [Model], [CoverImageUrl], [Km], [Transmission], [Seat], [Luggage], [Fuel], [BigImageUrl]) VALUES (9, 7, N'Mustang City', N'/carbook-UI/images/car-4.jpg', 150, N'Manuel', 4, 5, N'Dizel', N'/carbook-UI/images/car-4.jpg')
INSERT [dbo].[Cars] ([CarID], [BrandID], [Model], [CoverImageUrl], [Km], [Transmission], [Seat], [Luggage], [Fuel], [BigImageUrl]) VALUES (10, 2, N'City Feel', N'/carbook-UI/images/car-5.jpg', 220, N'Manuel', 4, 4, N'Dizel', N'/carbook-UI/images/car-5.jpg')
INSERT [dbo].[Cars] ([CarID], [BrandID], [Model], [CoverImageUrl], [Km], [Transmission], [Seat], [Luggage], [Fuel], [BigImageUrl]) VALUES (11, 8, N'Fast', N'/carbook-UI/images/car-6.jpg', 180, N'Otomatik', 2, 2, N'Benzin', N'/carbook-UI/images/car-6.jpg')
INSERT [dbo].[Cars] ([CarID], [BrandID], [Model], [CoverImageUrl], [Km], [Transmission], [Seat], [Luggage], [Fuel], [BigImageUrl]) VALUES (17, 2, N'E-305', N'/carbook-UI/images/car-6.jpg', 150, N'Manuel', 4, 4, N'Elektrik', N'/carbook-UI/images/car-6.jpg')
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (2, N'Araba')
INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (3, N'Motor')
INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (4, N'Elektrikli Araç')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([CommentID], [BlogID], [Email], [Title], [BlogComment], [CoverImage], [Name]) VALUES (2, 1, N'emre@gmail.com', N'Kalite', N'Daha önce böyle bir hizmet aldığımı hatırlamıyorum.', N'https://images.pexels.com/photos/12437056/pexels-photo-12437056.jpeg', N'Emre Saydam')
INSERT [dbo].[Comments] ([CommentID], [BlogID], [Email], [Title], [BlogComment], [CoverImage], [Name]) VALUES (3, 1, N'Ali@gmail.com', N'Tecrübe', N'A-Z `ye tecrübeyi hissettik , muhteşem bir deneyimdi.', N'https://www.shutterstock.com/image-photo/successful-businessman-standing-arms-crossed-260nw-2506293943.jpg', N'Ali Saydam')
INSERT [dbo].[Comments] ([CommentID], [BlogID], [Email], [Title], [BlogComment], [CoverImage], [Name]) VALUES (4, 1, N'Zeki@gmail.com', N'Kalite', N'Emeği Geçen Herkese Teşekkürler', N'https://image.hurimg.com/i/hurriyet/75/0x0/5a1eacf82269a21744f8cca3.jpg', N'Zeki Saydam')
INSERT [dbo].[Comments] ([CommentID], [BlogID], [Email], [Title], [BlogComment], [CoverImage], [Name]) VALUES (5, 1, N'ali@gmail.com', N'Hizmet Kalitesi', N'Hizmet Kalitesine 10 puan diyorum , çok başarılıydı.', N'https://cdn.prod.website-files.com/5fbb9b89508062592a9731b1/6448c1ce35d6ffe59e4d6f46_GettyImages-1399565382.jpg', N'Ali Saydam')
INSERT [dbo].[Comments] ([CommentID], [BlogID], [Email], [Title], [BlogComment], [CoverImage], [Name]) VALUES (6, 1, N'melike@gmail.com', N'Hız', N'Bu kadar hızlı aksiyon aldıklarını bilmiyordum.', N'https://easy-feedback.de/wp-content/uploads/2022/10/Employee-Journey-What-it-is-and-how-to-improve-it.jpg', N'Melike Şahin')
INSERT [dbo].[Comments] ([CommentID], [BlogID], [Email], [Title], [BlogComment], [CoverImage], [Name]) VALUES (7, 2, N'Bahadır@gmail.com', N'Kalite', N'Hizmet Kalitesi Gerçekten Harikaydı.', N'https://fekrait.com/uploads/topics/16750304198773.jpg', N'Bahadır Çimen')
INSERT [dbo].[Comments] ([CommentID], [BlogID], [Email], [Title], [BlogComment], [CoverImage], [Name]) VALUES (8, 2, N'hadise@gmail.com', N'Müşteri Desteği', N'Sürecin Başından Sonuna Kadar İlgilendiler, Çok Teşekkürler.', N'https://easy-feedback.de/wp-content/uploads/2022/10/Employee-Journey-What-it-is-and-how-to-improve-it.jpg', N'Hadise Tek')
INSERT [dbo].[Comments] ([CommentID], [BlogID], [Email], [Title], [BlogComment], [CoverImage], [Name]) VALUES (9, 3, N'Zekiye@gmail.com', N'Harika', N'Harika bir yazıydı, teşekkürler.', N'https://easy-feedback.de/wp-content/uploads/2022/10/Employee-Journey-What-it-is-and-how-to-improve-it.jpg', N'Zekiye Yılmaz')
INSERT [dbo].[Comments] ([CommentID], [BlogID], [Email], [Title], [BlogComment], [CoverImage], [Name]) VALUES (10, 2, N'emre@gmail.com', N'Kusursuz', N'Bu yazı gerçekten harika , biz motor tutkunları için daha fazla yazmalısınız.', N'https://fekrait.com/uploads/topics/16750304198773.jpg', N'Emre Çimen')
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([ContactID], [Name], [Email], [Subject], [Message], [SendDate]) VALUES (6, N'Emre', N'Emre@gmail.com', N'HİZMET?', N'7/24 Size ulaşabilir miyiz?', CAST(N'2025-06-30T12:16:41.9460000' AS DateTime2))
INSERT [dbo].[Contacts] ([ContactID], [Name], [Email], [Subject], [Message], [SendDate]) VALUES (7, N'Ali', N'Example@gmail.com', N'Araçlar?', N'Araçlar yolda kalırsa ne olacak ?', CAST(N'2025-06-30T12:16:41.9460000' AS DateTime2))
INSERT [dbo].[Contacts] ([ContactID], [Name], [Email], [Subject], [Message], [SendDate]) VALUES (8, N'Ayşe', N'Example@gmail.com', N'Araçlar?', N'Araçlaın Benzini Biterse Ne Olacak?', CAST(N'2025-06-30T12:16:41.9460000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Features] ON 

INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (2, N'4x2')
INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (3, N'Klima')
INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (4, N'Dijital Ekran')
INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (5, N'GPS')
INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (6, N'Bluetooth')
INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (7, N'Araç Kiti')
INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (8, N'Yangın Tüpü')
INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (9, N'Dijital Klima')
INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (10, N'Çocuk Kilidi')
INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (11, N'Adaptif Hız Sabitleyici')
INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (12, N'Otomatik Park Asistanı')
INSERT [dbo].[Features] ([FeatureID], [Name]) VALUES (13, N'Isıtmalı Koltuklar')
SET IDENTITY_INSERT [dbo].[Features] OFF
GO
SET IDENTITY_INSERT [dbo].[FooterAddresses] ON 

INSERT [dbo].[FooterAddresses] ([FooterAddressID], [Description], [Address], [Phone], [Email]) VALUES (2, N'Sürücülerimizin her yolculuğunu güvenle, konforla ve tutkuyla doldurarak, durmaksızın geleceğin mobilite çözümlerini inşa etmeye devam ediyoruz. İşimiz, yıllardır süregelen güveniniz.', N'Cumhuriyet Sk. No:15 Kadıköy/İstanbul', N'+90 500 400 3005', N'carbook@gmail.com')
SET IDENTITY_INSERT [dbo].[FooterAddresses] OFF
GO
SET IDENTITY_INSERT [dbo].[Locations] ON 

INSERT [dbo].[Locations] ([LocationID], [Name]) VALUES (2, N'Bursa')
INSERT [dbo].[Locations] ([LocationID], [Name]) VALUES (3, N'İstanbul')
INSERT [dbo].[Locations] ([LocationID], [Name]) VALUES (5, N'Balıkesir')
INSERT [dbo].[Locations] ([LocationID], [Name]) VALUES (6, N'İzmir')
INSERT [dbo].[Locations] ([LocationID], [Name]) VALUES (7, N'Manisa')
INSERT [dbo].[Locations] ([LocationID], [Name]) VALUES (8, N'Bandırma')
INSERT [dbo].[Locations] ([LocationID], [Name]) VALUES (9, N'Muğla')
INSERT [dbo].[Locations] ([LocationID], [Name]) VALUES (10, N'Çanakkale')
SET IDENTITY_INSERT [dbo].[Locations] OFF
GO
SET IDENTITY_INSERT [dbo].[Pricings] ON 

INSERT [dbo].[Pricings] ([PricingID], [Name]) VALUES (2, N'Günlük')
INSERT [dbo].[Pricings] ([PricingID], [Name]) VALUES (3, N'Haftalık')
INSERT [dbo].[Pricings] ([PricingID], [Name]) VALUES (4, N'Aylık')
SET IDENTITY_INSERT [dbo].[Pricings] OFF
GO
SET IDENTITY_INSERT [dbo].[RentAcars] ON 

INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (1, 2, 5, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (2, 2, 7, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (3, 2, 8, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (4, 2, 9, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (5, 2, 10, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (6, 2, 11, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (7, 2, 17, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (10, 3, 5, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (11, 3, 7, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (12, 3, 8, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (13, 3, 9, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (14, 3, 10, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (15, 3, 11, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (16, 3, 17, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (19, 5, 5, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (20, 5, 7, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (21, 5, 8, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (22, 5, 9, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (23, 5, 10, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (24, 5, 11, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (25, 5, 17, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (28, 6, 5, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (29, 6, 7, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (30, 6, 8, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (31, 6, 9, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (32, 6, 10, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (33, 6, 11, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (34, 6, 17, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (37, 7, 5, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (38, 7, 7, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (39, 7, 8, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (40, 7, 9, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (41, 7, 10, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (42, 7, 11, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (43, 7, 17, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (46, 8, 5, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (47, 8, 7, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (48, 8, 8, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (49, 8, 9, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (50, 8, 10, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (51, 8, 11, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (52, 8, 17, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (55, 9, 5, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (56, 9, 7, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (57, 9, 8, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (58, 9, 9, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (59, 9, 10, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (60, 9, 11, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (61, 9, 17, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (64, 10, 5, 0)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (65, 10, 7, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (66, 10, 8, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (67, 10, 9, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (68, 10, 10, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (69, 10, 11, 1)
INSERT [dbo].[RentAcars] ([RentAcarID], [LocationID], [CarID], [Available]) VALUES (70, 10, 17, 0)
SET IDENTITY_INSERT [dbo].[RentAcars] OFF
GO
SET IDENTITY_INSERT [dbo].[Reservations] ON 

INSERT [dbo].[Reservations] ([ReservationID], [Name], [Surname], [Email], [Phone], [CarID], [StartLocationID], [EndLocationID], [Age], [DriverLicenceYear], [Description], [Status]) VALUES (1, N'emre', N'binici', N'emre@gmail.com', N'551 122 07 82', 5, 2, 5, 25, 2, N'Deneme', N'Rezervasyon Alındı')
SET IDENTITY_INSERT [dbo].[Reservations] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([ServicesID], [Title], [Description], [IconUrl]) VALUES (2, N'Eşşsiz Yolculuk', N'Yol Boyunca 7/24  hizmet desteği.', N'flaticon-route')
INSERT [dbo].[Services] ([ServicesID], [Title], [Description], [IconUrl]) VALUES (3, N'Yükünüz Mü Var?', N'Geniş Araç Seçeneklerimiz İle Bagaj Yüküne Çözüm Sağlıyoruz.', N'flaticon-rent')
INSERT [dbo].[Services] ([ServicesID], [Title], [Description], [IconUrl]) VALUES (4, N'Uzun Yolculuklar', N'Yakıt Cimrisi Araçlarımız İle Daha Uzun Yolculuk Hizmeti Sunuyoruz.', N'flaticon-diesel')
INSERT [dbo].[Services] ([ServicesID], [Title], [Description], [IconUrl]) VALUES (5, N'Memnuniyet', N'Yılların Tecrübesi İle Memnuniyet Garantisi Veriyoruz.', N'flaticon-handshake')
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[SocialMedias] ON 

INSERT [dbo].[SocialMedias] ([SocialMediaID], [Name], [Url], [Icon]) VALUES (4, N'İnstagram', N'#', N'icon-instagram')
INSERT [dbo].[SocialMedias] ([SocialMediaID], [Name], [Url], [Icon]) VALUES (5, N'X', N'#', N'icon-twitter')
INSERT [dbo].[SocialMedias] ([SocialMediaID], [Name], [Url], [Icon]) VALUES (6, N'Facebook', N'#', N'icon-facebook')
SET IDENTITY_INSERT [dbo].[SocialMedias] OFF
GO
SET IDENTITY_INSERT [dbo].[Tags] ON 

INSERT [dbo].[Tags] ([TagID], [Name]) VALUES (6, N'Elektirikli Araç')
INSERT [dbo].[Tags] ([TagID], [Name]) VALUES (7, N'Araç')
INSERT [dbo].[Tags] ([TagID], [Name]) VALUES (8, N'Motor')
INSERT [dbo].[Tags] ([TagID], [Name]) VALUES (9, N'MotoGP')
INSERT [dbo].[Tags] ([TagID], [Name]) VALUES (10, N'Formula 1')
SET IDENTITY_INSERT [dbo].[Tags] OFF
GO
SET IDENTITY_INSERT [dbo].[Testimonials] ON 

INSERT [dbo].[Testimonials] ([TestimonialID], [Name], [Title], [Comment], [ImageUrl]) VALUES (2, N'Emre Binici', N'Developer', N'Çalışan arkadaşlar çok ilgilendiler , teşekkürler.', N'/carbook-UI/images/person_1.jpg')
INSERT [dbo].[Testimonials] ([TestimonialID], [Name], [Title], [Comment], [ImageUrl]) VALUES (3, N'Ali Yılmaz', N'Mühendis', N'Daha önce bu kadar konforlu bir yolculuk yapmamıştım , teşekkürler.', N'/carbook-UI/images/person_2.jpg')
SET IDENTITY_INSERT [dbo].[Testimonials] OFF
GO
/****** Object:  Index [IX_AppUsers_AppRoleID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_AppUsers_AppRoleID] ON [dbo].[AppUsers]
(
	[AppRoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Blogs_AuthorID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_Blogs_AuthorID] ON [dbo].[Blogs]
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Blogs_CategoryID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_Blogs_CategoryID] ON [dbo].[Blogs]
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_BlogTags_BlogID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_BlogTags_BlogID] ON [dbo].[BlogTags]
(
	[BlogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_BlogTags_TagID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_BlogTags_TagID] ON [dbo].[BlogTags]
(
	[TagID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarDescriptions_CarID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_CarDescriptions_CarID] ON [dbo].[CarDescriptions]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarFeatures_CarID_FeatureID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CarFeatures_CarID_FeatureID] ON [dbo].[CarFeatures]
(
	[CarID] ASC,
	[FeatureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarFeatures_FeatureID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_CarFeatures_FeatureID] ON [dbo].[CarFeatures]
(
	[FeatureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarPricings_CarID_PricingID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CarPricings_CarID_PricingID] ON [dbo].[CarPricings]
(
	[CarID] ASC,
	[PricingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarPricings_PricingID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_CarPricings_PricingID] ON [dbo].[CarPricings]
(
	[PricingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cars_BrandID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_Cars_BrandID] ON [dbo].[Cars]
(
	[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Comments_BlogID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_Comments_BlogID] ON [dbo].[Comments]
(
	[BlogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RentAcarProcesses_CarID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_RentAcarProcesses_CarID] ON [dbo].[RentAcarProcesses]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RentAcarProcesses_CustomerID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_RentAcarProcesses_CustomerID] ON [dbo].[RentAcarProcesses]
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RentAcars_CarID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_RentAcars_CarID] ON [dbo].[RentAcars]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RentAcars_LocationID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_RentAcars_LocationID] ON [dbo].[RentAcars]
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reservations_CarID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_Reservations_CarID] ON [dbo].[Reservations]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reservations_EndLocationID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_Reservations_EndLocationID] ON [dbo].[Reservations]
(
	[EndLocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Reservations_StartLocationID]    Script Date: 16.07.2025 16:47:56 ******/
CREATE NONCLUSTERED INDEX [IX_Reservations_StartLocationID] ON [dbo].[Reservations]
(
	[StartLocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Blogs] ADD  DEFAULT ((0)) FOR [CommentID]
GO
ALTER TABLE [dbo].[Comments] ADD  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[Reservations] ADD  DEFAULT (N'') FOR [Status]
GO
ALTER TABLE [dbo].[AppUsers]  WITH CHECK ADD  CONSTRAINT [FK_AppUsers_AppRoles_AppRoleID] FOREIGN KEY([AppRoleID])
REFERENCES [dbo].[AppRoles] ([AppRoleID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AppUsers] CHECK CONSTRAINT [FK_AppUsers_AppRoles_AppRoleID]
GO
ALTER TABLE [dbo].[Blogs]  WITH CHECK ADD  CONSTRAINT [FK_Blogs_Authors_AuthorID] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Blogs] CHECK CONSTRAINT [FK_Blogs_Authors_AuthorID]
GO
ALTER TABLE [dbo].[Blogs]  WITH CHECK ADD  CONSTRAINT [FK_Blogs_Categories_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Blogs] CHECK CONSTRAINT [FK_Blogs_Categories_CategoryID]
GO
ALTER TABLE [dbo].[BlogTags]  WITH CHECK ADD  CONSTRAINT [FK_BlogTags_Blogs_BlogID] FOREIGN KEY([BlogID])
REFERENCES [dbo].[Blogs] ([BlogID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BlogTags] CHECK CONSTRAINT [FK_BlogTags_Blogs_BlogID]
GO
ALTER TABLE [dbo].[BlogTags]  WITH CHECK ADD  CONSTRAINT [FK_BlogTags_Tags_TagID] FOREIGN KEY([TagID])
REFERENCES [dbo].[Tags] ([TagID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BlogTags] CHECK CONSTRAINT [FK_BlogTags_Tags_TagID]
GO
ALTER TABLE [dbo].[CarDescriptions]  WITH CHECK ADD  CONSTRAINT [FK_CarDescriptions_Cars_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([CarID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarDescriptions] CHECK CONSTRAINT [FK_CarDescriptions_Cars_CarID]
GO
ALTER TABLE [dbo].[CarFeatures]  WITH CHECK ADD  CONSTRAINT [FK_CarFeatures_Cars_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([CarID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarFeatures] CHECK CONSTRAINT [FK_CarFeatures_Cars_CarID]
GO
ALTER TABLE [dbo].[CarFeatures]  WITH CHECK ADD  CONSTRAINT [FK_CarFeatures_Features_FeatureID] FOREIGN KEY([FeatureID])
REFERENCES [dbo].[Features] ([FeatureID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarFeatures] CHECK CONSTRAINT [FK_CarFeatures_Features_FeatureID]
GO
ALTER TABLE [dbo].[CarPricings]  WITH CHECK ADD  CONSTRAINT [FK_CarPricings_Cars_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([CarID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarPricings] CHECK CONSTRAINT [FK_CarPricings_Cars_CarID]
GO
ALTER TABLE [dbo].[CarPricings]  WITH CHECK ADD  CONSTRAINT [FK_CarPricings_Pricings_PricingID] FOREIGN KEY([PricingID])
REFERENCES [dbo].[Pricings] ([PricingID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarPricings] CHECK CONSTRAINT [FK_CarPricings_Pricings_PricingID]
GO
ALTER TABLE [dbo].[Cars]  WITH CHECK ADD  CONSTRAINT [FK_Cars_Brands_BrandID] FOREIGN KEY([BrandID])
REFERENCES [dbo].[Brands] ([BrandID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cars] CHECK CONSTRAINT [FK_Cars_Brands_BrandID]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Blogs_BlogID] FOREIGN KEY([BlogID])
REFERENCES [dbo].[Blogs] ([BlogID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Blogs_BlogID]
GO
ALTER TABLE [dbo].[RentAcarProcesses]  WITH CHECK ADD  CONSTRAINT [FK_RentAcarProcesses_Cars_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([CarID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RentAcarProcesses] CHECK CONSTRAINT [FK_RentAcarProcesses_Cars_CarID]
GO
ALTER TABLE [dbo].[RentAcarProcesses]  WITH CHECK ADD  CONSTRAINT [FK_RentAcarProcesses_Customers_CustomerID] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RentAcarProcesses] CHECK CONSTRAINT [FK_RentAcarProcesses_Customers_CustomerID]
GO
ALTER TABLE [dbo].[RentAcars]  WITH CHECK ADD  CONSTRAINT [FK_RentAcars_Cars_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([CarID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RentAcars] CHECK CONSTRAINT [FK_RentAcars_Cars_CarID]
GO
ALTER TABLE [dbo].[RentAcars]  WITH CHECK ADD  CONSTRAINT [FK_RentAcars_Locations_LocationID] FOREIGN KEY([LocationID])
REFERENCES [dbo].[Locations] ([LocationID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RentAcars] CHECK CONSTRAINT [FK_RentAcars_Locations_LocationID]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Cars_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Cars] ([CarID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Cars_CarID]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Locations_EndLocationID] FOREIGN KEY([EndLocationID])
REFERENCES [dbo].[Locations] ([LocationID])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Locations_EndLocationID]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Locations_StartLocationID] FOREIGN KEY([StartLocationID])
REFERENCES [dbo].[Locations] ([LocationID])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Locations_StartLocationID]
GO
