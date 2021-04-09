using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _GIL_SeperateDocuments;
using Mongoose.IDO;
using Mongoose.IDO.Protocol;

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
            Client client = new Client("https://csi10a.erpsl.inforcloudsuite.com/IDORequestService/RequestService.aspx", IDOProtocol.Http);

            client.OpenSession("justin.brickler@solutionsx.com", "JTBrickler2020!", "GILSON_TRN_GLUS");

            string Infobar = "";
            //InvoiceSplit.InvoiceSubmitLoop(client,
            //                               Guid.NewGuid(),
            //                               "O",
            //                               "OrderInvoicingCreditMemoDetailReport",
            //                               "RBP",
            //                               "I",
            //                               "2021-03-17 00:00:00.00",
            //                               "     30",
            //                               "     30",
            //                               "",
            //                               "",
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               0,
            //                               "3",
            //                               0,
            //                               null,
            //                               0,
            //                               null,
            //                               null,
            //                               "CI",
            //                               0,
            //                               0,
            //                               0,
            //                               "E",
            //                               0,
            //                               0,
            //                               1,
            //                               1,
            //                               1,
            //                               0,
            //                               0,
            //                               1,
            //                               0,
            //                               0,
            //                               1,
            //                               1,
            //                               0,
            //                               null,
            //                               0,
            //                               null,
            //                               null,
            //                               2842,
            //                               ref Infobar,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               0,
            //                               "PROCESS",
            //                               0,
            //                               null,
            //                               null,
            //                               "en-US", //culture
            //                               null,
            //                               null,
            //                               null,
            //                               null,
            //                               0, //drawing
            //                               1, //tax
            //                               1, //code
            //                               0, //inco
            //                               0, //eu
            //                               0, //header
            //                               0, //create
            //                               0); //tax

            string infobar = "";
            //VerificationSplit.VerificationSubmitLoop(client, "1", "1", "PO", "POFC", "CI", "1", "1", "1", "D", "2021-03-18 00:00:00.00", "", "1", "1", "1", "1",
            //    "1", "0", "1", "0", "1", "1", "C", "         1", "        2", "", "", "", "", "", "", "0", "1", "0", "0", "E", "BG~TASKID~",
            //    "0", "0", "0", "0", "0", "0", "0", "0", "0", "GLUS", "Print", "0", ref infobar);

            SROSplit.SROInvoiceSubmitLoop(client,"PROCESS","USS0000060","USS0000093","","","","","","","","","","","","","","","1","1","I","20210330","0","S",500114,500115,"20210330","20210330","1","0","0","0","0","0","1","0","1","1","1","0","U","0","N");
            client.CloseSession();
        }
    }
}
