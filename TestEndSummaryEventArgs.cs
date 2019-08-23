using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQFormUI
{
    public class TestEndSummaryEventArgs : EventArgs
    {
        private ArrayList m_summary=null;
        private string m_analysis = string.Empty;

        public TestEndSummaryEventArgs(ArrayList summary, string analysis)
        {
            m_analysis = analysis;
            m_summary = summary;
        }

        public ArrayList TestSummary
        {
            get { return m_summary; }
        }

        public string Analysis
        {
            get { return m_analysis; }
        }
    }
}
