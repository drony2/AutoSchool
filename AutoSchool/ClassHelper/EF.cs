using AutoSchool.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSchool.ClassHelper
{
    internal class EF
    {
        public static AutoSchoolEntities Context { get; } = new AutoSchoolEntities();
    }
}
