using System;
using Thinkwise.ServiceModel;
using Thinkwise.Shared;
using Thinkwise.Shared.ObjectModel;

[assembly: TSFService(typeof(TSFObjectModel.IObjectModelExtender), typeof(ObjectmodelExtenderTemplate.CustomObjectModelExtender), "CustomObjectModelExtender.dll", LifetimeOption.Singleton)]

namespace ObjectmodelExtenderTemplate
{
    public class CustomObjectModelExtender : ObjectModelExtender
    {
        public override void ExtendModel(ObjectModelFillHelper fillHelper)
        {
            // Deze functie wordt gebruikt om te kunnen debuggen als er iets niet klopt. Als de objectmodel extender klaar is kan deze regel weg.
            //System.Diagnostics.Debugger.Launch();
        }
    }
}
