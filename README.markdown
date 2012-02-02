PetaPocoHierarchy Example
=========================

This sample project is meant to demonstrate how PetaPoco can load Hierarchical table data into a single POCO object while retaining the parent-child relationship.

Example Source Data
-------------------
<table border="1" cellspacing="0" cellpadding="2">
    <thead>
        <tr>
            <th>Id</th>
            <th>ParentId</th>
            <th>OrganizationCode</th>
            <th>Name</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>1</td>
            <td>NULL</td>
            <td>US</td>
            <td>United States</td>
        </tr>
        <tr>
            <td>2</td>
            <td>1</td>
            <td>MW</td>
            <td>Midwest</td>
        </tr>
        <tr>
        <td>3</td>
            <td>1</td>
            <td>NE</td>
            <td>Northeast</td>
        </tr>
        <tr>
            <td>4</td>
            <td>1</td>
            <td>NW</td>
            <td>Northwest</td>
        </tr>
        <tr>
            <td>5</td>
            <td>1</td>
            <td>SE</td>
            <td>Southeast</td>
        </tr>
        <tr>
            <td>6</td>
            <td>1</td>
            <td>SW</td>
            <td>Southwest</td>
        </tr>
        <tr>
            <td>7</td>
            <td>2</td>
            <td>MI</td>
            <td>Michigan</td>
        </tr>
        <tr>
            <td>8</td>
            <td>2</td>
            <td>IN</td>
            <td>Indiana</td>
        </tr>
        <tr>
            <td>9</td>
            <td>2</td>
            <td>IL</td>
            <td>Illinois</td>
        </tr>
        <tr>
            <td>10</td>
            <td>2</td>
            <td>OH</td>
            <td>Ohio</td>
        </tr>
        <tr>
            <td>11</td>
            <td>7</td>
            <td>WC</td>
            <td>Wayne</td>
        </tr>
        <tr>
            <td>12</td>
            <td>7</td>
            <td>WA</td>
            <td>Washtenaw</td>
        </tr>
        <tr>
            <td>13</td>
            <td>11</td>
            <td>DE</td>
            <td>Detroit</td>
        </tr>
        <tr>
            <td>14</td>
            <td>11</td>
            <td>CA</td>
            <td>Canton</td>
        </tr>
        <tr>
            <td>15</td>
            <td>11</td>
            <td>PM</td>
            <td>Plymouth</td>
        </tr>
        <tr>
            <td>16</td>
            <td>12</td>
            <td>AA</td>
            <td>Ann Arbor</td>
        </tr>
        <tr>
            <td>17</td>
            <td>12</td>
            <td>YP</td>
            <td>Ypsilanti</td>
        </tr>
        <tr>
            <td>18</td>
            <td>16</td>
            <td>UM</td>
            <td>University of Michigan</td>
        </tr>
            <tr>
            <td>19</td>
            <td>17</td>
            <td>EMU</td>
            <td>Eastern Michigan University</td>
        </tr>
    </tbody>
</table>

Sample Data Loaded as POCO Objects by PetaPoco
----------------------------------------------
<table border="1" cellspacing="0" cellpadding="2">
    <thead>
        <tr>
            <th>Hierarchy</th>
            <th>Name</th>
            <th>Code</th>
        </tr>
    </thead>
    <tbody>
            <tr>
                <td>United States</td>
                <td>United States</td>
                <td>US</td>
            </tr>
            <tr>
                <td>United States > Midwest</td>
                <td>Midwest</td>
                <td>MW</td>
            </tr>
            <tr>
                <td>United States > Midwest > Illinois</td>
                <td>Illinois</td>
                <td>IL</td>
            </tr>
            <tr>
                <td>United States > Midwest > Indiana</td>
                <td>Indiana</td>
                <td>IN</td>
            </tr>
            <tr>
                <td>United States > Midwest > Michigan</td>
                <td>Michigan</td>
                <td>MI</td>
            </tr>
            <tr>
                <td>United States > Midwest > Michigan > Washtenaw</td>
                <td>Washtenaw</td>
                <td>WA</td>
            </tr>
            <tr>
                <td>United States > Midwest > Michigan > Washtenaw > Ann Arbor</td>
                <td>Ann Arbor</td>
                <td>AA</td>
            </tr>
            <tr>
                <td>United States > Midwest > Michigan > Washtenaw > Ann Arbor > University of Michigan</td>
                <td>University of Michigan</td>
                <td>UM</td>
            </tr>
            <tr>
                <td>United States > Midwest > Michigan > Washtenaw > Ypsilanti</td>
                <td>Ypsilanti</td>
                <td>YP</td>
            </tr>
            <tr>
                <td>United States > Midwest > Michigan > Washtenaw > Ypsilanti > Eastern Michigan University</td>
                <td>Eastern Michigan University</td>
                <td>EMU</td>
            </tr>
            <tr>
                <td>United States > Midwest > Michigan > Wayne</td>
                <td>Wayne</td>
                <td>WC</td>
            </tr>
            <tr>
                <td>United States > Midwest > Michigan > Wayne > Canton</td>
                <td>Canton</td>
                <td>CA</td>
            </tr>
            <tr>
                <td>United States > Midwest > Michigan > Wayne > Detroit</td>
                <td>Detroit</td>
                <td>DE</td>
            </tr>
            <tr>
                <td>United States > Midwest > Michigan > Wayne > Plymouth</td>
                <td>Plymouth</td>
                <td>PM</td>
            </tr>
            <tr>
                <td>United States > Midwest > Ohio</td>
                <td>Ohio</td>
                <td>OH</td>
            </tr>
            <tr>
                <td>United States > Northeast</td>
                <td>Northeast</td>
                <td>NE</td>
            </tr>
            <tr>
                <td>United States > Northwest</td>
                <td>Northwest</td>
                <td>NW</td>
            </tr>
            <tr>
                <td>United States > Southeast</td>
                <td>Southeast</td>
                <td>SE</td>
            </tr>
            <tr>
                <td>United States > Southwest</td>
                <td>Southwest</td>
                <td>SW</td>
            </tr>
    </tbody>
</table>

How To Build It?
----------------

From a command window run: *build.bat*

Otherwise, open the Solution file in Visual Studio 2010 and Build

How Do You View It?
-------------------

From the Start menu, click Run, then type *inetmgr* to open the Internet Information Services (IIS) MMC snap-in.

1. Right mouse click on the Default Web Site and Select "Add Application"
2. Enter an Alias for the Site (i.e. *PetaPocoHierarchy*)
3. Enter the Physical Path (i.e. *C:\@WCP\clone\PetaPocoHierarchy\src\PetaPocoHierarchy*)
4. Open a web browser to: http://localhost/PetaPocoHierarchy/

Alternatively, Open the PetaPocoHierarchy.sln Solution in Visual Studio 2010 and explore.

The sample database file provided was created with SQL Server 2008 R2. The SQL needed to create the table and populate the sample data is provided in the src/database directory.

Thanks
------
This software is Open Source and check the LICENSE.txt file for more details.

Todd A. Wood
([@iToddWood](https://twitter.com/#!/iToddWood "Follow me on Twitter"))
Visit [Implement IToddWood](http://www.woodcp.com "Wood Consulting Practice, LLC")
