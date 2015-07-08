﻿using System;
using System.Xml.Serialization;

namespace Safezone.Model.Flag
{
    public class SerializableFlag
    {
        [XmlAttribute("name")]
        public String Name;
        [XmlAttribute("value")]
        public Object Value; 
    }
}