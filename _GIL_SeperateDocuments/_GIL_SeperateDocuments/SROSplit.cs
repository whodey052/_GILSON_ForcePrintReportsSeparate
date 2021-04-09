using Mongoose.IDO.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GIL_SeperateDocuments
{
    public static class SROSplit
    {
        public static short SROInvoiceSubmitLoop(IIDOCommands context, string ProcessReprint, string StartSRONum, string EndSRONum, string StartSROLine, string EndSROLine, string StartSROOper,
            string EndSROOper, string StartBillMgr, string EndBillMgr, string StartCustNum, string EndCustNum, string StartRegion, string EndRegion, string StartTransDate,
            string EndTransDate, string StartCloseDate, string EndCloseDate, string InclCalculated, string InclProject, string InvCred, string InvDate, string TransToDomCurr,
            string SortBy, int SubStartInvNum, int SubEndInvNum, string StartReprintInvDate, string EndReprintInvDate, string PrintCustomerNotes, string PrintSRONotes,
            string PrintSROLineNotes, string PrintSROOperNotes, string PrintTransNotes, string PrintInternalNotes, string PrintExternalNotes, string PrintSerials,
            string PrintMatl, string PrintLabor, string PrintMisc, string SummarizeTrans, string ShipToAddress, string PrintEuroTotal, string OrderBy)
        {
            for (int i = SubStartInvNum; i < SubEndInvNum + 1; i++)
            {
                InvokeRequestData invokeRequest = Functions.CreateInvokeRequestSetVar("ServiceOrderInvoicing",
                    nameof(ProcessReprint), ProcessReprint,
                    nameof(StartSRONum), StartSRONum,
                    nameof(EndSRONum), EndSRONum,
                    nameof(StartSROLine), StartSROLine,
                    nameof(EndSROLine), EndSROLine,
                    nameof(StartSROOper), StartSROOper,
                    nameof(EndSROOper), EndSROOper,
                    nameof(StartBillMgr), StartBillMgr,
                    nameof(EndBillMgr), EndBillMgr,
                    nameof(StartCustNum), StartCustNum,
                    nameof(EndCustNum), EndCustNum,
                    nameof(StartRegion), StartRegion,
                    nameof(EndRegion), EndRegion,
                    nameof(StartTransDate), StartTransDate,
                    nameof(EndTransDate), EndTransDate,
                    nameof(StartCloseDate), StartCloseDate,
                    nameof(EndCloseDate), EndCloseDate,
                    nameof(InclCalculated), InclCalculated,
                    nameof(InclProject), InclProject,
                    nameof(InvCred), InvCred,
                    nameof(InvDate), InvDate,
                    nameof(TransToDomCurr), TransToDomCurr,
                    nameof(SortBy), SortBy,
                    nameof(SubStartInvNum), i.ToString(),
                    nameof(SubEndInvNum), i.ToString(),
                    nameof(StartReprintInvDate), StartReprintInvDate,
                    nameof(EndReprintInvDate), EndReprintInvDate,
                    nameof(PrintCustomerNotes), PrintCustomerNotes,
                    nameof(PrintSRONotes), PrintSRONotes,
                    nameof(PrintSROLineNotes), PrintSROLineNotes,
                    nameof(PrintSROOperNotes), PrintSROOperNotes,
                    nameof(PrintTransNotes), PrintTransNotes,
                    nameof(PrintInternalNotes), PrintInternalNotes,
                    nameof(PrintExternalNotes), PrintExternalNotes,
                    nameof(PrintSerials), PrintSerials,
                    nameof(PrintMatl), PrintMatl,
                    nameof(PrintLabor), PrintLabor,
                    nameof(PrintMisc), PrintMisc,
                    nameof(SummarizeTrans), SummarizeTrans,
                    nameof(ShipToAddress), ShipToAddress,
                    nameof(PrintEuroTotal), PrintEuroTotal,
                    nameof(OrderBy), OrderBy);

                context.Invoke(invokeRequest);
            }

            return 0;
        }
    }
}
