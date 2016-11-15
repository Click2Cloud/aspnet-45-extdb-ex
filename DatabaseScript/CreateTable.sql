
CREATE TABLE [dbo].[Car](
 [CarId] [int] IDENTITY(1,1) NOT NULL,
 [Model] [nvarchar](50) NULL,
 [Year] [int] NULL,
 [Manufacturer] [nvarchar](50) NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
 [CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


INSERT INTO Car(Model,Year,Manufacturer) VALUES ('Camaro','2012', 'Chevrolet');
INSERT INTO Car(Model,Year,Manufacturer) VALUES ('Charger', '2013', 'Dodge');


