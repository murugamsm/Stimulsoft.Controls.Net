﻿#region Copyright (C) 2003-2016 Stimulsoft
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
using System.Drawing;
using System.Collections.Generic;
using System.Text;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Base.Json.Linq;

namespace Stimulsoft.Base.Context
{
    public class StiCachedShadowGeom : StiGeom
    {
        #region IStiJsonReportObject.override
        public override JObject SaveToJsonObject(StiJsonSaveMode mode)
        {
            var jObject = base.SaveToJsonObject(mode);

            jObject.Add(new JProperty("Rect", SaveRectangleFToJsonObject(Rect)));
            jObject.Add(new JProperty("Sides", Sides.ToString()));
            jObject.Add(new JProperty("IsPrinting", IsPrinting));

            return jObject;
        }

        public override void LoadFromJsonObject(JObject jObject)
        {
        }
        #endregion

        #region Fields
        public RectangleF Rect;
        public StiShadowSides Sides;
        public bool IsPrinting;
        #endregion

        #region Properties
        public override StiGeomType Type
        {
            get
            {
                return StiGeomType.CachedShadow;
            }
        }
        #endregion

        public StiCachedShadowGeom(RectangleF rect, StiShadowSides sides, bool isPrinting)
        {
            this.Rect = rect;
            this.Sides = sides;
            this.IsPrinting = isPrinting;
        }
    }
}
