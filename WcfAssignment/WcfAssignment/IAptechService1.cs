using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfAssignment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAptechService1" in both code and config file together.
    [ServiceContract]
    public interface IAptechService1
    {
        [OperationContract]
        List<Batch> GetAllBatches();

        [OperationContract]
        List<Student> GetStudntsByBatch(string batch);

        [OperationContract]
        string MarkAttandance(string sid);
    }
}
