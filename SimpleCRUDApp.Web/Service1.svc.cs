using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;

namespace SimpleCRUDApp.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1
    {
        [OperationContract]
        public List<Persons> GetPeople()
        {
            testmeEntities ctx = new testmeEntities();
            var people = from p in ctx.Persons
                         select p;

            return people.ToList();
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
