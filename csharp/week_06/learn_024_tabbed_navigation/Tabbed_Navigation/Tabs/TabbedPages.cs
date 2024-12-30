using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabbed_Navigation.Tabs
{
    public class TabbedPages : TabbedPage
    {
        public TabbedPages()
        {
            Children.Add(new OverviewTabPage());
            Children.Add(new DatabaseTabPage());
        }
    }
}
