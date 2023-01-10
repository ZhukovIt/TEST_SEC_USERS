using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RoleWorker : IModel
    {
        private int m_Id;
        private string m_Name;
        private bool m_BuiltIn;

        public int Id
        {
            get
            {
                return m_Id;
            }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        public bool BuiltIn
        {
            get
            {
                return m_BuiltIn;
            }
        }

        public RoleWorker(int id, string name, bool builtIn)
        {
            m_Id = id;
            m_Name = name;
            m_BuiltIn = builtIn;
        }

        public object GetObjectModel()
        {
            return null;
        }
    }
}
