CREATE TABLE [Album]
(
    [ID]       [int] IDENTITY(1,1) NOT NULL,
    [Title]    [nvarchar](128)     NOT NULL,
    [Artitst]  [nvarchar](128)     NOT NULL,
    [GenreID]  [int]               NOT NULL,
    [Year]     [bit]               NOT NULL,
    [CoverUrl] [nvarchar](256)     NULL
CONSTRAINT [PK_Album_ID] PRIMARY KEY CLUSTERED 
(
    [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
