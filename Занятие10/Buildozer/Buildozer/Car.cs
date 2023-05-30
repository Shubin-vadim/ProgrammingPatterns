using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildozer
{
    class Car
    {
        public string Engine { get; set; }
        public string Frame { get; set; }
        public string Wheels { get; set; }
        public string Luxury { get; set; }
        public string Muitimedia { get; set; }
        public string Safety { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Engine: {0}\n", Engine);
            sb.AppendFormat("Frame: {0}\n", Frame);
            sb.AppendFormat("Wheels: {0}\n", Wheels);
            if (Luxury != null)
            {
                sb.AppendFormat("Luxury: {0}\n", Luxury);
            }
            if (Muitimedia != null)
            {
                sb.AppendFormat("Muitimedia: {0}\n", Muitimedia);
            }
            sb.AppendFormat("Safety: {0}\n", Safety);
            return sb.ToString();
        }
    }
}
