using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages;

namespace DemoMobile
{
    public class DisplayModeSamsung
    {
        public DisplayModeSamsung()
        {
            DisplayModeProvider.Instance.Modes.Insert(0,
                new DefaultDisplayMode("samsung")
                {
                    ContextCondition = (
                                    x => x.Request
                                            .UserAgent
                                            .IndexOf("samsung", StringComparison.OrdinalIgnoreCase) > 0
                                    )
                }
            );
        }
    }
}