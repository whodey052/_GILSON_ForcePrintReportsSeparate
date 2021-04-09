using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mongoose.IDO;
using Mongoose.IDO.Protocol;
using ue_GIL_ShippingWorkbench;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Client = new Client("https://csi10a.erpsl.inforcloudsuite.com/IDORequestService/RequestService.aspx?ConfigGroup=GILSON", IDOProtocol.Http);

            Client.OpenSession("sa", "@dmin4Gilson", "GILSON_TRN_GLUS");
            string Infobar = "";
            Int32 iReturn = 0;
            string PickListId = "44";
            string stat_string = "";
            //iReturn = PickListCreation.InsertSxPickList(Client, "", "", "STOCK", "SX", "O", "GLUS", "T", "", "SX", "10/28/2020", ref PickListId, ref Infobar);
            Console.WriteLine(PickListId);
            Console.WriteLine(Infobar);
            //PickListId = "7";
            string RefNum = "USS0000093";
            string RefLine = "1";
            string RefType = "S";
            string PickStatus = "Not Picked";

            string PType = "M";
            string PDate = "02/02/2021";
            string PQty = "5";
            string PItem = "008025";
            string FromWhse = "GLUS";
            string FromLoc = "STOCK";
            string FromLot = "";
            string ToWhse = "GLUS";
            string ToLoc = "SXTest";
            string ToLot = "";
            string PZeroCost = "0";
            string PStat = "I";
            //string Infobar = ""
            string DocumentNum = "";
            string FromImportDocId = "";
            string ToImportDocId = "";
            string LocExists = "";
            string UcFlag = "0"; 
            string UnitCost = "0"; 
            string MatlCost = "0"; 
            string LbrCost = "0";
            string FovhdCost = "0"; 
            string VovhdCost = "0"; 
            string OutCost = "0"; 
            string SetPermFlag = "0";
            string RowPointer = "";
            string sMatlRowPointer = "4211e01e-562e-4e11-9a6e-2ed079e58154";
            string sPartnerId = "CGRAY";
            string sDept = "62BB";
            string sPostMode = "P";
            string sQty = "1";
            string sTransDate = "11/18/2020";
            string sPostDate = "11/20/2020";
            string sUpdateStatus = "A";


            //DateTime DateValue;
            //if (DateTime.TryParse(sTransDate, out DateValue))
            //{ }
            //else
            //    DateValue = DateTime.Now;
            //sTransDate = DateValue.ToString("yyyy") + DateValue.ToString("MM") + DateValue.ToString("dd");

            //if (DateTime.TryParse(sPostDate, out DateValue))
            //{ }
            //else
            //    DateValue = DateTime.Now;
            //sPostDate = DateValue.ToString("yyyy") + DateValue.ToString("MM") + DateValue.ToString("dd");

            //if (DateTime.TryParse(PDate, out DateValue))
            //{ }
            //else
            //    DateValue = DateTime.Now;
            //PDate = DateValue.ToString("yyyy") + DateValue.ToString("MM") + DateValue.ToString("dd");

            ////string sPackNum = "";

            //string sSxPLItemId = "";

            //udpate the ShipID on the ue_sx_pick_list
            //iReturn = Functions.GetSXPickListItemId(Client, "43", ref sSxPLItemId, ref Infobar);

            //if (string.IsNullOrEmpty(sSxPLItemId) == false)
            //{
            //    iReturn = Functions.UpdateSXPickListShipId(Client, sSxPLItemId, "62", ref Infobar);
            //    //if (iReturn != 0)
            //    //    return iReturn;
            //}


            //PickListCreation.CallPJShipPostShipment(Client, "26", ref Infobar);
            //PickListId = "134";
            //iReturn = Process.CompletePickList(Client, PickListId, "O", "PACK", "GLUS", PDate, ref Infobar);

            //stat_string = "";







            //iReturn = TransferOrderShipping.AddTransferPackHeader(Client, "SXTEST0001", "GLUS", "GLUS", "GLUS", "US01", sPostDate, ref sPackNum, ref Infobar);

            ////iReturn = ServiceOrderShipping.SROTransPostMatlSp(Client, sMatlRowPointer, sPostMode, sPartnerId, sDept, FromWhse, sTransDate,
            ////                                                    sPostDate, sQty, sUpdateStatus, ref Infobar);

            //iReturn = TransferOrderShipping.CreateDCTrans(Client, PickListId, "1", "SXTEST0003", "1", "FD10006", "EA", ref Infobar);
            //iReturn = TransferOrderShipping.InvokeTransferOrderShip(Client, "", ref Infobar);


            //iReturn = Functions.CheckForItemLoc(Client, PItem, ToLoc, ToWhse, ref LocExists, ref Infobar);

            //if (LocExists == "0" && iReturn == 0)
            //{
            //    iReturn = QtyMove.ItemLocAddSp(Client, ToWhse, PItem, ToLoc, UcFlag, UnitCost, MatlCost,
            //                                LbrCost, FovhdCost, VovhdCost, OutCost, SetPermFlag,
            //                                ref RowPointer, ref Infobar);
            //}

            //iReturn = QtyMove.QtyMoveSp(Client, PType, PDate, PQty, PItem, FromWhse,
            //                    FromLoc, FromLot, ToWhse, ToLoc, ToLot, PZeroCost,
            //                    PStat, ref Infobar, DocumentNum, FromImportDocId,
            //                    ToImportDocId);
            //iReturn = Process.UpdatePickStatus(Client, RefNum, RefLine, RefType, PickStatus, ref Infobar);

            //iReturn = Functions.CheckForSXPickList(Client, "", "", "", ref PickListId, ref Infobar);

            //iReturn = PickListCreation.InsertSxPickListRef(Client, PickListId, "0", "2", "1", "G000000001", "", "T", "1", "", "", ref Infobar);




            //TransferOrderShipping.AddShipTransferOrderLine(Client, "DT00000023", "      1", "1", "1", "EA", "STOCK", "200304000000002", ref Infobar);
            //TransferOrderShipping.AddShipTransferOrderSerial(Client, "A-65000-123", "1", ref Infobar);

            //TransferOrderShipping.InvokeTransferOrderShip(Client, "1", ref Infobar);

            //DataTable SROMatlTbl = new DataTable();
            //SROMatlTbl.Columns.Add("FsmRowPointer");
            //SROMatlTbl.Columns.Add("FsmPartnerId");
            //SROMatlTbl.Columns.Add("FsmDept");
            //SROMatlTbl.Columns.Add("FsmWhse");
            //SROMatlTbl.Columns.Add("FsmTransDate");
            //SROMatlTbl.Columns.Add("FsmPostDate");
            //SROMatlTbl.Columns.Add("QtyPicked");

            //Functions.GetSROPickListRefs(Client, ref SROMatlTbl, "15", "USS0000093");


            //DataTable GridTbl = new DataTable();
            //GridTbl.Columns.Add("Group");
            //GridTbl.Columns.Add("CoNum");
            //GridTbl.Columns.Add("CoLine");
            //GridTbl.Columns.Add("CoRelease");
            //GridTbl.Columns.Add("DueDate");
            //GridTbl.Columns.Add("Item");
            //GridTbl.Columns.Add("CoiDescription");
            //GridTbl.Columns.Add("PickStat");
            //GridTbl.Columns.Add("DerPickQty");
            //GridTbl.Columns.Add("DerQtyReadyConv");
            //GridTbl.Columns.Add("UM");
            //GridTbl.Columns.Add("CoCustNum");
            //GridTbl.Columns.Add("CoCustSeq");
            //GridTbl.Columns.Add("CoShipCode");
            //GridTbl.Columns.Add("Adr0Name");
            //GridTbl.Columns.Add("DropShip");
            //GridTbl.Columns.Add("DropShipTo");
            //GridTbl.Columns.Add("CadrName");
            //GridTbl.Columns.Add("DerCreditHold");

            //GridTbl.Columns.Add("Whse");
            //GridTbl.Columns.Add("SiteSite");
            //GridTbl.Columns.Add("Posted");
            //GridTbl.Columns.Add("Type");


            ////IIDOCommands context, ref string Infobar, ref DataTable GridTbl, string Whse, string Site, string Ready, string Partial, string NotReady, string CreditHold)
            //CLM_Processes.CLM_CustomerOrderWorkbenchGrid(Client, ref Infobar, ref GridTbl, "GLUS", "GLUS", "1", "1", "1", "", "");

            DataTable GridTbl = new DataTable();
            GridTbl.Columns.Add("Group");
            GridTbl.Columns.Add("SroNum");
            GridTbl.Columns.Add("SroLine");
            GridTbl.Columns.Add("SroOper");
            GridTbl.Columns.Add("TransNum");
            GridTbl.Columns.Add("TransDate");
            GridTbl.Columns.Add("Item");
            GridTbl.Columns.Add("Description");
            GridTbl.Columns.Add("PickStat");
            GridTbl.Columns.Add("MatlQtyConv");
            GridTbl.Columns.Add("QtyReady");
            GridTbl.Columns.Add("UM");
            GridTbl.Columns.Add("SroCustNum");
            GridTbl.Columns.Add("BillToName");
            GridTbl.Columns.Add("CustSeq");
            GridTbl.Columns.Add("ShpToName");
            GridTbl.Columns.Add("DropType");
            GridTbl.Columns.Add("ShipCode");
            GridTbl.Columns.Add("CreditHold");
            GridTbl.Columns.Add("ue_LineUfPickStatus");
            GridTbl.Columns.Add("ue_DerServiceItem");

            CLM_Processes.CLM_ServiceOrderWorkbenchGrid(Client, ref Infobar, ref GridTbl, "GLUS", "GLUS", "1", "1", "1", "", "0");

            this.dataGridView1.DataSource = GridTbl;


            Client.CloseSession();
        }
    }
}
