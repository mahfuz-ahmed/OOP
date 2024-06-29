﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.Interface
{
    public class Student: IInformation,IConvert
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Roll { get; set; }
        public string Email { get; set; }

        public void ConvertPdf(string formateType)
        {
            throw new NotImplementedException();
        }

        public void ConvertZip()
        {
            throw new NotImplementedException();
        }

        public string GetInformation()
        {
            return RegNo + " " + Name + " " + Roll;
        }
    }
}
