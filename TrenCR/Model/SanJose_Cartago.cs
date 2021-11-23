using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace TrenCR.Model
{
    public class SanJose_Cartago
    {
        [Key]
        public int Id { get; set; }
        public string EstacionAtlantico { get; set; }
        public string UCR { get; set; }
        public string Ulatina { get; set; }
        public string Cfia { get; set; }
        public string UACA { get; set; }
        public string TresRios { get; set; }
        public string EstacionCartago { get; set; }
        public string LosAngeles { get; set; }
    }
}
