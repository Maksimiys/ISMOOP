using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Applicant:Peoples
    {
        protected int ZNO;
        protected int Schooldoc;
        protected string Institution;
        public Applicant(string name,string surname,DateTime birthday,int zno,int schooldoc,string institution):base(name,surname,birthday)
        {
            ZNO = zno;
            Schooldoc = schooldoc;
            Institution = institution;
        }
    }
}
