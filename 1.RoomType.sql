Use [[DihuiHuang]].[HotelSystem]]]
Go
SET IDENTITY_INSERT [dbo].[RoomTypes] ON 

INSERT RoomTypes([Id], [RTDesc],[Rent]) VALUES (1, 'King Deluxe',200);
INSERT RoomTypes([Id], [RTDesc],[Rent]) VALUES (2, 'King Corner',250);
INSERT RoomTypes([Id], [RTDesc],[Rent]) VALUES (3, 'Studio Suite',300);
INSERT RoomTypes([Id], [RTDesc],[Rent]) VALUES (4, 'Queen Deluxe',200);
INSERT RoomTypes([Id], [RTDesc],[Rent]) VALUES (5, 'Park View Suite',500);
INSERT RoomTypes([Id], [RTDesc],[Rent]) VALUES (6, 'Presidential suite',1000);

SET IDENTITY_INSERT [dbo].[RoomTypes] OFF