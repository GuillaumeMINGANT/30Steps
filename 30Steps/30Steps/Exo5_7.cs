using System;
using System.Collections.Generic;
using System.Text;

namespace _30Steps
{
    class Exo5_7
    {
        int m_value;
        public Exo5_7(int value)
        {
            m_value = value;
        }

        public int Factorielle()
        {

            int ans = 1;
            for (int i = 1; i <= m_value; i++)
            {
                ans *= i;
            }
            return ans;
        }
    }
}
