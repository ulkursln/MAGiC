using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGiC
{
    public class SummaryWalkthroughBE
    {
        private SummaryWalkthroughUI controls;
        public SummaryWalkthroughBE(SummaryWalkthroughUI _controls)
        {
            controls = _controls;
            initialize();
        }

        public SummaryWalkthroughBE()
        {
            initialize();
        }


        private void initialize()
        {
            controls.btn_gotoFunction_home_summary.Click += new System.EventHandler(this.btn_gotoFunction_home_Click);
            controls.btn_gotoFunction_summary.Click += new System.EventHandler(this.btn_gotoFunction_summary_Click);
        }

        private void btn_gotoFunction_summary_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToSummary();
        }

        private void btn_gotoFunction_home_Click(object sender, EventArgs e)
        {
            controls.navigationListener.navigateToWalkthroughHome();
        }
    }
}
