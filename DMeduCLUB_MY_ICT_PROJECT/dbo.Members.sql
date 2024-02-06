CREATE TABLE [dbo].[Members] (
    [MemberId]      INT           NOT NULL,
    [MemberName]    NVARCHAR (50) NOT NULL,
    [NIC]           NVARCHAR (15) NOT NULL,
    [Province]      NVARCHAR (20) NOT NULL,
    [DateOFBirth]   DATE          NOT NULL,
    [Gender]        NCHAR (10)    NOT NULL,
    [CampusName]    NVARCHAR (15) NOT NULL,
    [Facalty]       NVARCHAR (20) NOT NULL,
    [MemberAddress] NVARCHAR (80) NOT NULL,
    [MemberAge]     INT           NOT NULL,
    [PhoneNumber]   INT           NOT NULL,
    [Email]         VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([MemberId] ASC)
);

