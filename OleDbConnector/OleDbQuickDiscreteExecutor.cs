using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using CoreComponents.Data;

namespace OleDbConnector
{

    public class OleDbQuickDiscreteExecutor : QuickDiscreteExecutor<OleDbConnection, OleDbCommand, OleDbParameter>
    {

        public OleDbQuickDiscreteExecutor()
        {
        }

    }

}
