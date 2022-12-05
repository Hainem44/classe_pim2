using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_pim2
{
    class passeio
    {
        public int id_passeio { get; set; }
        public double gps { get; set; }

        public feed feed1;
        public pet pet1;
        public profissional prof1;
        public pagamento paga1;

        public passeio()
        {
            feed1 = new feed();
            pet1 = new pet();
            prof1 = new profissional();
            paga1 = new pagamento();

            
        }
        
    }
}
