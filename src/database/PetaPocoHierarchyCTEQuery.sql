WITH CTE(Id, ParentId, OrganizationCode, Name, OrganizationLevel, LinkId) AS
(SELECT Id, ParentId, OrganizationCode, Name, 0 AS OrganizationLevel, Id as LinkId
FROM Organization
UNION ALL
SELECT o.Id, o.ParentId, o.OrganizationCode, o.Name, CTE.OrganizationLevel + 1 AS OrganizationLevel, CTE.LinkId
FROM Organization o INNER JOIN CTE ON CTE.ParentId = o.Id)
SELECT * FROM Organization org LEFT OUTER JOIN CTE ON CTE.LinkId = org.Id
ORDER BY org.Id, OrganizationLevel DESC
