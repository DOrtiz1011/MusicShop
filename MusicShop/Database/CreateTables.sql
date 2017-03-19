CREATE TABLE [Album]
(
    [ID]        [int] IDENTITY(1,1) NOT NULL,
    [Title]     [nvarchar](128)     NOT NULL,
    [ArtitstID] [int]               NOT NULL,
    [GenreID]   [int]               NOT NULL,
    [Year]      [int]               NOT NULL,
    [CoverUrl] [nvarchar](256)      NULL
CONSTRAINT [PK_Album_ID] PRIMARY KEY CLUSTERED 
(
    [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE UNIQUE INDEX [IX_AlbumnTitleAndArtistId] ON [Album] ([Title]);
GO 

---------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE [Artist]
(
    [ID]        [int] IDENTITY(1,1) NOT NULL,
    [Name]      [nvarchar](128)     NOT NULL
CONSTRAINT [PK_Artist_ID] PRIMARY KEY CLUSTERED 
(
    [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE UNIQUE INDEX [IX_ArtistName] ON [Artist] ([Name]);
GO 

---------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE [Genre]
(
    [ID]        [int] IDENTITY(1,1) NOT NULL,
    [Name]      [nvarchar](128)     NOT NULL
CONSTRAINT [PK_Genre_ID] PRIMARY KEY CLUSTERED 
(
    [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE UNIQUE INDEX [IX_GenreName] ON [Genre] ([Name]);
GO 

---------------------------------------------------------------------------------------------------------------------------------------------------

CREATE TABLE [Track]
(
    [ID]        [int] IDENTITY(1,1) NOT NULL,
    [AlbumID]   [int]               NOT NULL,
    [Number]    [int]               NOT NULL,
    [SongTitle] [nvarchar](128)     NOT NULL,
    [Length]    [BIGINT]            NOT NULL
CONSTRAINT [PK_Track_ID] PRIMARY KEY CLUSTERED 
(
    [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE UNIQUE INDEX [IX_AlbumnIDNumberTitle] ON [Track] ([AlbumID], [Number], [SongTitle]);
GO 
