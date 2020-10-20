﻿/*************************************************************************************************
  Required Notice: Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
  01/27/2020         EPPlus Software AB       Initial release EPPlus 5
 *************************************************************************************************/
using System.Xml;

namespace OfficeOpenXml.Drawing.Controls
{
    /*
    <xsd:complexType name="CT_Control">
    3135 <xsd:sequence>
    3136 <xsd:element name="controlPr" type="CT_ControlPr" minOccurs="0" maxOccurs="1"/>
    3137 </xsd:sequence>
    3138 <xsd:attribute name="shapeId" type="xsd:unsignedInt" use="required"/>
    3139 <xsd:attribute ref="r:id" use="required"/>
    3140 <xsd:attribute name="name" type="xsd:string" use="optional"/>
    3141 </xsd:complexType>
    3142 <xsd:complexType name="CT_ControlPr">
    3143 <xsd:sequence>
    3144 <xsd:element name="anchor" type="CT_ObjectAnchor" minOccurs="1" maxOccurs="1"/>
    3145 </xsd:sequence>
    3146 <xsd:attribute name="locked" type="xsd:boolean" use="optional" default="true"/>
    3147 <xsd:attribute name="defaultSize" type="xsd:boolean" use="optional" default="true"/>
    3148 <xsd:attribute name="print" type="xsd:boolean" use="optional" default="true"/>
    3149 <xsd:attribute name="disabled" type="xsd:boolean" use="optional" default="false"/>
    3150 <xsd:attribute name="recalcAlways" type="xsd:boolean" use="optional" default="false"/>
    3151 <xsd:attribute name="uiObject" type="xsd:boolean" use="optional" default="false"/>
    3152 <xsd:attribute name="autoFill" type="xsd:boolean" use="optional" default="true"/>
    3153 <xsd:attribute name="autoLine" type="xsd:boolean" use="optional" default="true"/>
    3154 <xsd:attribute name="autoPict" type="xsd:boolean" use="optional" default="true"/>
    3155 <xsd:attribute name="macro" type="ST_Formula" use="optional"/>
    3156 <xsd:attribute name="altText" type="s:ST_Xstring" use="optional"/>
    3157 <xsd:attribute name="linkedCell" type="ST_Formula" use="optional"/>
    3158 <xsd:attribute name="listFillRange" type="ST_Formula" use="optional"/>
    3159 <xsd:attribute name="cf" type="s:ST_Xstring" use="optional" default="pict"/>
    3160 <xsd:attribute ref="r:id" use="optional"/>
    3161 </xsd:complexType> 
    */
    internal class ControlInternal : XmlHelper
    {

        internal ControlInternal(XmlNamespaceManager nameSpaceManager, XmlNode topNode) : base(nameSpaceManager, topNode)
        {

        }
        internal string Name 
        { 
            get
            {
                return GetXmlNodeString("@name");
            }
            set
            {
                SetXmlNodeString("@name", value);
            }
        }
        internal int ShapeId
        {
            get
            {
                return GetXmlNodeInt("@shapeId");
            }
            set
            {
                SetXmlNodeInt("@shapeId", value);
            }
        }

    }
}