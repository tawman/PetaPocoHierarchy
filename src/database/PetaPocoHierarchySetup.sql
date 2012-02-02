DECLARE @root_node_pk UNIQUEIDENTIFIER = NEWID()

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (@root_node_pk, NULL, 'US', 'United States');

DECLARE @parent_pk UNIQUEIDENTIFIER = NEWID()

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (@parent_pk, @root_node_pk, 'MW', 'Midwest');

DECLARE @state_pk UNIQUEIDENTIFIER = NEWID()

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (@state_pk, @parent_pk, 'MI', 'Michigan');

DECLARE @county_pk UNIQUEIDENTIFIER = NEWID()

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (@county_pk, @state_pk, 'WC', 'Wayne');

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @county_pk, 'CA', 'Canton');
INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @county_pk, 'PM', 'Plymouth');
INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @county_pk, 'DE', 'Detroit');

SET @county_pk = NEWID()

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (@county_pk, @state_pk, 'WA', 'Washtenaw');

DECLARE @city_pk UNIQUEIDENTIFIER = NEWID()

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (@city_pk, @county_pk, 'AA', 'Ann Arbor');

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @city_pk, 'UM', 'University of Michigan');

SET @city_pk = NEWID()

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (@city_pk, @county_pk, 'YP', 'Ypsilanti');

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @city_pk, 'EMU', 'Eastern Michigan University');

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @parent_pk, 'IN', 'Indiana');
INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @parent_pk, 'IL', 'Illinois');
INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @parent_pk, 'OH', 'Ohio');

INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @root_node_pk, 'SW', 'Southwest');
INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @root_node_pk, 'SE', 'Southeast');
INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @root_node_pk, 'NW', 'Northwest');
INSERT INTO [dbo].[Organization]([Id],[ParentId],[OrganizationCode],[Name])
VALUES (NEWID(), @root_node_pk, 'NE', 'Northeast');
