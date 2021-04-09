using Mongoose.IDO.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GIL_SeperateDocuments
{
    public static class InvoiceSplit
    {

        public static LoadCollectionResponseData GetListCustomerOrders(IIDOCommands context,
                                                  string invCred,
                                                  string startCustomer,
                                                  string endCustomer,
                                                  string startOrderNum,
                                                  string endOrderNum)
        {
            string filter = "";

            if (invCred == "I")
            {
                filter = "QtyShipped > QtyInvoiced AND (Stat = 'O' OR Stat = 'F')";
            }
            else
            {
                filter = "QtyShipped < QtyInvoiced AND (Stat = 'O' OR Stat = 'F')";
            }

            if (!string.IsNullOrEmpty(startCustomer))
                filter += " AND DerCustNum >= '" + startCustomer + "'";
            
            if (!string.IsNullOrEmpty(endCustomer))
                filter += " AND DerCustNum <= '" + endCustomer + "'";

            if (!string.IsNullOrEmpty(startOrderNum))
                filter += " AND CoNum >= '" + startOrderNum + "'";

            if (!string.IsNullOrEmpty(startOrderNum))
                filter += " AND CoNum <= '" + endOrderNum + "'";

            LoadCollectionResponseData coItemsResponse = new LoadCollectionResponseData();
            LoadCollectionRequestData requestData = new LoadCollectionRequestData();
            
            requestData.Distinct = true;
            requestData.Filter = filter;
            requestData.IDOName = "SLCoitems";
            requestData.PropertyList = new PropertyList("DerCustNum,CoNum");
            requestData.OrderBy = "";
            requestData.RecordCap = 0;

            coItemsResponse = context.LoadCollection(requestData);

            return coItemsResponse;
        }

        public static short InvoiceSubmitLoop(
            IIDOCommands context, Guid? SessionID, string InvoiceType, string BGTaskName, string InvType, string InvCred,
            string InvDate, string StartCustomer, string EndCustomer, string StartOrderNum, string EndOrderNum,
            short? StartLine, short? EndLine, short? StartRelease, short? EndRelease, string StartLastShipDate,
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
            LoadCollectionResponseData coItems = InvoiceSplit.GetListCustomerOrders(context, InvCred, StartCustomer, EndCustomer, StartOrderNum, EndOrderNum);

            for (int i = 0; i < coItems.Items.Count; i++)
            {
                InvokeRequestData invokeRequest = Functions.CreateInvokeRequest(
                    "InvoicingBGSp", SessionID.ToString(), InvoiceType, BGTaskName, InvType, InvCred,
                    InvDate, coItems[i, 0].Value, coItems[i, 0].Value, coItems[i, 1].Value,
                    coItems[i, 1].Value, StartLine.ToString(), EndLine.ToString(), StartRelease.ToString(),
                    EndRelease.ToString(), StartLastShipDate, EndLastShipDate,
                    StartPackNum.ToString(), EndPackNum.ToString(), CreateFromPackSlip.ToString(), pMooreForms,
                    pNonDraftCust.ToString(), SelectedStartInvNum, CheckShipItemActiveFlag.ToString(), StartInvNum,
                    EndInvNum, PrintItemCustomerItem, TransToDomCurr.ToString(), PrintSerialNumbers.ToString(),
                    PrintPlanItemMaterial.ToString(), PrintConfigurationDetail, PrintEuro.ToString(),
                    PrintCustomerNotes.ToString(), PrintOrderNotes.ToString(), PrintOrderLineNotes.ToString(),
                    PrintOrderBlanketLineNotes.ToString(), PrintProgressiveBillingNotes.ToString(),
                    PrintInternalNotes.ToString(), PrintExternalNotes.ToString(), PrintItemOverview.ToString(),
                    DisplayHeader.ToString(), PrintLineReleaseDescription.ToString(), PrintStandardOrderText.ToString(),
                    PrintBillToNotes.ToString(), LangCode, PrintDiscountAmt.ToString(), BatchId.ToString(), BGSessionId,
                    UserId.ToString(), "MESSAGE", LCRVar.ToString(), pBegDoNum, pEndDoNum, pBegCustPo, pEndCustPo,
                    DoHdrList, PItemTypeCust.ToString(), PItemTypeItem.ToString(), PrintConInvReport.ToString(), PInvNum,
                    POrderNums.ToString(), PMiscCharges.ToString(), PSalesTax.ToString(), PFreight.ToString(), TCustPT,
                    PApplyToInvNum, TOpt, UseProfile.ToString(), Mode, PrintLotNumber.ToString(),
                    StartInvDate, EndInvDate, CurrentCultureName, StartingShipment.ToString(),
                    EndingShipment.ToString(), CalledFrom, InvoicBuilderProcessID.ToString(),
                    PrintDrawingNumber.ToString(), PrintTax.ToString(), PrintCurrencyCode.ToString(),
                    PrintDeliverIncoTerms.ToString(), PrintEUDetails.ToString(), PrintHeaderOnAllPages.ToString(),
                    CreateFromShipment.ToString(), PrintTaxID.ToString());
                
                InvokeResponseData invokeResponse = context.Invoke(invokeRequest);
            }

            return 0;
        }

    }
}
