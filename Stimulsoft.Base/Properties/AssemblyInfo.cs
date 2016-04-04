#region Copyright (C) 2003-2016 Stimulsoft
/*
{*******************************************************************}
{																	}
{	Stimulsoft Reports												}
{																	}
{	Copyright (C) 2003-2016 Stimulsoft     							}
{	ALL RIGHTS RESERVED												}
{																	}
{	The entire contents of this file is protected by U.S. and		}
{	International Copyright Laws. Unauthorized reproduction,		}
{	reverse-engineering, and distribution of all or any portion of	}
{	the code contained in this file is strictly prohibited and may	}
{	result in severe civil and criminal penalties and will be		}
{	prosecuted to the maximum extent possible under the law.		}
{																	}
{	RESTRICTIONS													}
{																	}
{	THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES			}
{	ARE CONFIDENTIAL AND PROPRIETARY								}
{	TRADE SECRETS OF Stimulsoft										}
{																	}
{	CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON		}
{	ADDITIONAL RESTRICTIONS.										}
{																	}
{*******************************************************************}
*/
#endregion Copyright (C) 2003-2016 Stimulsoft

using System;
using System.Reflection;
using System.Security;
using Stimulsoft.Base;

[assembly: AssemblyTitle("Stimulsoft.Base.dll")]
[assembly: AssemblyDescription("Base Functionality")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(StiPublicName.Company)]
[assembly: AssemblyProduct(StiPublicName.Product)]
[assembly: AssemblyCopyright(StiVersion.Copyright)]
[assembly: AssemblyTrademark(StiPublicName.Trademark)]
[assembly: AssemblyCulture("")]
[assembly: AllowPartiallyTrustedCallers]
[assembly: CLSCompliant(true)]
[assembly: AssemblyVersion(StiVersion.Version)]
[assembly: AssemblyDelaySign(false)]
[assembly: SecurityRules(SecurityRuleSet.Level1)]

public class StiVersion
{
    public const string Version = "2016.1.5.0";
    public const string CreationDate = "25 March 2016";
    public static DateTime Created = new DateTime(2016, 3, 25);
    public const string VersionInfo = "Version=" + Version + ", Culture=neutral, " + StiPublicKeyToken.KeyReports;
    public const string Copyright = "Copyright (C) 2003-2016 Stimulsoft";
}
