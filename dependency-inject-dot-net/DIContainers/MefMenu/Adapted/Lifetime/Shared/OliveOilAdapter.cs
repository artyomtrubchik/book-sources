﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Ploeh.Samples.MenuModel;

namespace Ploeh.Samples.Menu.Mef.Adapted.Lifetime.Shared
{
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class OliveOilAdapter : Ploeh.Samples.Menu.Mef.Adapted.OliveOilAdapter
    {
        [Export]
        public override OliveOil OliveOil
        {
            get { return base.OliveOil; }
        }
    }
}
