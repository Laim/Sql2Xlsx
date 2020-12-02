<a href="http://github.com/laim/sql2xlsx"><img src="https://user-images.githubusercontent.com/14845036/100935028-7b8f2300-34e7-11eb-8b8e-a396b1259edc.png" title="Sql2Xlsx" alt="Sql2Xlsx Logo"></a>

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

Easily export data from MS Sql Server to Microsoft Excel XLSX with no commerical licensing complications.

---
## Installation & Usage

Download the latest release and run the installer.  Unless you change the path, it will install to `C:\Program Files\Laim McKenzie\Sql2Xlsx\`.  

Once installed, open `Sql2Xlsx.exe` and connect to your SQL Server.  If you use a non-standard SQL Port, enter your SQL Server as `SQLSERVER,10130` or `SQLSERVER\INSTANCE,10130`, additional parameters can be added by doing `;parametername=value`, for example `SQLSERVER,10130;Connection Timeout=100`.

## Features

- Direct connect to SQL Server
- Quick export of data to Microsoft Excel Workbooks (xlsx)
- Use as a standard SQL Explorer if you don't want to install SMSS

# Screenshots
![Sql2XlsxMain](https://user-images.githubusercontent.com/14845036/100925371-d3bf2880-34d9-11eb-837f-204cb5aee0f5.png)
![Sql2XlsxConnection](https://user-images.githubusercontent.com/14845036/100925364-d1f56500-34d9-11eb-9dfe-bcbd6cdd706e.png)
![Sql2XlsxExport](https://user-images.githubusercontent.com/14845036/100925369-d3269200-34d9-11eb-9aa9-4b7806b467e8.PNG)

# Credits
- [EPPlus](https://www.epplussoftware.com/) for the Excel Exporting Library
- [Stackoverflow](https://stackoverflow/) as always
- SQL Icon made by [Iconixar](https://www.flaticon.com/authors/iconixar) from [Flaticon](https://flaticon.com)
- [Paul Kohler](http://minisqlquery.codeplex.com/license)
