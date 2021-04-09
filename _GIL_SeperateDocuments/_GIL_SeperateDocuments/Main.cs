using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mongoose.IDO;
using Mongoose.IDO.Protocol;

namespace _GIL_SeperateDocuments
{
    [IDOExtensionClass("_GIL_SeperateDocuments")]
    public class _GIL_SeperateDocuments : IDOExtensionClass
    {
        [IDOMethod(MethodFlags.None, "Infobar")]
        public short _GIL_Seperate_InvoicingBG(
            Guid? SessionID, string InvoiceType, string BGTaskName, string InvType, string InvCred, string InvDate,
            string StartCustomer, string EndCustomer, string StartOrderNum, string EndOrderNum, short? StartLine,
            short? EndLine, short? StartRelease, short? EndRelease, string StartLastShipDate,
            string EndLastShipDate, int? StartPackNum, int? EndPackNum, byte? CreateFromPackSlip, string pMooreForms,
            byte? pNonDraftCust, string SelectedStartInvNum, byte? CheckShipItemActiveFlag, string StartInvNum,
            string EndInvNum, string PrintItemCustomerItem, byte? TransToDomCurr, byte? PrintSerialNumbers,
            byte? PrintPlanItemMaterial, string PrintConfigurationDetail, byte? PrintEuro, byte? PrintCustomerNotes,
            byte? PrintOrderNotes, byte? PrintOrderLineNotes, byte? PrintOrderBlanketLineNotes,
            byte? PrintProgressiveBillingNotes, byte? PrintInternalNotes, byte? PrintExternalNotes,
            byte? PrintItemOverview, byte? DisplayHeader, byte? PrintLineReleaseDescription,
            byte? PrintStandardOrderText, byte? PrintBillToNotes, string LangCode, byte? PrintDiscountAmt, int? BatchId,
            string BGSessionId, decimal? UserId, ref string Infobar, byte? LCRVar, string pBegDoNum, string pEndDoNum,
            string pBegCustPo, string pEndCustPo, string DoHdrList, byte? PItemTypeCust, byte? PItemTypeItem,
            int? PrintConInvReport, string PInvNum, byte? POrderNums, decimal? PMiscCharges, decimal? PSalesTax,
            decimal? PFreight, string TCustPT, string PApplyToInvNum, string TOpt, byte? UseProfile, string Mode,
            byte? PrintLotNumber, string StartInvDate, string EndInvDate, string CurrentCultureName,
            decimal? StartingShipment, decimal? EndingShipment, string CalledFrom, Guid? InvoicBuilderProcessID,
            byte? PrintDrawingNumber, byte? PrintTax, byte? PrintCurrencyCode, byte? PrintDeliverIncoTerms,
            byte? PrintEUDetails, byte? PrintHeaderOnAllPages, byte? CreateFromShipment, byte? PrintTaxID)
        {
            try
            {
                InvoiceSplit.InvoiceSubmitLoop(this.Context.Commands, SessionID, InvoiceType, BGTaskName, InvType, InvCred, InvDate,
                    StartCustomer, EndCustomer, StartOrderNum, EndOrderNum, StartLine, EndLine, StartRelease, EndRelease,
                    StartLastShipDate, EndLastShipDate, StartPackNum, EndPackNum, CreateFromPackSlip, pMooreForms, pNonDraftCust, SelectedStartInvNum,
                    CheckShipItemActiveFlag, StartInvNum, EndInvNum, PrintItemCustomerItem, TransToDomCurr, PrintSerialNumbers, PrintPlanItemMaterial,
                    PrintConfigurationDetail, PrintEuro, PrintCustomerNotes, PrintOrderNotes, PrintOrderLineNotes, PrintOrderBlanketLineNotes, PrintProgressiveBillingNotes,
                    PrintInternalNotes, PrintExternalNotes, PrintItemOverview, DisplayHeader, PrintLineReleaseDescription, PrintStandardOrderText, PrintBillToNotes,
                    LangCode, PrintDiscountAmt, BatchId, BGSessionId, UserId, ref Infobar, LCRVar, pBegDoNum, pEndDoNum, pBegCustPo, pEndCustPo, DoHdrList, PItemTypeCust,
                    PItemTypeItem, PrintConInvReport, PInvNum, POrderNums, PMiscCharges, PSalesTax, PFreight, TCustPT, PApplyToInvNum, TOpt, UseProfile, Mode,
                    PrintLotNumber, StartInvDate, EndInvDate, CurrentCultureName, StartingShipment, EndingShipment, CalledFrom, InvoicBuilderProcessID, PrintDrawingNumber,
                    PrintTax, PrintCurrencyCode, PrintDeliverIncoTerms, PrintEUDetails, PrintHeaderOnAllPages, CreateFromShipment, PrintTaxID);
            }
            catch
            {

            }
            return 0;
        }

        [IDOMethod(MethodFlags.None, "Infobar")]
        public short _GIL_Seperate_OrderVerification(
            string CoTypeRegular, string CoTypeBlanket, string CoStatus, string CoLineReleaseStat,
            string PrintItemCustItem, string PrintOrderText, string PrintStandardOrderText, string PrintCompanyName,
            string DisplayDate, string DataToAppear, string DateToAppearOffset, string PrintBlanketLineText,
            string PrintBlanketLineDes, string PrintLineReleaseNotes, string PrintLineReleaseDes, string PrintShipToNotes, string printBillToNotes,
            string PrintPlanningItemMaterials, string IncludeSerialNumbers, string PrintEuroValue, string PrintPrice,
            string SoryBy, string OrderStarting, string OrderEnding, string SalespersonStarting,
            string SalespersonEnding, string OrderLineStarting, string OrderReleaseStarting, string OrderLineEnding,
            string OrderReleaseEnding, string PrintInternalNotes, string PrintExternalNotes, string PrintItemOverivew,
            string DisplayHeader, string ConfigDetails, string BG_TASKID, string PrintDrawingNumber, string PrintTax,
            string PrintDeliveryIncoTerms, string PrintEUCode, string PrintCommodityCode, string PrintOriginCode,
            string PrintCurrencyCode, string PrintHeaderOnAllPages, string PrintEndUserItem, string pSite, string PrintPreview,
            string UseProfile, ref string Infobar)
        {
            try
            {
                VerificationSplit.VerificationSubmitLoop(this.Context.Commands, CoTypeRegular, CoTypeBlanket, CoStatus, CoLineReleaseStat,
                 PrintItemCustItem, PrintOrderText, PrintStandardOrderText, PrintCompanyName,
                 DisplayDate, DataToAppear, DateToAppearOffset, PrintBlanketLineText,
                 PrintBlanketLineDes, PrintLineReleaseNotes, PrintLineReleaseDes, PrintShipToNotes, printBillToNotes,
                 PrintPlanningItemMaterials, IncludeSerialNumbers, PrintEuroValue, PrintPrice,
                 SoryBy, OrderStarting, OrderEnding, SalespersonStarting,
                 SalespersonEnding, OrderLineStarting, OrderReleaseStarting, OrderLineEnding,
                 OrderReleaseEnding, PrintInternalNotes, PrintExternalNotes, PrintItemOverivew,
                 DisplayHeader, ConfigDetails, BG_TASKID, PrintDrawingNumber, PrintTax,
                 PrintDeliveryIncoTerms, PrintEUCode, PrintCommodityCode, PrintOriginCode,
                 PrintCurrencyCode, PrintHeaderOnAllPages, PrintEndUserItem, pSite, PrintPreview, UseProfile, ref Infobar);
            }
            catch(Exception ex)
            {
                Infobar = ex.Message;
                return 18;
            }
            return 0;
        }

        [IDOMethod(MethodFlags.None, "Infobar")]
        public short _GIL_Seperate_SROInvoices(string ProcessReprint, string StartSRONum, string EndSRONum, string StartSROLine, string EndSROLine, string StartSROOper,
            string EndSROOper, string StartBillMgr, string EndBillMgr, string StartCustNum, string EndCustNum, string StartRegion, string EndRegion, string StartTransDate,
            string EndTransDate, string StartCloseDate, string EndCloseDate, string InclCalculated, string InclProject, string InvCred, string InvDate, string TransToDomCurr,
            string SoryBy, int SubStartInvNum, int SubEndInvNum, string StartReprintInvDate, string EndReprintInvDate, string PrintCustomerNotes, string PrintSRONotes,
            string PrintSROLineNotes, string PrintSROOperNotes, string PrintTransNotes, string PrintInternalNotes, string PrintExternalNotes, string PrintSerials,
            string PrintMatl, string PrintLabor, string PrintMisc, string SummarizeTrans, string ShipToAddress, string PrintEuroTotal, string OrderBy, ref string Infobar)
        {
            try
            {
                SROSplit.SROInvoiceSubmitLoop(
                    this.Context.Commands, ProcessReprint, StartSRONum, EndSRONum, StartSROLine, EndSROLine,
                    StartSROOper, EndSROOper, StartBillMgr, EndBillMgr, StartCustNum, EndCustNum, StartRegion, EndRegion,
                    StartTransDate, EndTransDate, StartCloseDate, EndCloseDate, InclCalculated, InclProject, InvCred,
                    InvDate, TransToDomCurr, SoryBy, SubStartInvNum, SubEndInvNum, StartReprintInvDate,
                    EndReprintInvDate, PrintCustomerNotes, PrintSRONotes, PrintSROLineNotes, PrintSROOperNotes,
                    PrintTransNotes, PrintInternalNotes, PrintExternalNotes, PrintSerials, PrintMatl, PrintLabor,
                    PrintMisc, SummarizeTrans, ShipToAddress, PrintEuroTotal, OrderBy);
            }
            catch (Exception ex)
            {
                Infobar = ex.Message;
            }
            return 0;
        }
    }
}
