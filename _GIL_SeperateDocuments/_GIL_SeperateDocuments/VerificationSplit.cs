using Mongoose.IDO.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GIL_SeperateDocuments
{
    public static class VerificationSplit
    {
        public static LoadCollectionResponseData GetListCustomerOrders_Verification(IIDOCommands context,
                                                  string startOrderNum,
                                                  string endOrderNum,
                                                  string startSalesperson,
                                                  string endSalesperson)
        {
            string filter = "";

            if (!string.IsNullOrEmpty(startOrderNum))
            {
                filter += "CoNum >= '" + startOrderNum.PadLeft(10) + "'";
            }

            if (!string.IsNullOrEmpty(endOrderNum))
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }

                filter += "CoNum <= '" + endOrderNum.PadLeft(10) + "'";
            }

            if (!string.IsNullOrEmpty(startSalesperson))
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }
                filter += "Slsman >= '" + startSalesperson + "'";
            }

            if (!string.IsNullOrEmpty(endSalesperson))
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    filter += " AND ";
                }

                filter += "Slsman <= '" + endSalesperson + "'";
            }
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

        public static short VerificationSubmitLoop(IIDOCommands context, 
            string CoTypeRegular, string CoTypeBlanket, string CoStatus, string CoLineReleaseStat,
            string PrintItemCustItem, string PrintOrderText, string PrintStandardOrderText, string PrintCompanyName,
            string DisplayDate, string DateToAppear, string DateToAppearOffset, string PrintBlanketLineText,
            string PrintBlanketLineDes, string PrintLineReleaseNotes, string PrintLineReleaseDes, string PrintShipToNotes, string printBillToNotes,
            string PrintPlanningItemMaterials, string IncludeSerialNumbers, string PrintEuroValue, string PrintPrice,
            string SoryBy, string OrderStarting, string OrderEnding, string SalespersonStarting,
            string SalespersonEnding, string OrderLineStarting, string OrderReleaseStarting, string OrderLineEnding,
            string OrderReleaseEnding, string PrintInternalNotes, string PrintExternalNotes, string PrintItemOverivew,
            string DisplayHeader, string ConfigDetails, string BG_TASKID, string PrintDrawingNumber, string PrintTax,
            string PrintDeliveryIncoTerms, string PrintEUCode, string PrintCommodityCode, string PrintOriginCode,
            string PrintCurrencyCode, string PrintHeaderOnAllPages, string PrintEndUserItem, string pSite, string PrintPreview, string UseProfile, ref string Infobar)
        {
            LoadCollectionResponseData coItems = GetListCustomerOrders_Verification(context, OrderStarting, OrderEnding, SalespersonStarting, SalespersonStarting);

            for (int i = 0; i < coItems.Items.Count; i++)
            {
                InvokeRequestData invokeRequest = Functions.CreateInvokeRequestSetVar(
                    "OrderVerificationReport", nameof(CoTypeRegular), CoTypeRegular, nameof(CoTypeBlanket), CoTypeBlanket, nameof(CoStatus),
                    CoStatus, nameof(CoLineReleaseStat), CoLineReleaseStat,
                    nameof(PrintItemCustItem), PrintItemCustItem, nameof(PrintOrderText), PrintOrderText, nameof(PrintStandardOrderText),
                    PrintStandardOrderText, nameof(PrintCompanyName), PrintCompanyName, nameof(DisplayDate), DisplayDate,
                    nameof(DateToAppear), DateToAppear, nameof(DateToAppearOffset), DateToAppearOffset, nameof(PrintBlanketLineText),
                    PrintBlanketLineText, nameof(PrintBlanketLineDes), PrintBlanketLineDes, nameof(PrintLineReleaseNotes), PrintLineReleaseNotes,
                    nameof(PrintLineReleaseDes), PrintLineReleaseDes, nameof(PrintShipToNotes), PrintShipToNotes, nameof(printBillToNotes), printBillToNotes, nameof(PrintPlanningItemMaterials), 
                    PrintPlanningItemMaterials, nameof(IncludeSerialNumbers), IncludeSerialNumbers, nameof(PrintEuroValue), PrintEuroValue,
                    nameof(PrintPrice), PrintPrice, nameof(SoryBy), SoryBy, "OrderStarting", coItems[i, 1].Value, "OrderEnding", coItems[i, 1].Value,
                    nameof(SalespersonStarting), SalespersonStarting, nameof(SalespersonEnding), SalespersonEnding,
                    nameof(OrderLineStarting), OrderLineStarting, nameof(OrderReleaseStarting), OrderReleaseStarting, nameof(OrderLineEnding), OrderLineEnding,
                    nameof(OrderReleaseEnding), OrderReleaseEnding, nameof(PrintInternalNotes), PrintInternalNotes,
                    nameof(PrintExternalNotes), PrintExternalNotes, nameof(PrintItemOverivew), PrintItemOverivew, nameof(DisplayHeader), 
                    DisplayHeader, nameof(ConfigDetails), ConfigDetails, "BG_TASKID", "BG~TASKID~", nameof(PrintDrawingNumber), PrintDrawingNumber,
                    nameof(PrintTax), PrintTax, nameof(PrintDeliveryIncoTerms), PrintDeliveryIncoTerms, nameof(PrintEUCode), PrintEUCode,
                    nameof(PrintCommodityCode), PrintCommodityCode, nameof(PrintOriginCode), PrintOriginCode,
                    nameof(PrintCurrencyCode), PrintCurrencyCode, nameof(PrintHeaderOnAllPages), PrintHeaderOnAllPages,
                    nameof(PrintEndUserItem), PrintEndUserItem, nameof(pSite), pSite, nameof(PrintPreview), PrintPreview, nameof(UseProfile),
                    UseProfile);
                
                context.Invoke(invokeRequest);
            }

            return 0;
        }
    }
}
