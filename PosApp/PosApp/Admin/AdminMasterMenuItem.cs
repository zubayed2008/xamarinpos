using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosApp.Admin
{

    public class AdminMasterMenuItem
    {
        public AdminMasterMenuItem()
        {
            TargetType = typeof(AdminMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }

        public Type TargetType { get; set; }
    }
}