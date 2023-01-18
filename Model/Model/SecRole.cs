using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SecRole
    {
        private dtsSecUsers m_dts_SEC_USERS;

        public SecRole(dtsSecUsers dts_SEC_USERS)
        {
            m_dts_SEC_USERS = dts_SEC_USERS;
        }
    }
}
