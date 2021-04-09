using Mongoose.IDO.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GIL_SeperateDocuments
{
    public static class Functions
    {
        public static InvokeRequestData CreateInvokeRequestSetVar(string task, params string[] args)
        {
            StringBuilder TaskParms = new StringBuilder();
            InvokeRequestData invokeRequest = new InvokeRequestData();

            int count = args.Count<string>();
            int i = 0;

            TaskParms.Append("SETVARVALUES(");
            for (i = 0; i < count; i++)
            {
                if (i % 2 == 0)
                {
                    TaskParms.Append("~LIT~(");
                    TaskParms.Append(args[i]);
                    TaskParms.Append("=");
                }
                else
                {
                    TaskParms.Append(args[i]);
                    TaskParms.Append("),");
                }
            }
            
            TaskParms.Remove(TaskParms.Length - 1, 1);
            TaskParms.Append(")");

            invokeRequest.IDOName = "BGTaskDefinitions";
            invokeRequest.MethodName = "BGTaskSubmit";

            invokeRequest.Parameters.Add(task);
            invokeRequest.Parameters.Add(TaskParms.ToString());
            invokeRequest.Parameters.Add(IDONull.Value);
            invokeRequest.Parameters.Add("");
            invokeRequest.Parameters.Add(IDONull.Value);
            invokeRequest.Parameters.Add("READY");
            invokeRequest.Parameters.Add(IDONull.Value);
            invokeRequest.Parameters.Add("");
            invokeRequest.Parameters.Add(IDONull.Value);
            invokeRequest.Parameters.Add(IDONull.Value);
            invokeRequest.Parameters.Add(IDONull.Value);


            return invokeRequest;
        }

        public static InvokeRequestData CreateInvokeRequest(string task, params string[] args)
        {
            StringBuilder TaskParms = new StringBuilder();
            InvokeRequestData invokeRequest = new InvokeRequestData();

            int count = args.Count<string>();
            int i = 0;

            for (i = 0; i < count - 1; i++)
            {
                TaskParms.Append("~LIT~(");
                TaskParms.Append(args[i]);
                TaskParms.Append(")");
                TaskParms.Append(",");
            }

            TaskParms.Append("~LIT~(");
            TaskParms.Append(args[i]);
            TaskParms.Append(")");

            invokeRequest.IDOName = "BGTaskDefinitions";
            invokeRequest.MethodName = "BGTaskSubmit";

            invokeRequest.Parameters.Add(task);
            invokeRequest.Parameters.Add(TaskParms.ToString());
            invokeRequest.Parameters.Add(IDONull.Value);
            invokeRequest.Parameters.Add("");
            invokeRequest.Parameters.Add(IDONull.Value);
            invokeRequest.Parameters.Add("READY");
            invokeRequest.Parameters.Add(IDONull.Value);
            invokeRequest.Parameters.Add("");
            invokeRequest.Parameters.Add(IDONull.Value);
            invokeRequest.Parameters.Add(IDONull.Value);
            invokeRequest.Parameters.Add(IDONull.Value);


            return invokeRequest;
        }
    }
}
